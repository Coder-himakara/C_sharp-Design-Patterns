namespace Pizza_shop_FactoryMethod
{
    partial class NY_interface
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            display_box1 = new ListBox();
            ny_pizza_list = new ComboBox();
            order_ny_btn = new Button();
            SuspendLayout();
            // 
            // display_box1
            // 
            display_box1.FormattingEnabled = true;
            display_box1.Location = new Point(29, 124);
            display_box1.Name = "display_box1";
            display_box1.Size = new Size(529, 264);
            display_box1.TabIndex = 0;
            // 
            // ny_pizza_list
            // 
            ny_pizza_list.FormattingEnabled = true;
            ny_pizza_list.Items.AddRange(new object[] { "cheese" });
            ny_pizza_list.Location = new Point(29, 44);
            ny_pizza_list.Name = "ny_pizza_list";
            ny_pizza_list.Size = new Size(196, 28);
            ny_pizza_list.TabIndex = 1;
            // 
            // order_ny_btn
            // 
            order_ny_btn.Location = new Point(313, 43);
            order_ny_btn.Name = "order_ny_btn";
            order_ny_btn.Size = new Size(110, 29);
            order_ny_btn.TabIndex = 2;
            order_ny_btn.Text = "make_order";
            order_ny_btn.UseVisualStyleBackColor = true;
            order_ny_btn.Click += order_ny_pizza;
            // 
            // NY_interface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(order_ny_btn);
            Controls.Add(ny_pizza_list);
            Controls.Add(display_box1);
            Name = "NY_interface";
            Size = new Size(592, 414);
            ResumeLayout(false);
        }

        #endregion

        private ListBox display_box1;
        private ComboBox ny_pizza_list;
        private Button order_ny_btn;
    }
}
