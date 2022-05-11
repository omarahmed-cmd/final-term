namespace final_term
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
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createFileBtn = new System.Windows.Forms.Button();
            this.deleteFileBtn = new System.Windows.Forms.Button();
            this.existLabel = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.databaseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(261, 34);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(126, 23);
            this.fileNameTextBox.TabIndex = 0;
            this.fileNameTextBox.TextChanged += new System.EventHandler(this.fileNameTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "file name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // createFileBtn
            // 
            this.createFileBtn.Location = new System.Drawing.Point(228, 69);
            this.createFileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createFileBtn.Name = "createFileBtn";
            this.createFileBtn.Size = new System.Drawing.Size(82, 22);
            this.createFileBtn.TabIndex = 2;
            this.createFileBtn.Text = "create";
            this.createFileBtn.UseVisualStyleBackColor = true;
            this.createFileBtn.Click += new System.EventHandler(this.createFileBtn_Click);
            // 
            // deleteFileBtn
            // 
            this.deleteFileBtn.Location = new System.Drawing.Point(332, 69);
            this.deleteFileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteFileBtn.Name = "deleteFileBtn";
            this.deleteFileBtn.Size = new System.Drawing.Size(82, 22);
            this.deleteFileBtn.TabIndex = 3;
            this.deleteFileBtn.Text = "delete";
            this.deleteFileBtn.UseVisualStyleBackColor = true;
            this.deleteFileBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // existLabel
            // 
            this.existLabel.AutoSize = true;
            this.existLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.existLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.existLabel.Location = new System.Drawing.Point(443, 37);
            this.existLabel.Name = "existLabel";
            this.existLabel.Size = new System.Drawing.Size(165, 21);
            this.existLabel.TabIndex = 4;
            this.existLabel.Text = "this file is already exist";
            this.existLabel.Visible = false;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(89, 234);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(80, 33);
            this.insertBtn.TabIndex = 17;
            this.insertBtn.Text = "insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(371, 239);
            this.modifyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(82, 28);
            this.modifyBtn.TabIndex = 19;
            this.modifyBtn.Text = "modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(486, 239);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(82, 22);
            this.searchBtn.TabIndex = 20;
            this.searchBtn.Text = "search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // databaseBtn
            // 
            this.databaseBtn.Location = new System.Drawing.Point(242, 228);
            this.databaseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.databaseBtn.Name = "databaseBtn";
            this.databaseBtn.Size = new System.Drawing.Size(82, 44);
            this.databaseBtn.TabIndex = 21;
            this.databaseBtn.Text = "Connect  Database";
            this.databaseBtn.UseVisualStyleBackColor = true;
            this.databaseBtn.Click += new System.EventHandler(this.databaseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 331);
            this.Controls.Add(this.databaseBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.existLabel);
            this.Controls.Add(this.deleteFileBtn);
            this.Controls.Add(this.createFileBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "gym application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox fileNameTextBox;
        private Label label1;
        private Button createFileBtn;
        private Button deleteFileBtn;
        private Label existLabel;
        private Button insertBtn;
        private Button modifyBtn;
        private Button searchBtn;
        private Button databaseBtn;
    }
}