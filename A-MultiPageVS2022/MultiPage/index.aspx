<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MultiPage.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 256px;
            height: 192px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to my Web Application</h1>
            <p>
                <img alt="Chiarelli" class="auto-style1" src="images/chiarelli.jpg" />&nbsp;&nbsp;&nbsp;
                <asp:Label ID="LblWelcome" runat="server"></asp:Label>
            </p>
           
            <br />
            Click here to go to <a href="Page2.aspx">Page 2</a><br />
            <br />
            <br />
            <a href="Page2.aspx">Please click here to go to Page 2</a><br />

        </div>
    </form>
</body>
</html>
