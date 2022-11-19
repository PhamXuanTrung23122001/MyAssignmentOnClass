namespace MyAssignment2PRn
{
    public partial class lblName : Form
    {
        public lblName()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            GetPay();
        }
        private void GetPay()
        {
            int total = 0;
            if (txtName.Text == "")
            {
                 MessageBox.Show("Tao mời mày nhập tên ạ", "Hệ Thống");
                
            }
            else
            {
                if (chkClean.Checked) total = total + 100000;
                if (chkWhitening.Checked) total = total + 1200000;
                if (chkXRay.Checked) total = total + 200000;
                total = total +(((int) numericUpDown1.Value)*80000);
                txtTotal.Text = total.ToString();
                
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Mày có muốn thoát không?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                return;
            }
        }

        private void lblName_Load(object sender, EventArgs e)
        {

        }
    }
}