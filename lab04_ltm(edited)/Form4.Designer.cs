namespace lab04_ltm_edited_
{
    partial class Form4
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
            listBoxPhotos = new ListBox();
            listBoxComments = new ListBox();
            listBoxUsers = new ListBox();
            btnLoadData = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBoxPhotos
            // 
            listBoxPhotos.FormattingEnabled = true;
            listBoxPhotos.Location = new Point(12, 92);
            listBoxPhotos.Name = "listBoxPhotos";
            listBoxPhotos.Size = new Size(240, 344);
            listBoxPhotos.TabIndex = 0;
            // 
            // listBoxComments
            // 
            listBoxComments.FormattingEnabled = true;
            listBoxComments.Location = new Point(271, 92);
            listBoxComments.Name = "listBoxComments";
            listBoxComments.Size = new Size(254, 344);
            listBoxComments.TabIndex = 1;
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.Location = new Point(544, 92);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(244, 344);
            listBoxUsers.TabIndex = 2;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(12, 12);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(94, 29);
            btnLoadData.TabIndex = 3;
            btnLoadData.Text = "Tải dữ liệu";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 57);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 4;
            label1.Text = "100 Photos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 57);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 5;
            label2.Text = "100 Comments";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(642, 57);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "10 Users";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLoadData);
            Controls.Add(listBoxUsers);
            Controls.Add(listBoxComments);
            Controls.Add(listBoxPhotos);
            Name = "Form4";
            Text = "Bài 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPhotos;
        private ListBox listBoxComments;
        private ListBox listBoxUsers;
        private Button btnLoadData;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}