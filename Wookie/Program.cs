﻿using System;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            //string encrypted = Wookie.Tools.Cryptography.StringCipher.Encrypt("Data Source = localhost; Initial Catalog = BS_PM_Master; Persist Security Info = True; User ID = sa; Password = 19theta#01","19theta#01");

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
                    string text = null;
                    text += "Could not connect to database '" + MasterDatabase.SqlConnection.Database + "'";
                    text += " on '" + MasterDatabase.SqlConnection.DataSource + "'";
                    XtraMessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                 
                }
            }
        }
    }
}