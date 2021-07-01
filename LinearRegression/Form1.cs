using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearRegression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //this is traning data set
        List<decimal> Tbl1DataX = new List<decimal>();
        List<decimal> Tbl1DataY = new List<decimal>();

        // this is testing data set
        List<decimal> testingX = new List<decimal>();
        List<decimal> testingY = new List<decimal>();


        private void button1_Click(object sender, EventArgs e)
        {
            Tbl1DataX.Clear();
            Tbl1DataY.Clear();
            testingX.Clear();
            testingY.Clear();
            label1.Text = "";
            setTrainingTable();
            setTestingTable();
            decimal xx = 0M;
            decimal x2 = 0M;
            decimal yy = 0M;
            decimal y2 = 0M;
            decimal xy = 0m;
            int n = 0;
            for (int i = 0; i < Tbl1DataX.Count; i++)
            {
                decimal xi = Tbl1DataX[i];
                decimal yi = Tbl1DataY[i];

                xx += xi;
                yy += yi;
                x2 += xi * xi;
                y2 += yi * yi;
                xy += xi * yi;

            }
            n = Tbl1DataX.Count;

            if (checkBox1.Checked)
            {
                xx = Convert.ToDecimal(txtxx.Text);
                yy = Convert.ToDecimal(txtyy.Text);
                x2 = Convert.ToDecimal(txtx2.Text);
                xy = Convert.ToDecimal(txtxy.Text);
                n = Convert.ToInt32(txtn.Text);
            }

            label1.Text = "Σ(x) : " + xx + "\n";
            label1.Text += "Σ(y) : " + yy + "\n";

            label1.Text += "Σ(x²) : " + x2 + "\n";
            label1.Text += "Σ(y²) : " + y2 + "\n";

            label1.Text += "Σ(xy) : " + xy + "\n";
            label1.Text += "n = " + n;
            label1.Text += "\n";

            var c = calculateC(n, xx, yy, x2, xy);
            var m = calculateM(n, xx, yy, x2, xy);

            addXinFormula(c,m);

        }

        private void addXinFormula(decimal c, decimal m)
        {
            List<decimal> predictedY = new List<decimal>();
            foreach (decimal item in testingX)
            {
                decimal pY = Math.Round(((item * m) + c),4);
               // label1.Text += "\ny= mx+c  => y=(" + m + " * " + item + ") + " + c + "  =>  y = " + pY;
               // label1.Text += "\ny= mx+c  =>   y = " + pY;
                predictedY.Add(pY);
            }


            label1.Text += "\n   Data_Y   |   PredictedY    |  Error   |    E²   ";
            decimal sumoferror2 = 0m;
            for (int i = 0; i < predictedY.Count; i++)
            {
                decimal itemx = testingX[i];
                decimal itemy = testingX[i];
                decimal predictY = predictedY[i];
                decimal error = (itemy - predictY);
                decimal error2 = error * error;
                sumoferror2 += error2;
                label1.Text += "\n   "+ itemy+ "   |   "+  predictY + "    |  "+ Math.Round(error2, 4) + "   |    "+ Math.Round(error2,4) + "   ";
            }

            label1.Text += "\n\nNow calculating Mean ";
            label1.Text += "\nMEAN = " + Math.Round(sumoferror2,4) + " / " + predictedY.Count;
            label1.Text += "\nMEAN = " + Math.Round((sumoferror2 / predictedY.Count),4);
            label1.Text += "\nRMSE = " + Math.Round(Math.Sqrt(Convert.ToDouble(sumoferror2 / predictedY.Count)),4);
             
        }

        private void setTestingTable()
        {
            string data = txtTestingSet.Text.Trim();
            string[] lines = data.Split('\n');


            foreach (string item in lines)
            {
                if (item != null && item.Length > 0 && item != string.Empty)
                {
                    string[] splited = item.Split(' ');
                    string one = splited[0];
                    string two = splited[1];
                    decimal test1 = Convert.ToDecimal(one);
                    decimal test2 = Convert.ToDecimal(two);
                    testingX.Add(test1);
                    testingY.Add(test2);
                }

            }
        }

        private decimal calculateM(int n, decimal xx, decimal yy, decimal x2, decimal xy)
        {
            decimal part1 = (n * xy) - (xx * yy);
            decimal part2 = (n * x2);
            decimal part3 = (xx * xx);
            decimal part4 = part2 - part3;
            decimal partall = part1 / part4;

            label1.Text += "\nm = " + partall.ToString("0.###") +"\n";
            return Math.Round(partall,4);
        }

        private decimal calculateC(int n, decimal xx, decimal yy, decimal x2, decimal xy)
        {
            //int n = Convert.ToInt32(txtValueOfN.Text);
            decimal part1 = (yy * x2);
            decimal part2 = xx * xy;
            decimal part12 = part1 - part2;

            decimal part3 = (n * x2) - (xx * xx);
            decimal partall = part12 / part3;
            label1.Text += "\ny = mx + c"; 
            label1.Text += "\nc = " + partall;
            return Math.Round(partall, 4);
        }

        private void setTrainingTable()
        {
            string data = txtTrainingSet.Text.Trim();
            string[] lines = data.Split('\n');


            foreach (string item in lines)
            {
                if (item != null && item.Length > 0 && item != string.Empty)
                {
                    string[] splited = item.Split(' ');
                    string one = splited[0];
                    string two = splited[1];
                    decimal test1 = Convert.ToDecimal(one);
                    decimal test2 = Convert.ToDecimal(two);
                    Tbl1DataX.Add(test1);
                    Tbl1DataY.Add(test2);
                }

            }
        }
    }
}
