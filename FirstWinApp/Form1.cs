namespace FirstWinApp
{
    public partial class Calculator : Form
    {
        int txtFirstNum = Convert.ToInt32(Console.ReadLine());
        int txtSecondNum= Convert.ToInt32(Console.ReadLine());   
        public Calculator()
        {
            InitializeComponent();
        }

        private void btmAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}