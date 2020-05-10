<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="startPage.aspx.cs" Inherits="Voting_system.WebForm1" %>

<center> 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 733px">
    <form id="form1" runat="server">
    <div style="height: 700px; font-size: x-large; font-weight: bold; font-style: inherit; font-variant: normal; color: #000000; font-family: 'Century Gothic'; background-color: #FFFFFF;">
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Wellcome To Online Voting System(OVS)<br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="admin" runat="server" BackColor="#FFFF99" Font-Names="Chock A Block NF" Font-Size="XX-Large" Height="300px" Text="Admin" Width="200px" OnClick="admin_Click" BorderColor="Black" BorderStyle="Ridge" BorderWidth="3px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Image ID="Image1" runat="server" Height="294px" ImageUrl="~/logo.png" Width="337px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="voter" runat="server" BackColor="#CCFF99" Font-Names="Chock A Block NF" Font-Size="XX-Large" Height="300px" Text="VOTER" Width="200px" OnClick="voter_Click" BorderColor="Black" BorderStyle="Ridge" BorderWidth="3px" />
    
    </div>
    </form>
</body>
    </center>
</html>
