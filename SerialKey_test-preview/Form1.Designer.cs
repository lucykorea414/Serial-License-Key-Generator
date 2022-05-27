namespace SerialKey_test_preview
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabValidate = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSerialKey = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.numAmountofKeys = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chbViewPassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMachineCode = new System.Windows.Forms.TextBox();
            this.chbMachineLock = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numDaysLeft = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtValSerialKey = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label_Error = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIsExpired = new System.Windows.Forms.TextBox();
            this.txtTimeLeft = new System.Windows.Forms.TextBox();
            this.txtExpirationDate = new System.Windows.Forms.TextBox();
            this.txtCreationDate = new System.Windows.Forms.TextBox();
            this.label_Valid = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabValidate.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountofKeys)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysLeft)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tabValidate
            // 
            this.tabValidate.Controls.Add(this.tabPage1);
            this.tabValidate.Controls.Add(this.tabPage2);
            this.tabValidate.Location = new System.Drawing.Point(12, 12);
            this.tabValidate.Name = "tabValidate";
            this.tabValidate.SelectedIndex = 0;
            this.tabValidate.Size = new System.Drawing.Size(524, 347);
            this.tabValidate.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSerialKey);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(516, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSerialKey
            // 
            this.txtSerialKey.Location = new System.Drawing.Point(98, 271);
            this.txtSerialKey.Name = "txtSerialKey";
            this.txtSerialKey.Size = new System.Drawing.Size(387, 23);
            this.txtSerialKey.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Serial Key : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGenerate);
            this.groupBox4.Controls.Add(this.numAmountofKeys);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.chbViewPassword);
            this.groupBox4.Controls.Add(this.txtPassword);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(500, 101);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Key Generate";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(281, 60);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numAmountofKeys
            // 
            this.numAmountofKeys.Enabled = false;
            this.numAmountofKeys.Location = new System.Drawing.Point(144, 62);
            this.numAmountofKeys.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numAmountofKeys.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmountofKeys.Name = "numAmountofKeys";
            this.numAmountofKeys.Size = new System.Drawing.Size(120, 23);
            this.numAmountofKeys.TabIndex = 4;
            this.numAmountofKeys.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmountofKeys.ValueChanged += new System.EventHandler(this.numAmountofKeys_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Amount of Keys";
            // 
            // chbViewPassword
            // 
            this.chbViewPassword.AutoSize = true;
            this.chbViewPassword.Location = new System.Drawing.Point(375, 26);
            this.chbViewPassword.Name = "chbViewPassword";
            this.chbViewPassword.Size = new System.Drawing.Size(106, 19);
            this.chbViewPassword.TabIndex = 2;
            this.chbViewPassword.Text = "View password";
            this.chbViewPassword.UseVisualStyleBackColor = true;
            this.chbViewPassword.CheckedChanged += new System.EventHandler(this.chbViewPassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(115, 22);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(241, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.chbMachineLock);
            this.groupBox2.Location = new System.Drawing.Point(330, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 138);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Machine locking";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.txtMachineCode);
            this.groupBox3.Location = new System.Drawing.Point(16, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 56);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Machine code";
            // 
            // txtMachineCode
            // 
            this.txtMachineCode.BackColor = System.Drawing.SystemColors.Control;
            this.txtMachineCode.Enabled = false;
            this.txtMachineCode.Location = new System.Drawing.Point(35, 21);
            this.txtMachineCode.Name = "txtMachineCode";
            this.txtMachineCode.ReadOnly = true;
            this.txtMachineCode.Size = new System.Drawing.Size(74, 23);
            this.txtMachineCode.TabIndex = 0;
            // 
            // chbMachineLock
            // 
            this.chbMachineLock.AutoSize = true;
            this.chbMachineLock.Location = new System.Drawing.Point(22, 31);
            this.chbMachineLock.Name = "chbMachineLock";
            this.chbMachineLock.Size = new System.Drawing.Size(120, 19);
            this.chbMachineLock.TabIndex = 0;
            this.chbMachineLock.Text = "use Machine lock";
            this.chbMachineLock.UseVisualStyleBackColor = true;
            this.chbMachineLock.CheckedChanged += new System.EventHandler(this.chbMachineLock_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.numDaysLeft);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date and Time";
            // 
            // numDaysLeft
            // 
            this.numDaysLeft.Location = new System.Drawing.Point(115, 99);
            this.numDaysLeft.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numDaysLeft.Name = "numDaysLeft";
            this.numDaysLeft.Size = new System.Drawing.Size(92, 23);
            this.numDaysLeft.TabIndex = 5;
            this.numDaysLeft.ValueChanged += new System.EventHandler(this.numTimeLeft_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Days Left";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(115, 62);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(190, 23);
            this.dtpEnd.TabIndex = 3;
            this.dtpEnd.Value = new System.DateTime(2022, 5, 20, 13, 36, 1, 0);
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(115, 25);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(190, 23);
            this.dtpStart.TabIndex = 2;
            this.dtpStart.Value = new System.DateTime(2022, 5, 20, 13, 35, 54, 0);
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expiration Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creation Date";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(516, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Validate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.txtValPassword);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.btnValidate);
            this.groupBox6.Controls.Add(this.txtValSerialKey);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(502, 96);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Password:";
            // 
            // txtValPassword
            // 
            this.txtValPassword.Location = new System.Drawing.Point(76, 55);
            this.txtValPassword.Name = "txtValPassword";
            this.txtValPassword.Size = new System.Drawing.Size(339, 23);
            this.txtValPassword.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Serial Key:";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(421, 55);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 4;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            // 
            // txtValSerialKey
            // 
            this.txtValSerialKey.Location = new System.Drawing.Point(76, 16);
            this.txtValSerialKey.Name = "txtValSerialKey";
            this.txtValSerialKey.Size = new System.Drawing.Size(420, 23);
            this.txtValSerialKey.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label_Error);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtIsExpired);
            this.groupBox5.Controls.Add(this.txtTimeLeft);
            this.groupBox5.Controls.Add(this.txtExpirationDate);
            this.groupBox5.Controls.Add(this.txtCreationDate);
            this.groupBox5.Controls.Add(this.label_Valid);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(8, 108);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(502, 205);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Result";
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(12, 19);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(71, 32);
            this.label_Error.TabIndex = 10;
            this.label_Error.Text = "Error!";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(89, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(330, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "** \"Valid\" indicates whether the key has been modified or not.";
            // 
            // txtIsExpired
            // 
            this.txtIsExpired.Location = new System.Drawing.Point(136, 165);
            this.txtIsExpired.Name = "txtIsExpired";
            this.txtIsExpired.Size = new System.Drawing.Size(333, 23);
            this.txtIsExpired.TabIndex = 8;
            // 
            // txtTimeLeft
            // 
            this.txtTimeLeft.Location = new System.Drawing.Point(136, 128);
            this.txtTimeLeft.Name = "txtTimeLeft";
            this.txtTimeLeft.Size = new System.Drawing.Size(333, 23);
            this.txtTimeLeft.TabIndex = 7;
            // 
            // txtExpirationDate
            // 
            this.txtExpirationDate.Location = new System.Drawing.Point(136, 93);
            this.txtExpirationDate.Name = "txtExpirationDate";
            this.txtExpirationDate.Size = new System.Drawing.Size(333, 23);
            this.txtExpirationDate.TabIndex = 6;
            // 
            // txtCreationDate
            // 
            this.txtCreationDate.Location = new System.Drawing.Point(136, 59);
            this.txtCreationDate.Name = "txtCreationDate";
            this.txtCreationDate.Size = new System.Drawing.Size(333, 23);
            this.txtCreationDate.TabIndex = 5;
            // 
            // label_Valid
            // 
            this.label_Valid.AutoSize = true;
            this.label_Valid.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Valid.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label_Valid.Location = new System.Drawing.Point(9, 19);
            this.label_Valid.Name = "label_Valid";
            this.label_Valid.Size = new System.Drawing.Size(74, 32);
            this.label_Valid.TabIndex = 4;
            this.label_Valid.Text = "Valid!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Is Expired: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Time Left: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Expiration Date: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Creation Date: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(549, 371);
            this.Controls.Add(this.tabValidate);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Key Test";
            this.tabValidate.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountofKeys)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysLeft)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolTip toolTip;
        private TabControl tabValidate;
        private TabPage tabPage1;
        private GroupBox groupBox4;
        private Button btnGenerate;
        private NumericUpDown numAmountofKeys;
        private Label label5;
        private CheckBox chbViewPassword;
        private TextBox txtPassword;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtMachineCode;
        private CheckBox chbMachineLock;
        private GroupBox groupBox1;
        private NumericUpDown numDaysLeft;
        private Label label3;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private GroupBox groupBox6;
        private Label label6;
        private Button btnValidate;
        private TextBox txtValSerialKey;
        private GroupBox groupBox5;
        private Label label_Error;
        private Label label12;
        private TextBox txtIsExpired;
        private TextBox txtTimeLeft;
        private TextBox txtExpirationDate;
        private TextBox txtCreationDate;
        private Label label_Valid;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label11;
        private TextBox txtValPassword;
        private TextBox txtSerialKey;
        private Label label13;
    }
}