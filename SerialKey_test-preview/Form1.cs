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
            label_Error.Visible = false;
            label_Valid.Visible = false;
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtNewPassword.Text = generatepassword(txtID.Text, txtPassword.Text);
            txtSerialKey.Text = generatemethod(txtNewPassword.Text, (int)numDaysLeft.Value);
        }

        private string generatemethod(string newpassword, int num)
        {
            Generate gen = new Generate();

            string serial = gen.generate_serialKey(newpassword, num);
            return serial;
        }

        private string generatepassword(string id, string password)
        {
            Generate gen = new Generate();

            return gen.generate_password(id, password);
        }

        private void vaildatemethod()
        {
            Validate val = new Validate(txtValPassword.Text, txtValSerialKey.Text);

            if (val.val_isValid())
            {
                label_Error.Visible = false;
                label_Valid.Visible = true;

                txtCreationDate.Text = val.val_creation();
                txtExpirationDate.Text = val.val_expiration();
                txtTimeLeft.Text = val.val_daysleft();

                if (val.val_isExpired())
                {
                    txtIsExpired.Text = "Expired";
                }
                else
                {
                    txtIsExpired.Text = "not Expired";
                }

            }
            else
            {
                label_Error.Visible = true;
                label_Valid.Visible = false;
            }

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            vaildatemethod();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            txtValSerialKey.Text = txtSerialKey.Text;
            txtValPassword.Text = txtNewPassword.Text;
            tabValidate.SelectTab(1);
        }
    }
}