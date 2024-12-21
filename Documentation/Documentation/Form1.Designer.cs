namespace Documentation
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(1246, 124);
            button1.Name = "button1";
            button1.Size = new Size(311, 69);
            button1.TabIndex = 0;
            button1.Text = "CIVIL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13F);
            button2.Location = new Point(1246, 227);
            button2.Name = "button2";
            button2.Size = new Size(311, 69);
            button2.TabIndex = 1;
            button2.Text = "Mechanical";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13F);
            button3.Location = new Point(1246, 319);
            button3.Name = "button3";
            button3.Size = new Size(311, 69);
            button3.TabIndex = 2;
            button3.Text = "Electrical";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkCyan;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 13F);
            button4.Location = new Point(1246, 435);
            button4.Name = "button4";
            button4.Size = new Size(311, 69);
            button4.TabIndex = 3;
            button4.Text = "structural";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlDark;
            button5.Font = new Font("Segoe UI", 13F);
            button5.Location = new Point(526, 574);
            button5.Name = "button5";
            button5.Size = new Size(474, 63);
            button5.TabIndex = 4;
            button5.Text = "EXIT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Crimson;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 13F);
            button6.Location = new Point(46, 124);
            button6.Name = "button6";
            button6.Size = new Size(311, 69);
            button6.TabIndex = 5;
            button6.Text = "WEEKLYREPORT";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Coral;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 13F);
            button7.Location = new Point(46, 319);
            button7.Name = "button7";
            button7.Size = new Size(311, 69);
            button7.TabIndex = 6;
            button7.Text = "transferMaterials";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 13F);
            button8.Location = new Point(46, 227);
            button8.Name = "button8";
            button8.Size = new Size(311, 69);
            button8.TabIndex = 7;
            button8.Text = "Daily Report";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Coral;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 13F);
            button9.Location = new Point(46, 435);
            button9.Name = "button9";
            button9.Size = new Size(311, 69);
            button9.TabIndex = 8;
            button9.Text = "longMaterials";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.CornflowerBlue;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 13F);
            button10.Location = new Point(605, 251);
            button10.Name = "button10";
            button10.Size = new Size(305, 73);
            button10.TabIndex = 9;
            button10.Text = "timeSheet";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(624, 52);
            label1.Name = "label1";
            label1.Size = new Size(297, 54);
            label1.TabIndex = 10;
            label1.Text = "Documentation\n";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_12_03_at_3_23_56_AM;
            ClientSize = new Size(1616, 739);
            Controls.Add(label1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label1;
    }
}
