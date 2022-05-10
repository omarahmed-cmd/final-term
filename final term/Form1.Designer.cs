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
            this.fileNameTxtBox = new System.Windows.Forms.TextBox();
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
            // fileNameTxtBox
            // 
            this.fileNameTxtBox.Location = new System.Drawing.Point(298, 46);
            this.fileNameTxtBox.Name = "fileNameTxtBox";
            this.fileNameTxtBox.Size = new System.Drawing.Size(143, 27);
            this.fileNameTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "file name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // createFileBtn
            // 
            this.createFileBtn.Location = new System.Drawing.Point(261, 92);
            this.createFileBtn.Name = "createFileBtn";
            this.createFileBtn.Size = new System.Drawing.Size(94, 29);
            this.createFileBtn.TabIndex = 2;
            this.createFileBtn.Text = "create";
            this.createFileBtn.UseVisualStyleBackColor = true;
            this.createFileBtn.Click += new System.EventHandler(this.createFileBtn_Click);
            // 
            // deleteFileBtn
            // 
            this.deleteFileBtn.Location = new System.Drawing.Point(380, 92);
            this.deleteFileBtn.Name = "deleteFileBtn";
            this.deleteFileBtn.Size = new System.Drawing.Size(94, 29);
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
            this.existLabel.Location = new System.Drawing.Point(506, 49);
            this.existLabel.Name = "existLabel";
            this.existLabel.Size = new System.Drawing.Size(205, 28);
            this.existLabel.TabIndex = 4;
            this.existLabel.Text = "this file is already exist";
            this.existLabel.Visible = false;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(131, 319);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(94, 29);
            this.insertBtn.TabIndex = 17;
            this.insertBtn.Text = "insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(424, 319);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(94, 29);
            this.modifyBtn.TabIndex = 19;
            this.modifyBtn.Text = "modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(555, 319);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(94, 29);
            this.searchBtn.TabIndex = 20;
            this.searchBtn.Text = "search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // databaseBtn
            // 
            this.databaseBtn.Location = new System.Drawing.Point(279, 319);
            this.databaseBtn.Name = "databaseBtn";
            this.databaseBtn.Size = new System.Drawing.Size(94, 29);
            this.databaseBtn.TabIndex = 21;
            this.databaseBtn.Text = "database";
            this.databaseBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.databaseBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.existLabel);
            this.Controls.Add(this.deleteFileBtn);
            this.Controls.Add(this.createFileBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileNameTxtBox);
            this.Name = "Form1";
            this.Text = "gym application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox fileNameTxtBox;
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