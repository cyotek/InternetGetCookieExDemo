using System;
using System.Drawing;
using System.Linq;
using System.Media;
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
  public partial class MainForm : Form
  {
    #region Fields

    private WebBrowser _webBrowser;

    #endregion

    #region Constructors

    public MainForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Methods

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        components?.Dispose();

        if (_webBrowser != null)
        {
          _webBrowser.CanGoBackChanged -= this.WebBrowserCanGoBackChangedHandler;
          _webBrowser.CanGoForwardChanged -= this.WebBrowserCanGoForwardChangedHandler;
          _webBrowser.Navigating -= this.WebBrowserNavigatingHandler;
          _webBrowser.Navigated -= this.WebBrowserNavigatedHandler;
          _webBrowser.DocumentCompleted -= this.WebBrowserDocumentCompletedHandler;
        }
      }

      base.Dispose(disposing);
    }

    protected void ExecCommand(Action<WebBrowser> command)
    {
      if (_webBrowser != null)
      {
        try
        {
          command(_webBrowser);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.GetBaseException().Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      else
      {
        SystemSounds.Beep.Play();
      }
    }

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Form.FormClosing"/> event.
    /// </summary>
    /// <param name="e">A <see cref="T:System.Windows.Forms.FormClosingEventArgs"/> that contains the event data. </param>
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (_webBrowser != null && !_webBrowser.IsDisposed)
      {
        _webBrowser.CanGoBackChanged -= this.WebBrowserCanGoBackChangedHandler;
        _webBrowser.CanGoForwardChanged -= this.WebBrowserCanGoForwardChangedHandler;
        _webBrowser.Navigating -= this.WebBrowserNavigatingHandler;
        _webBrowser.Navigated -= this.WebBrowserNavigatedHandler;
        _webBrowser.DocumentCompleted -= this.WebBrowserDocumentCompletedHandler;

        _webBrowser.Parent?.Controls.Remove(_webBrowser);
        _webBrowser = null;
      }

      base.OnFormClosing(e);
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      if (!this.DesignMode)
      {
        this.Font = SystemFonts.DialogFont;
      }

      this.Text = Application.ProductName;
    }

    /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data. </param>
    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);

      this.ResizeUriEditor();
    }

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Form.Shown"/> event.
    /// </summary>
    /// <param name="e">A <see cref="T:System.EventArgs"/> that contains the event data. </param>
    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      Uri uri;

      uri = new Uri("https://demo.cyotek.com/features/cookies.php");

      uriToolStripTextBox.Text = uri.OriginalString;

      _webBrowser = this.CreateWebBrowser();

      if (_webBrowser != null)
      {
        splitContainer.Panel1.Controls.Add(_webBrowser);

        _webBrowser.Navigate(uri);
      }
      else
      {
        MessageBox.Show("Failed to create embedded web browser.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (AboutDialog dialog = new AboutDialog())
      {
        dialog.ShowDialog(this);
      }
    }

    private void browserToolStrip_ItemAdded(object sender, ToolStripItemEventArgs e)
    {
      this.ResizeUriEditor();
    }

    private void CheckIfDone()
    {
      if (_webBrowser != null && !_webBrowser.IsBusy)
      {
        statusToolStripStatusLabel.Text = string.Empty;

        uriToolStripTextBox.Text = _webBrowser.Url.OriginalString;

        stopToolStripButton.Enabled = false;
        refreshToolStripButton.Enabled = true;

        this.ListCookies();
      }
    }

    private void cookiesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (ViewCookiesDialog dialog = new ViewCookiesDialog(_webBrowser.Url))
      {
        dialog.ShowDialog();
      }
    }

    private WebBrowser CreateWebBrowser()
    {
      WebBrowser result;

      try
      {
        result = new WebBrowser
                 {
                   Dock = DockStyle.Fill,
                   ScriptErrorsSuppressed = true,
                   IsWebBrowserContextMenuEnabled = false
                 };
        result.CanGoBackChanged += this.WebBrowserCanGoBackChangedHandler;
        result.CanGoForwardChanged += this.WebBrowserCanGoForwardChangedHandler;
        result.Navigating += this.WebBrowserNavigatingHandler;
        result.Navigated += this.WebBrowserNavigatedHandler;
        result.DocumentCompleted += this.WebBrowserDocumentCompletedHandler;
      }
      catch
      {
        result = null;
      }

      return result;
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private CookieRetrievalFlags GetFlags()
    {
      CookieRetrievalFlags flags;

      flags = CookieRetrievalFlags.None;

      if (includeHTTPOnlyToolStripMenuItem.Checked)
      {
        flags |= CookieRetrievalFlags.HttpOnly;
      }

      return flags;
    }

    private void includeHTTPOnlyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      includeHTTPOnlyToolStripMenuItem.Checked = !includeHTTPOnlyToolStripMenuItem.Checked;

      this.ListCookies();
    }

    private void ListCookies()
    {
      this.ListInternetGetCookieEx();
      this.ListWebBrowserControlCookies();
    }

    private void ListInternetGetCookieEx()
    {
      CookieRetrievalFlags flags;
      string cookies;

      flags = this.GetFlags();

      cookies = Cookies.GetCookies(_webBrowser.Url, flags);

      cookiesTextBox.Cookies = cookies;

      //CookieContainer container;
      //HttpWebRequest request;

      //container = new CookieContainer();
      //container.SetCookies(_webBrowser.Url, cookies.Replace("; ", ","));

      //request = WebRequest.CreateHttp(_webBrowser.Url);
      //request.CookieContainer = container;
    }

    private void ListWebBrowserControlCookies()
    {
      string cookies;

      cookies = _webBrowser?.Document?.Cookie;

      instanceCookiesTextBox.Cookies = cookies;
    }

    private void Navigate(Uri uri)
    {
      if (uri != null)
      {
        this.ExecCommand(wb => wb.Navigate(uri));
      }
      else
      {
        SystemSounds.Exclamation.Play();
      }
    }

    private void Navigate(string url)
    {
      Uri uri;

      if (!string.IsNullOrEmpty(url) && Uri.TryCreate(url, UriKind.Absolute, out uri))
      {
        this.ExecCommand(wb => wb.Navigate(uri));
      }
      else
      {
        SystemSounds.Exclamation.Play();
      }
    }

    private void navigateBackToolStripButton_Click(object sender, EventArgs e)
    {
      this.ExecCommand(wb => wb.GoBack());
    }

    private void navigateForwardToolStripButton_Click(object sender, EventArgs e)
    {
      this.ExecCommand(wb => wb.GoForward());
    }

    private void refreshToolStripButton_Click(object sender, EventArgs e)
    {
      this.Navigate(_webBrowser.Url);
    }

    private void ResizeUriEditor()
    {
      if (browserToolStrip != null)
      {
        int width;
        int otherWidth;

        otherWidth = browserToolStrip.Items.Cast<ToolStripItem>().Where(item => item != uriToolStripTextBox).Sum(item => item.Width + item.Margin.Horizontal);
        width = this.ClientSize.Width - (otherWidth + uriToolStripTextBox.Margin.Horizontal + 8);

        uriToolStripTextBox.Width = width;
        uriToolStripTextBox.Invalidate();
      }
    }

    private void stopToolStripButton_Click(object sender, EventArgs e)
    {
      this.ExecCommand(wb => wb.Stop());
    }

    private void uriToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == '\r')
      {
        e.Handled = true;

        this.Navigate(uriToolStripTextBox.Text);
      }
    }

    private void WebBrowserCanGoBackChangedHandler(object sender, EventArgs e)
    {
      navigateBackToolStripButton.Enabled = _webBrowser.CanGoBack;
    }

    private void WebBrowserCanGoForwardChangedHandler(object sender, EventArgs e)
    {
      navigateForwardToolStripButton.Enabled = _webBrowser.CanGoForward;
    }

    private void WebBrowserDocumentCompletedHandler(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
      this.CheckIfDone();
    }

    private void WebBrowserNavigatedHandler(object sender, WebBrowserNavigatedEventArgs e)
    {
      this.CheckIfDone();
    }

    private void WebBrowserNavigatingHandler(object sender, WebBrowserNavigatingEventArgs e)
    {
      stopToolStripButton.Enabled = true;

      statusToolStripStatusLabel.Text = e.Url.ToString();
    }

    #endregion
  }
}
