﻿namespace Documentation
{
    partial class longMaterials
    {
        /// <summary>
        /// المتغيرات اللازمة للنموذج.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// تنظيف الموارد التي تستخدمها.
        /// </summary>
        /// <param name="disposing">إذا كان يجب التخلص من الموارد المخصصة.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region "Code Generated by Windows Forms Designer"
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
            button1.BackColor = SystemColors.Highlight;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(1122, 269);
            button1.Name = "button1";
            button1.Size = new Size(378, 71);
            button1.TabIndex = 0;
            button1.Text = "File";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13F);
            button2.Location = new Point(101, 247);
            button2.Name = "button2";
            button2.Size = new Size(378, 71);
            button2.TabIndex = 0;
            button2.Text = "NEW";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13F);
            button3.Location = new Point(624, 520);
            button3.Name = "button3";
            button3.Size = new Size(378, 71);
            button3.TabIndex = 1;
            button3.Text = "B A C K";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(567, 74);
            label1.Name = "label1";
            label1.Size = new Size(388, 67);
            label1.TabIndex = 2;
            label1.Text = " LONG Materials";
            // 
            // longMaterials
            // 
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_12_03_at_3_23_56_AM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1648, 779);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "longMaterials";
            Text = "longMaterials Form";
            Load += longMaterials_Load;
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
