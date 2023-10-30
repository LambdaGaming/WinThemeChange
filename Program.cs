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

			MessageBox.Show( "WinThemeChange v2.1.1 | Copyright © 2022-2023 LambdaGaming\n\nWARNING: This program makes changes to your registry. Please consider making a backup before proceeding.\n\nYou are using this software at your own risk. The creator is not responsible for any damage or other problems that may arise from using this software." );
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new MainForm() );
		}
	}
}
