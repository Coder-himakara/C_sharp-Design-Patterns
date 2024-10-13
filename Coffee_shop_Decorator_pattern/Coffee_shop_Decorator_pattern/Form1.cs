namespace Coffee_shop_Decorator_pattern
{
    public partial class Form1 : Form
    {
        Beverage beverage;       
        double cost;

        public Form1()
        {
            InitializeComponent();
        }

        private void select_btn(object sender, EventArgs e)
        {
            string coffeType = comboBox1.Text;
            textBox1.Text = "You have selected " + coffeType;
            createCoffee(coffeType);
        }

        public Beverage createCoffee(string coffee)
        {
            if (coffee == "HouseBlend")
            {
                beverage = new HouseBlend();
            }
            else if (coffee == "Espresso")
            {
                beverage = new Espresso();
            }
            return beverage;
        }

        private void add_milk(object sender, EventArgs e)
        {
            if (beverage != null)
            {
                beverage = new Milk(beverage);
                string description = this.beverage.getDescription();
                listBox1.Items.Add(description);
                cost = beverage.cost();
            }
            else
            {
                MessageBox.Show("Coffee is not selected");
            }

        }

        private void add_mocha(object sender, EventArgs e)
        {
            if (beverage != null)
            {
                beverage = new Mocha(beverage);
                string description = this.beverage.getDescription();
                listBox1.Items.Add(description);
                cost = beverage.cost();
            }
            else
            {
                MessageBox.Show("Coffee is not selected");
            }

        }

        private void calculate_bill(object sender, EventArgs e)
        {
            string cost_text = Convert.ToString(cost);
            cost_box.Text = cost_text;
        }
    }
}
