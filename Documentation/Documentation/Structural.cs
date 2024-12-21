using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Documentation
{
    public partial class Structural : Form
    {
        public Structural()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            comboBox1.Items.Add("SD");
            comboBox1.Items.Add("MT");
            comboBox1.Items.Add("DT");
            comboBox1.Items.Add("MS");
            comboBox1.Items.Add("ACN");
            comboBox1.Items.Add("IR");
            comboBox1.Items.Add("MIR");
            comboBox1.Items.Add("PCC");
            comboBox1.Items.Add("RPC");
            comboBox1.Items.Add("RFL");
            comboBox1.Items.Add("TQR");
            comboBox1.Items.Add("SOR");
            comboBox1.Items.Add("CR");
            comboBox1.Items.Add("NCR");
            comboBox1.Items.Add("PAR");
            comboBox1.Items.Add("مجلد 16");
            comboBox1.Items.Add("مجلد 17");

            // تعيين الحدث عند اختيار عنصر معين
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            
            // التحقق من أن sender ليس null
            if (sender is ComboBox comboBox)
            {
                // الحصول على العنصر المحدد من ComboBox
                string selectedItem = comboBox.SelectedItem?.ToString() ?? string.Empty;

                // تحديد مسارات المجلدات بناءً على الاختيار
                string folderPath = string.Empty;

                // تحديد مسارات المجلدات بناءً على اختيار المستخدم
                switch (selectedItem)
                {
                    case "SD":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\Filea\rchitectural\SD"; // مسار المجلد 1
                        break;
                    case "MT":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\architectural\MT"; // مسار المجلد 2
                        break;
                    case "DT":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\architectural\DT"; // مسار المجلد 3
                        break;
                    case "MS":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\architectural\MS"; // مسار المجلد 4
                        break;
                    case "ACN":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\architecturall\ACN"; // مسار المجلد 5
                        break;
                    case "IR":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\architectural\IR"; // مسار المجلد 6
                        break;
                    case " MIR":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\architectural\MIR"; // مسار المجلد 7
                        break;
                    case "PCC":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\architectural\PCC"; // مسار المجلد 8
                        break;
                    case "RPC":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\architecturall\RPC"; // مسار المجلد 9
                        break;
                    case "RFL":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\architectural\RFL"; // مسار المجلد 10
                        break;
                    case "TQR":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\architectural\TQR"; // مسار المجلد 11
                        break;
                    case "SOR":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\architectural\SOR"; // مسار المجلد 12
                        break;
                    case "CR":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\architectural\CR"; // مسار المجلد 13
                        break;
                    case "NCR":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\architectural\NCR"; // مسار المجلد 14
                        break;
                    case "PAR":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\architectural\PAR"; // مسار المجلد 15
                        break;
                    case "مجلد 16":
                        folderPath = @"C:\Users\Public\Documents"; // مسار المجلد 16
                        break;
                    case "مجلد 17":
                        folderPath = @"C:\Users\Public\Documents"; // مسار المجلد 17
                        break;
                }

                // فتح المجلد إذا تم تحديد مسار صالح
                if (!string.IsNullOrEmpty(folderPath))
                {
                    try
                    {
                        // التحقق إذا كان المسار هو مجلد
                        if (Directory.Exists(folderPath)) // إذا كان المسار مجلد
                        {
                            // فتح المجلد باستخدام مستعرض الملفات (Explorer)
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = folderPath,  // مسار المجلد
                                UseShellExecute = true   // تفعيل استخدام مستعرض الملفات
                            });
                        }
                        else
                        {
                            MessageBox.Show("المجلد غير موجود.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء فتح المجلد: " + ex.Message);
                    }
                }
            }

        
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Structural_Load(object sender, EventArgs e)
        {

        }

       
    }
        
    
}
