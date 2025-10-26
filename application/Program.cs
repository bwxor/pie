/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using pie.Classes;
using pie.Constants;

namespace pie
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());

            App myApp = new App();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            myApp.Run(Environment.GetCommandLineArgs());
        }

        private static void CurrentDomain_UnhandledException(object sender, System.UnhandledExceptionEventArgs e)
        {
            File.WriteAllText(SpecialPaths.CrashReport, e.ExceptionObject.ToString());
            ShowFatalNotification();
        }

        private static void ShowFatalNotification()
        {
            NotificationFatalForm notificationFatalForm = new NotificationFatalForm();
            notificationFatalForm.ShowDialog();
        }
    }

    class App : WindowsFormsApplicationBase
    {
        public App()
        {
            // Make this a single-instance application
            this.IsSingleInstance = true;
            this.EnableVisualStyles = true;

            // There are some other things available in 
            // the VB application model, for
            // instance the shutdown style:
            this.ShutdownStyle =
              Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses;

            // Add StartupNextInstance handler
            this.StartupNextInstance +=
              new StartupNextInstanceEventHandler(this.SIApp_StartupNextInstance);
        }

        protected override void OnCreateMainForm()
        {
            // Create an instance of the main form 
            // and set it in the application; 
            // but don't try to run() it.
            this.MainForm = new t();

            // We want to pass along the command-line arguments to 
            // this first instance

            // Allocate room in our string array
            ((t)this.MainForm).Args =
                  new string[this.CommandLineArgs.Count];

            // And copy the arguments over to our form
            this.CommandLineArgs.CopyTo(((t)this.MainForm).Args, 0);
        }

        protected void SIApp_StartupNextInstance(object sender, StartupNextInstanceEventArgs eventArgs)
        {
            // Copy the arguments to a string array
            string[] args = new string[eventArgs.CommandLine.Count];
            eventArgs.CommandLine.CopyTo(args, 0);

            // Need to use invoke to b/c this is being called 
            // from another thread.
            this.MainForm.Invoke(new t.ProcessParametersDelegate(
                ((t)this.MainForm).ProcessParameters), new object[] { args });
        }
    }
}
