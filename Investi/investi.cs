using System.Collections.Generic;

namespace Investi
{
    public partial class investi : Form
    {
        public investi()
        {
            InitializeComponent();
            panel1.Visible = true;
            Login.Visible = false;
            Register.Visible = false;
    
        }


    private void investi_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            Login.Visible=true;
            Login.BringToFront();


        }

        private void Username_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPassword_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Register_Btn2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Username_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_Password1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Login_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Btn2_Click(object sender, EventArgs e)
        {
              new Content_Creator().Show();
               this.Hide();
           
        }

        private void Register_Btn3_Click(object sender, EventArgs e)
        {

        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {
            Register.Visible = true;
            Register.BringToFront();

        }
    }
}
