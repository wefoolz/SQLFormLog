using Microsoft.Data.SqlClient;
using System.Data;

namespace SQLFormLogin
{
    
    public partial class form_Login : System.Windows.Forms.Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=KD\SQLEXPRESS;Initial Catalog=SqlForm;Persist Security Info=True;User ID=Log13June;Password=123;Encrypt=True;Trust Server Certificate=True");
        public form_Login()
        {
            InitializeComponent();
        }
       
        private void button_Login_Click(object sender, EventArgs e)
        {
            String userName = textBox_Username.Text;
            String password = textBox_password.Text;
            try
            {
                con.Open();
                //String query = "Select * from Login where username= @username and password = @password";
                String query = "Select * from Login where username= '"+userName+"' and password = '"+password+"'";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                /*SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("username", userName);
                cmd.Parameters.AddWithValue("password", password);
                SqlDataReader rdr = cmd.ExecuteReader();*/


                // if (rdr!=null)
                if (dt.Rows.Count>0)
                {
                    
                    FormMenu formmenu = new FormMenu();
                    formmenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login details!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Username.Clear();
                    textBox_password.Clear();

                    textBox_Username.Focus();
                }

            }
            catch(Exception ex) {
            
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Username.Clear();
            textBox_password.Clear(); 
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void form_Login_Load(object sender, EventArgs e)
        {


        }
    }
}
