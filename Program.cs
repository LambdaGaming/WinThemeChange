using Microsoft.Win32;
using System.Security.Principal;

#pragma warning disable CA1416 // Validate platform compatibility

const string currentUser = @"HKEY_CURRENT_USER\";
const string localMachine = @"HKEY_LOCAL_MACHINE\";
const string personalization = currentUser + @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize";
bool IsAdmin() => new WindowsPrincipal( WindowsIdentity.GetCurrent() ).IsInRole( WindowsBuiltInRole.Administrator );

Console.WriteLine( "This program will allow you to customize an unactivated version of Windows 10 or 11 as if it were activated." );
Console.WriteLine( "Initializing..." );
if ( !IsAdmin() )
{
	Console.WriteLine( "ERROR: Please restart the app with administrator privileges." );
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

Console.WriteLine( "Would you like to enable transparency effects?" );
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
