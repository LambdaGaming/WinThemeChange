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

			MessageBox.Show( "WinThemeChange v2.0.0 | Copyright © 2022 LambdaGaming\nDo not redistribute this program without the creator's permission!\n\nThis program will allow you to customize unactivated versions of Windows 10 and 11 as if they were activated.\n\nWARNING: This program makes changes to your registry. Please consider making a backup before proceeding.\n\nThe creator of this software is not responsible for any damages caused by the use of this software. Proceed at your own risk." );
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new MainForm() );
		}
	}
}
