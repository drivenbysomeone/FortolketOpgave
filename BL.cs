using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortolketOpgave
{
    class BL
    {
        DAL dal = new DAL();


        public DataExtractions Randomize(int platformId)
        {
            Random r = new Random();

            var browsers = ShowBrowser();
            int i = r.Next(0, browsers.Count);
            var theBrowsers = browsers.OrderBy(x => r.Next()).Take(i).ToList();

            var connections = ShowInternet();
            i = r.Next(1, connections.Count);
            var connection = connections[i];

            var programs = ShowProgram(platformId);
            i = r.Next(0, programs.Count);
            var program = programs.OrderBy(x => r.Next()).Take(i).ToList();

            var theOS = ShowOS(platformId);
            i = r.Next(0, theOS.Count);
            var OS = theOS[i];

            #region Algorithm for controlled shuffling frequecncy technique
            //Algortihm
            var units = ShowUnits();              
            int theRank = 0;
            for (int k = 0; k < 3; k++)
            {
                units.Shuffle();
                theRank = units[0].TheRank;
                if (theRank == 1)
                    break; 
            }
            // Linq-code
            var query = (from a in units
                         where a.TheRank == theRank
                         select a).ToList();
            var unit = query[0];
            #endregion


            DataExtractions extract = new DataExtractions();
            extract.Browser = theBrowsers;
            extract.Connection = connection;
            extract.Program = program;
            extract.OperatingSystem = OS;
            extract.Quantity = unit;

            return extract;
        }


        internal List<Browsers> ShowBrowser()
        {

            DataTable dt = dal.GetBrowsers();
            var l1 = new List<Browsers>();
            foreach (DataRow item in dt.Rows)
            {
                var browser = new Browsers();

                browser.TheId = Convert.ToInt32(item["Id"].ToString());
                browser.TheBrowser = item["Browser"].ToString();
                l1.Add(browser);


            }
            return l1;
        }

        internal List<Connections> ShowInternet()
        {

            DataTable dt = dal.GetInternet();
            var l1 = new List<Connections>();
            foreach (DataRow item in dt.Rows)
            {
                var connection = new Connections();

                connection.ConnectionId = Convert.ToInt32(item["Id"].ToString());
                connection.TheConnection = item["Connection"].ToString();
                connection.TheText = item["Text"].ToString();
                l1.Add(connection);

            }
            return l1;
        }

        //TODO - List<Programs> ShowPrograms()    - do the same with OS

        internal List<Programs> ShowAllPrograms()
        {
            DataTable dt = dal.GetPrograms();
            var l = new List<Programs>();
            foreach (DataRow item in dt.Rows)
            {
                var program = new Programs();
                program.TheId = Convert.ToInt32(item["Id"].ToString());
                program.TheProgram = item["Program"].ToString();
                l.Add(program);
            }
            return l;
        }

        internal List<OperatingSystems> ShowAllOS()
        {
            DataTable dt = dal.GetOS();
            var l = new List<OperatingSystems>();
            foreach (DataRow item in dt.Rows)
            {
                var os = new OperatingSystems();
                os.theId = Convert.ToInt32(item["Id"].ToString());
                os.TheOperatingSystem = item["Operating System"].ToString();
                l.Add(os);

            }
            return l;
        }

        internal List<Programs> ShowProgram(int i)
        {

            DataTable dt = dal.GetProgramsById(i);
            var l1 = new List<Programs>();
            foreach (DataRow item in dt.Rows)
            {
                var program = new Programs();
                program.TheId = Convert.ToInt32(item["Id"].ToString());
                program.TheProgram = item["Program"].ToString();
                l1.Add(program);

            }
            return l1;
        }

        internal List<OperatingSystems> ShowOS(int i)
        {

            DataTable dt = dal.GetTheOSById(i);
            var l1 = new List<OperatingSystems>();
            foreach (DataRow item in dt.Rows)
            {
                var os = new OperatingSystems();
                os.theId = Convert.ToInt32(item["Id"].ToString());
                os.TheOperatingSystem = item["Operating System"].ToString();
                l1.Add(os);

            }
            return l1;
        }


        internal List<Quantity> ShowUnits()
        {

            DataTable dt = dal.GetUnits();
            var l1 = new List<Quantity>();
            foreach (DataRow item in dt.Rows)
            {
                var units = new Quantity();
                units.TheQuantity = Convert.ToInt32(item["Quantity"].ToString());
                units.TheRank = Convert.ToInt32(item["Rank"].ToString());
                l1.Add(units);


            }
            return l1;
        }

        internal void InsertBrowserValue(string browser)
        {
            Browsers theBrowser = new Browsers();
            theBrowser.TheBrowser = browser;

            dal.addNewBrowserValue(theBrowser);

        }

        internal void InsertNewOsValue(string os, int id)
        {

            OperatingSystems theOS = new OperatingSystems();
            theOS.TheOperatingSystem = os;
            theOS.PlatformId = id;

            if (theOS.PlatformId != 0)
                dal.addNewOsValue(theOS);
            else
                dal.AddTwoLinesOS(theOS);
        }

        internal void InsertNewProgramValue(string program, int id)
        {
            Programs theProgram = new Programs();
            theProgram.TheProgram = program;
            theProgram.PlatformId = id;

            if (theProgram.PlatformId != 0)
                dal.addNewProgramValue(theProgram);
            else
                dal.AddTwoLinesProgram(theProgram);
        }



        internal void InsertConnectionValue(string connection)
        {
            Connections theConnection = new Connections();
            theConnection.TheText = connection;

            dal.addNewTextConnectionValue(theConnection);

        }

        internal List<Platforms> ShowPlatform()
        {
            DataTable dt = dal.addCmbValues();
            var l1 = new List<Platforms>();
            var platform = new Platforms();
            platform.TheId = 0;
            platform.ThePlatform = "Alle";
            l1.Add(platform);
            foreach (DataRow item in dt.Rows)
            {
                platform = new Platforms();

                platform.TheId = Convert.ToInt32(item["Id"].ToString());
                platform.ThePlatform = item["PlatformName"].ToString();

                l1.Add(platform);
            }

            return l1;

        }


    }
}
