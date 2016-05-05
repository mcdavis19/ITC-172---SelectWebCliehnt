using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    ShowTrackerServiceRef.ShowTrackerServiceClient ShowTracker = new ShowTrackerServiceRef.ShowTrackerServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillGridView(gvArtists, ShowTracker.GetArtists());
            FillGridView(gvVenues, ShowTracker.GetVenues());
            FillGridView(gvShows, ShowTracker.GetShows());

            LoadArtistsDropDown();
            LoadVenuesDropDown();
        }
    }
    protected void FillGridView(GridView gv, object[] list)
    {
        gv.DataSource = list;
        gv.DataBind();
    }
    protected void LoadVenuesDropDown()
    {
        string[] venues = ShowTracker.GetVenues();
        VenuesDropDown.DataSource = venues;
        VenuesDropDown.DataBind();
        VenuesDropDown.Items.Insert(0, "Pick a Venue");
        VenuesDropDown.Items.Insert(1, "---------");
    }
    protected void LoadArtistsDropDown()
    {
        string[] artists = ShowTracker.GetArtists();
        ArtistsDropDown.DataSource = artists;
        ArtistsDropDown.DataBind();
        ArtistsDropDown.Items.Insert(0, "Pick an Artist");
        ArtistsDropDown.Items.Insert(1, "---------");
    }

    protected void btnGetShowsByArtist_Click(object sender, EventArgs e)
    {
        FillGridView(gvShowsByArtist, ShowTracker.GetShowsByArtist(ArtistsDropDown.SelectedValue));
    }

    protected void btngetshowsbyvenue_click(object sender, EventArgs e)
    {
        FillGridView(gvShowsByVenue, ShowTracker.GetShowsByVenue(VenuesDropDown.SelectedValue));
    }
}