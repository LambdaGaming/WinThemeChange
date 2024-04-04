using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace WinThemeChange
{
	internal static class Program
	{
		static bool IsAdmin() => new WindowsPrincipal( WindowsIdentity.GetCurrent() ).IsInRole( WindowsBuiltInRole.Administrator );

		[STAThread]
		static void Main()
		{
			if ( !IsAdmin() )
			{
				MessageBox.Show( "Please restart the program with administrator privileges.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

			MessageBox.Show( "WinThemeChange v3.0 | Copyright © 2022-2024 OPGman\n\nWARNING: This program makes changes to your registry and other system configurations. Please consider making a backup before proceeding.\n\nYou are using this software at your own risk. The creator is not responsible for any damage or other problems that may arise from using it." );
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new MainForm() );
		}
	}
}
