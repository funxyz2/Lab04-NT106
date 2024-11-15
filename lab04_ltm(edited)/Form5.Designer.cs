namespace lab04_ltm_edited_
{
    partial class Form5
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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            label1 = new Label();
            Browser = new Button();
            Download = new Button();
            label2 = new Label();
            comboBoxOption = new ComboBox();
            txtUrl = new TextBox();
            panel1 = new Panel();
            Delete = new Button();
            Exit = new Button();
            View = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(-15, 2);
            webView21.Margin = new Padding(4);
            webView21.Name = "webView21";
            webView21.Size = new Size(1781, 807);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 1;
            label1.Text = "URL: ";
            label1.Click += label1_Click;
            // 
            // Browser
            // 
            Browser.Location = new Point(630, 3);
            Browser.Name = "Browser";
            Browser.Size = new Size(88, 40);
            Browser.TabIndex = 3;
            Browser.Text = "Browser";
            Browser.UseVisualStyleBackColor = true;
            Browser.Click += Browser_Click;
            // 
            // Download
            // 
            Download.Location = new Point(406, 43);
            Download.Name = "Download";
            Download.Size = new Size(127, 40);
            Download.TabIndex = 4;
            Download.Text = "Download";
            Download.UseVisualStyleBackColor = true;
            Download.Click += Download_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 50);
            label2.Name = "label2";
            label2.Size = new Size(199, 25);
            label2.TabIndex = 6;
            label2.Text = "Download source code:";
            // 
            // comboBoxOption
            // 
            comboBoxOption.FormattingEnabled = true;
            comboBoxOption.Items.AddRange(new object[] { "Chỉ file HTML", "Toàn bộ mã nguồn" });
            comboBoxOption.Location = new Point(218, 47);
            comboBoxOption.Name = "comboBoxOption";
            comboBoxOption.Size = new Size(182, 33);
            comboBoxOption.TabIndex = 5;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(59, 6);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(565, 31);
            txtUrl.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(Delete);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(View);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Download);
            panel1.Controls.Add(comboBoxOption);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUrl);
            panel1.Controls.Add(Browser);
            panel1.Location = new Point(12, 659);
            panel1.Name = "panel1";
            panel1.Size = new Size(1754, 141);
            panel1.TabIndex = 8;
            // 
            // Delete
            // 
            Delete.Location = new Point(770, 6);
            Delete.Name = "Delete";
            Delete.Size = new Size(102, 58);
            Delete.TabIndex = 11;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(770, 80);
            Exit.Name = "Exit";
            Exit.Size = new Size(102, 58);
            Exit.TabIndex = 10;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // View
            // 
            View.Location = new Point(539, 43);
            View.Name = "View";
            View.Size = new Size(179, 40);
            View.TabIndex = 8;
            View.Text = "View full source";
            View.UseVisualStyleBackColor = true;
            View.Click += View_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1763, 799);
            Controls.Add(panel1);
            Controls.Add(webView21);
            Margin = new Padding(4);
            Name = "Form5";
            Text = "Bài 4";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Label label1;
        private Button Browser;
        private Button Download;
        private Label label2;
        private ComboBox comboBoxOption;
        private TextBox txtUrl;
        private Panel panel1;
        private Button View;
        private Button Delete;
        private Button Exit;
    }
}