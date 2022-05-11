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
        public string filename;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
           // filename = "d:\\" + fileNameTextBox.Text + ".txt";
            BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.Open, FileAccess.Write));
            int length = (int)bw.BaseStream.Length;
            if (length != 0)
            {
                bw.BaseStream.Seek(length, SeekOrigin.Begin);
            }
            bw.Write(int.Parse(IDtextBox.Text));    // Id TextBox:

            Name_textBox.Text = Name_textBox.Text.PadRight(9); // Name
            bw.Write(Name_textBox.Text.Substring(0, 9));

            bw.Write(int.Parse(Age_textBox.Text));   //Age

            phone_textBox.Text = phone_textBox.Text.PadRight(11);
            bw.Write(phone_textBox.Text.Substring(0, 11));  //Phone_Number

            IDtextBox.Text = Name_textBox.Text = Age_textBox.Text = phone_textBox.Text;

            MessageBox.Show(" Data is Saved Successfully! ");
            bw.Close();
        }

        private void idTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
