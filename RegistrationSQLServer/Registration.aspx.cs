using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationSQLServer
{
    public partial class Registration : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs args)
        {
            if (!IsPostBack)
            {
                btnEdit.Visible = false;
            }
        }

        protected void EnterInfoButton_OnClick(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
              BusinessLayer.UserInformation ui = new BusinessLayer.UserInformation();
                ui.FirstName = Server.HtmlEncode(firstNameTextBox.Text);
                ui.LastName = Server.HtmlEncode(lastNameTextBox.Text);
                ui.Address = Server.HtmlEncode(addressTextBox.Text);
                ui.City = Server.HtmlEncode(cityTextBox.Text);
                ui.Province = Server.HtmlEncode(stateOrProvinceTextBox.Text);
                ui.PostalCode = Server.HtmlEncode(zipCodeTextBox.Text);
                ui.Country = Server.HtmlEncode(countryTextBox.Text);
               
                if (DBLayer.DBUtilites.InsertUserInformation(ui) == 1)
                {
                    btnEdit.Visible = true;
                    Msg.Text = "Added successfully!";
                }
                else
                {
                    Msg.Text = "Added unsuccessfully!";
                }               
            }
        }

        protected void BtnEdit_OnClick(object sender, EventArgs e)
        {
            if (Page.IsValid)
            { 
                
                Response.Redirect($"EditUserInformationById.aspx?Id=1");
            }
           
        }
    }
}