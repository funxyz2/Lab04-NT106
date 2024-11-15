namespace lab04_ltm_edited_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUrl = new TextBox();
            btnLoad = new Button();
            rtbHtmlContent = new RichTextBox();
            btnDownLoad = new Button();
            label1 = new Label();
            dgvHeaders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHeaders).BeginInit();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(73, 22);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(347, 27);
            txtUrl.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(441, 22);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // rtbHtmlContent
            // 
            rtbHtmlContent.Location = new Point(12, 78);
            rtbHtmlContent.Name = "rtbHtmlContent";
            rtbHtmlContent.Size = new Size(476, 364);
            rtbHtmlContent.TabIndex = 2;
            rtbHtmlContent.Text = "";
            // 
            // btnDownLoad
            // 
            btnDownLoad.Location = new Point(554, 22);
            btnDownLoad.Name = "btnDownLoad";
            btnDownLoad.Size = new Size(94, 29);
            btnDownLoad.TabIndex = 4;
            btnDownLoad.Text = "Download";
            btnDownLoad.UseVisualStyleBackColor = true;
            btnDownLoad.Click += btnDownLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 5;
            label1.Text = "URL:";
            // 
            // dgvHeaders
            // 
            dgvHeaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHeaders.Location = new Point(503, 78);
            dgvHeaders.Name = "dgvHeaders";
            dgvHeaders.RowHeadersWidth = 51;
            dgvHeaders.Size = new Size(370, 364);
            dgvHeaders.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 449);
            Controls.Add(dgvHeaders);
            Controls.Add(label1);
            Controls.Add(btnDownLoad);
            Controls.Add(rtbHtmlContent);
            Controls.Add(btnLoad);
            Controls.Add(txtUrl);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvHeaders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrl;
        private Button btnLoad;
        private RichTextBox rtbHtmlContent;
        private Button btnDownLoad;
        private Label label1;
        private DataGridView dgvHeaders;
    }
}
