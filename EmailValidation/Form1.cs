
/*
 *   This file is part of EmailValidation source code.  All Rights Reserved.
 *
 *  EmailValidation is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2 of the License.
 *
 *  This software is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this software; if not, write to the Free Software
 *  Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307,
 *  USA.
 */


/*
 *     Author: Philip Murray
 *     Project Homepage: https://github.com/PhilipMur/EmailValidation
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EmailValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].Width = 80;
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 80;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            ValidateEmailUtility validateEmail = new ValidateEmailUtility();

            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if(row.Cells[0].Value != null)
                    {
                        double domainPercentMatch = 0;
                        double tldPercentMatch = 0;

                        bool isValid = validateEmail.ValidateEmailAddress(row.Cells[0].Value.ToString() , 
                            domainPercentMatch: out domainPercentMatch , tldPercentMatch: out tldPercentMatch);

                        bool isValid2 = validateEmail.ValidateEmailAddress(row.Cells[0].Value.ToString());



                        if (isValid)
                        {
                            row.Cells[1].Value = true;
                            row.Cells[2].Value = false;

                        }
                        else
                        {
                            row.Cells[1].Value = false;
                            row.Cells[2].Value = true;
                        }

                        row.Cells[3].Value = domainPercentMatch;
                        row.Cells[4].Value = tldPercentMatch;
                    }
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text Files |*.txt|CSV Files |*.csv";

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    List<string> sampleList = new List<string>();
                    sampleList = File.ReadAllLines(ofd.FileName).ToList();

                    dataGridView1.Rows.Clear();

                    foreach (var item in sampleList)
                    {
                        dataGridView1.Rows.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error ::" + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error ::" + ex.Message);
            }
        }

        //private bool ValidateEmailAddress(string email , out double percentMatch)
        //{
        //    percentMatch = 0;

        //    List<string> domainsList = new List<string>();
        //    domainsList.Add("gmail");
        //    domainsList.Add("yahoo");
        //    domainsList.Add("hotmail");
        //    domainsList.Add("aol");
        //    domainsList.Add("msn");
        //    domainsList.Add("live");
        //    domainsList.Add("outlook");
        //    domainsList.Add("proton");

        //    try
        //    {
        //       if(string.IsNullOrWhiteSpace(email))
        //        {
        //            return false;
        //        }

        //        if (email.Contains('@') && email.Contains('.'))
        //        {
        //            if(email.Contains(".co.uk"))
        //            {
        //                email = email.Replace(".uk", "");
        //            }

        //            int startIndex = email.IndexOf('@') + 1;
        //            int lastIndex = email.LastIndexOf('.');

        //            if(lastIndex < startIndex)
        //            {
        //                return false;
        //            }

        //            string domainName = email.Substring(startIndex, lastIndex - startIndex);
        //           // string [] strArr = email.Split(splitArr, StringSplitOptions.RemoveEmptyEntries);

        //            if(domainName.Length > 2)
        //            {
        //                foreach (string item in domainsList)
        //                {
        //                    double val = CalculateSimilarity(source: domainName, target: item);

        //                    percentMatch = Math.Round( (val * 100) ,2);

        //                   // Console.WriteLine("percentage:" + val.ToString());

        //                    if (val == 1)
        //                    {
        //                        return true;
        //                    }

        //                    if (val >= 0.8)
        //                    {
        //                        return false;
        //                    }
        //                }

        //            }

        //        }
        //        else
        //        {
        //            return false;
        //        }


        //        return true;
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }
        //}
        //private double CalculateSimilarity(string source, string target)
        //{
        //    if ((source == null) || (target == null))
        //    {
        //        return 0.0;
        //    }
        //    if ((source.Length == 0) || (target.Length == 0))
        //    {
        //        return 0.0;
        //    }
        //    if (source == target)
        //    {
        //        return 1.0;
        //    }

        //    int stepsToSame = ComputeLevenshteinDistance(source, target);
        //    return (1.0 - ((double)stepsToSame / (double)Math.Max(source.Length, target.Length)));
        //}

        //private int ComputeLevenshteinDistance(string source, string target)
        //{
        //    if ((source == null) || (target == null))
        //    {
        //        return 0;
        //    }
        //    if ((source.Length == 0) || (target.Length == 0))
        //    {
        //        return 0;
        //    }
        //    if (source == target)
        //    {
        //        return source.Length;
        //    }

        //    int sourceWordCount = source.Length;
        //    int targetWordCount = target.Length;

        //    // Step 1
        //    if (sourceWordCount == 0)
        //        return targetWordCount;

        //    if (targetWordCount == 0)
        //        return sourceWordCount;

        //    int[,] distance = new int[sourceWordCount + 1, targetWordCount + 1];

        //    // Step 2
        //    for (int i = 0; i <= sourceWordCount; distance[i, 0] = i++) ;
        //    for (int j = 0; j <= targetWordCount; distance[0, j] = j++) ;

        //    for (int i = 1; i <= sourceWordCount; i++)
        //    {
        //        for (int j = 1; j <= targetWordCount; j++)
        //        {
        //            // Step 3
        //            int cost = (target[j - 1] == source[i - 1]) ? 0 : 1;

        //            // Step 4
        //            distance[i, j] = Math.Min(Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1), distance[i - 1, j - 1] + cost);
        //        }
        //    }

        //    return distance[sourceWordCount, targetWordCount];
        //}
    }
}
