namespace final_term
{
    public partial class Form1 : Form
    {
        public string filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete(filename);
            fileNameTextBox.Clear();
            existLabel.Visible = false;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void createFileBtn_Click(object sender, EventArgs e)
        {
            filename = "d:\\" + fileNameTextBox.Text + ".txt";
            if (!File.Exists(filename))
            {
                File.Create(filename).Close();
                MessageBox.Show("File is Created successfully!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            else
            {
                existLabel.Visible = true;

            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void fileNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}