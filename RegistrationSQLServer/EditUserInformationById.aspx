<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditUserInformationById.aspx.cs" Inherits="RegistrationSQLServer.EditUserInformationById" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                <h3>User Edit</h3>
    <asp:Label ID="Msg" ForeColor="maroon" runat="server" /><br />
    <asp:Panel ID="enterUserInfoPanel" runat="server">
        <table border="0">
            <tr>
                <td>First name:</td>
                <td>
                    <asp:TextBox ID="firstNameTextBox" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" ControlToValidate="firstNameTextBox" ForeColor="red" runat="server" ErrorMessage="Please enter your first name!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Last name:</td>
                <td>
                    <asp:TextBox ID="lastNameTextBox" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" ControlToValidate="lastNameTextBox" ForeColor="red" runat="server" ErrorMessage="Please enter your last name!"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>Address:</td>
                <td>
                    <asp:TextBox ID="addressTextBox" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddressTextBox" ControlToValidate="addressTextBox" ForeColor="red" runat="server" ErrorMessage="Please enter your address!"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>City:</td>
                <td>
                    <asp:TextBox ID="cityTextBox" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCityTextBox" ControlToValidate="cityTextBox" ForeColor="red" runat="server" ErrorMessage="Please enter your city name!"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>State or Province:</td>
                <td>
                    <asp:TextBox ID="stateOrProvinceTextBox" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorStateOrProvinceTextBox" ControlToValidate="stateOrProvinceTextBox" ForeColor="red" runat="server" ErrorMessage="Please enter your state province!"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>Zip Code/Postal Code:</td>
                <td>
                    <asp:TextBox ID="zipCodeTextBox" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorZipCodeTextBox" ControlToValidate="zipCodeTextBox" ForeColor="red" runat="server" ErrorMessage="Please enter your zip code!"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>Country:</td>
                <td>
                    <asp:TextBox ID="countryTextBox" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCountryTextBox" ControlToValidate="countryTextBox" ForeColor="red" runat="server" ErrorMessage="Please enter your country filed!"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="updateButton" runat="server" Text="Enter user information" OnClick="UpdateButton_OnClick" />
                    <asp:HyperLink ID="HyperLink1" NavigateUrl="Registration.aspx" runat="server" >Add new Account</asp:HyperLink>

                </td>
            </tr>
        </table>
    </asp:Panel>
    </form>
</body>
</html>
