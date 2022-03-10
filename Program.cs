using Microsoft.Win32;
using System.Security.Principal;

const string currentUser = @"HKEY_CURRENT_USER\";
const string localMachine = @"HKEY_LOCAL_MACHINE\";
const string personalization = currentUser + @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize";
const string dwm = currentUser + @"SOFTWARE\Microsoft\Windows\DWM";
bool IsAdmin() => new WindowsPrincipal( WindowsIdentity.GetCurrent() ).IsInRole( WindowsBuiltInRole.Administrator );

string RGBToBGR( string color )
{
	string r = color.Substring( 2, 2 );
	string g = color.Substring( 4, 2 );
	string b = color.Substring( 6, 2 );
	return string.Format( "0x{0}{1}{2}", b, g, r );
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine( "WinThemeUpdate v1.0.0 | Created by LambdaGaming" );
Console.WriteLine( "This program will allow you to customize an unactivated version of Windows 10 or 11 as if it were activated." );
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine( "WARNING: This program makes changes to your registry. Please consider making a backup before proceeding." );
Console.WriteLine( "The creator of this software is not responsible for any damage done as a result of using this software.\n" );
Console.ResetColor();

Console.WriteLine( "Initializing..." );
if ( !IsAdmin() )
{
	Console.ForegroundColor= ConsoleColor.Red;
	Console.WriteLine( "ERROR: Please restart the app with administrator privileges." );
	Console.ReadKey();
	return;
}

Console.WriteLine( "Disabling activation watermark..." );
Registry.SetValue( localMachine + @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\SoftwareProtectionPlatform", "NotificationDisabled", 1 );

Console.WriteLine( "Would you like to enable system dark mode? (y/n)" );
if ( Console.ReadKey().Key == ConsoleKey.Y )
{
	Console.WriteLine( "Enabling system dark mode..." );
	Registry.SetValue( personalization, "SystemUsesLightTheme", 0 );
}
else
{
	Console.WriteLine( "Disabling system dark mode..." );
	Registry.SetValue( personalization, "SystemUsesLightTheme", 1 );
}

Console.WriteLine( "Would you like to enable app dark mode? (y/n)" );
if ( Console.ReadKey().Key == ConsoleKey.Y )
{
	Console.WriteLine( "Enabling app dark mode..." );
	Registry.SetValue( personalization, "AppsUseLightTheme", 0 );
}
else
{
	Console.WriteLine( "Disabling app dark mode..." );
	Registry.SetValue( personalization, "AppsUseLightTheme", 1 );
}

Console.WriteLine( "Would you like to enable transparency effects? (y/n)" );
if ( Console.ReadKey().Key == ConsoleKey.Y )
{
	Console.WriteLine( "Enabling transparency effects..." );
	Registry.SetValue( personalization, "EnableTransparency", 1 );
}
else
{
	Console.WriteLine( "Disabling transparency effects..." );
	Registry.SetValue( personalization, "EnableTransparency", 0 );
}

Console.WriteLine( "Would you like Windows to automatically choose colors based on the current wallpaper? (y/n)" );
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine( "Note: If you choose yes, you will need to apply a new wallpaper or reapply your current one in order for changes to take effect." );
Console.ResetColor();
if ( Console.ReadKey().Key == ConsoleKey.Y )
{

	Registry.SetValue( currentUser + @"Control Panel\Desktop", "AutoColorization", 1, RegistryValueKind.DWord );
}
else
{
	Registry.SetValue( currentUser + @"Control Panel\Desktop", "AutoColorization", 0, RegistryValueKind.DWord );
	Console.WriteLine( "Would you like to set a custom color for the taskbar? (y/n)" );
	if ( Console.ReadKey().Key == ConsoleKey.Y )
	{
		Console.WriteLine( "Enabling custom taskbar colors..." );
		Registry.SetValue( personalization, "ColorPrevalence", 1 );

		Console.WriteLine( "Enter the color you want the taskbar to be as an RGB format hex code: " );
		Console.WriteLine( "(Example: 0xFF0000 is red) Use the Google color picker and copy the hex code if you are unsure: https://g.co/kgs/yE982u" );

	TaskbarColor:
		string? hex = Console.ReadLine();
		if ( hex != null && hex.StartsWith( "0x" ) )
		{
			Console.WriteLine( "Applying taskbar color..." );
			// TODO: Find registry key for taskbar color
		}
		else
		{
			Console.WriteLine( "Incorrect color format. Make sure it starts with '0x'." );
			goto TaskbarColor;
		}
	}
	else
	{
		Console.WriteLine( "Disabling custom taskbar color..." );
		Registry.SetValue( personalization, "ColorPrevalence", 0 );
	}

	Console.WriteLine( "Would you like to set a custom color for application windows? (y/n)" );
	if ( Console.ReadKey().Key == ConsoleKey.Y )
	{
		Console.WriteLine( "Enabling custom application window colors..." );
		Registry.SetValue( dwm, "ColorPrevalence", 1 );

		Console.WriteLine( "Enter the color you want the taskbar to be as an RGB format hex code: " );
		Console.WriteLine( "(Example: 0xFF0000 is red) Use the Google color picker and copy the hex code if you are unsure: https://g.co/kgs/yE982u" );

	AppWindowColor:
		string? hex = Console.ReadLine();
		if ( hex != null && hex.StartsWith( "0x" ) )
		{
			Console.WriteLine( "Applying application window color..." );
			Registry.SetValue( dwm, "AccentColor", RGBToBGR( hex ) );
		}
		else
		{
			Console.WriteLine( "Incorrect color format. Make sure it starts with '0x'." );
			goto AppWindowColor;
		}
	}
	else
	{
		Console.WriteLine( "Disabling custom application window colors..." );
		Registry.SetValue( dwm, "ColorPrevalence", 0 );
	}
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine( "Finished! Most changes should take effect immediately, but restarting your system is still recommended." );
Console.WriteLine( "Press any key to continue..." );
Console.ReadKey();
