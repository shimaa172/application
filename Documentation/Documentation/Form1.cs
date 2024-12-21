namespace Documentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CIVIL CIVIL = new CIVIL();
            CIVIL.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mechnical mechnical = new Mechnical();
            mechnical.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Electrical Electrical = new Electrical();
            Electrical.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Structural structural = new Structural();
            structural.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Time_Sheet timeSheet = new Time_Sheet();
            timeSheet.Show();
            this.Hide();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            DailyReport dailyReport = new DailyReport();
            dailyReport.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            longMaterials longMaterials = new longMaterials();
            longMaterials.Show();
            this.Hide();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Wekly_Report wekly_Report = new Wekly_Report();
            wekly_Report.Show();
            this.Hide();
        }
    }
}
