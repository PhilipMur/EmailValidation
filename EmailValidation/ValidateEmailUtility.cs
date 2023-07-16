
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
using System.Linq;

namespace EmailValidation
{
    class ValidateEmailUtility
    {

        private List<string> TLDList()
        {
            //Verify 100% that its a valid Top Level domain aka TLD
            //it has to exist in here otherwise its not a valid TLD
            List<string> tldsList = new List<string>();
            //popular
            tldsList.Add("ie");
            tldsList.Add("com");
            tldsList.Add("net");
            tldsList.Add("org");
            tldsList.Add("info");
            tldsList.Add("biz");
            tldsList.Add("eu");
            tldsList.Add("edu");
            tldsList.Add("int");
            tldsList.Add("mil");
            tldsList.Add("arpa");
            tldsList.Add("co");
            tldsList.Add("uk");
            tldsList.Add("gov");
            //generic
            tldsList.Add("agency");
            tldsList.Add("academy");
            tldsList.Add("app");
            tldsList.Add("aisa");
            tldsList.Add("art");
            tldsList.Add("aero");
            tldsList.Add("africa");
            tldsList.Add("biz");
            tldsList.Add("bet");
            tldsList.Add("buzz");
            tldsList.Add("blog");
            tldsList.Add("best");
            tldsList.Add("cat");
            tldsList.Add("careers");
            tldsList.Add("club");
            tldsList.Add("cloud");
            tldsList.Add("company");
            tldsList.Add("center");
            tldsList.Add("click");
            tldsList.Add("coop");
            tldsList.Add("city");
            tldsList.Add("cyou");
            tldsList.Add("dance");
            tldsList.Add("dev");
            tldsList.Add("digital");
            tldsList.Add("email");
            tldsList.Add("expert");
            tldsList.Add("education");
            tldsList.Add("farm");
            tldsList.Add("finance");
            tldsList.Add("global");
            tldsList.Add("group");
            tldsList.Add("holiday");
            tldsList.Add("host");
            tldsList.Add("irish");
            tldsList.Add("live");
            tldsList.Add("life");
            tldsList.Add("link");
            tldsList.Add("ltd");
            tldsList.Add("marketing");
            tldsList.Add("market");
            tldsList.Add("mobi");
            tldsList.Add("media");
            tldsList.Add("moscow");
            tldsList.Add("name");
            tldsList.Add("network");
            tldsList.Add("nyc");
            tldsList.Add("online");
            tldsList.Add("one");
            tldsList.Add("pro");
            tldsList.Add("plus");
            tldsList.Add("site");
            tldsList.Add("shop");
            tldsList.Add("store");
            tldsList.Add("space");
            tldsList.Add("studio");
            tldsList.Add("solutions");
            tldsList.Add("services");
            tldsList.Add("school");
            tldsList.Add("top");
            tldsList.Add("travel");
            tldsList.Add("tech");
            tldsList.Add("today");
            tldsList.Add("tokyo");
            tldsList.Add("team");
            tldsList.Add("rocks");
            tldsList.Add("watch");
            tldsList.Add("website");
            tldsList.Add("work");
            tldsList.Add("world");
            tldsList.Add("win");
            tldsList.Add("wiki");
            tldsList.Add("vip");
            tldsList.Add("video");
            tldsList.Add("xyz");
            tldsList.Add("xxx");
            tldsList.Add("zone");
            //country
            tldsList.Add("ae");
            tldsList.Add("ac");
            tldsList.Add("at");
            tldsList.Add("au");
            tldsList.Add("ar");
            tldsList.Add("ai");
            tldsList.Add("am");
            tldsList.Add("al");
            tldsList.Add("az");
            tldsList.Add("ba");
            tldsList.Add("be");
            tldsList.Add("br");
            tldsList.Add("by");
            tldsList.Add("bg");
            tldsList.Add("bz");
            tldsList.Add("cz");
            tldsList.Add("cr");
            tldsList.Add("ca");
            tldsList.Add("ch");
            tldsList.Add("ci");
            tldsList.Add("cn");
            tldsList.Add("cf");
            tldsList.Add("cl");
            tldsList.Add("cc");
            //tldsList.Add("cm");
            tldsList.Add("cy");
            tldsList.Add("cx");
            tldsList.Add("dk");
            tldsList.Add("de");
            tldsList.Add("do");
            tldsList.Add("fi");
            tldsList.Add("fr");
            tldsList.Add("fm");
            tldsList.Add("es");
            tldsList.Add("ec");
            tldsList.Add("eu");
            tldsList.Add("ee");
            tldsList.Add("es");
            tldsList.Add("eg");
            tldsList.Add("gr");
            tldsList.Add("ga");
            tldsList.Add("ge");
            tldsList.Add("gq");
            tldsList.Add("gg");
            tldsList.Add("hu");
            tldsList.Add("hk");
            tldsList.Add("hr");
            tldsList.Add("ie");
            tldsList.Add("in");
            tldsList.Add("it");
            tldsList.Add("id");
            tldsList.Add("io");
            tldsList.Add("il");
            tldsList.Add("im");
            tldsList.Add("is");
            tldsList.Add("jp");
            tldsList.Add("jo");
            tldsList.Add("ki");
            tldsList.Add("kr");
            tldsList.Add("kz");
            tldsList.Add("ke");
            tldsList.Add("kg");
            tldsList.Add("la");
            tldsList.Add("lv");
            tldsList.Add("lt");
            tldsList.Add("lk");
            tldsList.Add("lu");
            tldsList.Add("ma");
            tldsList.Add("md");
            tldsList.Add("mx");
            tldsList.Add("me");
            tldsList.Add("mk");
            tldsList.Add("my");
            tldsList.Add("ml");
            tldsList.Add("mn");
            tldsList.Add("mu");
            tldsList.Add("ms");
            tldsList.Add("nl");
            tldsList.Add("nz");
            tldsList.Add("ng");
            tldsList.Add("np");
            tldsList.Add("no");
            tldsList.Add("nu");
            tldsList.Add("om");
            tldsList.Add("pa");
            tldsList.Add("pl");
            tldsList.Add("ph");
            tldsList.Add("pk");
            tldsList.Add("pe");
            tldsList.Add("pt");
            tldsList.Add("pw");
            tldsList.Add("ro");
            tldsList.Add("ru");
            tldsList.Add("sa");
            tldsList.Add("sc");
            tldsList.Add("si");
            tldsList.Add("sg");
            tldsList.Add("se");
            tldsList.Add("su");
            tldsList.Add("sk");
            tldsList.Add("se");
            tldsList.Add("si");
            tldsList.Add("so");
            tldsList.Add("sh");
            tldsList.Add("tk");
            tldsList.Add("tw");
            tldsList.Add("tv");
            tldsList.Add("th");
            tldsList.Add("tn");
            tldsList.Add("to");
            tldsList.Add("tj");
            tldsList.Add("ws");
            tldsList.Add("us");
            tldsList.Add("uy");
            tldsList.Add("uz");
            tldsList.Add("ug");
            tldsList.Add("vn");
            tldsList.Add("ve");
            tldsList.Add("vc");
            tldsList.Add("za");

            return tldsList;
        }

        private List<string> DomainList()
        {
            //verify misspelling of a popular domain by error of 1 character
            //If it doesnt exist in here its a private domain so its valid
            //if anyone knows a better solution let me know.
            List<string> domainsList = new List<string>();
            domainsList.Add("gmail");
            domainsList.Add("yahoo");
            domainsList.Add("hotmail");
            domainsList.Add("aol");
            domainsList.Add("aim");
            domainsList.Add("msn");
            domainsList.Add("live");
            domainsList.Add("outlook");
            domainsList.Add("proton");
            domainsList.Add("googlemail");
            domainsList.Add("rocketmail");
            domainsList.Add("t-online");
            domainsList.Add("ntlworld");
            domainsList.Add("skynet");
            domainsList.Add("sky");
            domainsList.Add("mac");
            domainsList.Add("aim");
            domainsList.Add("eircom");
            domainsList.Add("btinternet");
            domainsList.Add("gmx");
            domainsList.Add("free");
            domainsList.Add("mail");

            return domainsList;
        }


        public bool ValidateEmailAddress(string email, out double domainPercentMatch, out double tldPercentMatch)
        {
            domainPercentMatch = 0;
            tldPercentMatch = 0;

            string domainName = "";
            string tldName1 = "";
            string tldName2 = "";

            email = email.ToLower().Trim();

            try
            {
                if (email.Contains('@') && email.Contains('.'))
                {
                    var addr = new System.Net.Mail.MailAddress(email);

                   

                }
                else
                {
                    return false;
                }


            }
            catch(Exception ex)
            {
                return false;
            }

            List<string> domainsList = new List<string>();
            domainsList = DomainList();

            List<string> tldsList = new List<string>();
            tldsList = TLDList();

           

            try
            {



                //Verify TLD
                bool isValidTld = GeTldName(email: email, tldName1: out tldName1, tldName2: out tldName2);

                if (isValidTld)
                {
                    foreach (string item in tldsList)
                    {


                        if (tldName2 != "")
                        {
                            //calculate the simularity to the correct spelling
                            double val1 = CalculateSimilarity(source: tldName1, target: item);




                            tldPercentMatch = Math.Round((val1 * 100), 2);


                            if (val1 == 1)
                            {
                                foreach (string item2 in tldsList)
                                {
                                    double val2 = CalculateSimilarity(source: tldName1, target: item);

                                    if (val2 == 1)
                                    {
                                        break;
                                    }

                                    if (val2 >= 0.8)
                                    {

                                        return false;
                                    }
                                }

                                break;
                            }

                            if (val1 >= 0.8)
                            {

                                return false;
                            }


                        }
                        else
                        {
                            //calculate the simularity to the correct spelling
                            double val1 = CalculateSimilarity(source: tldName1, target: item);

                            tldPercentMatch = Math.Round((val1 * 100), 2);


                            if (val1 == 1)
                            {
                                break;
                            }

                            if (val1 >= 0.75)
                            {
                                return false;
                            }
                        }

                    }

                    if(tldName2 != "")
                    {
                        //if they have all the correct characters but in the wrong order
                        if (CheckTldSpelling(comapreList: tldsList, stringToCompare: tldName2))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        //if they have all the correct characters but in the wrong order
                        if (CheckTldSpelling(comapreList: tldsList, stringToCompare: tldName1))
                        {
                            return false;
                        }
                    }

                   
                }
                else
                {
                    return false;
                }

                //Verify Domain
                bool isValidDomain = GetDomainName(email: email, domainName: out domainName);



                if (isValidDomain && domainName.Length > 2)
                {
                    foreach (string item in domainsList)
                    {
                        //calculate simularity to the correct spelling where they are missing at least one character
                        double val = CalculateSimilarity(source: domainName, target: item);

                        domainPercentMatch = Math.Round((val * 100), 2);


                        if (val == 1)
                        {
                            return true;
                        }

                        if (val >= 0.75)
                        {
                            return false;
                        }
                    }

                    //if they have all the correct characters but in the wrong order
                    if (CheckDomainSpelling(comapreList: domainsList, stringToCompare: domainName))
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {


                return false;
            }
        }

        public bool ValidateEmailAddress(string email)
        {
            //domainPercentMatch = 0;
            //tldPercentMatch = 0;

            string domainName = "";
            string tldName1 = "";
            string tldName2 = "";

            email = email.ToLower().Trim();

            try
            {
                if (email.Contains('@') && email.Contains('.'))
                {
                    var addr = new System.Net.Mail.MailAddress(email);



                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                return false;
            }


            List<string> domainsList = new List<string>();
            domainsList = DomainList();

            List<string> tldsList = new List<string>();
            tldsList = TLDList();

           

            try
            {



                //Verify TLD
                bool isValidTld = GeTldName(email: email, tldName1: out tldName1, tldName2: out tldName2);

                if (isValidTld)
                {
                    foreach (string item in tldsList)
                    {


                        if (tldName2 != "")
                        {
                            //calculate the simularity to the correct spelling
                            double val1 = CalculateSimilarity(source: tldName1, target: item);




                           // tldPercentMatch = Math.Round((val1 * 100), 2);


                            if (val1 == 1)
                            {
                                foreach (string item2 in tldsList)
                                {
                                    double val2 = CalculateSimilarity(source: tldName1, target: item);

                                    if (val2 == 1)
                                    {
                                        break;
                                    }

                                    if (val2 >= 0.8)
                                    {

                                        return false;
                                    }
                                }

                                break;
                            }

                            if (val1 >= 0.8)
                            {

                                return false;
                            }


                        }
                        else
                        {
                            //calculate the simularity to the correct spelling
                            double val1 = CalculateSimilarity(source: tldName1, target: item);

                           // tldPercentMatch = Math.Round((val1 * 100), 2);


                            if (val1 == 1)
                            {
                                break;
                            }

                            if (val1 >= 0.75)
                            {
                                return false;
                            }
                        }

                    }

                    if (tldName2 != "")
                    {
                        //if they have all the correct characters but in the wrong order
                        if (CheckTldSpelling(comapreList: tldsList, stringToCompare: tldName2))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        //if they have all the correct characters but in the wrong order
                        if (CheckTldSpelling(comapreList: tldsList, stringToCompare: tldName1))
                        {
                            return false;
                        }
                    }


                }
                else
                {
                    return false;
                }

                //Verify Domain
                bool isValidDomain = GetDomainName(email: email, domainName: out domainName);



                if (isValidDomain && domainName.Length > 2)
                {
                    foreach (string item in domainsList)
                    {
                        //calculate simularity to the correct spelling where they are missing at least one character
                        double val = CalculateSimilarity(source: domainName, target: item);

                       // domainPercentMatch = Math.Round((val * 100), 2);


                        if (val == 1)
                        {
                            return true;
                        }

                        if (val >= 0.75)
                        {
                            return false;
                        }
                    }

                    //if they have all the correct characters but in the wrong order
                    if (CheckDomainSpelling(comapreList: domainsList, stringToCompare: domainName))
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {


                return false;
            }
        }



        private bool GetDomainName(string email, out string domainName)
        {


            domainName = "";

            try
            {


                if (string.IsNullOrWhiteSpace(email))
                {
                    return false;
                }

                foreach (char c in email)
                {
                    if (char.IsLetterOrDigit(c) == false
                        && c != '@' && c != '.' && c != '-' && c != '_' && c != '+' && c != '!' && c != '/' && c != '#' && c != '&' && c != '\'')
                    {
                        return false;
                    }
                }

                if (email.Contains('@') && email.Contains('.'))
                {


                    int startIndex = email.IndexOf('@') + 1;
                    int lastIndex = email.LastIndexOf('.');


                    
                    string nameRemoved = email.Substring(startIndex);

                    string[] occurence = nameRemoved.Split('.');

                    if (occurence.Length <= 0)
                    {
                        return false;
                    }

                    
                    if (lastIndex < startIndex)
                    {
                        return false;
                    }

                    domainName = occurence[0];

                    // domainName = email.Substring(startIndex, lastIndex - startIndex);


                    if (domainName.Length > 2)
                    {

                        return true;

                      
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }


        private bool GeTldName(string email, out string tldName1, out string tldName2)
        {


            tldName1 = ""; //.com .co etc....
            tldName2 = ""; //.com.uk etc....

            try
            {


                if (string.IsNullOrWhiteSpace(email))
                {
                    return false;
                }

               
                if (email.Contains('@') && email.Contains('.'))
                {

                 

                    int startIndex = email.IndexOf('@') + 1;
                    int lastIndex = email.LastIndexOf('.');

                    if (lastIndex < startIndex)
                    {
                        return false;
                    }

                   
                    string nameRemoved = email.Substring(startIndex);

                    string[] occurence = nameRemoved.Split('.');

                    if (occurence.Length <= 0)
                    {
                        return false;
                    }

                   
                    if (occurence.Length >= 2)
                    {
                        tldName1 = occurence[1];
                    }
                    if (occurence.Length >= 3)
                    {
                        tldName2 = occurence[2];
                    }

                    // tldName1 = email.Substring(startIndex, lastIndex - startIndex);


                    if (tldName1.Length >= 2)
                    {

                        return true;

                       

                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        private bool CheckDomainSpelling(List<string> comapreList, string stringToCompare)
        {
            List<bool> boolList = new List<bool>();

            try
            {
                if (string.IsNullOrWhiteSpace(stringToCompare))
                {
                    return false;
                }



                char[] domainChars = stringToCompare.ToArray();




                foreach (string item in comapreList)
                {
                    char[] listChars = item.ToArray();

                  

                    if (domainChars.Except(listChars).Count() == 0 && domainChars.Length == listChars.Length)
                    {

                        //they match all the same chars but check they are in the same order
                        if (stringToCompare == item && domainChars.SequenceEqual(listChars))
                        {
                            //has all the same chars and in the same order/spelled correctly
                            return false;
                        }
                        else
                        {
                            //has all the same chars but spelled wrong
                            return true;
                        }

                    }

                    //if all the characters are there but in the wrong order /spelled wrong 
                    bool isBadSpelling = domainChars.Except(listChars).Any() == false && listChars.Except(domainChars).Any() == false;


                    if (isBadSpelling)
                    {
                        return true;
                    }



                }

                return false;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        private bool CheckTldSpelling(List<string> comapreList, string stringToCompare)
        {
            try
            {
                if (comapreList.Contains(stringToCompare))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }

      
        private double CalculateSimilarity(string source, string target)
        {
            if ((source == null) || (target == null))
            {
                return 0.0;
            }
            if ((source.Length == 0) || (target.Length == 0))
            {
                return 0.0;
            }
            if (source == target)
            {
                return 1.0;
            }

            int stepsToSame = ComputeLevenshteinDistance(source, target);
            return (1.0 - ((double)stepsToSame / (double)Math.Max(source.Length, target.Length)));
        }

        private int ComputeLevenshteinDistance(string source, string target)
        {
            if ((source == null) || (target == null))
            {
                return 0;
            }
            if ((source.Length == 0) || (target.Length == 0))
            {
                return 0;
            }
            if (source == target)
            {
                return source.Length;
            }

            int sourceWordCount = source.Length;
            int targetWordCount = target.Length;

           
            if (sourceWordCount == 0)
            {
                return targetWordCount;
            }


            if (targetWordCount == 0)
            {
                return sourceWordCount;
            }


            int[,] distance = new int[sourceWordCount + 1, targetWordCount + 1];

           
            for (int i = 0; i <= sourceWordCount; distance[i, 0] = i++) ;
            for (int j = 0; j <= targetWordCount; distance[0, j] = j++) ;

            for (int i = 1; i <= sourceWordCount; i++)
            {
                for (int j = 1; j <= targetWordCount; j++)
                {
                   
                    int cost = (target[j - 1] == source[i - 1]) ? 0 : 1;

                   
                    distance[i, j] = Math.Min(Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1), distance[i - 1, j - 1] + cost);
                }
            }

            return distance[sourceWordCount, targetWordCount];
        }


    }
}
