using System;
using System.ComponentModel;
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
  [DefaultProperty(nameof(Cookies))]
  [DefaultEvent(nameof(CookiesChanged))]
  internal class CookiesTextBox : TextBox
  {
    #region Constants

    private static readonly object _eventCookiesChanged = new object();

    #endregion

    #region Fields

    private string _cookies;

    #endregion

    #region Constructors

    public CookiesTextBox()
    {
      base.ReadOnly = true;
      base.Multiline = true;
      base.ScrollBars = ScrollBars.Both;
      base.WordWrap = false;
    }

    #endregion

    #region Events

    /// <summary>
    /// Occurs when the Cookies property value changes
    /// </summary>
    [Category("Property Changed")]
    public event EventHandler CookiesChanged
    {
      add { this.Events.AddHandler(_eventCookiesChanged, value); }
      remove { this.Events.RemoveHandler(_eventCookiesChanged, value); }
    }

    #endregion

    #region Properties

    [Category("Appearance")]
    [DefaultValue("")]
    public string Cookies
    {
      get { return _cookies; }
      set
      {
        if (_cookies != value)
        {
          _cookies = value;

          this.OnCookiesChanged(EventArgs.Empty);
        }
      }
    }

    [DefaultValue(true)]
    public override bool Multiline
    {
      get { return base.Multiline; }
      set { base.Multiline = value; }
    }

    [DefaultValue(true)]
    public new bool ReadOnly
    {
      get { return base.ReadOnly; }
      set { base.ReadOnly = value; }
    }

    [DefaultValue(typeof(ScrollBars), "Both")]
    public new ScrollBars ScrollBars
    {
      get { return base.ScrollBars; }
      set { base.ScrollBars = value; }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override string Text
    {
      get { return base.Text; }
      set { base.Text = value; }
    }

    [DefaultValue(false)]
    public new bool WordWrap
    {
      get { return base.WordWrap; }
      set { base.WordWrap = value; }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Raises the <see cref="CookiesChanged" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    protected virtual void OnCookiesChanged(EventArgs e)
    {
      EventHandler handler;

      this.SetCookieText();

      handler = (EventHandler)this.Events[_eventCookiesChanged];

      handler?.Invoke(this, e);
    }

    private void SetCookieText()
    {
      if (!string.IsNullOrEmpty(_cookies))
      {
        base.Text = _cookies.Replace("; ", Environment.NewLine);
      }
      else
      {
        base.Text = string.Empty;
      }
    }

    #endregion
  }
}
