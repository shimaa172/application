﻿namespace Documentation{    public partial class longMaterials : Form    {        public longMaterials()        {            InitializeComponent();            this.ControlBox = false;            this.FormBorderStyle = FormBorderStyle.FixedDialog;        }        // الحدث الذي يتم تنفيذه عند تحميل النموذج        private void longMaterials_Load(object sender, EventArgs e)        {            // يمكنك إضافة الكود الذي تريد تنفيذه عند تحميل النموذج هنا        }        // الحدث الذي يتم تنفيذه عند النقر على الزر Button3        private void Button3_Click(object sender, EventArgs e)        {        }        private void button2_Click(object sender, EventArgs e)        {        }        private void button3_Click_1(object sender, EventArgs e)        {            // فتح نموذج Form1 وإخفاء هذا النموذج            Form1 form1 = new Form1();            form1.Show();            this.Hide();        }    }}