using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace MyClient
{
    public partial class _Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            // sets dropdown list empty
            DropDownListSOAP.Items.Clear();
            
            loadDropDownSOAP();

        }

        private void loadDropDownSOAP()
        {
            // XML-SOAP CALL TO WCF SERVICE
            WCFReference.ServiceClient oWebservice = new WCFReference.ServiceClient();
            WCFReference.cTourList oTourList = oWebservice.GetTourListXML();

            foreach (WCFReference.cTour oTour in oTourList)
            {
                DropDownListSOAP.Items.Add(new ListItem(oTour.description, Convert.ToString(oTour.ID)));
            }
        }

    }
}
