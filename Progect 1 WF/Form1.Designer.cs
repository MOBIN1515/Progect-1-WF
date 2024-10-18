
namespace Progect_1_WF
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
            label1 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            TEXTBOXNAME2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBoxPassword = new Label();
            textBoxName = new Label();
            TextBoxId = new Label();
            TextBoxSignup = new Button();
            groupBox1 = new GroupBox();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(469, 84);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(233, 39);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(162, 134);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TEXTBOXNAME2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Location = new Point(399, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(365, 183);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Remover";
            // 
            // TEXTBOXNAME2
            // 
            TEXTBOXNAME2.AutoSize = true;
            TEXTBOXNAME2.Location = new Point(11, 47);
            TEXTBOXNAME2.Name = "TEXTBOXNAME2";
            TEXTBOXNAME2.Size = new Size(41, 15);
            TEXTBOXNAME2.TabIndex = 12;
            TEXTBOXNAME2.Text = "NAME";
            TEXTBOXNAME2.Click += label3_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(197, 32);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 23);
            textBox3.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.AutoSize = true;
            textBoxPassword.Location = new Point(35, 124);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(62, 15);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.Text = "passsword";
            // 
            // textBoxName
            // 
            textBoxName.AccessibleName = "";
            textBoxName.AutoSize = true;
            textBoxName.Location = new Point(35, 85);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(37, 15);
            textBoxName.TabIndex = 7;
            textBoxName.Text = "name";
            // 
            // TextBoxId
            // 
            TextBoxId.AutoSize = true;
            TextBoxId.Location = new Point(35, 50);
            TextBoxId.Name = "TextBoxId";
            TextBoxId.Size = new Size(18, 15);
            TextBoxId.TabIndex = 2;
            TextBoxId.Text = "ID";
            TextBoxId.Click += label3_Click;
            // 
            // TextBoxSignup
            // 
            TextBoxSignup.Location = new Point(248, 155);
            TextBoxSignup.Name = "TextBoxSignup";
            TextBoxSignup.Size = new Size(75, 30);
            TextBoxSignup.TabIndex = 6;
            TextBoxSignup.Text = "Sign up";
            TextBoxSignup.UseVisualStyleBackColor = true;
            TextBoxSignup.Click += buttonSign_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TextBoxSignup);
            groupBox1.Controls.Add(TextBoxId);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 191);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign Up";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox4;
        private Button button1;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label textBoxPassword;
        private Label textBoxName;
        private Label TextBoxId;
        private Button TextBoxSignup;
        private GroupBox groupBox1;
        private Label TEXTBOXNAME2;
    }
}
