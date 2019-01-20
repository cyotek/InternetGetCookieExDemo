using System;
using System.Runtime.InteropServices;
using System.Text;

// Reading cookies from Internet Explorer
// https://www.cyotek.com/blog/reading-cookies-from-internet-explorer
// Copyright © 2019 Cyotek Ltd. All Rights Reserved.

// This source code is licensed under the Creative Commons Attribution 4.0 International License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

// Found this example useful? 
// https://www.paypal.me/cyotek

// ReSharper disable IdentifierTypo
// ReSharper disable StringLiteralTypo
// ReSharper disable InconsistentNaming

namespace Cyotek.Demonstrations.InternetGetCookieEx
{
  internal class NativeMethods
  {
    #region Externals

    [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern bool InternetGetCookieEx(string lpszUrl, string lpszCookieName, StringBuilder lpszCookieData, ref int lpdwSize, int dwFlags, IntPtr lpReserved);

    #endregion

    #region Constants

    public const int ERROR_INSUFFICIENT_BUFFER = 122;

    public const int INTERNET_COOKIE_HTTPONLY = 0x00002000;

    public const int INTERNET_COOKIE_RESTRICTED_ZONE = 0x00020000;

    public const int INTERNET_COOKIE_THIRD_PARTY = 0x10;

    #endregion
  }
}
