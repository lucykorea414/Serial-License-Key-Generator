namespace SerialKey_test_preview
{
    public partial class Form1 : Form
    {
        int NumofKey;
        public Form1()
        {
            InitializeComponent();

            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            numDaysLeft.Value = 0;
            NumofKey = (int)numAmountofKeys.Value;

            chbMachineLock.Checked = false;
            chbViewPassword.Checked = false;
            label_Error.Visible = false;
            label_Valid.Visible = false;
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            int cmp = DateTime.Compare(dtpStart.Value, dtpEnd.Value);
            if(cmp <= 0)  //start time 이 end time 보다 먼저일 경우
            {
                numDaysLeft.Value = -(dtpStart.Value - dtpEnd.Value).Days;
            }
            else //start time 이 end time 보다 뒤일 경우
            {
                dtpEnd.Value = dtpStart.Value.AddDays((int)numDaysLeft.Value);
                
            }
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            int cmp = DateTime.Compare(dtpStart.Value, dtpEnd.Value);
            if (cmp <= 0)  //start time 이 end time 보다 먼저일 경우
            {
                numDaysLeft.Value = -(dtpStart.Value - dtpEnd.Value).Days;
            }
            else //start time 이 end time 보다 뒤일 경우
            {
                dtpEnd.Value = dtpStart.Value.AddDays((int)numDaysLeft.Value);
                MessageBox.Show("start time 보다 뒤로 선택해주세요.");
                return;
            }
        }

        private void numTimeLeft_ValueChanged(object sender, EventArgs e)
        {
            if(numDaysLeft.Value < 0)  //TimeLeft에 음수값을 넣었을때
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
                
                //txtMachineCode.Text = [           머신코드 계산 결과           ]
                //머신 코드 계산하는 메서드 필요
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
                txtPassword.PasswordChar = default(char);
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void numAmountofKeys_ValueChanged(object sender, EventArgs e)
        {
            NumofKey = (int)numAmountofKeys.Value;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(NumofKey == 1)
            {
                txtSerialKey.Text = generatemethod();
            }
            else
            {
                //없음
            }
        }

        private string generatemethod()
        {
            Generate gen = new Generate();

            //txtPassword.Text = UserID+UserPassword
            string serial = gen.generate_serialKey(txtPassword.Text, (int)numDaysLeft.Value);
            return serial;
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
    }
}