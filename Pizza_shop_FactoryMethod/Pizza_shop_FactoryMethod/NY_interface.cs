using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_shop_FactoryMethod
{
    public partial class NY_interface : UserControl
    {
        NyPizzaStore obj1; //store the object comming from Form 1
        public NY_interface()
        {
            InitializeComponent();
        }

        private void order_ny_pizza(object sender, EventArgs e)
        {

        }

        public void SetClassInstance(NyPizzaStore obj1)
        {
            this.obj1 = obj1;          
        }
    }
}
