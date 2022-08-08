using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace MovieWebApp
{
    public class MovieDbConnection
    {

        //1. connectionstring 
        //if / is giving error we can use @ before string quaotation
        //"Data Source=;intial catlog=;Integrated security=true"
        public static string sqlCon = @"Data Source=WKS61642\SQLEXPRESS;Initial Catalog=MyMovieDb;Integrated Security=True";

        public string InsertMovie(MovieData movieData)
        {
            string msg = "";
            //connection establishment
            SqlConnection con = new SqlConnection(sqlCon);

            //passing command to sql
            string qry = "insert into movie values('" + movieData.MovieName + "','" + movieData.MovieDesc + "','" + movieData.MovieType + "')";
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
        public string UpdateMovie(MovieData movieData)
        {
            string msg = "";
            //connection establishment
            SqlConnection con = new SqlConnection(sqlCon);

            //passing command to sql
            string qry = "update movie set MovieName='" + movieData.MovieName + "', MovieDesc='" + movieData.MovieDesc + "', movietype='" + movieData.MovieType + "'where id=" + movieData.Id + "";
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
        public DataTable GetMovieById(int movieId)
        {
            DataTable moviedata = new DataTable();
            //connection establishment
            SqlConnection con = new SqlConnection(sqlCon);

            //passing command to sql
            string qry = "select * from movie where id=" + movieId + "";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            moviedata.Load(reader);
            con.Close();


            return moviedata;
        }
        public DataTable GetAllMovie()
        {
            DataTable moviedata = new DataTable();
            //connection establishment
            SqlConnection con = new SqlConnection(sqlCon);

            //passing command to sql
            string qry = "select * from movie ";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            moviedata.Load(reader);
            con.Close();


            return moviedata;
        }
        public string DeleteMovieById(int movieId)
        {
            string msg = string.Empty;
            //connection establishment
            SqlConnection con = new SqlConnection(sqlCon);

            //passing command to sql
            string qry = "delete from movie where id= " + movieId;
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

    public class MovieData
    {
        public int Id { get; set; }

        public string MovieName { get; set; }
        public string MovieDesc { get; set; }

        public string MovieType { get; set; }
    }
}