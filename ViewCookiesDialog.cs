using System;
using System.Drawing;
using System.Windows.Forms;

// Reading cookies from Internet Explorer
// https://www.cyotek.com/blog/reading-cookies-from-internet-explorer
// Copyright © 2019 Cyotek Ltd. All Rights Reserved.

// This source code is licensed under the Creative Commons Attribution 4.0 International License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

// Found this example useful? 
// https://www.paypal.me/cyotek

namespace Cyotek.Demonstrations.InternetGetCookieEx
{
  internal sealed partial class ViewCookiesDialog : Form
  {
    #region Constructors

    public ViewCookiesDialog()
    {
      this.InitializeComponent();
    }

    public ViewCookiesDialog(Uri uri)
      : this()
    {
      if (uri != null)
      {
        uriTextBox.Text = uri.OriginalString;
      }
    }

    #endregion

    #region Methods

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      if (!this.DesignMode)
      {
        this.Font = SystemFonts.DialogFont;
      }
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void debounceTimer_Tick(object sender, EventArgs e)
    {
      string cookieData;

      debounceTimer.Stop();

      cookieData = Cookies.GetCookies(uriTextBox.Text, this.GetFlags());

      cookiesTextBox1.Cookies = cookieData;
    }

    private CookieRetrievalFlags GetFlags()
    {
      CookieRetrievalFlags flags;

      flags = CookieRetrievalFlags.None;

      if (httpOnlyCheckBox.Checked)
      {
        flags |= CookieRetrievalFlags.HttpOnly;
      }

      if (thirdPartyCheckBox.Checked)
      {
        flags |= CookieRetrievalFlags.ThirdParty;
      }

      if (restrictedZoneCheckBox.Checked)
      {
        flags |= CookieRetrievalFlags.RestrictedZone;
      }

      return flags;
    }

    private void uriTextBox_TextChanged(object sender, EventArgs e)
    {
      debounceTimer.Stop();
      debounceTimer.Start();
    }

    #endregion
  }
}
