namespace Pizza_shop_FactoryMethod
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
            chicago_btn = new Button();
            ny_store_btn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            nY_interface1 = new NY_interface();
            welcome_interface1 = new welcome_interface();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chicago_btn);
            panel1.Controls.Add(ny_store_btn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 476);
            panel1.TabIndex = 0;
            // 
            // chicago_btn
            // 
            chicago_btn.Location = new Point(12, 229);
            chicago_btn.Name = "chicago_btn";
            chicago_btn.Size = new Size(189, 51);
            chicago_btn.TabIndex = 1;
            chicago_btn.Text = "Chicago Store";
            chicago_btn.UseVisualStyleBackColor = true;
            chicago_btn.Click += select_chicago_store;
            // 
            // ny_store_btn
            // 
            ny_store_btn.Location = new Point(12, 138);
            ny_store_btn.Name = "ny_store_btn";
            ny_store_btn.Size = new Size(189, 51);
            ny_store_btn.TabIndex = 0;
            ny_store_btn.Text = "New York Store";
            ny_store_btn.UseVisualStyleBackColor = true;
            ny_store_btn.Click += select_NY_store;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(228, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(592, 62);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 18);
            label1.Name = "label1";
            label1.Size = new Size(171, 30);
            label1.TabIndex = 0;
            label1.Text = "Pizza Store";
            // 
            // panel3
            // 
            panel3.Controls.Add(welcome_interface1);
            panel3.Controls.Add(nY_interface1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(228, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(592, 414);
            panel3.TabIndex = 2;
            // 
            // nY_interface1
            // 
            nY_interface1.Location = new Point(0, 0);
            nY_interface1.Name = "nY_interface1";
            nY_interface1.Size = new Size(740, 518);
            nY_interface1.TabIndex = 1;
            // 
            // welcome_interface1
            // 
            welcome_interface1.Location = new Point(3, 3);
            welcome_interface1.Name = "welcome_interface1";
            welcome_interface1.Size = new Size(740, 518);
            welcome_interface1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 476);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button chicago_btn;
        private Button ny_store_btn;
        private Label label1;
        private NY_interface nY_interface1;
        private welcome_interface welcome_interface1;
    }
}
