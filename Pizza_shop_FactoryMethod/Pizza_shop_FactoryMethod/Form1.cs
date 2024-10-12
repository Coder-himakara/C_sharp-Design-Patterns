using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Pizza_shop_FactoryMethod
{
    public partial class Form1 : Form
    {
        NyPizzaStore obj;
        private NY_interface nY_Interface;
        public Form1()
        {
            InitializeComponent();
            nY_Interface = new NY_interface();
            nY_Interface.Visible = false;
            Controls.Add(nY_Interface);

        }

        private void select_NY_store(object sender, EventArgs e)
        {
               obj = NyPizzaStore.getInstance();  //singleton object
               nY_Interface.SetClassInstance(obj); //pass the object to NY_interface
               welcome_interface1.Visible =false ;
               nY_Interface.Visible = true;
            if (obj != null)
            {
                MessageBox.Show("Pizza factory is initialized.");
            }
            else
            {
                MessageBox.Show("Pizza factory is not initialized.");
            }
               

        }

        private void select_chicago_store(object sender, EventArgs e)
        {

        }

       
    }
}
