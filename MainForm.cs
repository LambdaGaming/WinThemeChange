using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WinThemeChange
{
	public partial class MainForm : Form
	{
		const string currentUser = @"HKEY_CURRENT_USER\";
		const string personalization = currentUser + @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize";
		const string dwm = currentUser + @"SOFTWARE\Microsoft\Windows\DWM";
		const string accent = currentUser + @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Accent";

		static void EnableDarkMode( bool enable ) => Registry.SetValue( personalization, "SystemUsesLightTheme", enable ? 0 : 1 );
		static void EnableAppDarkMode( bool enable ) => Registry.SetValue( personalization, "AppsUseLightTheme", enable ? 0 : 1 );
		static void EnableTransparency( bool enable ) => Registry.SetValue( personalization, "EnableTransparency", enable ? 1 : 0 );

		static void DisableWatermark()
		{
			// Use both in case the old one still works
			Registry.SetValue( @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SoftwareProtectionPlatform", "NotificationDisabled", 1 );
			Registry.SetValue( currentUser + @"\Control Panel\Desktop", "PaintDesktopVersion", 0 );
		}

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

		public MainForm()
		{
			InitializeComponent();
		}

		private void Button1_Click( object sender, EventArgs e ) => DisableWatermark();
		private void Button2_Click( object sender, EventArgs e ) => EnableDarkMode( true );
		private void button3_Click( object sender, EventArgs e ) => EnableDarkMode( false );
		private void button4_Click( object sender, EventArgs e ) => EnableAppDarkMode( true );
		private void button5_Click( object sender, EventArgs e ) => EnableAppDarkMode( false );
		private void button6_Click( object sender, EventArgs e ) => EnableAutoColors();
		private void button7_Click( object sender, EventArgs e ) => SetTaskbarColor();
		private void button8_Click( object sender, EventArgs e ) => CustomThemeColor();
		private void button9_Click( object sender, EventArgs e ) => EnableTransparency( true );
		private void button10_Click( object sender, EventArgs e ) => EnableTransparency( false );
		private void button11_Click( object sender, EventArgs e ) => ResetThemeColors();
		private void button12_Click( object sender, EventArgs e ) => RestartExplorer();
	}
}
