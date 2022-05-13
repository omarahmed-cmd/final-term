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
            this.components = new System.ComponentModel.Container();
            this.insertBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileNameTxtBox = new System.Windows.Forms.TextBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.insertBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.insertBtn.Location = new System.Drawing.Point(262, 150);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(94, 59);
            this.insertBtn.TabIndex = 17;
            this.insertBtn.Text = "insert";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Visible = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.modifyBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modifyBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.modifyBtn.Location = new System.Drawing.Point(413, 215);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(94, 59);
            this.modifyBtn.TabIndex = 19;
            this.modifyBtn.Text = "modify";
            this.modifyBtn.UseVisualStyleBackColor = false;
            this.modifyBtn.Visible = false;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.searchBtn.Location = new System.Drawing.Point(413, 150);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(94, 59);
            this.searchBtn.TabIndex = 20;
            this.searchBtn.Text = "search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Visible = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.displayBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.displayBtn.Location = new System.Drawing.Point(262, 215);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(94, 59);
            this.displayBtn.TabIndex = 21;
            this.displayBtn.Text = "display";
            this.displayBtn.UseVisualStyleBackColor = false;
            this.displayBtn.Visible = false;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fileNameTxtBox
            // 
            this.fileNameTxtBox.Location = new System.Drawing.Point(171, 82);
            this.fileNameTxtBox.Name = "fileNameTxtBox";
            this.fileNameTxtBox.Size = new System.Drawing.Size(161, 27);
            this.fileNameTxtBox.TabIndex = 23;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileNameLabel.Location = new System.Drawing.Point(81, 89);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(84, 20);
            this.fileNameLabel.TabIndex = 24;
            this.fileNameLabel.Text = "file name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 25;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.createBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.createBtn.Location = new System.Drawing.Point(413, 80);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(94, 29);
            this.createBtn.TabIndex = 26;
            this.createBtn.Text = "create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteBtn.Location = new System.Drawing.Point(543, 82);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 27);
            this.deleteBtn.TabIndex = 38;
            this.deleteBtn.Text = "delete file";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileNameTxtBox);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.insertBtn);
            this.Name = "Form1";
            this.Text = "gym application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button insertBtn;
        private Button modifyBtn;
        private Button searchBtn;
        private Button displayBtn;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox fileNameTxtBox;
        private Label fileNameLabel;
        private Label label2;
        private Button createBtn;
        private Button deleteBtn;
    }
}