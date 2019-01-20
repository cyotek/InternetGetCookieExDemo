namespace Cyotek.Demonstrations.InternetGetCookieEx
{
  partial class ViewCookiesDialog
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Label label1;
      System.Windows.Forms.Label label2;
      this.uriTextBox = new System.Windows.Forms.TextBox();
      this.closeButton = new System.Windows.Forms.Button();
      this.debounceTimer = new System.Windows.Forms.Timer(this.components);
      this.cookiesTextBox1 = new Cyotek.Demonstrations.InternetGetCookieEx.CookiesTextBox();
      this.httpOnlyCheckBox = new System.Windows.Forms.CheckBox();
      this.thirdPartyCheckBox = new System.Windows.Forms.CheckBox();
      this.restrictedZoneCheckBox = new System.Windows.Forms.CheckBox();
      label1 = new System.Windows.Forms.Label();
      label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new System.Drawing.Point(9, 9);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(32, 13);
      label1.TabIndex = 0;
      label1.Text = "&URL:";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new System.Drawing.Point(9, 126);
      label2.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
      label2.Name = "label2";
      label2.Size = new System.Drawing.Size(48, 13);
      label2.TabIndex = 5;
      label2.Text = "&Cookies:";
      // 
      // uriTextBox
      // 
      this.uriTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.uriTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.uriTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
      this.uriTextBox.Location = new System.Drawing.Point(12, 25);
      this.uriTextBox.Name = "uriTextBox";
      this.uriTextBox.Size = new System.Drawing.Size(360, 20);
      this.uriTextBox.TabIndex = 1;
      this.uriTextBox.TextChanged += new System.EventHandler(this.uriTextBox_TextChanged);
      // 
      // closeButton
      // 
      this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.closeButton.Location = new System.Drawing.Point(297, 376);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(75, 23);
      this.closeButton.TabIndex = 7;
      this.closeButton.Text = "Close";
      this.closeButton.UseVisualStyleBackColor = true;
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      // 
      // debounceTimer
      // 
      this.debounceTimer.Tick += new System.EventHandler(this.debounceTimer_Tick);
      // 
      // cookiesTextBox1
      // 
      this.cookiesTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cookiesTextBox1.Cookies = null;
      this.cookiesTextBox1.Location = new System.Drawing.Point(12, 142);
      this.cookiesTextBox1.Name = "cookiesTextBox1";
      this.cookiesTextBox1.Size = new System.Drawing.Size(360, 228);
      this.cookiesTextBox1.TabIndex = 6;
      // 
      // httpOnlyCheckBox
      // 
      this.httpOnlyCheckBox.AutoSize = true;
      this.httpOnlyCheckBox.Location = new System.Drawing.Point(12, 51);
      this.httpOnlyCheckBox.Name = "httpOnlyCheckBox";
      this.httpOnlyCheckBox.Size = new System.Drawing.Size(79, 17);
      this.httpOnlyCheckBox.TabIndex = 2;
      this.httpOnlyCheckBox.Text = "&HTTP Only";
      this.httpOnlyCheckBox.UseVisualStyleBackColor = true;
      this.httpOnlyCheckBox.CheckedChanged += new System.EventHandler(this.uriTextBox_TextChanged);
      // 
      // thirdPartyCheckBox
      // 
      this.thirdPartyCheckBox.AutoSize = true;
      this.thirdPartyCheckBox.Location = new System.Drawing.Point(12, 74);
      this.thirdPartyCheckBox.Name = "thirdPartyCheckBox";
      this.thirdPartyCheckBox.Size = new System.Drawing.Size(77, 17);
      this.thirdPartyCheckBox.TabIndex = 3;
      this.thirdPartyCheckBox.Text = "&Third Party";
      this.thirdPartyCheckBox.UseVisualStyleBackColor = true;
      this.thirdPartyCheckBox.CheckedChanged += new System.EventHandler(this.uriTextBox_TextChanged);
      // 
      // restrictedZoneCheckBox
      // 
      this.restrictedZoneCheckBox.AutoSize = true;
      this.restrictedZoneCheckBox.Location = new System.Drawing.Point(12, 97);
      this.restrictedZoneCheckBox.Name = "restrictedZoneCheckBox";
      this.restrictedZoneCheckBox.Size = new System.Drawing.Size(102, 17);
      this.restrictedZoneCheckBox.TabIndex = 4;
      this.restrictedZoneCheckBox.Text = "&Restricted Zone";
      this.restrictedZoneCheckBox.UseVisualStyleBackColor = true;
      this.restrictedZoneCheckBox.CheckedChanged += new System.EventHandler(this.uriTextBox_TextChanged);
      // 
      // ViewCookiesDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.closeButton;
      this.ClientSize = new System.Drawing.Size(384, 411);
      this.Controls.Add(this.restrictedZoneCheckBox);
      this.Controls.Add(this.thirdPartyCheckBox);
      this.Controls.Add(this.httpOnlyCheckBox);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(this.cookiesTextBox1);
      this.Controls.Add(label2);
      this.Controls.Add(this.uriTextBox);
      this.Controls.Add(label1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ViewCookiesDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Cookies";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox uriTextBox;
    private CookiesTextBox cookiesTextBox1;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.Timer debounceTimer;
    private System.Windows.Forms.CheckBox httpOnlyCheckBox;
    private System.Windows.Forms.CheckBox thirdPartyCheckBox;
    private System.Windows.Forms.CheckBox restrictedZoneCheckBox;
  }
}