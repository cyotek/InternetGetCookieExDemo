namespace Cyotek.Demonstrations.InternetGetCookieEx
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.SplitContainer outputSplitContainer;
      System.Windows.Forms.GroupBox win32GroupBox;
      System.Windows.Forms.GroupBox webBrowserGoupBox;
      this.cookiesTextBox = new Cyotek.Demonstrations.InternetGetCookieEx.CookiesTextBox();
      this.instanceCookiesTextBox = new Cyotek.Demonstrations.InternetGetCookieEx.CookiesTextBox();
      this.splitContainer = new System.Windows.Forms.SplitContainer();
      this.browserToolStrip = new System.Windows.Forms.ToolStrip();
      this.navigateBackToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.navigateForwardToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.uriToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
      this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.stopToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cookiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.includeHTTPOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      outputSplitContainer = new System.Windows.Forms.SplitContainer();
      win32GroupBox = new System.Windows.Forms.GroupBox();
      webBrowserGoupBox = new System.Windows.Forms.GroupBox();
      ((System.ComponentModel.ISupportInitialize)(outputSplitContainer)).BeginInit();
      outputSplitContainer.Panel1.SuspendLayout();
      outputSplitContainer.Panel2.SuspendLayout();
      outputSplitContainer.SuspendLayout();
      win32GroupBox.SuspendLayout();
      webBrowserGoupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      this.browserToolStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // outputSplitContainer
      // 
      outputSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      outputSplitContainer.Location = new System.Drawing.Point(0, 0);
      outputSplitContainer.Name = "outputSplitContainer";
      outputSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // outputSplitContainer.Panel1
      // 
      outputSplitContainer.Panel1.Controls.Add(win32GroupBox);
      // 
      // outputSplitContainer.Panel2
      // 
      outputSplitContainer.Panel2.Controls.Add(webBrowserGoupBox);
      outputSplitContainer.Size = new System.Drawing.Size(354, 658);
      outputSplitContainer.SplitterDistance = 327;
      outputSplitContainer.TabIndex = 1;
      // 
      // win32GroupBox
      // 
      win32GroupBox.Controls.Add(this.cookiesTextBox);
      win32GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      win32GroupBox.Location = new System.Drawing.Point(0, 0);
      win32GroupBox.Name = "win32GroupBox";
      win32GroupBox.Size = new System.Drawing.Size(354, 327);
      win32GroupBox.TabIndex = 0;
      win32GroupBox.TabStop = false;
      win32GroupBox.Text = "InternetGetCookieEx:";
      // 
      // cookiesTextBox
      // 
      this.cookiesTextBox.Cookies = null;
      this.cookiesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cookiesTextBox.Location = new System.Drawing.Point(3, 16);
      this.cookiesTextBox.Name = "cookiesTextBox";
      this.cookiesTextBox.Size = new System.Drawing.Size(348, 308);
      this.cookiesTextBox.TabIndex = 0;
      // 
      // webBrowserGoupBox
      // 
      webBrowserGoupBox.Controls.Add(this.instanceCookiesTextBox);
      webBrowserGoupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      webBrowserGoupBox.Location = new System.Drawing.Point(0, 0);
      webBrowserGoupBox.Name = "webBrowserGoupBox";
      webBrowserGoupBox.Size = new System.Drawing.Size(354, 327);
      webBrowserGoupBox.TabIndex = 1;
      webBrowserGoupBox.TabStop = false;
      webBrowserGoupBox.Text = "WebBrowser.Cookie";
      // 
      // instanceCookiesTextBox
      // 
      this.instanceCookiesTextBox.Cookies = null;
      this.instanceCookiesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.instanceCookiesTextBox.Location = new System.Drawing.Point(3, 16);
      this.instanceCookiesTextBox.Name = "instanceCookiesTextBox";
      this.instanceCookiesTextBox.Size = new System.Drawing.Size(348, 308);
      this.instanceCookiesTextBox.TabIndex = 0;
      // 
      // splitContainer
      // 
      this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.splitContainer.Location = new System.Drawing.Point(0, 49);
      this.splitContainer.Name = "splitContainer";
      // 
      // splitContainer.Panel2
      // 
      this.splitContainer.Panel2.Controls.Add(outputSplitContainer);
      this.splitContainer.Size = new System.Drawing.Size(1008, 658);
      this.splitContainer.SplitterDistance = 650;
      this.splitContainer.TabIndex = 0;
      // 
      // browserToolStrip
      // 
      this.browserToolStrip.CanOverflow = false;
      this.browserToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.browserToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigateBackToolStripButton,
            this.navigateForwardToolStripButton,
            this.uriToolStripTextBox,
            this.refreshToolStripButton,
            this.stopToolStripButton});
      this.browserToolStrip.Location = new System.Drawing.Point(0, 24);
      this.browserToolStrip.Name = "browserToolStrip";
      this.browserToolStrip.Size = new System.Drawing.Size(1008, 25);
      this.browserToolStrip.Stretch = true;
      this.browserToolStrip.TabIndex = 2;
      this.browserToolStrip.Text = "Browser";
      this.browserToolStrip.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.browserToolStrip_ItemAdded);
      this.browserToolStrip.ItemRemoved += new System.Windows.Forms.ToolStripItemEventHandler(this.browserToolStrip_ItemAdded);
      // 
      // navigateBackToolStripButton
      // 
      this.navigateBackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.navigateBackToolStripButton.Enabled = false;
      this.navigateBackToolStripButton.Image = global::Cyotek.Demonstrations.InternetGetCookieEx.Properties.Resources.NavigateBack;
      this.navigateBackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.navigateBackToolStripButton.Name = "navigateBackToolStripButton";
      this.navigateBackToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.navigateBackToolStripButton.Text = "Back";
      this.navigateBackToolStripButton.Click += new System.EventHandler(this.navigateBackToolStripButton_Click);
      // 
      // navigateForwardToolStripButton
      // 
      this.navigateForwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.navigateForwardToolStripButton.Enabled = false;
      this.navigateForwardToolStripButton.Image = global::Cyotek.Demonstrations.InternetGetCookieEx.Properties.Resources.NavigateForward;
      this.navigateForwardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.navigateForwardToolStripButton.Name = "navigateForwardToolStripButton";
      this.navigateForwardToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.navigateForwardToolStripButton.Text = "Forward";
      this.navigateForwardToolStripButton.Click += new System.EventHandler(this.navigateForwardToolStripButton_Click);
      // 
      // uriToolStripTextBox
      // 
      this.uriToolStripTextBox.AutoSize = false;
      this.uriToolStripTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.uriToolStripTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
      this.uriToolStripTextBox.Name = "uriToolStripTextBox";
      this.uriToolStripTextBox.Size = new System.Drawing.Size(100, 25);
      this.uriToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uriToolStripTextBox_KeyPress);
      // 
      // refreshToolStripButton
      // 
      this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.refreshToolStripButton.Enabled = false;
      this.refreshToolStripButton.Image = global::Cyotek.Demonstrations.InternetGetCookieEx.Properties.Resources.NavigateRefresh;
      this.refreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.refreshToolStripButton.Name = "refreshToolStripButton";
      this.refreshToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.refreshToolStripButton.Text = "Refresh";
      this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
      // 
      // stopToolStripButton
      // 
      this.stopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.stopToolStripButton.Enabled = false;
      this.stopToolStripButton.Image = global::Cyotek.Demonstrations.InternetGetCookieEx.Properties.Resources.NavigateStop;
      this.stopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.stopToolStripButton.Name = "stopToolStripButton";
      this.stopToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.stopToolStripButton.Text = "Stop";
      this.stopToolStripButton.Click += new System.EventHandler(this.stopToolStripButton_Click);
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripStatusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 707);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(1008, 22);
      this.statusStrip.TabIndex = 1;
      // 
      // statusToolStripStatusLabel
      // 
      this.statusToolStripStatusLabel.Name = "statusToolStripStatusLabel";
      this.statusToolStripStatusLabel.Size = new System.Drawing.Size(993, 17);
      this.statusToolStripStatusLabel.Spring = true;
      this.statusToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.includeHTTPOnlyToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cookiesToolStripMenuItem});
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.viewToolStripMenuItem.Text = "&View";
      // 
      // cookiesToolStripMenuItem
      // 
      this.cookiesToolStripMenuItem.Name = "cookiesToolStripMenuItem";
      this.cookiesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
      this.cookiesToolStripMenuItem.Text = "&Cookies...";
      this.cookiesToolStripMenuItem.Click += new System.EventHandler(this.cookiesToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.aboutToolStripMenuItem.Text = "&About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // includeHTTPOnlyToolStripMenuItem
      // 
      this.includeHTTPOnlyToolStripMenuItem.Name = "includeHTTPOnlyToolStripMenuItem";
      this.includeHTTPOnlyToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
      this.includeHTTPOnlyToolStripMenuItem.Text = "Include &HTTP Only";
      this.includeHTTPOnlyToolStripMenuItem.Click += new System.EventHandler(this.includeHTTPOnlyToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
      // 
      // MainForm
      // 
      this.ClientSize = new System.Drawing.Size(1008, 729);
      this.Controls.Add(this.splitContainer);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.browserToolStrip);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.Text = "www.cyotek.com InternetGetCookieEx Demonstration";
      outputSplitContainer.Panel1.ResumeLayout(false);
      outputSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(outputSplitContainer)).EndInit();
      outputSplitContainer.ResumeLayout(false);
      win32GroupBox.ResumeLayout(false);
      win32GroupBox.PerformLayout();
      webBrowserGoupBox.ResumeLayout(false);
      webBrowserGoupBox.PerformLayout();
      this.splitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
      this.splitContainer.ResumeLayout(false);
      this.browserToolStrip.ResumeLayout(false);
      this.browserToolStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ToolStrip browserToolStrip;
    private System.Windows.Forms.ToolStripButton navigateBackToolStripButton;
    private System.Windows.Forms.ToolStripButton navigateForwardToolStripButton;
    private System.Windows.Forms.ToolStripButton refreshToolStripButton;
    private System.Windows.Forms.ToolStripButton stopToolStripButton;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel;
    private System.Windows.Forms.ToolStripTextBox uriToolStripTextBox;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private CookiesTextBox cookiesTextBox;
    private CookiesTextBox instanceCookiesTextBox;
    private System.Windows.Forms.SplitContainer splitContainer;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cookiesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem includeHTTPOnlyToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
  }
}