namespace Documentation
{
    partial class Wekly_Report
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(1227, 200);
            button1.Name = "button1";
            button1.Size = new Size(332, 60);
            button1.TabIndex = 0;
            button1.Text = "File";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13F);
            button2.Location = new Point(70, 186);
            button2.Name = "button2";
            button2.Size = new Size(332, 60);
            button2.TabIndex = 1;
            button2.Text = "NEW";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDarkDark;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(684, 567);
            button3.Name = "button3";
            button3.Size = new Size(289, 47);
            button3.TabIndex = 2;
            button3.Text = "B A C K";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26F);
            label1.Location = new Point(589, 54);
            label1.Name = "label1";
            label1.Size = new Size(362, 70);
            label1.TabIndex = 3;
            label1.Text = "Weekly Report";
            label1.Click += label1_Click;
            // 
            // Wekly_Report
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_12_03_at_3_23_56_AM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1645, 751);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Wekly_Report";
            Text = "Wekly_Report";
            Load += Wekly_Report_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}