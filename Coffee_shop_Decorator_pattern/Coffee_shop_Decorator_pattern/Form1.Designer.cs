namespace Coffee_shop_Decorator_pattern
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            milk_btn = new Button();
            mocha_btn = new Button();
            get_total = new Button();
            cost_box = new TextBox();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 106);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(251, 30);
            label1.Name = "label1";
            label1.Size = new Size(222, 39);
            label1.TabIndex = 0;
            label1.Text = "Coffee Shop";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "HouseBlend", "Espresso" });
            comboBox1.Location = new Point(25, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(258, 28);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Select Your Coffee Type";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(128, 128, 255);
            button1.Location = new Point(349, 150);
            button1.Name = "button1";
            button1.Size = new Size(108, 35);
            button1.TabIndex = 2;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = true;
            button1.Click += select_btn;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(25, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "Your Coffee Appear here";
            // 
            // milk_btn
            // 
            milk_btn.BackColor = Color.Bisque;
            milk_btn.FlatStyle = FlatStyle.Popup;
            milk_btn.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            milk_btn.ForeColor = Color.DarkRed;
            milk_btn.Location = new Point(25, 276);
            milk_btn.Name = "milk_btn";
            milk_btn.Size = new Size(94, 29);
            milk_btn.TabIndex = 4;
            milk_btn.Text = "Add Milk";
            milk_btn.UseVisualStyleBackColor = false;
            milk_btn.Click += add_milk;
            // 
            // mocha_btn
            // 
            mocha_btn.BackColor = Color.Bisque;
            mocha_btn.FlatStyle = FlatStyle.Popup;
            mocha_btn.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mocha_btn.ForeColor = Color.DarkRed;
            mocha_btn.Location = new Point(165, 276);
            mocha_btn.Name = "mocha_btn";
            mocha_btn.Size = new Size(108, 29);
            mocha_btn.TabIndex = 5;
            mocha_btn.Text = "Add Mocha";
            mocha_btn.UseVisualStyleBackColor = false;
            mocha_btn.Click += add_mocha;
            // 
            // get_total
            // 
            get_total.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            get_total.ForeColor = Color.FromArgb(128, 128, 255);
            get_total.Location = new Point(23, 353);
            get_total.Name = "get_total";
            get_total.Size = new Size(108, 35);
            get_total.TabIndex = 7;
            get_total.Text = "Get Bill";
            get_total.UseVisualStyleBackColor = true;
            get_total.Click += calculate_bill;
            // 
            // cost_box
            // 
            cost_box.Location = new Point(23, 411);
            cost_box.Name = "cost_box";
            cost_box.Size = new Size(168, 27);
            cost_box.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(364, 211);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(322, 244);
            listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 467);
            Controls.Add(listBox1);
            Controls.Add(cost_box);
            Controls.Add(get_total);
            Controls.Add(mocha_btn);
            Controls.Add(milk_btn);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private Button milk_btn;
        private Button mocha_btn;
        private Button get_total;
        private TextBox cost_box;
        private ListBox listBox1;
    }
}
