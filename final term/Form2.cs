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
    
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
            fileNameTxtBox.Text = infocs.filename;
        }

        private void Save_Click(object sender, EventArgs e)
        {
           
            BinaryWriter bw = new BinaryWriter(File.Open(infocs.filename, FileMode.Open, FileAccess.Write));
            int length = (int)bw.BaseStream.Length;
            if (length != 0)
            {
                bw.BaseStream.Seek(length, SeekOrigin.Begin);
            }
            bw.Write(Int32.Parse(IDTxtBox.Text));    // Id TextBox  4-byte

            nameTextBox.Text = nameTextBox.Text.PadRight(9); // Name  9-byte
            bw.Write(nameTextBox.Text.Substring(0, 9));
            

            bw.Write(Int32.Parse(AgeTxtBox.Text));   //Age  4-byte

            phoneTxtBox.Text = phoneTxtBox.Text.PadRight(11); 
            bw.Write(phoneTxtBox.Text.Substring(0, 11));  //Phone_Number 11-byte

            bw.Write(Int32.Parse(hieghtTxtBox.Text)); // int  4-byte

            bw.Write(Int32.Parse(wieghtTxtBox.Text)); // int  4-byte

            //IDTxtBox.Text = nameTextBox.Text = AgeTxtBox.Text = phoneTxtBox.Text;

            MessageBox.Show(" Data is Saved Successfully! ");
            IDTxtBox.Clear();
            nameTextBox.Clear();
            phoneTxtBox.Clear();
            AgeTxtBox.Clear();
            hieghtTxtBox.Clear();
            wieghtTxtBox.Clear();
            bw.Close();
        }

        private void idTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        

       

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 form = new Form4();   
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form = new Form3();
            form.Show();
        }
    }
}
