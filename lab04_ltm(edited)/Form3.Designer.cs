namespace lab04_ltm_edited_
{
    partial class Form3
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
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            userAgentComboBox = new ComboBox();
            urlTextBox = new TextBox();
            DuyetWeb = new Button();
            deviceComboBox = new ComboBox();
            toolPanel = new Panel();
            Delete = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            toolPanel.SuspendLayout();
            SuspendLayout();
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(0, 0);
            webView.Margin = new Padding(4);
            webView.Name = "webView";
            webView.Size = new Size(996, 562);
            webView.TabIndex = 0;
            webView.ZoomFactor = 1D;
            webView.Click += webView_Click;
            // 
            // userAgentComboBox
            // 
            userAgentComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userAgentComboBox.FormattingEnabled = true;
            userAgentComboBox.Location = new Point(224, 75);
            userAgentComboBox.Margin = new Padding(4);
            userAgentComboBox.Name = "userAgentComboBox";
            userAgentComboBox.Size = new Size(393, 33);
            userAgentComboBox.TabIndex = 1;
            userAgentComboBox.SelectedIndexChanged += userAgentComboBox_SelectedIndexChanged_1;
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(224, 22);
            urlTextBox.Margin = new Padding(4);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(244, 31);
            urlTextBox.TabIndex = 2;
            // 
            // DuyetWeb
            // 
            DuyetWeb.Location = new Point(502, 21);
            DuyetWeb.Margin = new Padding(4);
            DuyetWeb.Name = "DuyetWeb";
            DuyetWeb.Size = new Size(118, 36);
            DuyetWeb.TabIndex = 3;
            DuyetWeb.Text = "Duyệt Web";
            DuyetWeb.UseVisualStyleBackColor = true;
            DuyetWeb.Click += WebBrowser_Click;
            // 
            // deviceComboBox
            // 
            deviceComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            deviceComboBox.FormattingEnabled = true;
            deviceComboBox.Location = new Point(224, 134);
            deviceComboBox.Margin = new Padding(4);
            deviceComboBox.Name = "deviceComboBox";
            deviceComboBox.Size = new Size(393, 33);
            deviceComboBox.TabIndex = 4;
            deviceComboBox.SelectedIndexChanged += deviceComboBox_SelectedIndexChanged;
            // 
            // toolPanel
            // 
            toolPanel.Controls.Add(Delete);
            toolPanel.Controls.Add(button1);
            toolPanel.Controls.Add(label3);
            toolPanel.Controls.Add(label2);
            toolPanel.Controls.Add(label1);
            toolPanel.Controls.Add(deviceComboBox);
            toolPanel.Controls.Add(userAgentComboBox);
            toolPanel.Controls.Add(urlTextBox);
            toolPanel.Controls.Add(DuyetWeb);
            toolPanel.Dock = DockStyle.Bottom;
            toolPanel.Location = new Point(0, 367);
            toolPanel.Margin = new Padding(4);
            toolPanel.Name = "toolPanel";
            toolPanel.Size = new Size(998, 195);
            toolPanel.TabIndex = 5;
            toolPanel.Paint += toolPanel_Paint;
            // 
            // Delete
            // 
            Delete.Location = new Point(867, 21);
            Delete.Name = "Delete";
            Delete.Size = new Size(102, 58);
            Delete.TabIndex = 9;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // button1
            // 
            button1.Location = new Point(867, 105);
            button1.Name = "button1";
            button1.Size = new Size(102, 58);
            button1.TabIndex = 8;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 7;
            label3.Text = "Chọn loại thiết bị";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 79);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 25);
            label2.TabIndex = 6;
            label2.Text = "Chọn loại User-Agent";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 5;
            label1.Text = "Nhập URL Web:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 562);
            Controls.Add(toolPanel);
            Controls.Add(webView);
            Margin = new Padding(4);
            Name = "Form3";
            Text = "Bài 2";
            Load += Form3_Load;
            Resize += Form3_Resize_1;
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            toolPanel.ResumeLayout(false);
            toolPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private ComboBox userAgentComboBox;
        private TextBox urlTextBox;
        private Button DuyetWeb;
        private ComboBox deviceComboBox;
        private Panel toolPanel;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Delete;
        private Button button1;
    }
}