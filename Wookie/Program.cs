using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using Wookie.Tools.Database;
using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraSplashScreen;
using Wookie.Controls;
using System.Reflection;

namespace Wookie
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WindowsFormsSettings.ForceDirectXPaint();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            if (MasterDatabase.KeyFileExists && MasterDatabase.Connected)
            {
                Application.Run(new Controls.XtraForm1());
            }
            else
            {
                if (!MasterDatabase.KeyFileExists)
                {
                    XtraMessageBox.Show("Missing mandatory file 'Master.key'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!MasterDatabase.Connected)
                {
                    string text = System.String.Format("Could not connect to '{0}' on '{1}'", 
                        MasterDatabase.SqlConnection.Database, 
                        MasterDatabase.SqlConnection.DataSource);
                    
                    XtraMessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                 
                }
            }
        }
    }
}