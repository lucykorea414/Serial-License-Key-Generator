namespace SerialKey_test_preview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            numDaysLeft.Value = 0;

            chbMachineLock.Checked = false;
            chbViewPassword.Checked = false;
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            int cmp = DateTime.Compare(dtpStart.Value, dtpEnd.Value);
            if(cmp <= 0)  //start time �� end time ���� ������ ���
            {
                numDaysLeft.Value = -(dtpStart.Value - dtpEnd.Value).Days;
            }
            else //start time �� end time ���� ���� ���
            {
                dtpEnd.Value = dtpStart.Value.AddDays((int)numDaysLeft.Value);
                
            }
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            int cmp = DateTime.Compare(dtpStart.Value, dtpEnd.Value);
            if (cmp <= 0)  //start time �� end time ���� ������ ���
            {
                numDaysLeft.Value = -(dtpStart.Value - dtpEnd.Value).Days;
            }
            else //start time �� end time ���� ���� ���
            {
                dtpEnd.Value = dtpStart.Value.AddDays((int)numDaysLeft.Value);
                MessageBox.Show("start time ���� �ڷ� �������ּ���.");
                return;
            }
        }

        private void numTimeLeft_ValueChanged(object sender, EventArgs e)
        {
            if(numDaysLeft.Value < 0)  //TimeLeft�� �������� �־�����
            {
                MessageBox.Show("input an positive integer");
                return;
            }

            dtpEnd.Value = dtpStart.Value.AddDays((int)numDaysLeft.Value);
        }

        private void chbMachineLock_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMachineLock.Checked)
            {
                txtMachineCode.BackColor = SystemColors.ButtonHighlight;
                
                //txtMachineCode.Text = [           �ӽ��ڵ� ��� ���           ]
                //�ӽ� �ڵ� ����ϴ� �޼��� �ʿ�
            }
            else
            {
                txtMachineCode.BackColor = SystemColors.Control;
                txtMachineCode.Text = "";
            }
        }

        private void chbViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbViewPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void numAmountofKeys_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //key generate method �ʿ�
        }
    }
}