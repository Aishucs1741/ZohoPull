<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ZohoPull.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function Switchplaces() {
            // add your custom logic here
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>CLICK THE BUTTON TO GO TO LOGIN PAGE👇</p>
       <asp:LinkButton ID="Submit" runat="server" Text="LOGIN" onclick="SwitchPlaces" />
    </form>
</body>
</html>
