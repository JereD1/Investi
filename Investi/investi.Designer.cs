namespace Investi
{
    partial class investi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Panel();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Panel();
            this.Register_Btn2 = new System.Windows.Forms.Button();
            this.Register_Box = new System.Windows.Forms.ComboBox();
            this.ConfirmPassword_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Password_textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Username_textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Login_Btn2 = new System.Windows.Forms.Button();
            this.Login_Box = new System.Windows.Forms.ComboBox();
            this.Show_Password1 = new System.Windows.Forms.CheckBox();
            this.Register_Btn3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Register_Btn = new System.Windows.Forms.Button();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Login.SuspendLayout();
            this.Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Investi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Poppins ExtraBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(13, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 70);
            this.label2.TabIndex = 1;
            this.label2.Text = "Let\'s Get Started";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Register_Btn);
            this.panel1.Controls.Add(this.Login_Btn);
            this.panel1.Location = new System.Drawing.Point(-1, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 773);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Login
            // 
            this.Login.Controls.Add(this.Register);
            this.Login.Controls.Add(this.TxtPassword);
            this.Login.Controls.Add(this.TxtUsername);
            this.Login.Controls.Add(this.Login_Btn2);
            this.Login.Controls.Add(this.Login_Box);
            this.Login.Controls.Add(this.Show_Password1);
            this.Login.Controls.Add(this.Register_Btn3);
            this.Login.Controls.Add(this.label6);
            this.Login.Controls.Add(this.label5);
            this.Login.Controls.Add(this.label4);
            this.Login.Controls.Add(this.label7);
            this.Login.Controls.Add(this.label8);
            this.Login.Controls.Add(this.label9);
            this.Login.Location = new System.Drawing.Point(-2, 1);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(496, 781);
            this.Login.TabIndex = 3;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Location = new System.Drawing.Point(80, 376);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(366, 56);
            this.TxtPassword.TabIndex = 30;
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsername.Location = new System.Drawing.Point(80, 236);
            this.TxtUsername.Multiline = true;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(366, 56);
            this.TxtUsername.TabIndex = 29;
            // 
            // Register
            // 
            this.Register.Controls.Add(this.Register_Btn2);
            this.Register.Controls.Add(this.Register_Box);
            this.Register.Controls.Add(this.ConfirmPassword_textBox);
            this.Register.Controls.Add(this.label10);
            this.Register.Controls.Add(this.checkBox1);
            this.Register.Controls.Add(this.button2);
            this.Register.Controls.Add(this.label11);
            this.Register.Controls.Add(this.label12);
            this.Register.Controls.Add(this.Password_textBox2);
            this.Register.Controls.Add(this.label13);
            this.Register.Controls.Add(this.Username_textBox2);
            this.Register.Controls.Add(this.label14);
            this.Register.Controls.Add(this.label15);
            this.Register.Controls.Add(this.label16);
            this.Register.Location = new System.Drawing.Point(-2, 1);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(510, 766);
            this.Register.TabIndex = 28;
            // 
            // Register_Btn2
            // 
            this.Register_Btn2.BackColor = System.Drawing.Color.Navy;
            this.Register_Btn2.Font = new System.Drawing.Font("Poppins ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Register_Btn2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Register_Btn2.Location = new System.Drawing.Point(275, 596);
            this.Register_Btn2.Name = "Register_Btn2";
            this.Register_Btn2.Size = new System.Drawing.Size(156, 47);
            this.Register_Btn2.TabIndex = 42;
            this.Register_Btn2.Text = "Register";
            this.Register_Btn2.UseVisualStyleBackColor = false;
            this.Register_Btn2.Click += new System.EventHandler(this.Register_Btn2_Click);
            // 
            // Register_Box
            // 
            this.Register_Box.Font = new System.Drawing.Font("Poppins ExtraBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Register_Box.ForeColor = System.Drawing.Color.DarkBlue;
            this.Register_Box.FormattingEnabled = true;
            this.Register_Box.Items.AddRange(new object[] {
            "Content Creator",
            "Client"});
            this.Register_Box.Location = new System.Drawing.Point(87, 596);
            this.Register_Box.Name = "Register_Box";
            this.Register_Box.Size = new System.Drawing.Size(182, 47);
            this.Register_Box.TabIndex = 41;
            this.Register_Box.Text = "Register As ";
            this.Register_Box.SelectedIndexChanged += new System.EventHandler(this.Register_Box_SelectedIndexChanged);
            // 
            // ConfirmPassword_textBox
            // 
            this.ConfirmPassword_textBox.Location = new System.Drawing.Point(87, 458);
            this.ConfirmPassword_textBox.Multiline = true;
            this.ConfirmPassword_textBox.Name = "ConfirmPassword_textBox";
            this.ConfirmPassword_textBox.Size = new System.Drawing.Size(354, 55);
            this.ConfirmPassword_textBox.TabIndex = 40;
            this.ConfirmPassword_textBox.TextChanged += new System.EventHandler(this.ConfirmPassword_textBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(81, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 38);
            this.label10.TabIndex = 39;
            this.label10.Text = "Confirm Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(275, 527);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 29);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Poppins ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(296, 682);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 47);
            this.button2.TabIndex = 37;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(78, 695);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Don\'t Have an Account?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(143, 742);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 25);
            this.label12.TabIndex = 35;
            this.label12.Text = "All Rights Reserved 2022";
            // 
            // Password_textBox2
            // 
            this.Password_textBox2.Location = new System.Drawing.Point(87, 324);
            this.Password_textBox2.Multiline = true;
            this.Password_textBox2.Name = "Password_textBox2";
            this.Password_textBox2.Size = new System.Drawing.Size(354, 55);
            this.Password_textBox2.TabIndex = 34;
            this.Password_textBox2.TextChanged += new System.EventHandler(this.Password_textBox2_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label13.Location = new System.Drawing.Point(81, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 38);
            this.label13.TabIndex = 33;
            this.label13.Text = "Password";
            // 
            // Username_textBox2
            // 
            this.Username_textBox2.Location = new System.Drawing.Point(87, 188);
            this.Username_textBox2.Multiline = true;
            this.Username_textBox2.Name = "Username_textBox2";
            this.Username_textBox2.Size = new System.Drawing.Size(354, 55);
            this.Username_textBox2.TabIndex = 32;
            this.Username_textBox2.TextChanged += new System.EventHandler(this.Username_textBox2_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label14.Location = new System.Drawing.Point(78, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 38);
            this.label14.TabIndex = 31;
            this.label14.Text = "Username";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Font = new System.Drawing.Font("Poppins ExtraBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(19, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(266, 70);
            this.label15.TabIndex = 30;
            this.label15.Text = "Get Started";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Font = new System.Drawing.Font("Poppins ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(21, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(390, 64);
            this.label16.TabIndex = 29;
            this.label16.Text = "Welcome To Investi";
            // 
            // Login_Btn2
            // 
            this.Login_Btn2.BackColor = System.Drawing.Color.Navy;
            this.Login_Btn2.Font = new System.Drawing.Font("Poppins ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_Btn2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Login_Btn2.Location = new System.Drawing.Point(271, 544);
            this.Login_Btn2.Name = "Login_Btn2";
            this.Login_Btn2.Size = new System.Drawing.Size(162, 47);
            this.Login_Btn2.TabIndex = 27;
            this.Login_Btn2.Text = "Login";
            this.Login_Btn2.UseVisualStyleBackColor = false;
            this.Login_Btn2.Click += new System.EventHandler(this.Login_Btn2_Click);
            // 
            // Login_Box
            // 
            this.Login_Box.Font = new System.Drawing.Font("Poppins ExtraBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_Box.ForeColor = System.Drawing.Color.DarkBlue;
            this.Login_Box.FormattingEnabled = true;
            this.Login_Box.Items.AddRange(new object[] {
            "Content Creator",
            "Client"});
            this.Login_Box.Location = new System.Drawing.Point(83, 544);
            this.Login_Box.Name = "Login_Box";
            this.Login_Box.Size = new System.Drawing.Size(182, 47);
            this.Login_Box.TabIndex = 26;
            this.Login_Box.Text = "Login As ";
            this.Login_Box.SelectedIndexChanged += new System.EventHandler(this.Login_Box_SelectedIndexChanged);
            // 
            // Show_Password1
            // 
            this.Show_Password1.AutoSize = true;
            this.Show_Password1.Location = new System.Drawing.Point(271, 442);
            this.Show_Password1.Name = "Show_Password1";
            this.Show_Password1.Size = new System.Drawing.Size(162, 29);
            this.Show_Password1.TabIndex = 25;
            this.Show_Password1.Text = "Show Password";
            this.Show_Password1.UseVisualStyleBackColor = true;
            this.Show_Password1.CheckedChanged += new System.EventHandler(this.Show_Password1_CheckedChanged);
            // 
            // Register_Btn3
            // 
            this.Register_Btn3.BackColor = System.Drawing.Color.Navy;
            this.Register_Btn3.Font = new System.Drawing.Font("Poppins ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Register_Btn3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Register_Btn3.Location = new System.Drawing.Point(302, 649);
            this.Register_Btn3.Name = "Register_Btn3";
            this.Register_Btn3.Size = new System.Drawing.Size(135, 47);
            this.Register_Btn3.TabIndex = 24;
            this.Register_Btn3.Text = "Register";
            this.Register_Btn3.UseVisualStyleBackColor = false;
            this.Register_Btn3.Click += new System.EventHandler(this.Register_Btn3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(80, 657);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Don\'t Have an Account?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(141, 744);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "All Rights Reserved 2022";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(73, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 38);
            this.label4.TabIndex = 20;
            this.label4.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(70, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 38);
            this.label7.TabIndex = 18;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Poppins ExtraBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(53, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 70);
            this.label8.TabIndex = 17;
            this.label8.Text = "Get Started";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Poppins ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(53, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(390, 64);
            this.label9.TabIndex = 16;
            this.label9.Text = "Welcome To Investi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(54, 736);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "All Rights Reserved 2022";
            // 
            // Register_Btn
            // 
            this.Register_Btn.BackColor = System.Drawing.Color.DarkBlue;
            this.Register_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_Btn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Register_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Register_Btn.Location = new System.Drawing.Point(29, 385);
            this.Register_Btn.Name = "Register_Btn";
            this.Register_Btn.Size = new System.Drawing.Size(292, 66);
            this.Register_Btn.TabIndex = 1;
            this.Register_Btn.Text = "Register";
            this.Register_Btn.UseVisualStyleBackColor = false;
            this.Register_Btn.Click += new System.EventHandler(this.Register_Btn_Click);
            // 
            // Login_Btn
            // 
            this.Login_Btn.BackColor = System.Drawing.Color.DarkBlue;
            this.Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Btn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login_Btn.Location = new System.Drawing.Point(29, 299);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(292, 66);
            this.Login_Btn.TabIndex = 0;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.UseVisualStyleBackColor = false;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // investi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 765);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "investi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.investi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.Register.ResumeLayout(false);
            this.Register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button Register_Btn;
        private Button Login_Btn;
        private Label label3;
        private Panel Login;
        private Button Login_Btn2;
        private ComboBox Login_Box;
        private CheckBox Show_Password1;
        private Button Register_Btn3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel Register;
        private Button Register_Btn2;
        private ComboBox Register_Box;
        private TextBox ConfirmPassword_textBox;
        private Label label10;
        private CheckBox checkBox1;
        private Button button2;
        private Label label11;
        private Label label12;
        private TextBox Password_textBox2;
        private Label label13;
        private TextBox Username_textBox2;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox TxtPassword;
        private TextBox TxtUsername;
    }
}