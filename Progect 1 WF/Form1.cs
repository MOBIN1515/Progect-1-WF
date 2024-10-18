using System.Reflection;
using System.Windows.Forms;

namespace Progect_1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        private void TextBoxUserName_Click(object sender, EventArgs e)
        {
        }
        struct Student3()
        {
            public int? id;
            public string name;
            public int? password;
        }

         Student3[] _student4 = new Student3[5];
        int _Pointer = 0;
        private void buttonSign_Click(object sender, EventArgs e)
        {
            _student4[_Pointer].id = _Pointer;
            _student4[_Pointer].name = textBox2.Text;
            _student4[_Pointer].password = int.Parse(textBox1.Text);
            _Pointer++;
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;

            Student student2 = new Student();
            student2.FirstName = "Mobin";
            student2.LastName = "Mansouri";
            student2.NationalIdNumber = "0111111111";
            student2.PhoneNumber = "0937001122";
            string username = textBox2.Text;
            string password = textBox1.Text;
            string Id = TextBoxId.Text;
            
            
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(Id))
                {
                    MessageBox.Show("Please enter correct Informatoin.");
                    
                }
            else
            {
                MessageBox.Show("Add");
            }
                if (Id.Length == 14)
                {
                    MessageBox.Show("Please enter correct Id.");
                
                    
                }
               
            
            
           
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            _student4[0].name = "hassan";
            _student4[1].name = "ali";
            _student4[2].name = "hossien";
            _student4[3].name = "mobin";
            _student4[4].name = "amir";
            bool bi = false;
            for (int i = 0; i < _student4.Length; i++)
            {
                if (TEXTBOXNAME2.Text == _student4[i].name)
                {
                    _student4[i].name = string.Empty;
                    _student4[i].id = null;
                    _student4[i].id = null;
                    break;
                }
            }
            if (bi)
            {
                MessageBox.Show("this student was deleted");
            }
            else
            {
                MessageBox.Show("this student wad not find");
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
