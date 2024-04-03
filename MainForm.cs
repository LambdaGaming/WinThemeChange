﻿using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinThemeChange
{
	public partial class MainForm : Form
	{
		const string currentUser = @"HKEY_CURRENT_USER\";
		const string personalization = currentUser + @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize";
		const string dwm = currentUser + @"SOFTWARE\Microsoft\Windows\DWM";
		const string accent = currentUser + @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Accent";
		const int SPI_SETDESKWALLPAPER = 20;
		const int SPIF_UPDATEINIFILE = 1;
		const int SPIF_SENDCHANGE = 2;

		public MainForm()
		{
			InitializeComponent();
			BackgroundPanel.BringToFront();
			string wallpaper = GetWallpaper();
			if ( File.Exists( wallpaper ) )
			{
				WallpaperImage.BackgroundImage = Image.FromFile( wallpaper );
				WallpaperImage.BackgroundImageLayout = ImageLayout.Zoom;
			}
			else
			{
				WallpaperImage.BackColor = Color.Black;
			}
		}

		[DllImport( "user32.dll", CharSet = CharSet.Auto, SetLastError = true )]
		static extern int SystemParametersInfo( int action, int param, string plvParam, int fuWinIni );

		static void EnableDarkMode( bool enable ) => Registry.SetValue( personalization, "SystemUsesLightTheme", enable ? 0 : 1 );
		static void EnableAppDarkMode( bool enable ) => Registry.SetValue( personalization, "AppsUseLightTheme", enable ? 0 : 1 );
		static void EnableTransparency( bool enable ) => Registry.SetValue( personalization, "EnableTransparency", enable ? 1 : 0 );

		static void RestartExplorer()
		{
			foreach ( Process proc in Process.GetProcesses() )
			{
				if ( proc.ProcessName == "explorer" )
				{
					proc.Kill();
					break;
				}
			}
		}

		static string GetWallpaper()
		{
			string path = ( string ) Registry.GetValue( currentUser + @"Control Panel\Desktop", "WallPaper", "" );
			return path;
		}

		static void EnableAutoColors()
		{
			Registry.SetValue( currentUser + @"Control Panel\Desktop", "AutoColorization", 1 );
			MessageBox.Show( "You will need to reapply your wallpaper for this setting to take effect." );
		}

		static Color AdjustTaskbarColor( Color color )
		{
			return Color.FromArgb( ( int ) ( color.R * 0.5 ), ( int ) ( color.G * 0.5 ), ( int ) ( color.B * 0.5 ) );
		}

		void CustomThemeColor()
		{
			colorDialog.ShowDialog();
			Registry.SetValue( currentUser + @"Control Panel\Desktop", "AutoColorization", 0 );

			// App colors
			int color = RGBToBGR( colorDialog.Color );
			Registry.SetValue( dwm, "ColorPrevalence", 1 );
			Registry.SetValue( dwm, "AccentColor", color, RegistryValueKind.DWord );
			Registry.SetValue( accent, "AccentColorMenu", color, RegistryValueKind.DWord );
			Registry.SetValue( accent, "StartColorMenu", color, RegistryValueKind.DWord );

			// Taskbar colors
			Registry.SetValue( personalization, "ColorPrevalence", 1 );
			Registry.SetValue( accent, "AccentPalette", CreatePalette( AdjustTaskbarColor( colorDialog.Color ) ), RegistryValueKind.Binary );
		}

		void SetTaskbarColor()
		{
			colorDialog.ShowDialog();
			Registry.SetValue( currentUser + @"Control Panel\Desktop", "AutoColorization", 0 );
			Registry.SetValue( personalization, "ColorPrevalence", 1 );
			Registry.SetValue( accent, "AccentPalette", CreatePalette( AdjustTaskbarColor( colorDialog.Color ) ), RegistryValueKind.Binary );
		}

		static void ResetThemeColors()
		{
			Registry.SetValue( dwm, "ColorPrevalence", 0 );
			Registry.SetValue( personalization, "ColorPrevalence", 0 );
		}

		static int RGBToBGR( Color color )
		{
			byte r = color.R;
			byte g = color.G;
			byte b = color.B;
			return Color.FromArgb( b, g, r ).ToArgb();
		}

		static byte[] CreatePalette( Color color )
		{
			int count = 0;
			byte[] final = new byte[32];
			byte[] separate = {
				color.R,
				color.G,
				color.B,
				0xFF
			};
			for ( int i = 0; i < 32; i++ )
			{
				final[i] = separate[count];
				if ( count == 3 )
					count = 0;
				else
					count++;
			}
			final[31] = 0x0;
			return final;
		}

		static void UpdateWallpaperStyle( string style )
		{
			Registry.SetValue( currentUser + @"Control Panel\Desktop", "WallpaperStyle", style );
			if ( style == "1" )
				Registry.SetValue( currentUser + @"Control Panel\Desktop", "TileWallpaper", "1" );
			else
				Registry.SetValue( currentUser + @"Control Panel\Desktop", "TileWallpaper", "0" );
		}

		static void DisableWatermark()
		{
			// Use both in case the old one still works
			Registry.SetValue( @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SoftwareProtectionPlatform\Activation", "NotificationDisabled", 1 );
			Registry.SetValue( currentUser + @"Control Panel\Desktop", "PaintDesktopVersion", 0 );
		}

		#region LeftSide
		private void ExperimentalButton_Click( object sender, EventArgs e ) => ExperimentalPanel.BringToFront();
		private void TaskbarButton_Click( object sender, EventArgs e ) => TaskbarPanel.BringToFront();
		private void StartButton_Click( object sender, EventArgs e ) => StartPanel.BringToFront();
		private void FontsButton_Click( object sender, EventArgs e ) => FontsPanel.BringToFront();
		private void ThemesButton_Click( object sender, EventArgs e ) => ThemesPanel.BringToFront();
		private void LockScreenButton_Click( object sender, EventArgs e ) => LockScreenPanel.BringToFront();
		private void ColorsButton_Click( object sender, EventArgs e ) => ColorsPanel.BringToFront();
		private void BackgroundButton_Click( object sender, EventArgs e ) => BackgroundPanel.BringToFront();
		#endregion

		#region RightSide
		private void WallpaperButton_Click( object sender, EventArgs e )
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Supported formats (*.jpg *.jpeg *.bmp *.dib *.png *.jfif *.jpe *.gif *.tif *.tiff *.wdp *.heic *.heif *.heics *.heifs *.avci *.avcs *.avif *.avifs)|*.jpg;*.jpeg;*.bmp;*.dib;*.png;*.jfif;*.jpe;*.gif;*.tif;*.tiff;*.wdp;*.heic;*.heif;*.heics;*.heifs;*.avci;*.avcs;*.avif;*.avifs";
			dialog.InitialDirectory = "C:\\Windows\\Web\\Wallpaper";
			if ( dialog.ShowDialog() == DialogResult.OK )
			{
				SystemParametersInfo( SPI_SETDESKWALLPAPER, 0, dialog.FileName, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE );
				WallpaperImage.BackgroundImage = Image.FromFile( GetWallpaper() );
			}
		}

		private void WallpaperFit_SelectedIndexChanged( object sender, EventArgs e )
		{
			switch ( WallpaperFit.SelectedIndex )
			{
				case 0:
					UpdateWallpaperStyle( "0" );
					break;
				case 1:
					UpdateWallpaperStyle( "1" );
					break;
				case 2:
					UpdateWallpaperStyle( "2" );
					break;
				case 3:
					UpdateWallpaperStyle( "6" );
					break;
				case 4:
					UpdateWallpaperStyle( "10" );
					break;
				case 5:
					UpdateWallpaperStyle( "22" );
					break;
			}
			SystemParametersInfo( SPI_SETDESKWALLPAPER, 0, GetWallpaper(), SPIF_UPDATEINIFILE | SPIF_SENDCHANGE );
		}

		private void DisableWatermarkButton_Click( object sender, EventArgs e )
		{
			DisableWatermark();
		}
		#endregion
	}
}
