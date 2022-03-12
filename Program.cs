using Microsoft.Win32;
using System;
using System.Security.Principal;

namespace WinThemeChange
{
	internal class Program
	{
		const string currentUser = @"HKEY_CURRENT_USER\";
		const string personalization = currentUser + @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize";
		const string dwm = currentUser + @"SOFTWARE\Microsoft\Windows\DWM";
		const string accent = currentUser + @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Accent";
		static bool IsAdmin() => new WindowsPrincipal( WindowsIdentity.GetCurrent() ).IsInRole( WindowsBuiltInRole.Administrator );

		static int RGBToBGR( string color )
		{
			string r = color.Substring( 2, 2 );
			string g = color.Substring( 4, 2 );
			string b = color.Substring( 6, 2 );
			return Convert.ToInt32( string.Format( "0x{0}{1}{2}", b, g, r ), 16 );
		}

		static byte[] CreatePalette( string color )
		{
			int count = 0;
			byte[] final = new byte[32];
			byte[] separate = {
				Convert.ToByte( string.Concat( "0x", color.Substring( 2, 2 ) ), 16 ),
				Convert.ToByte( string.Concat( "0x", color.Substring( 4, 2 ) ), 16 ),
				Convert.ToByte( string.Concat( "0x", color.Substring( 6, 2 ) ), 16 ),
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

		static void Main( string[] args )
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine( "WinThemeChange v1.0.0 | Created by LambdaGaming" );
			Console.WriteLine( "This program will allow you to customize an unactivated version of Windows 10 or 11 as if it were activated." );
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine( "WARNING: This program makes changes to your registry. Please consider making a backup before proceeding." );
			Console.WriteLine( "The creator of this software is not responsible for any damage done as a result of using this software.\n" );
			Console.ResetColor();

			Console.WriteLine( "Initializing..." );
			if ( !IsAdmin() )
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine( "ERROR: Please restart the app with administrator privileges." );
				Console.ReadKey();
				return;
			}

			Console.WriteLine( "Disabling activation watermark..." );
			Registry.SetValue( @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SoftwareProtectionPlatform", "NotificationDisabled", 1 );

			Console.WriteLine( "\nWould you like to enable system dark mode? (y/n)" );
			if ( Console.ReadKey().Key == ConsoleKey.Y )
			{
				Console.WriteLine( "\nEnabling system dark mode..." );
				Registry.SetValue( personalization, "SystemUsesLightTheme", 0 );
			}
			else
			{
				Console.WriteLine( "\nDisabling system dark mode..." );
				Registry.SetValue( personalization, "SystemUsesLightTheme", 1 );
			}

			Console.WriteLine( "\nWould you like to enable app dark mode? (y/n)" );
			if ( Console.ReadKey().Key == ConsoleKey.Y )
			{
				Console.WriteLine( "\nEnabling app dark mode..." );
				Registry.SetValue( personalization, "AppsUseLightTheme", 0 );
			}
			else
			{
				Console.WriteLine( "\nDisabling app dark mode..." );
				Registry.SetValue( personalization, "AppsUseLightTheme", 1 );
			}

			Console.WriteLine( "\nWould you like to enable transparency effects? (y/n)" );
			if ( Console.ReadKey().Key == ConsoleKey.Y )
			{
				Console.WriteLine( "\nEnabling transparency effects..." );
				Registry.SetValue( personalization, "EnableTransparency", 1 );
			}
			else
			{
				Console.WriteLine( "\nDisabling transparency effects..." );
				Registry.SetValue( personalization, "EnableTransparency", 0 );
			}

			Console.WriteLine( "\nWould you like Windows to automatically choose colors based on the current wallpaper? (y/n)" );
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine( "Note: If you choose yes, you will need to apply a new wallpaper or reapply your current one in order for changes to take effect." );
			Console.ResetColor();
			if ( Console.ReadKey().Key == ConsoleKey.Y )
			{
				Console.WriteLine( "\nEnabling auto colorization..." );
				Registry.SetValue( currentUser + @"Control Panel\Desktop", "AutoColorization", 1 );
			}
			else
			{
				Registry.SetValue( currentUser + @"Control Panel\Desktop", "AutoColorization", 0 );
				Console.WriteLine( "\nWould you like to set a custom color for application windows? (y/n)" );
				if ( Console.ReadKey().Key == ConsoleKey.Y )
				{
					Registry.SetValue( dwm, "ColorPrevalence", 1 );
					Console.WriteLine( "Enter the color you want app windows to be as a 24-bit hex code: " );
					Console.WriteLine( "(Example: 0xFF0000 is red) Use the Google color picker and copy the hex code if you are unsure: https://g.co/kgs/yE982u" );

				AppWindowColor:
					string hex = Console.ReadLine();
					if ( hex != null && hex.StartsWith( "0x" ) && hex.Length == 8 )
					{
						int color = RGBToBGR( hex );
						Console.WriteLine( "\nApplying application window color..." );
						Registry.SetValue( dwm, "AccentColor", color, RegistryValueKind.DWord );
						Registry.SetValue( accent, "AccentColorMenu", color, RegistryValueKind.DWord );
						Registry.SetValue( accent, "StartColorMenu", color, RegistryValueKind.DWord );
					}
					else
					{
						Console.WriteLine( "Incorrect color format. Make sure it starts with '0x'." );
						goto AppWindowColor;
					}
				}
				else
				{
					Console.WriteLine( "\nDisabling custom application window colors..." );
					Registry.SetValue( dwm, "ColorPrevalence", 0 );
				}

				Console.WriteLine( "\nWould you like to set a custom color for the taskbar? (y/n)" );
				if ( Console.ReadKey().Key == ConsoleKey.Y )
				{
					Registry.SetValue( personalization, "ColorPrevalence", 1 );
					Console.WriteLine( "Enter the color you want the taskbar to be as a 24-bit hex code: " );
					Console.WriteLine( "(Example: 0xFF0000 is red) Use the Google color picker and copy the hex code if you are unsure: https://g.co/kgs/yE982u" );
					Console.WriteLine( "For best results, you should make the taskbar color a little darker than the application window color." );

				TaskbarColor:
					string hex = Console.ReadLine();
					if ( hex != null && hex.StartsWith( "0x" ) && hex.Length == 8 )
					{
						Console.WriteLine( "\nApplying taskbar color..." );
						Registry.SetValue( accent, "AccentPalette", CreatePalette( hex ), RegistryValueKind.Binary );
					}
					else
					{
						Console.WriteLine( "Incorrect color format. Make sure it starts with '0x'." );
						goto TaskbarColor;
					}
				}
				else
				{
					Console.WriteLine( "\nDisabling custom taskbar color..." );
					Registry.SetValue( personalization, "ColorPrevalence", 0 );
				}
			}

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine( "\nFinished! Most changes should take effect immediately, but some will require a restart." );
			Console.WriteLine( "Press any key to continue..." );
			Console.ReadKey();
		}
	}
}
