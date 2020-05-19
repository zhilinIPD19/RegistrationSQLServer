using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationSQLServer
{
    public partial class EditUserInformationById : System.Web.UI.Page
    {

        static int id;
        static BusinessLayer.UserInformation ui;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Int32.Parse(Request.QueryString["Id"]);
            ui = DBLayer.DBUtilites.SelectUserInformationById(id);

            firstNameTextBox.Text = ui.FirstName;
            lastNameTextBox.Text = ui.LastName;
            addressTextBox.Text = ui.Address;
            cityTextBox.Text = ui.City;
            stateOrProvinceTextBox.Text = ui.Province;
            zipCodeTextBox.Text = ui.PostalCode;
            countryTextBox.Text = ui.Country;
        }

        protected void UpdateButton_OnClick(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                ui.FirstName = Server.HtmlEncode(firstNameTextBox.Text);
                ui.LastName = Server.HtmlEncode(lastNameTextBox.Text);
                ui.Address = Server.HtmlEncode(addressTextBox.Text);
                ui.City = Server.HtmlEncode(cityTextBox.Text);
                ui.Province = Server.HtmlEncode(stateOrProvinceTextBox.Text);
                ui.PostalCode = Server.HtmlEncode(zipCodeTextBox.Text);
                ui.Country = Server.HtmlEncode(countryTextBox.Text);

                if (DBLayer.DBUtilites.UpdateUserInformationById(ui.Id,ui) == 1)
                {                 
                    Msg.Text = "Updated successfully!";
                }
                else
                {
                    Msg.Text = "Updated unsuccessfully!";
                }
            }

        }
    }
}