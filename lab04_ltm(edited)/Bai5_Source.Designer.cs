namespace lab04_ltm_edited_
{
    partial class Bai5_Source
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
            rtbHtmlSource = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // rtbHtmlSource
            // 
            rtbHtmlSource.Dock = DockStyle.Fill;
            rtbHtmlSource.Location = new Point(0, 0);
            rtbHtmlSource.Name = "rtbHtmlSource";
            rtbHtmlSource.Size = new Size(800, 450);
            rtbHtmlSource.TabIndex = 0;
            rtbHtmlSource.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 17);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 1;
            label1.Text = "HTML Source Code";
            // 
            // Bai5_Source
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(rtbHtmlSource);
            Name = "Bai5_Source";
            Text = "Bai5_Source";
            Load += Bai5_Source_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbHtmlSource;
        private Label label1;
    }
}