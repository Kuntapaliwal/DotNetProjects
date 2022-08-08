using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace TheaterWebApp
{
    public class TheaterDbConnection
    {
        //Data Source = WKS61642\SQLEXPRESS;Initial Catalog = MyTheaterDb; Integrated Security = True
        public static string sqlCon = @"Data Source = WKS61642\SQLEXPRESS;Initial Catalog = MyTheaterDb; Integrated Security = True";

        public string InsertTheater(TheaterData theaterData)
        {
            string msg = "";
            //connection establishment
            SqlConnection con = new SqlConnection(sqlCon);

            //passing command to sql
            string qry = "insert into Theatre values('" + theaterData.TheaterName + "','" + theaterData.TheaterDesc + "','" + theaterData.City + "')";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result != 0)
            {
                msg = "inserted";
            }
            con.Close();


            return msg;
        }
        public string UpdateTheater(TheaterData theaterData)
        {
            string msg = "";
            //connection establishment
            SqlConnection con = new SqlConnection(sqlCon);

            //passing command to sql
            string qry = "update Theatre set TheaterName='" + theaterData.TheaterName + "', TheaterDesc='" + theaterData.TheaterDesc + "', City='" + theaterData.City + "'where id=" + theaterData.Id + "";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result != 0)
            {
                msg = "updated";
            }
            con.Close();


            return msg;
        }
        public DataTable GetTheaterById(int theaterId)
        {
            DataTable theaterdata = new DataTable();
            //connection establishment
            SqlConnection con = new SqlConnection(sqlCon);

            //passing command to sql
            string qry = "select * from Theatre where id=" + theaterId + "";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            theaterdata.Load(reader);
            con.Close();


            return theaterdata;
        }
        public DataTable GetAllTheater()
        {
            DataTable theaterdata = new DataTable();
            //connection establishment
            SqlConnection con = new SqlConnection(sqlCon);

            //passing command to sql
            string qry = "select * from Theatre ";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            theaterdata.Load(reader);
            con.Close();


            return theaterdata;
        }
        public string DeleteTheaterById(int theatreId)
        {
            string msg = string.Empty;
            //connection establishment
            SqlConnection con = new SqlConnection(sqlCon);

            //passing command to sql
            string qry = "delete from Theatre where id= " + theatreId;
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result != 0)
            {
                msg = "Deleted successfully";
            }
            con.Close();


            return msg;
        }

    }

    public class TheaterData
    {
        public int Id { get; set; }

        public string TheaterName { get; set; }
        public string TheaterDesc { get; set; }

        public string City { get; set; }
    }

}
