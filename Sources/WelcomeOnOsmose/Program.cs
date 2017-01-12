/*
 * Created by SharpDevelop.
 * User: Etienne.MARTIN
 * ADA: merci ETIENNE!
 * ADA: je recommence à tester un commit
 * CAU : OMG, je code?
 * Date: 29/09/2016
 * Time: 10:00
 * thomas tu fais n'importe quoi!!!!
 * je suis branchée
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
 // Maximo Commentaire
 // Test Christian
using System;
using System.Windows.Forms;

namespace WelcomeOnOsmose
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			// Launch App
			Application.Run(new MainForm());
		}
		
	}
}
// Test CPIN 2