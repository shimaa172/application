using System.Diagnostics;
using System.IO;

namespace Documentation
{
    public partial class CIVIL : Form
    {
        public EventHandler ComboBox1_SelectedIndexChanged { get; }

        public CIVIL()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // إضافة 17 عنصرًا في ComboBox
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

        // الحدث الذي يتم تنفيذه عند تحميل النموذج
        private void CIVIL_Load(object sender, EventArgs e)
        {
            // يمكنك إضافة أي كود ترغب في تنفيذه عند تحميل النموذج هنا
        }

        // الحدث الذي يتم تنفيذه عند النقر على button3
        private void Button3_Click(object sender, EventArgs e)
        {
            // تحقق من وجود المجلد في المسار المحدد
            string folderPath = @"C:\Users\Admin\Desktop\New folder\File\Civil1";

            // تحقق من وجود المجلد في المسار المحدد
            if (System.IO.Directory.Exists(folderPath))
            {
                // إذا كان المجلد موجودًا، افتحه باستخدام مستعرض الملفات
                Process.Start(new ProcessStartInfo
                {
                    FileName = folderPath,  // مسار المجلد
                    UseShellExecute = true   // تفعيل استخدام مستعرض الملفات
                });
            }
            else
            {
                // إذا كان المجلد غير موجود، اطبع رسالة تنبيه
                Console.WriteLine("المجلد غير موجود في المسار المحدد.");
            }
        }

        // الحدث الذي يتم تنفيذه عند النقر على button1
        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        // الحدث الذي يتم تنفيذه عند النقر على button6
        private void Button6_Click(object sender, EventArgs e)
        {
           
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
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\Civil1\SD"; // مسار المجلد 1
                        break;
                    case "MT":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\Civil1\MT"; // مسار المجلد 2
                        break;
                    case "DT":
                        folderPath = @"C:\Users\Admin\Desktop\New folder\File\Civil1\DT"; // مسار المجلد 3
                        break;
                    case "MS":
                        folderPath = @"C:\Users\Public\Documents"; // مسار المجلد 4
                        break;
                    case "ACN":
                        folderPath = @"C:\Users\Public\Documents"; // مسار المجلد 5
                        break;
                    case "IR":
                        folderPath = @"C:\Users\Public\Documents"; // مسار المجلد 6
                        break;
                    case " MIR":
                        folderPath = @"C:\Users\Public\Documents"; // مسار المجلد 7
                        break;
                    case "PCC":
                        folderPath = @"C:\Users\Public\Documents"; // مسار المجلد 8
                        break;
                    case "RPC":
                        folderPath = @"C:\Users\Public\Documents"; // مسار المجلد 9
                        break;
                    case "RFL":
                        folderPath = @"C:\Users\Public\Documents"; // مسار المجلد 10
                        break;
                    case "TQR":
                        folderPath = @"C:\Users\Public\Documents"; // مسار المجلد 11
                        break;
                    case "SOR":
                        folderPath = @"C:\Users\Public\Documents"; // مسار المجلد 12
                        break;
                    case "CR":
                        folderPath = @"C:\Users\Public\Documents"; // مسار المجلد 13
                        break;
                    case "NCR":
                        folderPath = @"C:\Users\Public\Documents"; // مسار المجلد 14
                        break;
                    case "PAR":
                        folderPath = @"C:\Users\Public\Documents"; // مسار المجلد 15
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
    }
}
