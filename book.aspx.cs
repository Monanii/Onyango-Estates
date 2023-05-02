using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Realestates
{
    public partial class book : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReserve_Click(object sender, EventArgs e)
        {
            string propertyName = txtPropertyName.Text;
            string reservedBy = txtReservedBy.Text;

            // Logic for reserving the property
            if (propertyIsAlreadyReserved(propertyName))
            {
                lblMessage.Text = "Sorry, this property is already reserved.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                reserveProperty(propertyName, reservedBy);
                lblMessage.Text = "Property reserved successfully.";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
        }
        private bool propertyIsAlreadyReserved(string propertyName)
        {
            bool isReserved = false;

            return isReserved;
        }

        private void reserveProperty(string propertyName, string reservedBy)
        {
            Console.WriteLine($"Property {propertyName} reserved by {reservedBy}");

        }
    }
}