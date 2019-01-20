using System;

// Reading cookies from Internet Explorer
// https://www.cyotek.com/blog/reading-cookies-from-internet-explorer
// Copyright © 2019 Cyotek Ltd. All Rights Reserved.

// This source code is licensed under the Creative Commons Attribution 4.0 International License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

// Found this example useful? 
// https://www.paypal.me/cyotek

namespace Cyotek.Demonstrations.InternetGetCookieEx
{
  [Flags]
  internal enum CookieRetrievalFlags
  {
    None,

    HttpOnly = NativeMethods.INTERNET_COOKIE_HTTPONLY,

    ThirdParty = NativeMethods.INTERNET_COOKIE_THIRD_PARTY,

    RestrictedZone = NativeMethods.INTERNET_COOKIE_RESTRICTED_ZONE
  }
}
