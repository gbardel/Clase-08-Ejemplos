using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSMathsMistakes;

namespace CalculateMathFunctionsMist
{
    public partial class CalculateFunctions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculateDiv_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(txtValue7.Text);
            int value2 = int.Parse(txtValue8.Text);

            WSMathsMistakes.ComplexFunctionsClient complexFunctionsClient = new WSMathsMistakes.ComplexFunctionsClient();
            try
            {
                int value = complexFunctionsClient.Divide(value1, value2);
                lblResultDiv.Text = "Resultado: " + value.ToString();
            }
            catch (FaultException<ExceptionFaultContract> ex)
            {
            }


        }
    }
}