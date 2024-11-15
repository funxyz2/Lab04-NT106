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
            label4 = new Label();
            Delete = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // listBoxPhotos
            // 
            listBoxPhotos.FormattingEnabled = true;
            listBoxPhotos.ItemHeight = 25;
            listBoxPhotos.Location = new Point(15, 115);
            listBoxPhotos.Margin = new Padding(4);
            listBoxPhotos.Name = "listBoxPhotos";
            listBoxPhotos.Size = new Size(299, 429);
            listBoxPhotos.TabIndex = 0;
            // 
            // listBoxComments
            // 
            listBoxComments.FormattingEnabled = true;
            listBoxComments.ItemHeight = 25;
            listBoxComments.Location = new Point(339, 115);
            listBoxComments.Margin = new Padding(4);
            listBoxComments.Name = "listBoxComments";
            listBoxComments.Size = new Size(316, 429);
            listBoxComments.TabIndex = 1;
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 25;
            listBoxUsers.Location = new Point(680, 115);
            listBoxUsers.Margin = new Padding(4);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(304, 429);
            listBoxUsers.TabIndex = 2;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(15, 46);
            btnLoadData.Margin = new Padding(4);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(118, 36);
            btnLoadData.TabIndex = 3;
            btnLoadData.Text = "Tải dữ liệu";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 86);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 4;
            label1.Text = "100 Photos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 86);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 5;
            label2.Text = "100 Comments";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(808, 86);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 6;
            label3.Text = "10 Users";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(419, 9);
            label4.Name = "label4";
            label4.Size = new Size(236, 38);
            label4.TabIndex = 7;
            label4.Text = "API/Web Service";
            // 
            // Delete
            // 
            Delete.Location = new Point(156, 46);
            Delete.Margin = new Padding(4);
            Delete.Name = "Delete";
            Delete.Size = new Size(118, 36);
            Delete.TabIndex = 8;
            Delete.Text = "Xóa dữ liệu";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(869, 46);
            Exit.Margin = new Padding(4);
            Exit.Name = "Exit";
            Exit.Size = new Size(118, 36);
            Exit.TabIndex = 9;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(Exit);
            Controls.Add(Delete);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLoadData);
            Controls.Add(listBoxUsers);
            Controls.Add(listBoxComments);
            Controls.Add(listBoxPhotos);
            Margin = new Padding(4);
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
        private Label label4;
        private Button Delete;
        private Button Exit;
    }
}