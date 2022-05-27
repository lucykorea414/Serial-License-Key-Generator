

namespace SerialKeyDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*SKGL.Generate generate = new SKGL.Generate();

            txtStatus.Text += "Machine Code: " + generate.MachineCode;*/
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            SKGL.Generate generate = new SKGL.Generate();
            generate.secretPhase = txtPassword.Text;
            txtSerial.Text = generate.doKey(Convert.ToInt32(txtDay.Text));
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            SKGL.Validate validate = new SKGL.Validate();  
            validate.secretPhase = txtPassword.Text;
            validate.Key = txtSerial.Text;
            txtStatus.Text = "Creation date: " + validate.CreationDate + "\r\n" + "Expire Date: " + validate.ExpireDate + "\r\n" + "Day left: " + validate.DaysLeft + "\r\n";
            txtStatus.Text += "Check Validation: " + validate.IsValid + "\r\n";  
            txtStatus.Text += "Check Expiration: " + validate.IsExpired + "\r\n";
            //txtStatus.Text = "Check Machine: " + validate.IsOnRightMachine.ToString() + "\r\n";

            txtStatus.Text += "Check Expiration: " + validate.Key + "\r\n";
            txtStatus.Text += "Check Expiration: " + validate.secretPhase + "\r\n";
            
            
        }
    }
}