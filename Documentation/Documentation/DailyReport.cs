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

namespace Documentation
{
    public partial class DailyReport : Form
    {
        public DailyReport()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            comboBox1.Items.Add("SD");
            comboBox1.Items.Add("MT");
            comboBox1.Items.Add("DT");
        }

        private void DailyReport_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\ELectical\SD"; // مسار المجلد 1
                        break;
                    case "MT":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\ELectical\MT"; // مسار المجلد 2
                        break;
                    case "DT":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\ELectical\DT"; // مسار المجلد 3
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
    }
    
}
