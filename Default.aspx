<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div><!--Artists-->
        <h2>Artists</h2>
        <asp:GridView ID="gvArtists" runat="server"></asp:GridView>
    </div>

    <div><!--Venues-->
        <h2>Venues</h2>
        <asp:GridView ID="gvVenues" runat="server"></asp:GridView>
    </div>

    <div><!--Shows-->
        <h2>Shows</h2>
        <asp:GridView ID="gvShows" runat="server"></asp:GridView>
    </div>
    
    <br /><!--Shows by Venue-->
    <div id="ShowsByVenue">
        <h2>Shows by Venue</h2>
        <asp:DropDownList ID="VenuesDropDown" runat="server"></asp:DropDownList>
        <asp:gridview id="gvShowsByVenue" runat="server"></asp:gridview>
        <asp:button id="btnGetShowsByVenue" runat="server" text="Get Shows" onclick="btngetshowsbyvenue_click" Width="90px" />
    </div>

    <br /><!--Shows by Artist-->
    <div id="ShowsByArtist">
        <h2>Shows by Artist</h2>
        <asp:DropDownList ID="ArtistsDropDown" runat="server"></asp:DropDownList>
        <asp:GridView ID="gvShowsByArtist" runat="server"></asp:GridView>
        <asp:Button ID="btnGetShowsByArtist" runat="server" Text="Get Shows" OnClick="btnGetShowsByArtist_Click" Width="90px" />
    </div>

    </form>
</body>
</html>
