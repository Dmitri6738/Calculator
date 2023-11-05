using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

/**
 @brief Calculator interface Form.

 @details
 The form is a calculator with some standard arithmetic and trigonometric functions.
 In addition to the numbers, it has buttons with the names of variables obtained from the previous form.
 For convenience, the numbers obtained from the previous form are presented in the table at the top of the form.

 @param top and left- button position
 @param countBut counter of buttons placed in a row
 @param totalWidth and totalHeight- table sizes
 @param primer example text
 @param sss2 and sss various symbols
 @param tempPrimer part of the example for the invoice
 @param pos2 to store the index of an element in a row
 @param tempStr for part of the example
 @param kf the numerical part of trigonometry

 @return When you click on the button, it calculates an example.
 */

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        //! I do not know what they are doing here. They are never used, but I am afraid to delete them, as everything may break. I don't remember why they were needed.
        int totalWid = 0, formWidth, formHeight;

        //! Starting function
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            download();
            buttonsName(dataGridView1);
            button25.Text = "Расчёт";
            formWidth = this.Width;
            formHeight = this.Height;
        }

        //! A function for determining the number, name and location of dynamically created buttons with variable names.
        void buttonsName(DataGridView dgv)
        {
            int top = 115;
            int left = 218;

            int countButton = Form1.listName.Count / 4, countBut = 0;

            for (int i = 0; i < Form1.listName.Count; i++)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                button.Name = "buttonName" + i;
                button.Click += ButtonOnClickName;
                button.Height = 30;

                DataGridViewElementStates states = DataGridViewElementStates.None;
                button.Width = (dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth)/( (Form1.listName.Count*65)/47);
                button.Text = Form1.listName[i];

                this.Controls.Add(button);
                top += button.Height;
                countBut++;
                if (countBut == 3)
                {
                    top = 115;
                    left += button.Width + 1;
                    countBut = 0;
                    button25.Width = 2 * button.Width + 1;
                }
                textBox2.Location = new Point(219, 241);
                textBox2.Size = new Size(button25.Width - 2, 23);
            }
        }

        private void ButtonOnClickName(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                textBox1.Text += button.Text;
            }
        }

        //! Defines the size of the table
        void sizeDGV(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.None;
            var totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight;
            totalHeight += dgv.Rows.Count * 4;
            var totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
            dgv.ClientSize = new Size(totalWidth, totalHeight);
            textBox1.Width = totalWidth-32;
            totalWid = totalWidth;
        }

        //! Filling in the table
        void download()
        {
            for (int i = 0; i < Form1.listName.Count; i++)
            {
                dataGridView1.Columns.Add(Form1.listName[i], Form1.listName[i]);
                dataGridView1.Rows[0].Cells[i].Value = Form1.listNumber[i];
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sizeDGV(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += button20.Text;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += button24.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += button14.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += button13.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += button12.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += button23.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += button17.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += button16.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += button15.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += button21.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += button19.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += button18.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += button22.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string primer = textBox1.Text;
            primer = proverka(primer);
            if (primer != "ERROR") divide(primer);
        }

        //! Checking the example for logical correctness
        string proverka(string primer)
        {
            int f = 0;
            for (int i = 0; i < primer.Length; i++)
            {
                if (primer[i] == '(') f++;
                if (primer[i] == ')') f--;
            }
            if (f != 0)
            {
                Console.WriteLine("Ошибка в количестве скобок");
                MessageBox.Show("Ошибка в количестве скобок");
                return "ERROR";
            }
            Console.WriteLine(primer);
            for (int i = 0; i < Form1.listName.Count; i++)
            {
                primer = primer.Replace(Form1.listName[i], Form1.listNumber[i].ToString());
            }
            Console.WriteLine(primer);
            return primer;
        }

        //! Dividing an example into its components
        void divide(string primer)
        {
            string sss = "+-", sss2 = "-";
            primer = primer.Replace(sss, sss2);
            sss = "--"; sss2 = "-";
            primer = primer.Replace(sss, sss2);
            sss = " "; sss2 = "";
            primer = primer.Replace(sss, sss2);

            if (primer[0] == '+') primer = primer.Substring(1);

            int pos = primer.IndexOf(')');
            if (pos > 0)
            {
                string tempPrimer = primer.Substring(0, pos);
                int pos2 = tempPrimer.LastIndexOf('(');
                tempPrimer = tempPrimer.Substring(pos2 + 1);
                if (IsDigitsOnly(tempPrimer))
                {
                    string s1 = "(" + tempPrimer + ")";
                    primer = primer.Replace(s1, tempPrimer);
                    Console.WriteLine(primer);
                    divide(primer);
                }
                else
                {
                    string tempPrimer2 = schet(tempPrimer);
                    if (tempPrimer == "ERROR") return;
                    primer = primer.Replace(tempPrimer, tempPrimer2);
                    divide(primer);
                }
            }
            else
            {
                string tempPrimer = primer;
                Console.WriteLine(tempPrimer);
                if (IsDigitsOnly(tempPrimer))
                {
                    string s1 = "(" + tempPrimer + ")";
                    primer = primer.Replace(s1, tempPrimer);
                    Console.WriteLine(primer);
                    textBox2.Text = primer;
                }
                else
                {
                    string tempPrimer2 = schet(tempPrimer);
                    if (tempPrimer == "ERROR") return;
                    primer = primer.Replace(tempPrimer, tempPrimer2);
                    divide(primer);
                }
            }
        }

        //! Calculating individual parts of the example
        string schet(string tempPrimer)
        {
            string s1 = "sin", s2 = "cos", s3 = "asin", s4 = "acos", s5 = "^", s6 = "√";
            if ((tempPrimer.IndexOf(s1) >= 0) || (tempPrimer.IndexOf(s2) >= 0) || (tempPrimer.IndexOf(s3) >= 0) || (tempPrimer.IndexOf(s4) >= 0) || (tempPrimer.IndexOf(s5) >= 0) || (tempPrimer.IndexOf(s6) >= 0))
            {
                if (tempPrimer.IndexOf(s3) >= 0)
                {
                    int pos = tempPrimer.IndexOf(s3);
                    string tempStr = tempPrimer.Substring(pos + 4);
                    double kf = Convert.ToDouble(findKf(tempStr, false));
                    string ss = "asin" + kf;
                    if (kf >= -1 && kf <= 1)
                    {
                        kf = Math.Asin(kf);
                        ss = tempPrimer.Replace(ss, kf.ToString());
                        return ss;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка в значении asin: выход за пределы диапазона -1<x<1");
                        Console.WriteLine("Ошибка в значении asin: выход за пределы диапазона -1<x<1");
                        return "ERROR";
                    }
                }
                if (tempPrimer.IndexOf(s4) >= 0)
                {
                    int pos = tempPrimer.IndexOf(s4);
                    string tempStr = tempPrimer.Substring(pos + 4);
                    double kf = Convert.ToDouble(findKf(tempStr, false));
                    string ss = "acos" + kf;
                    if (kf >= -1 && kf <= 1)
                    {
                        kf = Math.Acos(kf);
                        ss = tempPrimer.Replace(ss, kf.ToString());
                        return ss;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка в значении acos: выход за пределы диапазона -1<x<1");
                        Console.WriteLine("Ошибка в значении acos: выход за пределы диапазона -1<x<1");
                        return "ERROR";
                    }
                }
                if (tempPrimer.IndexOf(s1) >= 0 && tempPrimer.IndexOf(s3) < 0)
                {
                    int pos = tempPrimer.IndexOf(s1);
                    string tempStr = tempPrimer.Substring(pos + 3);
                    double kf = Convert.ToDouble(findKf(tempStr, false));
                    string ss = "sin" + kf;
                    kf = Math.Sin(kf);
                    ss = tempPrimer.Replace(ss, kf.ToString());
                    return ss;
                }
                if (tempPrimer.IndexOf(s2) >= 0 && tempPrimer.IndexOf(s4) < 0)
                {
                    int pos = tempPrimer.IndexOf(s2);
                    string tempStr = tempPrimer.Substring(pos + 3);
                    double kf = Convert.ToDouble(findKf(tempStr, false));
                    string ss = "cos" + kf;
                    kf = Math.Cos(kf);
                    ss = tempPrimer.Replace(ss, kf.ToString());
                    return ss;
                }
                if (tempPrimer.IndexOf(s5) >= 0)
                {
                    int pos = tempPrimer.IndexOf(s5);
                    string tempStr = tempPrimer.Substring(pos+1);
                    double kf = Convert.ToDouble(findKf(tempStr, false));
                    tempPrimer = new string(tempPrimer.Reverse().ToArray());
                    pos = tempPrimer.IndexOf(s5);
                    string tempStr2 = tempPrimer.Substring(pos+1);
                    string kf22 = findKf(tempStr2, true);
                    kf22= new string(kf22.Reverse().ToArray());
                    double kf2 = Convert.ToDouble(kf22);
                    string ss = kf2 + "^" + kf;

                    string kfstr = "";
                    if (kf2 < 0 && kf % 2 == 0) kfstr = "+";

                    kf = Math.Pow(kf2, kf);
                    kfstr += kf.ToString();
                    tempPrimer = new string(tempPrimer.Reverse().ToArray());
                    ss = tempPrimer.Replace(ss, kfstr);
                    return ss;
                }
                if (tempPrimer.IndexOf(s6) >= 0)
                {
                    int pos = tempPrimer.IndexOf(s6);
                    string tempStr = tempPrimer.Substring(pos);
                    double kf = Convert.ToDouble(findKf(tempStr, false));
                    string ss = "√" + kf;
                    if (kf < 0) { MessageBox.Show("Под корнем отрицательное число"); Console.WriteLine("Под корнем отрицательное число"); return "ERROR"; }
                    kf = Math.Sqrt(kf);
                    ss = tempPrimer.Replace(ss, kf.ToString());
                    return ss;
                }
            }

            s1 = "*"; s2 = "/"; s3 = "+"; s4 = "-";
            if ((tempPrimer.IndexOf(s1) >= 0) || (tempPrimer.IndexOf(s2) >= 0) || (tempPrimer.IndexOf(s3) >= 0) || (tempPrimer.IndexOf(s4) >= 0))
            {
                int pos = -1;
                if ((pos = tempPrimer.IndexOf(s1)) == -1)
                    if ((pos = tempPrimer.IndexOf(s2)) == -1)
                        if ((pos = tempPrimer.IndexOf(s3)) == -1)
                            pos = tempPrimer.LastIndexOf(s4);

                string tempStr = tempPrimer.Substring(pos + 1);
                double kf = 1, kf2 = 1;
                kf2 = Convert.ToDouble(obrezka(tempStr));
                tempStr = tempPrimer.Substring(0, pos);
                kf = Convert.ToDouble(reversObrezka(tempStr));
                bool negative = false;
                if (kf < 0) negative = true;

                char name = tempPrimer[pos];
                string ss = kf.ToString() + name + kf2.ToString();
                switch (name)
                {
                    case '*':
                        kf *= kf2;
                        break;
                    case '/':
                        kf /= kf2;
                        break;
                    case '+':
                        kf += kf2;
                        break;
                    case '-':
                        kf -= kf2;
                        break;
                }
                bool b = false;
                if (negative)
                {
                    if (kf > 0) b=true;
                }

                string kfstr = "";
                if (b) kfstr = "+";
                kfstr+= kf.ToString();
                ss = tempPrimer.Replace(ss, kfstr);
                Console.WriteLine(ss);
                return ss;
            }

            return tempPrimer;
        }


        string reversObrezka(string str)
        {
            str = new string(str.Reverse().ToArray());
            string indSimbol = "-j";
            bool find = true;
            foreach (char c in str)
            {
                if (find)
                {
                    if (c == '+' || c == '-' || c == '*' || c == '/')
                    {
                        indSimbol = c.ToString();
                        find = false;
                    }
                }
            }
            if (indSimbol != "-j")
            {
                int pos = str.IndexOf(indSimbol);
                if (indSimbol != "-")
                {
                    str = str.Substring(0, pos);
                }
                else
                {
                    str = str.Substring(0, pos + 1);
                }
            }
            str = new string(str.Reverse().ToArray());
            return str;
        }

        string obrezka(string str)
        {
            string indSimbol = "-j";
            int iii=0;
            bool find = true;
            foreach (char c in str)
            {
                if (find)
                {
                    if ((c == '+' || c == '-' || c == '*' || c == '/') && iii>0)
                    {
                        indSimbol = c.ToString();
                        find = false;
                    }
                }
                iii++;
            }
            if (indSimbol != "-j")
            {
                int pos = str.IndexOf(indSimbol);
                str = str.Substring(0, pos);
            }
            return str;
        }

        string findKf(string str, bool revers)
        {
            string str2 = findSimbol(str);
            if (str2 != "-j")
            {
                if (str2=="^") str = new string(str.Reverse().ToArray());
                int pos = str.IndexOf(str2);
                string tempStr = str;
                if (str2=="-" && revers)
                tempStr = str.Substring(0, pos+1);
                else tempStr = str.Substring(0, pos);
                return tempStr;
            }
            else return str; 
        }

        string findSimbol(string str)
        {
            string indSimbol = "-j";
            int i = -1; char ii='j';
            foreach (char c in str)
            {
                i++;
                if ((c < '0' || c > '9') && (c != ','))
                    if ((c != '-' || i != 0) && (ii!='*'|| ii != '/' || ii != '+' || ii != '-'))
                    {
                        indSimbol = c.ToString();
                        return indSimbol;
                    }
                ii = c;
            }
            return indSimbol;
        }


        bool IsDigitsOnly(string str)
        {
            int i = -1;
            foreach (char c in str)
            {
                i++;
                if ((c < '0' || c > '9') && (c != ','))
                    if (c != '-' || i != 0)
                    return false;
            }
            return true;
        }

        private void checkBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }
    }
}