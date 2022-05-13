using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace final_term
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //try
            //{
              //  infocs.filename = "D://" + fileNameTxtBox.Text + ".txt";  //if user entered special characters
            //}catch 
            //{

//            }
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        

        private void insertBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }



        private void modifyBtn_Click(object sender, EventArgs e)
        {

        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                infocs.filename = "D://" + fileNameTxtBox.Text + ".txt";  //if user entered special characters
                if (!File.Exists(infocs.filename))
                {
                    File.Create(infocs.filename).Close();
                    MessageBox.Show("File is Created successfully!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            insertBtn.Visible = true;
            searchBtn.Visible = true;
            displayBtn.Visible = true;
            modifyBtn.Visible = true;
            createBtn.Visible = false;
            fileNameLabel.Visible = false;
            fileNameTxtBox.Visible = false;
            deleteBtn.Visible = false;


        }

        private void delete_Click(object sender, EventArgs e)
        {
            try {
                infocs.filename = "D://" + fileNameTxtBox.Text + ".txt";
                if (File.Exists(infocs.filename))
                {
                    File.Delete(infocs.filename);
                    fileNameTxtBox.Clear();
                    MessageBox.Show("File is deleted successfully!", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("File is Not Exist!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch 
            {
                
            }
    } 
    }
}