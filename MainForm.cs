using Microsoft.Win32;
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
		const string content = currentUser + @"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
		const string systemPersonalize = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\PersonalizationCSP";
		const int SPI_SETDESKWALLPAPER = 20;
		const int SPIF_UPDATEINIFILE = 1;
		const int SPIF_SENDCHANGE = 2;
		const int COLOR_DESKTOP = 1;

		public MainForm()
		{
			InitializeComponent();
			BackgroundPanel.BringToFront();
			UpdateImages();
			SystemDarkMode.Checked = ( int ) Registry.GetValue( personalization, "SystemUsesLightTheme", 0 ) == 0;
			AppDarkMode.Checked = ( int ) Registry.GetValue( personalization, "AppsUseLightTheme", 0 ) == 0;
			TransparencyEffects.Checked = ( int ) Registry.GetValue( personalization, "EnableTransparency", 0 ) == 1;
			AccentBackground.Checked = ( int ) Registry.GetValue( currentUser + @"Control Panel\Desktop", "AutoColorization", 0 ) == 1;
			LockScreenFacts.Checked = ( int ) Registry.GetValue( content, "RotatingLockScreenOverlayEnabled", 0 ) == 1;
			SignInImage.Checked = ( int ) Registry.GetValue( @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "DisableLogonBackgroundImage", 0 ) == 0;
		}

		[DllImport( "user32.dll", CharSet = CharSet.Auto, SetLastError = true )]
		private static extern int SystemParametersInfo( int action, int param, string plvParam, int fuWinIni );

		[DllImport( "user32.dll" )]
		private static extern bool SetSysColors( int cElements, int[] lpaElements, int[] lpaRgbValues );

		private void UpdateImages()
		{
			string wallpaper = GetWallpaper();
			if ( File.Exists( wallpaper ) )
			{
				Image img = Image.FromFile( wallpaper );
				WallpaperImage.BackgroundImage = img;
				WallpaperImage.BackgroundImageLayout = ImageLayout.Zoom;
				ColorImage.BackgroundImage = img;
				ColorImage.BackgroundImageLayout = ImageLayout.Zoom;
				ThemeImage.BackgroundImage = img;
				ThemeImage.BackgroundImageLayout = ImageLayout.Zoom;
			}

			string reg = ( string ) Registry.GetValue( currentUser + @"Control Panel\Colors", "Background", "0 0 0" );
			string[] colors = reg.Split( ' ' );
			Color background = Color.FromArgb( int.Parse( colors[0] ), int.Parse( colors[1] ), int.Parse( colors[2] ) );
			WallpaperImage.BackColor = background;
			ColorImage.BackColor = background;
			ThemeImage.BackColor = background;

			string lk = ( string ) Registry.GetValue( systemPersonalize, "LockScreenImagePath", "" );
			if ( File.Exists( lk ) )
			{
				Image img = Image.FromFile( lk );
				LockImage.BackgroundImage = img;
				LockImage.BackgroundImageLayout = ImageLayout.Zoom;
			}
		}

		private static string GetWallpaper()
		{
			string path = ( string ) Registry.GetValue( currentUser + @"Control Panel\Desktop", "WallPaper", "" );
			return path;
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

		private static void UpdateWallpaperStyle( string style )
		{
			Registry.SetValue( currentUser + @"Control Panel\Desktop", "WallpaperStyle", style );
			if ( style == "1" )
				Registry.SetValue( currentUser + @"Control Panel\Desktop", "TileWallpaper", "1" );
			else
				Registry.SetValue( currentUser + @"Control Panel\Desktop", "TileWallpaper", "0" );
		}

		#region LeftSide
		private void ExperimentalButton_Click( object sender, EventArgs e ) => ExperimentalPanel.BringToFront();
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
			dialog.InitialDirectory = @"C:\Windows\Web\Wallpaper";
			if ( dialog.ShowDialog() == DialogResult.OK )
			{
				SystemParametersInfo( SPI_SETDESKWALLPAPER, 0, dialog.FileName, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE );
				UpdateImages();
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

		private void BackgroundColorButton_Click( object sender, EventArgs e )
		{
			colorDialog.ShowDialog();
			int[] elements = { COLOR_DESKTOP };
			int[] colors = { ColorTranslator.ToWin32( colorDialog.Color ) };
			SetSysColors( elements.Length, elements, colors );
			Registry.SetValue( currentUser + @"Control Panel\Colors", "Background", string.Format( "{0} {1} {2}", colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B ) );
			UpdateImages();
		}

		private void SystemDarkMode_CheckedChanged( object sender, EventArgs e )
		{
			Registry.SetValue( personalization, "SystemUsesLightTheme", SystemDarkMode.Checked ? 0 : 1 );
		}

		private void AppDarkMode_CheckedChanged( object sender, EventArgs e )
		{
			Registry.SetValue( personalization, "AppsUseLightTheme", SystemDarkMode.Checked ? 0 : 1 );
		}

		private void TransparencyEffects_CheckedChanged( object sender, EventArgs e )
		{
			Registry.SetValue( personalization, "EnableTransparency", TransparencyEffects.Checked ? 1 : 0 );
		}

		private void AccentBackground_CheckedChanged( object sender, EventArgs e )
		{
			// Wallpaper needs reapplied for setting to take effect
			Registry.SetValue( currentUser + @"Control Panel\Desktop", "AutoColorization", AccentBackground.Checked ? 1 : 0 );
			SystemParametersInfo( SPI_SETDESKWALLPAPER, 0, GetWallpaper(), SPIF_UPDATEINIFILE | SPIF_SENDCHANGE );
		}

		private void ColorButton_Click( object sender, EventArgs e )
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
			Color adjusted = Color.FromArgb( ( int ) ( colorDialog.Color.R * 0.5 ), ( int ) ( colorDialog.Color.G * 0.5 ), ( int ) ( colorDialog.Color.B * 0.5 ) );
			Registry.SetValue( personalization, "ColorPrevalence", 1 );
			Registry.SetValue( accent, "AccentPalette", CreatePalette( adjusted ), RegistryValueKind.Binary );
		}

		private void LockImageButton_Click( object sender, EventArgs e )
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Supported formats (*.jpg *.jpeg *.bmp *.dib *.png *.jfif *.jpe *.gif *.tif *.tiff *.wdp *.heic *.heif *.heics *.heifs *.avci *.avcs *.avif *.avifs)|*.jpg;*.jpeg;*.bmp;*.dib;*.png;*.jfif;*.jpe;*.gif;*.tif;*.tiff;*.wdp;*.heic;*.heif;*.heics;*.heifs;*.avci;*.avcs;*.avif;*.avifs";
			dialog.InitialDirectory = @"C:\Windows\Web\Screen";
			if ( dialog.ShowDialog() == DialogResult.OK )
			{
				Registry.SetValue( systemPersonalize, "LockScreenImageStatus", 1 );
				Registry.SetValue( systemPersonalize, "LockScreenImagePath", dialog.FileName );
				Registry.SetValue( systemPersonalize, "LockScreenImageUrl", dialog.FileName );
				UpdateImages();
			}
		}

		private void LockScreenFacts_CheckedChanged( object sender, EventArgs e )
		{
			Registry.SetValue( content, "RotatingLockScreenOverlayEnabled", LockScreenFacts.Checked ? 1 : 0 );
			Registry.SetValue( content, "SubscribedContent-338387Enabled", LockScreenFacts.Checked ? 1 : 0 );
		}

		private void SignInImage_CheckedChanged( object sender, EventArgs e )
		{
			Registry.SetValue( @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "DisableLogonBackgroundImage", SignInImage.Checked ? 0 : 1 );
		}

		private void GotoBackgroundButton_Click( object sender, EventArgs e )
		{
			BackgroundPanel.BringToFront();
		}

		private void GotoColorsButton_Click( object sender, EventArgs e )
		{
			ColorsPanel.BringToFront();
		}

		private void CursorButton_Click( object sender, EventArgs e )
		{
			Process.Start( "control.exe", "main.cpl,,1" );
		}

		private void SoundButton_Click( object sender, EventArgs e )
		{
			Process.Start( "control.exe", "mmsys.cpl,,2 sounds" );
		}

		private void BrowseThemesButton_Click( object sender, EventArgs e )
		{
			Process.Start( "explorer.exe", @"C:\Windows\Resources" );
		}

		private void ActivateThemeButton_Click( object sender, EventArgs e )
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Theme files (*.theme *.themepack)|*.theme;*.themepack";
			dialog.InitialDirectory = @"C:\Windows\Resources";
			if ( dialog.ShowDialog() == DialogResult.OK )
			{
				Process.Start( "explorer.exe", dialog.FileName );
			}
		}

		private void BrowseFontsButton_Click( object sender, EventArgs e )
		{
			Process.Start( "control.exe", "fonts" );
		}

		private void InstallFontButton_Click( object sender, EventArgs e )
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Font files (*.ttf)|*.ttf";
			if ( dialog.ShowDialog() == DialogResult.OK )
			{
				Process.Start( dialog.FileName );
			}
		}

		private void DisableWatermarkButton_Click( object sender, EventArgs e )
		{
			// Use both in case the old one still works
			Registry.SetValue( @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SoftwareProtectionPlatform\Activation", "NotificationDisabled", 1 );
			Registry.SetValue( currentUser + @"Control Panel\Desktop", "PaintDesktopVersion", 0 );
		}
		#endregion
	}
}
