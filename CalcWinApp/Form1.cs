namespace CalcWinApp
{
    public partial class Form1 : Form
    {
        float num1, num2, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txtFirstNum.Text);
            num2 = Convert.ToInt32(txtSecondNum.Text);
            result = num1 - num2;
            txtResult.Text = result.ToString();
        }

            private void btnMultiply_Click(object sender, EventArgs e)
            {

                num1 = Convert.ToInt32(txtFirstNum.Text);
                num2 = Convert.ToInt32(txtSecondNum.Text);
                result = num1 * num2;
                txtResult.Text = result.ToString();
            }

            private void btnDivide_Click(object sender, EventArgs e)
            {

                num1 = Convert.ToInt32(txtFirstNum.Text);
                num2 = Convert.ToInt32(txtSecondNum.Text);
                result = num1 / num2;
                txtResult.Text = result.ToString();
            }

        private void txtSecondNum_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtSecondNum.Text.Trim(), out num2))
            {

            }
            else
            {
                MessageBox.Show(" Pls enter the integer value");
            }
        }

        private void txtFirstNum_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtSecondNum.Focus();
            }
        }

        private void txtSecondNum_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
            {
                if(float.TryParse(txtFirstNum.Text.Trim(),out num1))
            {

            }
            else
            {
                MessageBox.Show(" Pls enter the integer value");
               
            }
            }

            private void btnAdd_Click(object sender, EventArgs e)
            {

                num1 = Convert.ToInt32(txtFirstNum.Text);
                num2 = Convert.ToInt32(txtSecondNum.Text);
                result = num1 + num2;
                txtResult.Text = result.ToString();
            }
        
    }
}