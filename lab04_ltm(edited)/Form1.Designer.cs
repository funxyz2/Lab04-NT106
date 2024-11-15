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
            Delete = new Button();
            Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHeaders).BeginInit();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(70, 31);
            txtUrl.Margin = new Padding(4);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(473, 31);
            txtUrl.TabIndex = 0;
            txtUrl.TextChanged += txtUrl_TextChanged;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(551, 28);
            btnLoad.Margin = new Padding(4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(118, 36);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // rtbHtmlContent
            // 
            rtbHtmlContent.Location = new Point(15, 98);
            rtbHtmlContent.Margin = new Padding(4);
            rtbHtmlContent.Name = "rtbHtmlContent";
            rtbHtmlContent.Size = new Size(594, 454);
            rtbHtmlContent.TabIndex = 2;
            rtbHtmlContent.Text = "";
            // 
            // btnDownLoad
            // 
            btnDownLoad.Location = new Point(692, 28);
            btnDownLoad.Margin = new Padding(4);
            btnDownLoad.Name = "btnDownLoad";
            btnDownLoad.Size = new Size(118, 36);
            btnDownLoad.TabIndex = 4;
            btnDownLoad.Text = "Download";
            btnDownLoad.UseVisualStyleBackColor = true;
            btnDownLoad.Click += btnDownLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 5;
            label1.Text = "URL:";
            // 
            // dgvHeaders
            // 
            dgvHeaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHeaders.Location = new Point(629, 98);
            dgvHeaders.Margin = new Padding(4);
            dgvHeaders.Name = "dgvHeaders";
            dgvHeaders.RowHeadersWidth = 51;
            dgvHeaders.Size = new Size(462, 455);
            dgvHeaders.TabIndex = 6;
            // 
            // Delete
            // 
            Delete.Location = new Point(836, 30);
            Delete.Margin = new Padding(4);
            Delete.Name = "Delete";
            Delete.Size = new Size(118, 36);
            Delete.TabIndex = 7;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(973, 30);
            Exit.Margin = new Padding(4);
            Exit.Name = "Exit";
            Exit.Size = new Size(118, 36);
            Exit.TabIndex = 8;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 561);
            Controls.Add(Exit);
            Controls.Add(Delete);
            Controls.Add(dgvHeaders);
            Controls.Add(label1);
            Controls.Add(btnDownLoad);
            Controls.Add(rtbHtmlContent);
            Controls.Add(btnLoad);
            Controls.Add(txtUrl);
            Margin = new Padding(4);
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
        private Button Delete;
        private Button Exit;
    }
}
