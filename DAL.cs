using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FortolketOpgave
{
    class DAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        public DataTable GetData(string sql)
        {

            //Remember add System.Configuration in References - when adding the SQL-string in App-config. 
            //AND add using System.Configuration - in DAL-class



            DataTable dt = new DataTable();
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        // Returns platform Id
        public int InsertDataGetId(string sql)
        {
            int modified = 0;
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    modified = (int)cmd.ExecuteScalar();

                }
            }
            return modified;
        }
        public void InsertData(string sql)
        {

            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }

        }


        internal DataTable GetBrowsers()
        {
            string queryString = "SELECT * FROM Browsers";
            return GetData(queryString);

        }

        internal DataTable GetInternet()
        {
            string queryString = "SELECT * FROM Internet";
            return GetData(queryString);

        }

        internal DataTable GetPrograms()
        {
            string queryString = "SELECT * FROM Programs";
            return GetData(queryString);
        }

        internal DataTable GetOS()
        {
            string queryString = "SELECT * FROM TheOS";
            return GetData(queryString);
        }

    
        internal DataTable GetProgramsById(int i)
        {
            string query = "";
            
            if (i == 0)
            {
                query = "select  distinct(ProgramId) AS Id, program from PlatformProgram, Programs";
                query += " where ProgramId in (select (ProgramId) from PlatformProgram";
                query += " group by ProgramId having count(ProgramId) > 1)";
                query += " and PlatformProgram.ProgramId = Programs.Id";
            }
            else            
                query = "SELECT a.id, a.Program FROM Programs a, PlatformProgram b WHERE b.PlatformId = "+ i + " AND a.Id = b.ProgramId";
    
            return GetData(query);
        }

        internal DataTable GetTheOSById(int i)
        {

            string query = "";

            if (i == 0)
            {
                query = "select distinct(OSId) AS Id, [Operating System] FROM PlatformOs, TheOS";
                query += " where OSId in (SELECT (OSId) FROM PlatformOs";
                query += " group by OSId having count(OSId) > 1)";
                query += " and PlatformOs.OSId = TheOS.Id";
            }

            else
            {
                query = "SELECT a.Id, a.[Operating System] FROM TheOS a, PlatformOs b WHERE";
                query += " b.PlatformsId = " + i + " AND a.Id = b.OSId";
            }

            return GetData(query);

        }

        internal DataTable GetUnits()
        {

            string queryString = "SELECT * FROM Units";
            return GetData(queryString);

        }

        internal void addNewBrowserValue(Browsers browser)
        {
            string queryString = "INSERT INTO Browsers (Browser) VALUES ('" + Convert.ToString(browser.TheBrowser) + "')";

            InsertData(queryString);

        }

        internal void addNewOsValue(OperatingSystems os)
        {
            string queryString = "INSERT INTO TheOS ([Operating System]) output INSERTED.ID VALUES ('" + os.TheOperatingSystem + "')";
            int modified = InsertDataGetId(queryString); //we know that modify returns an int value - but not exactly what int. (See InsertDataGetId). The new OsId has now been generated
            queryString = "INSERT INTO PlatformOS (PlatformsId, OsId) VALUES (" + os.PlatformId + " , " + modified + ")";
            InsertData(queryString);
        }

        internal void addNewProgramValue(Programs program)
        {
            string queryString = "INSERT INTO Programs (Program) output INSERTED.ID VALUES ('" + program.TheProgram + "')";
            int modified = InsertDataGetId(queryString);
            queryString = "INSERT INTO PlatformProgram (PlatformId, ProgramId) VALUES (" + program.PlatformId + ", " + modified + ")";
            InsertData(queryString);
        }

        internal void addNewTextConnectionValue(Connections connection)
        {
            string queryString = "INSERT INTO Internet (Text) VALUES ('" + Convert.ToString(connection.TheText) + "')";
            InsertData(queryString);
        }

        internal DataTable addCmbValues()
        {
            string queryString = "SELECT * FROM Platform";
            return GetData(queryString);
        }

        internal void AddTwoLinesOS(OperatingSystems os)
        {
            string queryString = "INSERT INTO TheOS ([Operating System]) output INSERTED.ID VALUES ('" + os.TheOperatingSystem + "')";
            int modified = InsertDataGetId(queryString);

            queryString = "SELECT * FROM Platform";
            DataTable dt = GetData(queryString);
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["Id"].ToString());
                string query = "INSERT INTO PlatformOs (PlatformsId, OsID) VALUES (" + id + ", " + modified + ")";
                InsertData(query);

            }
        }

        internal void AddTwoLinesProgram(Programs program)
        {
            string queryString = "INSERT INTO Programs (Program) output INSERTED.ID VALUES ('" + program.TheProgram + "')";
            int modified = InsertDataGetId(queryString);

            queryString = "SELECT * FROM Platform";
            DataTable dt = GetData(queryString);
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["Id"].ToString());
                string query = "INSERT INTO PlatformProgram (PlatformId, ProgramId) VALUES (" + id + ", " + modified + ")";
                InsertData(query);

            }
        }



    }
}


//foreach (var item in collection)
//{

//}



