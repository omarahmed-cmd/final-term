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
            this.insertBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.databaseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.insertBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.insertBtn.Location = new System.Drawing.Point(275, 152);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(94, 59);
            this.insertBtn.TabIndex = 17;
            this.insertBtn.Text = "Binary";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.modifyBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modifyBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.modifyBtn.Location = new System.Drawing.Point(426, 217);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(94, 59);
            this.modifyBtn.TabIndex = 19;
            this.modifyBtn.Text = "modify";
            this.modifyBtn.UseVisualStyleBackColor = false;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.searchBtn.Location = new System.Drawing.Point(426, 152);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(94, 59);
            this.searchBtn.TabIndex = 20;
            this.searchBtn.Text = "search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // databaseBtn
            // 
            this.databaseBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.databaseBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.databaseBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.databaseBtn.Location = new System.Drawing.Point(275, 217);
            this.databaseBtn.Name = "databaseBtn";
            this.databaseBtn.Size = new System.Drawing.Size(94, 59);
            this.databaseBtn.TabIndex = 21;
            this.databaseBtn.Text = "Connect  Database";
            this.databaseBtn.UseVisualStyleBackColor = false;
            this.databaseBtn.Click += new System.EventHandler(this.databaseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.databaseBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.insertBtn);
            this.Name = "Form1";
            this.Text = "gym application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button insertBtn;
        private Button modifyBtn;
        private Button searchBtn;
        private Button databaseBtn;
    }
}