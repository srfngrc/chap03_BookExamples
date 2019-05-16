using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap03_BookExamplesPROJ
{
    public class frmMain : Form
    {
        private Label label1;
        private TextBox txtOperand1;
        private TextBox txtOperand2;
        private TextBox txtResult;
        private Button btnCalc;
        private Button btnExit;
        private Label label2;
        #region Windows Code
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter first integer value";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter second integer value";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(193, 31);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 20);
            this.txtOperand1.TabIndex = 2;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(193, 65);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 20);
            this.txtOperand2.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(43, 112);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(305, 20);
            this.txtResult.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(64, 152);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(218, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(386, 187);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integer Division";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            frmMain main = new frmMain();
            Application.Run(main);
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            bool flag;
            //int operand1;
            //int operand2;
            //int answer;


            //TRYITOUT PAGE 71
            //float operand1;
            //float operand2;
            //float answer;

            //TRYITOUT PAGE 72
            //double operand1;
            //double operand2;
            //double answer;

            //TRYITOUT PAGE 75
            decimal operand1;
            decimal operand2;
            decimal answer;

            // Input Step
            // Check first input...
            //flag = int.TryParse(txtOperand1.Text, out operand1);
            //TRYITOUT PAGE 71
            //flag = float.TryParse(txtOperand1.Text, out operand1);
            //TRYITOUT PAGE 72
            //flag = double.TryParse(txtOperand1.Text, out operand1);
            //TRYITOUT PAGE 75
            flag = decimal.TryParse(txtOperand1.Text, out operand1);

            if (flag == false)
            {
                MessageBox.Show("The first value you entered is not a number: " + txtOperand1.Text);
                // MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand1.Focus();
                return;
            }
            // Check second input...
            //flag = int.TryParse(txtOperand2.Text, out operand2);
            //TRYITOUT PAGE 71
            //flag = float.TryParse(txtOperand2.Text, out operand2);
            //TRYITOUT PAGE 71
            //flag = double.TryParse(txtOperand2.Text, out operand2);
            //TRYITOUT PAGE 75
            flag = decimal.TryParse(txtOperand2.Text, out operand2);

            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand2.Focus();
                return;
            }
            // Process Step
            answer = operand1 / operand2;
            // Display Step
            txtResult.Text = operand1.ToString() + " divided by " + operand2.ToString() + " equals " + answer.ToString();
            txtResult.Visible = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
