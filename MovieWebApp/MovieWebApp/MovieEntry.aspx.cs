using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace MovieWebApp
{
    public partial class MovieEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)//Ispostback is inbuilt property.....///this we did so every time on refreshing the page it will not update the table data
            {
                MovieDbConnection movieDbConnection = new MovieDbConnection();
                DataTable dtMovies = movieDbConnection.GetAllMovie();
                gvMovieDetails.DataSource = dtMovies;
                gvMovieDetails.DataBind();
            }


        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            MovieDbConnection movieDbConnection = new MovieDbConnection();
            MovieData movieData = new MovieData();
            movieData.MovieName = txtMovieName.Text;
            movieData.MovieDesc = txtMovieDesc.Text;
            movieData.MovieType = txtMovieType.Text;

            string msg = movieDbConnection.InsertMovie(movieData);
            if (msg != "")
            {
                lblMsg.Text = msg;
                DataTable dtMovies = movieDbConnection.GetAllMovie();
                gvMovieDetails.DataSource = dtMovies;
                gvMovieDetails.DataBind();
            }
            else
                lblMsg.Text = "Failed!";
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtMovieId.Text = "";
            txtMovieName.Text = "";
            txtMovieDesc.Text = "";
            txtMovieType.Text = "";
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            int movieId = Convert.ToInt32(txtMovieId.Text);
            MovieDbConnection movieDbConnection = new MovieDbConnection();
            DataTable dtMovies = movieDbConnection.GetMovieById(movieId);
            if (dtMovies != null && dtMovies.Rows.Count > 0)
            {
                txtMovieName.Text = dtMovies.Rows[0][1].ToString();
                txtMovieDesc.Text = dtMovies.Rows[0][2].ToString();
                txtMovieType.Text = dtMovies.Rows[0][3].ToString();
            }
            else
            {
                lblMsg.Text = "No Data Found";
            }
        }

        protected void txtMovieId_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            MovieDbConnection movieDbConnection = new MovieDbConnection();
            MovieData movieData = new MovieData();
            movieData.Id = Convert.ToInt32(txtMovieId.Text);
            movieData.MovieName = txtMovieName.Text;
            movieData.MovieDesc = txtMovieDesc.Text;
            movieData.MovieType = txtMovieType.Text;
            string msg = movieDbConnection.UpdateMovie(movieData);
            //DataTable dtMovies = movieDbConnection.GetMovieById(movieId);
            if (msg != "")
            {
                lblMsg.Text = msg;
                DataTable dtMovies = movieDbConnection.GetAllMovie();
                gvMovieDetails.DataSource = dtMovies;
                gvMovieDetails.DataBind();
            }
            else
                lblMsg.Text = "Failed!";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int movieId = Convert.ToInt32(txtMovieId.Text);
            MovieDbConnection movieDbConnection = new MovieDbConnection();
            string msg = movieDbConnection.DeleteMovieById(movieId);
            if (msg != "")
            {
                lblMsg.Text = msg;
                DataTable dtMovies = movieDbConnection.GetAllMovie();
                gvMovieDetails.DataSource = dtMovies;
                gvMovieDetails.DataBind();
            }
            else
                lblMsg.Text = "Failed!";

        }
    }
}
