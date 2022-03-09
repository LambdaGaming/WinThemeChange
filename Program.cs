using Microsoft.Win32;
using System.Security.Principal;

const string currentUser = @"HKEY_CURRENT_USER\";
const string localMachine = @"HKEY_LOCAL_MACHINE\";
const string personalization = currentUser + @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize";
bool IsAdmin() => new WindowsPrincipal( WindowsIdentity.GetCurrent() ).IsInRole( WindowsBuiltInRole.Administrator );

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine( "This program will allow you to customize an unactivated version of Windows 10 or 11 as if it were activated." );
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine( "WARNING: This program makes changes to your registry. Please consider making a backup before proceeding." );
Console.WriteLine( "The creator of this software is not responsible for any damage done as a result of using this software.\n" );
Console.ResetColor();

Console.WriteLine( "Initializing..." );
if ( !IsAdmin() )
{
	Console.WriteLine( "ERROR: Please restart the app with administrator privileges." );
	Console.ReadKey();
	return;
}

Console.WriteLine( "Disabling activation watermark..." );
Registry.SetValue( localMachine + @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\SoftwareProtectionPlatform", "NotificationDisabled", 1 );

Console.WriteLine( "Enabling themes tab in Windows explorer..." );
Registry.SetValue( currentUser + @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoThemesTab", 0, RegistryValueKind.DWord );

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

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine( "Finished! Most changes should take effect immediately, but restarting your system is still recommended." );
Console.WriteLine( "Press any key to continue..." );
Console.ReadKey();
