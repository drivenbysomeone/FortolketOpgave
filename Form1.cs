using Novacode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FortolketOpgave
{
    
    public partial class Form1 : Form
    {

        
        BL bl = new BL();
        string userInput = "";
     

        public Form1()
        {

            InitializeComponent();
            allDataRevealed();
            
        }

      

        private void allDataRevealed()

        {
            int thePlatformId = Convert.ToInt32(cmbBoxPlatforms.SelectedValue);
            listOS.ValueMember = "TheId";
            listOS.DisplayMember = "TheOperatingSystem";
            listOS.DataSource = bl.ShowAllOS();
        //    listOS.DataSource = bl.ShowOS(0);
            

            listPrograms.ValueMember = "TheId";
            listPrograms.DisplayMember = "TheProgram";
            listPrograms.DataSource = bl.ShowAllPrograms();
           // listPrograms.DataSource = bl.ShowProgram(0);

            listBrowsers.ValueMember = "TheId";
            listBrowsers.DisplayMember = "TheBrowser";
            listBrowsers.DataSource = bl.ShowBrowser();

            listConnectionConfig.ValueMember = "ConnectionId";
            listConnectionConfig.DisplayMember = "TheText";            
            listConnectionConfig.DataSource = bl.ShowInternet();

            cmbBoxPlatforms.ValueMember = "TheId";
            cmbBoxPlatforms.DisplayMember = "ThePlatform";
            cmbBoxPlatforms.DataSource = bl.ShowPlatform();


        }


        #region Click button

        private void btnGetData_Click(object sender, EventArgs e)
        {

           GenerateMessageBoxText();

           #region Run path/Word program
           // Forcing the path below to run everytime the this btn-click happens
           Console.WriteLine("\tCreated: docs\\Indentation.docx\n");
           string test = @"U:\AspIT1020\2.år - flex\projekter\FortolketOpgave\FortolketOpgave\bin\Debug\docs\Indentation.docx";
           Process.Start("WINWORD.EXE", "\"" + test + "\"");
   

           #endregion
        }
        
        #endregion
        #region GenerateMsgBoc method
        private void GenerateMessageBoxText()
        {
           
            #region SQL and BL
            // --> BL and SQL code - where SQL database-string is contained in App.config

            //Check the cmbBox platformId.

            int thePlatformId = Convert.ToInt32(cmbBoxPlatforms.SelectedValue);


            DataExtractions de = bl.Randomize(thePlatformId);


            string browsers = "";
            string programs = "";

            //If BL-code takes more than 1 random items I add ", ":
            int theCount = 0;        
            int countBrowser = de.Browser.Count;

            if (countBrowser == theCount)
            {
                browsers = "ingen browsere skal installeres";
            }

            foreach (var item in de.Browser)
            {
                theCount++;

                if (countBrowser == theCount)
                {
                    browsers += item.TheBrowser;
                    theCount = 0;
                }
                else
                    browsers += item.TheBrowser + ", ";           
            }

            
            int countProgram = de.Program.Count;

            if (countProgram < theCount)
            {
                programs = "ingen programmer skal installeres";
            }

            foreach (var item in de.Program)
            {
                theCount++;

 
                if (countProgram == theCount)
                {
                    programs += item.TheProgram;
                    theCount = 0;
                }
                else
                    programs += item.TheProgram + ", ";
            }

            #endregion

                  #region Outdated layout format in C#

            //StringBuilder build = new StringBuilder();
            //build.AppendLine();
            //build.AppendLine("Tag " + de.Quantity.TheQuantity.ToString() + " pc'er");
            //build.AppendLine("På pc'erne skal der installeres følgende:");
            //build.AppendLine("OS: " + de.OperatingSystem.TheOperatingSystem);
            //build.AppendLine("Programmer: " + programs);
            //build.AppendLine("Browsers: " + browsers);
            //build.AppendLine();
            //build.AppendLine(de.Connection.TheText);

            // return build;

            #endregion 
           
                  #region INFO: Plug-in installed: "docx libary" - and source-link found:
            //Se: https://docx.codeplex.com/SourceControl/latest#Examples/Program.cs
#endregion 

       # region Start document docX - code
            using (DocX document = DocX.Create(@"docs\Indentation.docx"))
            {

                #region Header - implemented code
                // Add Headers and Footers to this document.

                document.AddHeaders();
                document.AddFooters();
                // Force the first page to have a different Header and Footer.
                document.DifferentFirstPage = true;
                // Get the first Header for this document.
                Header header_first = document.Headers.first;
                // Insert a Paragraph into the first Header.
                Paragraph p0 = header_first.InsertParagraph();
                p0.Append("Computer opsætning").Font(new FontFamily("Times New Roman")).FontSize(32).Color(Color.Blue).Bold();

                p0.Alignment = Alignment.center;
                // Save all changes made to this document.
            


                #endregion 

                #region Main content
                //The main content - layout:

                Paragraph allText = document.InsertParagraph().AppendLine();
                allText.AppendLine();
                allText.Append("Tag ").Append(de.Quantity.TheQuantity.ToString());
                allText.Append(" pc'er");
                allText.AppendLine();
                allText.AppendLine();
                allText.Append("På pc'erne skal der installeres følgende:");
                allText.AppendLine();
                allText.Append("OS: ").Bold();
                allText.Append(de.OperatingSystem.TheOperatingSystem);
                allText.AppendLine();
                allText.Append("Programmer: ").Bold();
                allText.Append(programs);
                allText.AppendLine();
                allText.Append("Browsere: ").Bold();
                allText.Append(browsers);
                allText.AppendLine();
                allText.AppendLine();
                allText.Append(de.Connection.TheText);

                // System.Diagnostics.Process.Start(@".Manual.pdf");

                document.Save();
                #endregion
   
            }

            #endregion 

        }

        #endregion

 

        private void btnAddValue_Click(object sender, EventArgs e)
        {
            int thePlatformId = Convert.ToInt32(cmbBoxPlatforms.SelectedValue);
            //Programs allProgramValues = new Programs();
            //int platformId = allProgramValues.PlatformId;

            if (txtBoxInput.Text != "" && cmbBoxPlatforms != null)
            {
                userInput = txtBoxInput.Text;

                if (rdbBrowsers.Checked == true)
                {
                    bl.InsertBrowserValue(userInput);
                    
                }

                if (rdbOS.Checked == true)
                {
                    bl.InsertNewOsValue(userInput, thePlatformId);

                }

                if(rdbPrograms.Checked == true)
                {
                    bl.InsertNewProgramValue(userInput, thePlatformId);

                }

                if (rdbConnectionConfig.Checked == true)
                {
                    bl.InsertConnectionValue(userInput);
                }

            }

            else
            {
                MessageBox.Show("Indtast en værdi i tekstfeltet og vælg den katagori der matcher din nye værdi." + Environment.NewLine + Environment.NewLine + "Please insert a value in the text field - and select the matching catagory for your new value");
                
            }

            allDataRevealed();
           
        }

   
       


    }
}
