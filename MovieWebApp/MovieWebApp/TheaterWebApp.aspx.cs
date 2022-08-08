using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace MovieWebApp
{
    public partial class TheaterWebApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//Ispostback is inbuilt property
            {
                TheaterDbConnection movieDbConnection = new TheaterDbConnection();
                DataTable dtTheater = movieDbConnection.GetAllTheater();
                gvTheaterDetails.DataSource = dtTheater;
                gvTheaterDetails.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            TheaterDbConnection theaterDbConnection = new TheaterDbConnection();
            TheaterData movieData = new TheaterData();
            movieData.TheaterName = txtTheaterName.Text;
            movieData.TheaterDesc = txtTheaterDesc.Text;
            movieData.City = txtTheaterCity.Text;

            string msg = theaterDbConnection.InsertTheater(movieData);
            if (msg != "")
            {
                lblMsg.Text = msg;
                DataTable dtTheater = theaterDbConnection.GetAllTheater();
                gvTheaterDetails.DataSource = dtTheater;
                gvTheaterDetails.DataBind();
            }
            else
                lblMsg.Text = "Failed!";
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            int movieId = Convert.ToInt32(txtTheaterId.Text);
            TheaterDbConnection movieDbConnection = new TheaterDbConnection();
            DataTable dtTheater = movieDbConnection.GetTheaterById(movieId);
            if (dtTheater != null && dtTheater.Rows.Count > 0)
            {
                txtTheaterName.Text = dtTheater.Rows[0][1].ToString();
                txtTheaterDesc.Text = dtTheater.Rows[0][2].ToString();
                txtTheaterCity.Text = dtTheater.Rows[0][3].ToString();
            }
            else
            {
                lblMsg.Text = "No Data Found";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            TheaterDbConnection movieDbConnection = new TheaterDbConnection();
            TheaterData TheaterData = new TheaterData();
            TheaterData.Id = Convert.ToInt32(txtTheaterId.Text);
            TheaterData.TheaterName = txtTheaterName.Text;
            TheaterData.TheaterDesc = txtTheaterDesc.Text;
            TheaterData.City = txtTheaterCity.Text;
            string msg = movieDbConnection.UpdateTheater(TheaterData);

            if (msg != "")
            {
                lblMsg.Text = msg;
                DataTable dtMovies = movieDbConnection.GetAllTheater();
                gvTheaterDetails.DataSource = dtMovies;
                gvTheaterDetails.DataBind();
            }
            else
                lblMsg.Text = "Failed!";

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int TheaterId = Convert.ToInt32(txtTheaterId.Text);
            TheaterDbConnection movieDbConnection = new TheaterDbConnection();
            string msg = movieDbConnection.DeleteTheaterById(TheaterId);
            if (msg != "")
            {
                lblMsg.Text = msg;
                DataTable dtMovies = movieDbConnection.GetAllTheater();
                gvTheaterDetails.DataSource = dtMovies;
                gvTheaterDetails.DataBind();
            }
            else
                lblMsg.Text = "Failed!";
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtTheaterId.Text = "";
            txtTheaterName.Text = "";
            txtTheaterDesc.Text = "";
            txtTheaterCity.Text = "";

        }

        protected void txtMovieId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}