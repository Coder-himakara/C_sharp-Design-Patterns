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

        public void SetClassInstance(NyPizzaStore obj)
        {
            obj1 = obj;
        }
        private void order_ny_pizza(object sender, EventArgs e)
        {
            obj1 = NyPizzaStore.getInstance();
            if (obj1 != null)
            {
                string pizzaType = ny_pizza_list.Text;
                if (pizzaType!="")
                {
                    obj1.makeOrder(pizzaType);
                    string text = obj1.getText1();
                    display_box1.Items.Add(text);
                    string text2 = obj1.getText2();
                    display_box1.Items.Add(text2);
                    string text3 = obj1.getText3();
                    display_box1.Items.Add(text3);
                }
                else
                {
                    MessageBox.Show("Select your pizza type");
                }
                
                

            }
            else
            {
                // Handle the case where obj1 is null
                MessageBox.Show("Error: Pizza object is not initialized.");
            }

        }

       
    }
}
