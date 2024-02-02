using System;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1() => InitializeComponent();

		private string Action { get; set; } = "";

		private double FirstNumber { get; set; } = 0;

		private double SecondNumber { get; set; } = 0;

		private double Result { get; set; } = 0;

		private void btn1_Click(object sender, EventArgs e) => AddTextToLabel(btn1);
		private void btn2_Click(object sender, EventArgs e) => AddTextToLabel(btn2);
		private void btn3_Click(object sender, EventArgs e) => AddTextToLabel(btn3);
		private void btn4_Click(object sender, EventArgs e) => AddTextToLabel(btn4);
		private void btn5_Click(object sender, EventArgs e) => AddTextToLabel(btn5);
		private void btn6_Click(object sender, EventArgs e) => AddTextToLabel(btn6);
		private void btn7_Click(object sender, EventArgs e) => AddTextToLabel(btn7);
		private void btn8_Click(object sender, EventArgs e) => AddTextToLabel(btn8);
		private void btn9_Click(object sender, EventArgs e) => AddTextToLabel(btn9);
		private void btn10_Click(object sender, EventArgs e) => AddTextToLabel(btn10);
		private void btn15_Click(object sender, EventArgs e) => AddTextToLabel(btn15);

		private void AddTextToLabel(Button button) => lbl1.Text += button.Text;

		private void btnPlus_Click(object sender, EventArgs e)
		{
			FirstNumber = Convert.ToDouble(lbl1.Text);
			lbl1.Text = "";
			Action = "+";
		}

		private void btnMinus_Click(object sender, EventArgs e)
		{
			FirstNumber = Convert.ToDouble(lbl1.Text);
			lbl1.Text = "";
			Action = "-";
		}

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(lbl1.Text);
            lbl1.Text = "";
            Action = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(lbl1.Text);
            lbl1.Text = "";
            Action = "/";
        }

        private void btn13_Click(object sender, EventArgs e)
		{
			SecondNumber = Convert.ToDouble(lbl1.Text);
			if (Action == "+")
			{
				Result = FirstNumber + SecondNumber;
				lbl1.Text = Result.ToString();
			}
			if (Action == "-")
			{
				Result = FirstNumber - SecondNumber;
				lbl1.Text = Result.ToString();
			}
            if (Action == "*")
            {
                Result = FirstNumber * SecondNumber;
                lbl1.Text = Result.ToString();
            }
            if (Action == "/")
            {
                Result = FirstNumber / SecondNumber;
                lbl1.Text = Result.ToString();
            }
        }

		private void btn14_Click(object sender, EventArgs e)
		{
			lbl1.Text = "";
			FirstNumber = 0;
			SecondNumber = 0;
		}
	}
}
