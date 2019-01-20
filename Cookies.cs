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

namespace Cyotek.Demonstrations.InternetGetCookieEx
{
  internal static class Cookies
  {
    #region Static Methods

    public static string GetCookies(Uri uri)
    {
      return GetCookies(uri.OriginalString);
    }

    public static string GetCookies(string uri)
    {
      return GetCookies(uri, CookieRetrievalFlags.None);
    }

    public static string GetCookies(Uri uri, CookieRetrievalFlags flags)
    {
      return GetCookies(uri.OriginalString, flags);
    }

    public static string GetCookies(string uri, CookieRetrievalFlags flags)
    {
      StringBuilder buffer;
      string result;
      int bufferLength;

      bufferLength = 1024;
      buffer = new StringBuilder(bufferLength);

      if (NativeMethods.InternetGetCookieEx(uri, null, buffer, ref bufferLength, (int)flags, IntPtr.Zero))
      {
        result = buffer.ToString();
      }
      else
      {
        result = null;

        if (Marshal.GetLastWin32Error() == NativeMethods.ERROR_INSUFFICIENT_BUFFER)
        {
          buffer.Length = bufferLength;

          if (NativeMethods.InternetGetCookieEx(uri, null, buffer, ref bufferLength, (int)flags, IntPtr.Zero))
          {
            result = buffer.ToString();
          }
        }
      }

      return result;
    }

    #endregion
  }
}
