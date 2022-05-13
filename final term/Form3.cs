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

namespace final_term
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            fileNameTxtBox.Text = infocs.filename;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {
                BinaryReader br = new BinaryReader(File.Open(infocs.filename, FileMode.Open, FileAccess.Read));
                int sId = Int32.Parse(searchTxtBox.Text);
                int num_of_records = (int)br.BaseStream.Length / infocs.recSize;
                for (int i = 0; i < num_of_records; i++)
                {
                    int id = br.ReadInt32();
                    string name = br.ReadString();
                    int age = br.ReadInt32();
                    string phone = br.ReadString();
                    int hieght = br.ReadInt32();
                    int wieght = br.ReadInt32();
                    if(sId == id)
                    {
                        idTxtBox.Text = id.ToString();
                        nameTxtBox.Text = name;
                        ageTxtBox.Text = age.ToString();
                        phoneTxtBox.Text = phone.ToString();    
                        hieghtTxtBox.Text = hieght.ToString();
                        wieghtTxtBox.Text = wieght.ToString();
                        flag = true;
                    }
                }
                br.Close(); 
            }
            catch
            {

            }
            if(flag == false)
            {
                MessageBox.Show("this ID does not found","ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);   
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
