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
            button1 = new Button();
            deviceComboBox = new ComboBox();
            toolPanel = new Panel();
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
            webView.Name = "webView";
            webView.Size = new Size(800, 450);
            webView.TabIndex = 0;
            webView.ZoomFactor = 1D;
            // 
            // userAgentComboBox
            // 
            userAgentComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userAgentComboBox.FormattingEnabled = true;
            userAgentComboBox.Location = new Point(179, 60);
            userAgentComboBox.Name = "userAgentComboBox";
            userAgentComboBox.Size = new Size(317, 28);
            userAgentComboBox.TabIndex = 1;
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(179, 18);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(196, 27);
            urlTextBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(402, 17);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Duyệt Web";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // deviceComboBox
            // 
            deviceComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            deviceComboBox.FormattingEnabled = true;
            deviceComboBox.Location = new Point(179, 107);
            deviceComboBox.Name = "deviceComboBox";
            deviceComboBox.Size = new Size(317, 28);
            deviceComboBox.TabIndex = 4;
            deviceComboBox.SelectedIndexChanged += deviceComboBox_SelectedIndexChanged;
            // 
            // toolPanel
            // 
            toolPanel.Controls.Add(label3);
            toolPanel.Controls.Add(label2);
            toolPanel.Controls.Add(label1);
            toolPanel.Controls.Add(deviceComboBox);
            toolPanel.Controls.Add(userAgentComboBox);
            toolPanel.Controls.Add(urlTextBox);
            toolPanel.Controls.Add(button1);
            toolPanel.Dock = DockStyle.Bottom;
            toolPanel.Location = new Point(0, 294);
            toolPanel.Name = "toolPanel";
            toolPanel.Size = new Size(800, 156);
            toolPanel.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 110);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 7;
            label3.Text = "Chọn loại thiết bị";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 63);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 6;
            label2.Text = "\u007fChọn loại User-Agent";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 5;
            label1.Text = "Nhập URL Web:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolPanel);
            Controls.Add(webView);
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
        private Button button1;
        private ComboBox deviceComboBox;
        private Panel toolPanel;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}