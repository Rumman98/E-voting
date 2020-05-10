<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vote_data.aspx.cs" Inherits="Voting_system.vote_data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 372px">
    <form id="form1" runat="server">
    <div style="height: 374px">
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="60px" OnClick="Button1_Click" Text="Back" Width="123px" BackColor="#FF5050" Font-Size="X-Large" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="297px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="1070px">
            <Columns>
                <asp:BoundField DataField="Awamelegue" HeaderText="Awami league" />
                <asp:BoundField DataField="BNP" HeaderText="BNP" />
                <asp:BoundField DataField="Jamayat" HeaderText="Jamayat islami Party" />
                <asp:BoundField DataField="Jatiyo_party" HeaderText="Jatiyo party" />
                <asp:BoundField DataField="No_Vote" HeaderText="Na Vote" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
