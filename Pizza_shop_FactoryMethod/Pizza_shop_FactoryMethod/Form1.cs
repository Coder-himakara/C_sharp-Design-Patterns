namespace Pizza_shop_FactoryMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
           
        }

        private void select_NY_store(object sender, EventArgs e)
        {
           welcome_interface1.Visible =false ;
           nY_interface1.Visible = true;
           
        }

        private void select_chicago_store(object sender, EventArgs e)
        {

        }

       
    }
}
