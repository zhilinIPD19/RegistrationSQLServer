﻿using System;
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
                if (Session["address"] == null)
                {
                    enterUserInfoPanel.Visible = true;
                    userInfoPanel.Visible = false;
                }
                else
                {
                    enterUserInfoPanel.Visible = false;
                    userInfoPanel.Visible = true;

                    SetLabels();
                }
            }
        }

        protected void SetLabels()
        {
            firstNameLabel.Text = Session["firstName"].ToString();
            lastNameLabel.Text = Session["lastName"].ToString();
            addressLabel.Text = Session["address"].ToString();
            cityLabel.Text = Session["city"].ToString();
            stateOrProvinceLabel.Text = Session["stateOrProvince"].ToString();
            zipCodeLabel.Text = Session["zipCode"].ToString();
            countryLabel.Text = Session["country"].ToString();
        }

        protected void EnterInfoButton_OnClick(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Session["firstName"] = Server.HtmlEncode(firstNameTextBox.Text);
                Session["lastName"] = Server.HtmlEncode(lastNameTextBox.Text);
                Session["address"] = Server.HtmlEncode(addressTextBox.Text);
                Session["city"] = Server.HtmlEncode(cityTextBox.Text);
                Session["stateOrProvince"] = Server.HtmlEncode(stateOrProvinceTextBox.Text);
                Session["zipCode"] = Server.HtmlEncode(zipCodeTextBox.Text);
                Session["country"] = Server.HtmlEncode(countryTextBox.Text);


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
                    enterUserInfoPanel.Visible = false;
                    userInfoPanel.Visible = true;

                    SetLabels();
                }
                else
                {

                }

                
            }
        }

        protected void ChangeInfoButton_OnClick(object sender, EventArgs args)
        {
            enterUserInfoPanel.Visible = true;
            userInfoPanel.Visible = true;
        }
    }
}