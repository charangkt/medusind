<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NEWASP.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 196px;
        }
        #Select1 {
            width: 44px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div aria-autocomplete="none">
            NAME&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="19px" style="margin-left: 1px; margin-top: 41px" Width="232px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BorderColor="Blue" ControlToValidate="TextBox1" ErrorMessage="*NAME" ForeColor="#0066CC"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            FAMILYNAME&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 4px" Width="232px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" BorderColor="#0033CC" ControlToValidate="TextBox2" ErrorMessage="*familyname" ForeColor="#0066CC"></asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox1" ControlToValidate="TextBox2" ErrorMessage="deffer from name" ForeColor="#CC3300"></asp:CompareValidator>
            <br />
            <br />
            <br />
            ADDRESS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server" Height="16px" style="margin-left: 7px" Width="252px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" BorderColor="#0033CC" ControlToValidate="TextBox3" ErrorMessage="*ENTER YOUR VALID ADDRESS" ForeColor="#0066CC"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" BorderColor="Maroon" ControlToValidate="TextBox3" ErrorMessage="*atleast twochar" ForeColor="#CC3300" ValidationExpression="^[A-Za-z] {2}.+$"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            CITY&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 5px" Width="238px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" BorderColor="#0033CC" ControlToValidate="TextBox4" ErrorMessage="*CITY" ForeColor="#0066FF"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" BorderColor="#990000" ControlToValidate="TextBox4" ErrorMessage="*ENTER FULL ADDRESS" ForeColor="#CC3300" ValidationExpression="^[A-Za-z] {2}.+$"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            ZIPCODE&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 10px" Width="243px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" BorderColor="#0033CC" ControlToValidate="TextBox5" ErrorMessage="*ZIPCODE" ForeColor="#0066FF"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" BorderColor="#FF3300" ControlToValidate="TextBox5" ErrorMessage="Valid ZIPCODE" ForeColor="#CC3300" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            PHONE NUMBER&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 21px" Width="248px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" BorderColor="#0033CC" ControlToValidate="TextBox6" ErrorMessage="*CONTACT NUMBER" ForeColor="#0066FF"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" BorderColor="#CC3300" ControlToValidate="TextBox6" ErrorMessage="Valid NUMBER" ForeColor="#CC3300" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
            <br />
            <br />
            EMAIL&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox7" runat="server" Width="248px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" BorderColor="#0033CC" BorderStyle="None" ControlToValidate="TextBox7" ErrorMessage="*ENTER YOUR VALID EMAIL" ForeColor="#0066FF"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" BorderColor="#CC3300" ControlToValidate="TextBox7" ErrorMessage="Valid GMAIL" ForeColor="#CC3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="CLICK" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />
        </div>
    </form>
</body>
</html>
