using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace final_term
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            filenameTxtBox.Text = infocs.filename;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                
                BinaryReader br = new BinaryReader(File.Open(infocs.filename, FileMode.Open, FileAccess.Read));


                displayBtn.Text = "next";
                filenameLabel.Visible = false;
                filenameTxtBox.Visible = false;


                int num_of_records = (int)br.BaseStream.Length / infocs.recSize;

                if (num_of_records > 0) // If The file Not Empty
                {
                    IDLabel.Visible = true;
                    IDTxtBox.Visible = true;
                    nameLabel.Visible = true;
                    nameTxtBox.Visible = true;
                    phoneLabel.Visible = true;
                    phoneTxtBox.Visible = true;
                    ageTxtBox.Visible = true;
                    ageLabel.Visible = true;
                    hieghtLabel.Visible = true;
                    hieghtTxtBox.Visible = true;
                    wieghtTxtBox.Visible = true;
                    wieghtLabel.Visible = true;

                    numOfRecLabel.Text = num_of_records.ToString();
                    fileSizeLabel.Text = br.BaseStream.Length.ToString();

                    br.BaseStream.Seek(infocs.count, SeekOrigin.Begin); // Move to Specific Position in a File

                    IDTxtBox.Text = br.ReadInt32().ToString(); // Read ID and display it in the ID text Box

                    nameTxtBox.Text = br.ReadString(); // Read Name 
                    ageTxtBox.Text = br.ReadInt32().ToString(); // Read age
                    
                    phoneTxtBox.Text = br.ReadString(); // Read phone
                    hieghtTxtBox.Text = br.ReadInt32().ToString(); // Read hieght
                    wieghtTxtBox.Text = br.ReadInt32().ToString(); // Read wieght

                    
                    if ((infocs.count / infocs.recSize) >= (num_of_records - 1)) // If I reach the End of file , Go to the Beginning of file
                        infocs.count = 0;
                    else
                    {
                        infocs.count += infocs.recSize;

                    }
                }

            else MessageBox.Show("Empty File");
            br.Close();
            }
            catch 
            {
                MessageBox.Show("this file is not exist","ERROR!",MessageBoxButtons.OK ,MessageBoxIcon.Error);

            }

        }

            
        

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
