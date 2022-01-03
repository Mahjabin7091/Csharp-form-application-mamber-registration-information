/*Author: Mahjabin Sajadi
 *purpose: Assignment_3
 *Date: 29-6-2021
 */
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
using System.Globalization;
using System.Text.RegularExpressions;

namespace Assignment3
{
    public partial class Form1 : Form
    {

     /*************Variable definition******************/
        StreamWriter writer = null;
        StreamReader reader = null;

        string path = "";
        string filePath = "";
        string fileName = "";
        string line = "";
        string pathAndfileName = "";
        string record = "";
        string header = "";
        int counter = 0;

        bool flagExist = false;
        bool flagmember = false;
        /************Form1*************/
        public Form1()
        {
            InitializeComponent();

            rtbShow.Enabled = true;
            rtbShow.ReadOnly = true;
        }

        /********************Form Load************************/
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        /***********************Confirm file button*************************************/
        private void btnConfirmFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilePathName.Text))
                lblerrorShow.Text = "no file or path specified";
            else
            {
                //check to exist file before
                path = Path.GetDirectoryName(txtFilePathName.Text);  // using System.IO.Path, the path parser
                fileName = Path.GetFileName(txtFilePathName.Text);

                if (!Directory.Exists(path) && path != "") //path and file are not existed.
                    Directory.CreateDirectory(path);

                // check the address that user enter
                else if (path == "")
                {
                    path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                    path = String.Join(@"\", path.Split('\\').Reverse().Skip(3).Reverse());
                }
                pathAndfileName = System.IO.Path.Combine(path, fileName);

                using (StreamWriter sw = new StreamWriter(@pathAndfileName, true))
                {
                    //
                }
                System.IO.StreamReader file = new System.IO.StreamReader(@pathAndfileName);
               
                if ((line = file.ReadLine()) == null)  //The file is empty
                {
                    header = "Member ID \t" + "First Name \t" + "Last Name \t" + "Date Registered \t" +
                             "Number of Classes \t" + "Total  Cost per Class \t" + "Total Cost of Classes \t" +
                             "Total Paid \t" + "Amount Outstanding";
                    flagExist = true;
                }
                file.Close();
                if (flagExist == true)
                {
                    
                    TextWriter exist = new StreamWriter(@pathAndfileName,true);
                    exist.WriteLine(header,line,"\n");
                    exist.Close();
                    //System.IO.File.AppendAllText(@pathAndfileName, line + "\n");
                }


            }

        }
        /****************************************Read text file****************************************/
        private void btnReloadRecord_Click(object sender, EventArgs e)
        {
            rtbShow.Text = "";
            try
            {
                //reading each line to end of file
                using (StreamReader Reader = new StreamReader(@pathAndfileName)) // example  (@"c:\path\patient.txt "))
                {
                    while (!Reader.EndOfStream)
                    {
                        rtbShow.AppendText(Reader.ReadLine()+"\n");
                    }
                    Reader.Close();
                }


            }
            catch (Exception ex)
            {
                lblerrorShow.Text = "unexpected Exception\n" + ex.Message;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Dispose();//reader.Close(); 
                }
            }
        }
        /***************************************************************************/
        private void btnSaveAddUpdate_Click(object sender, EventArgs e)
        {
            record = "";
            try
            {

                /*******************Member ID*****************/
                if (txtMemberID.Text == "")
                {
                    lblerrorShow.Text = " Please enter your Member ID if you have it!";
                }
                else
                {
                    if(!txtMemberID.Text.Contains("MS"))
                    {
                        lblerrorShow.Text = " Invalid! You must enter \"MS\" at the and of the memberID";
                        lblerrorShow.ForeColor = Color.Red;
                        txtMemberID.Text = txtMemberID.Text.ToUpper() + "MS";
                        record += txtMemberID.Text;
                    }
                    else
                    {
                        lblerrorShow.Text = "valid!";
                        lblerrorShow.ForeColor = Color.Green;
                        txtMemberID.Text = txtMemberID.Text.ToUpper() ;
                        record += txtMemberID.Text;
                    }
                   
    
                }

                /***********************First Name********************/
                if (txtFirstName.Text == "")
                {
                    lblerrorShow.Text = "Please enter your First Name if you have it!";
                }
                else
                {
                    txtFirstName.Text = char.ToUpper(txtFirstName.Text[0]) + txtFirstName.Text.Substring(1);
                    record += "\t" + txtFirstName.Text;

                }
                /******Last Name*******/
                if (txtLastName.Text == "")
                {
                    gbMassages.Text = " Please enter your Last Name if you have it!";
                }
                else
                {
                    txtLastName.Text = char.ToUpper(txtLastName.Text[0]) + txtLastName.Text.Substring(1);
                    record += "\t" + "\t" + txtLastName.Text;

                }
                /**************date registered***************/
                Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");

                //Verify whether date entered in dd/MM/yyyy format.
                bool isValid = regex.IsMatch(txtDataRegistered.Text.Trim());

                //Verify whether entered date is Valid date.
                DateTime dt;
                isValid = DateTime.TryParseExact(txtDataRegistered.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
                record += "\t" + "\t" + txtDataRegistered.Text;
                if (!isValid)
                {
                    lblerrorShow.Text = "Invalid Date! ex: 19/03/2019";
                    lblerrorShow.ForeColor = Color.Red;
                }
                else
                {
                    lblerrorShow.Text = "valid Date!";
                    lblerrorShow.ForeColor = Color.Green;
                }

                /*******************Number of Class*********/

                if (Convert.ToInt32(txtNumberOfClasses.Text) > 0 && Convert.ToInt32(txtNumberOfClasses.Text) <= 20)  //20 classes
                {
                    record += "\t" + "\t" + txtNumberOfClasses.Text;
                }
                else
                {
                    lblerrorShow.Text = " Please enter your valid number class between 1 to 20!";
                }
                /*********Total cost per class************/
                if (Convert.ToDouble(txtTotalCost.Text) >0 && Convert.ToDouble(txtTotalCost.Text) <= 1500) //cost of per class between $100-$1500
                {
                    if (txtTotalCost.Text.Contains("$"))
                    {
                        record += "\t" + "\t" + "$" + txtTotalCost.Text;
                        record += string.Format("{0:#,##0.00}", double.Parse(txtTotalCost.Text));
                    }
                    else
                    {
                        record += "\t" + "\t" + "$" + txtTotalCost.Text;
                        record += string.Format("{0:#,##0.00}", double.Parse(txtTotalCost.Text));

                    }

                }
                else
                {
                    lblerrorShow.Text = " Please enter valid number from 1-1500 without $ sign!";
                }
                /**************total cost all class*****************/

                txtTotalCostAllClasses.Text = (Convert.ToInt32(txtNumberOfClasses.Text) * Convert.ToDouble(txtTotalCost.Text)).ToString();

                record += "\t" + "\t" + "$" + txtTotalCostAllClasses.Text;
                record += string.Format("{0:#,##0.00}", double.Parse(txtTotalCostAllClasses.Text));

                /********************Total Paid*****************/
                txtTotalPaid.Text = txtTotalCostAllClasses.Text;

                record += "\t" + "\t" + "$" + string.Format("{0:#,##0.00}", double.Parse(txtTotalPaid.Text));


                /********************Amount Outstanding*********/
                txtAmountOutstanding.Text = (double.Parse(txtTotalPaid.Text) - int.Parse(txtTotalCostAllClasses.Text)).ToString();

                record += "\t" + "\t" + "$" + string.Format("{0:#,##0.00}", double.Parse(txtAmountOutstanding.Text));
                /***********Update Information************/

                var lines = File.ReadAllLines(@pathAndfileName);
                counter = 0;
                int numberLine = 0;
                flagmember = false;

                foreach (var lin in lines)
                {
                    if (lin.Contains(txtMemberID.Text))
                    {
                        flagmember = true;
                        numberLine = counter;
                    }
                    counter++;

                }
                //MessageBox.Show("Hello" + numberLine);
                if(flagmember == false)  //we do not have a doublicate memberID.
                {
                    TextWriter writeToFlie = new StreamWriter(@pathAndfileName, true);
                    writeToFlie.WriteLine(record, "\n");
                    writeToFlie.Close();
                }
                else
                {
                    MessageBox.Show("A record with the same  member ID exists, program will be update that record.");

                    using (StreamWriter writer = new StreamWriter(@pathAndfileName))
                    {
                        for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                        {
                            if (currentLine == numberLine +1)
                            {
                                writer.WriteLine(record , "\n");
                            }
                            else
                            {
                                writer.WriteLine(lines[currentLine - 1]);
                            }
                        }
                    }


                }
               
            }
            catch (Exception ex)
            {
                lblerrorShow.Text = "unexpected Exception\n" + ex.Message;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Dispose();//reader.Close(); 
                }
            }


        }
/********************Delete the memberID number********************************/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text != "")
                txtMemberID.Clear();
        }
/*******************************Empty the text file**************************/
        private void btnEmptyFile_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter(@pathAndfileName, false);
            tw.Write(string.Empty);
            tw.Close();
        }
/********************************Exit Program*******************************/
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }



    }
}
