using System.Data;
using System.Data.SqlClient;
using System.Numerics;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CreateAccount
{
    public partial class Form1 : Form
    {
        string constring = "Data Source=DESKTOP-OGJDEFM\\SQLEXPRESS;Initial Catalog=db_UserAccount;Integrated Security=True";
     //   private Regex validate_Emailaddress;
        public Form1()
        {
            InitializeComponent();
           // validate_Emailaddress = Email_validation();
            
        }
          
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
          
          
        }

        private void txtday_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
          ;
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void btmSubmit_Click(object sender, EventArgs e)
        {
            string currntemail = Convert.ToString(txtCureentEmail.Text);
            string location = Convert.ToString(listLocation.Text);
                if (txtUsername.Text == "" || txtpassword.Text == "")
                {
                    MessageBox.Show("please fill username and password");
                }
                else if(txtFirstName.Text=="" && txtSecondname.Text=="")
            {
                MessageBox.Show("please fill firstname and lastname","Empty textbox",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
                else if (txtpassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Password doenot mached \n fill password correctly");
                }
             else
             {
                using (SqlConnection conn = new SqlConnection(constring))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("procUserAccount", conn);
                    cmd.CommandType = CommandType.StoredProcedure;             
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", txtSecondname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtpassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@Month", listMonth.Text.Trim());
                    cmd.Parameters.AddWithValue("@Day", txtday.Text.Trim());
                    cmd.Parameters.AddWithValue("@Year", txtYear.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", listGender.Text.Trim());
                    cmd.Parameters.AddWithValue("@MobilePhone", txtphoneNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@CurrentEmailAddress", currntemail);
                    cmd.Parameters.AddWithValue("@Location", location);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("submitted successfully");
                 
                    conn.Close();
                }
             }

            clear();
        }
        void clear()
        {
            txtFirstName.Text = txtSecondname.Text = txtUsername.Text = txtpassword.Text = txtday.Text = txtYear.Text = txtphoneNumber.Text = txtCureentEmail.Text=txtConfirmPassword.Text = "";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select UserId,FirstName,LastName,Username,Gender,MobilePhone,CurrentEmailAddress,Location from tbl_UserAccount", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCreateAccount.DataSource = dt;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtYear.Text.Trim(), out int num1))
            {

            }
            else
            {
                MessageBox.Show(" Pls enter the year correctly");

            }
        }

        private void txtday_Leave(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtday.Text);
            if (num1 > 0 && num1 <= 32)
            {

                if (int.TryParse(txtday.Text.Trim(), out  num1))
                {

                }
                else
                {
                    MessageBox.Show(" Pls enter the Day correctly");

                }
            }
            else
            {
                errorProvider1.SetError(this.txtday,"please provide valide day");
                MessageBox.Show("please provide valide day");
            }
        }

        private void txtday_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validatenumber(sender,e);
        }
        private bool validatenumber(object sender , KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            }
            return false;
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validatenumber(sender,e);
        }
      /*  private Regex Email_validation()
        {
            string pattern =@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'+/=?^_`{|}~]|(?<!\.)\.))(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
      */

        private void txtCureentEmail_Leave(object sender, EventArgs e)
        {
            /*  if(validate_Emailaddress.IsMatch(txtCureentEmail.Text)!=true)
              {
                  MessageBox.Show("Invalid Email Address!","invalid",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                  txtCureentEmail.Focus();

              } */
            string pattern = "^([0-9a-zA-Z]([-\\.\\w])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if(Regex.IsMatch(txtCureentEmail.Text, pattern))
            {
                errorProvider2.Clear();

            }
            else
            {
                errorProvider2.SetError(this.txtCureentEmail,"Please provide valid mail Address");
            }
        }

        private void txtphoneNumber_Leave(object sender, EventArgs e)
        {
          
        }

        private void txtphoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validatenumber(sender, e);
        }
    }

}

