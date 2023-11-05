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
 @brief File addition Form.

 @details
 The Form provides the ability to add a ".tab" file.
 Reads the file and calculates the average value for each variable.

 @param filename Name of the selected file
 @param maintext The variable to which the contents of the file are copied
 @param pos The position of the transition to a new line
 @param temptext Contains one line of text
 @param mintext Contains a single number in string format
 @param sss1 Contains a certain number of lines of text
 @param j2 Number of lines in the file
 @param j Like j2 only j
 @param kkk The position of the text separation in the format double
 @param kkk2 The position of the text separation in the format int
 @param ssss1 Text separation position
 @param pos2Position of the space position

 @return Passes the average value of variables to the next Form
 */


/**
@mainpage Calculator for working with an experimental setup
Tasks:
- opening and reading a file
- averaging values
- simplified input of averaged variables
- arithmetic and trigonometric operations with variables and numbers


\authors
Dmitri
*/

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        //! Array of numbers in string format
        public static List<string> listName { get; set; } = new List<string>();

        //! Array of numbers in double format
        public static List<double> listNumber { get; set; } = new List<double>();

        //! Starting function
        public Form1() 
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            openFileDialog1.Filter = "All files(*.*)|*.*";
        }

        /**
        @param filename Name of the selected file
        @param maintext The variable to which the contents of the file are copied
        @param pos The position of the transition to a new line
        @param temptext Contains one line of text
        @param mintext Contains a single number in string format
        @param sss1 Contains a certain number of lines of text
        @param j2 Number of lines in the file
        @param j Like j2 only j
        @param kkk The position of the text separation in the format double
        @param kkk2 The position of the text separation in the format int
        @param ssss1 Text separation position
        @param pos2Position of the space position
        @param 
        @param 
        */

        //! File Open button
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Ошибка открытия файла");
                return;
            }

            //! Writing the file name to a string variable
            string filename = openFileDialog1.FileName;
            //! Writing the file to a string variable
            string maintext = System.IO.File.ReadAllText(filename);

            //! Finding the end of the current line
            int pos = maintext.IndexOf('\n');
            string temptext = maintext.Substring(0, pos);
            maintext = maintext.Remove(0, pos+1);

            while (temptext.Length>0)
            {
                pos = temptext.IndexOf('\t');
                if (pos > 0)
                {
                    string mintext = temptext.Substring(0, pos);
                    temptext = temptext.Remove(0, pos + 1);
                    listName.Add(mintext);
                }
                else
                {
                    string mintext = temptext.Substring(0, temptext.Length);
                    temptext = temptext.Remove(0, temptext.Length);
                    listName.Add(mintext);
                }
            }

            List<double>[] listNumbers = new List<double>[listName.Count];
            for (int i = 0; i < listName.Count; i++)
            {
                listNumbers[i] = new List<double>();
            }

            maintext = maintext.Replace(".", ",");

            string sss1 = "", sss2 = "", sss3 = "", sss4 = "", sss5 = "",
                sss6 = "", sss7 = "", sss8 = "", sss9 = "", sss10 = "";
            int ssss1 = 0, ssss2 = 0, ssss3 = 0, ssss4 = 0, ssss5 = 0,
                ssss6 = 0, ssss7 = 0, ssss8 = 0, ssss9 = 0;

            int j = 0, j2 = 0;

            for (int i = 0; i < maintext.Length; i++)
            {
                if (maintext[i] == '\n') j2++;
            }

            if (j2<10000)
            {
                foo(maintext);
            }
            else
            {
                List<int> tempList = new List<int>();
                for (int i = 0; i < 10; i++)
                {
                    double kkk = (j2 / 10) * (i + 1);
                    int kkk2 = Convert.ToInt32(kkk);
                    tempList.Add(kkk2);
                }

                for (int i = 0; i < maintext.Length; i++)
                {
                    if (maintext[i] == '\n') j++;
                    if (j == tempList[0]) ssss1 = i;
                    if (j == tempList[1]) ssss2 = i;
                    if (j == tempList[2]) ssss3 = i;
                    if (j == tempList[3]) ssss4 = i;
                    if (j == tempList[4]) ssss5 = i;
                    if (j == tempList[5]) ssss6 = i;
                    if (j == tempList[6]) ssss7 = i;
                    if (j == tempList[7]) ssss8 = i;
                    if (j == tempList[8]) ssss9 = i;
                }

                sss1 = maintext.Substring(0, ssss1);
                sss2 = maintext.Substring(ssss1 + 2, ssss2 - ssss1);
                sss3 = maintext.Substring(ssss2 + 2, ssss3 - ssss2);
                sss4 = maintext.Substring(ssss3 + 2, ssss4 - ssss3);
                sss5 = maintext.Substring(ssss4 + 2, ssss5 - ssss4);
                sss6 = maintext.Substring(ssss5 + 2, ssss6 - ssss5);
                sss7 = maintext.Substring(ssss6 + 2, ssss7 - ssss6);
                sss8 = maintext.Substring(ssss7 + 2, ssss8 - ssss7);
                sss9 = maintext.Substring(ssss8 + 2, ssss9 - ssss8);
                sss10 = maintext.Substring(ssss9 + 2);

                foo(sss1);
                foo(sss2);
                foo(sss3);
                foo(sss4);
                foo(sss5);
                foo(sss6);
                foo(sss7);
                foo(sss8);
                foo(sss9);
                foo(sss10);
            }

            void foo(string maintext)
            {
                while (maintext.Length > 0)
                {
                    pos = maintext.IndexOf('\n');
                    if (pos > 0)
                    {
                        temptext = maintext.Substring(0, pos);
                        maintext = maintext.Remove(0, pos + 1);
                        while (temptext.Length > 0)
                        {
                            for (int i = 0; i < listName.Count; i++)
                            {
                                int pos2 = temptext.IndexOf('\t');
                                if (pos2 > 0)
                                {
                                    string mintext = temptext.Substring(0, pos2);
                                    temptext = temptext.Remove(0, pos2 + 1);
                                    listNumbers[i].Add(Convert.ToDouble(mintext));
                                }
                                else
                                {
                                    string mintext = temptext.Substring(0, temptext.Length);
                                    temptext = temptext.Remove(0, temptext.Length);
                                    listNumbers[i].Add(Convert.ToDouble(mintext));
                                }
                            }
                        }
                    }
                    else
                    {
                        temptext = maintext;
                        maintext = maintext.Remove(0, maintext.Length);
                        while (temptext.Length > 0)
                        {
                            for (int i = 0; i < listName.Count; i++)
                            {
                                int pos2 = temptext.IndexOf('\t');
                                if (pos2 > 0)
                                {
                                    string mintext = temptext.Substring(0, pos2);
                                    temptext = temptext.Remove(0, pos2 + 1);
                                    listNumbers[i].Add(Convert.ToDouble(mintext));
                                }
                                else
                                {
                                    string mintext = temptext.Substring(0, temptext.Length);
                                    temptext = temptext.Remove(0, temptext.Length);
                                    listNumbers[i].Add(Convert.ToDouble(mintext));
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < listName.Count; i++)
            {
                listNumber.Add(listNumbers[i].Average());
            }

            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();

            if (checkBox1.Checked)
            {
                [DllImport("kernel32.dll", SetLastError = true)]
                [return: MarshalAs(UnmanagedType.Bool)]
                static extern bool AllocConsole();
                AllocConsole();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}