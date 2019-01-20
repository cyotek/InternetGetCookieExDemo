using System;
using System.Windows.Forms;
using Cyotek.ApplicationServices.Windows.Forms;

// Reading cookies from Internet Explorer
// https://www.cyotek.com/blog/reading-cookies-from-internet-explorer
// Copyright © 2019 Cyotek Ltd. All Rights Reserved.

// This source code is licensed under the Creative Commons Attribution 4.0 International License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

// Found this example useful? 
// https://www.paypal.me/cyotek

namespace Cyotek.Demonstrations.InternetGetCookieEx
{
  internal static class Program
  {
    #region Static Methods

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      InternetExplorerBrowserEmulation.SetBrowserEmulationVersion();

      Application.Run(new MainForm());
    }

    #endregion
  }
}
