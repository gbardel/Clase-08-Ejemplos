using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculateMathFunctions
{
    public partial class CalculateFunctions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(txtValue1.Text);
            int value2 = int.Parse(txtValue2.Text);

            // Invoco a metodo del web service asmx
            appservicesmathsasmx.BasicFunctions basicFunctions = new appservicesmathsasmx.BasicFunctions();
            int value = basicFunctions.Add(value1,value2);
            lblResultAdd.Text = "Resultado: " + value.ToString();

        }

        protected void btnCalculateSub_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(txtValue3.Text);
            int value2 = int.Parse(txtValue4.Text);

            // Invoco a metodo del web service asmx
            appservicesmathsasmx.BasicFunctions basicFunctions = new appservicesmathsasmx.BasicFunctions();
            int value =basicFunctions.Substract(value1, value2);
            lblResultSub.Text = "Resultado: " + value.ToString();


        }

        protected void btnCalculateMul_Click(object sender, EventArgs e)
        {

            int value1 = int.Parse(txtValue5.Text);
            int value2 = int.Parse(txtValue6.Text);

            WSComplexFunctionsSVC.ComplexFunctionsClient complexFunctionsClient = new WSComplexFunctionsSVC.ComplexFunctionsClient();
            int value=complexFunctionsClient.Multiply(value1,value2);
            lblResultMul.Text = "Resultado: " + value.ToString();


        }

        protected void btnCalculateDiv_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(txtValue7.Text);
            int value2 = int.Parse(txtValue8.Text);

            WSComplexFunctionsSVC.ComplexFunctionsClient complexFunctionsClient = new WSComplexFunctionsSVC.ComplexFunctionsClient();
            int value=complexFunctionsClient.Divide(value1, value2);
            lblResultDiv.Text = "Resultado: " + value.ToString();

        }
    }
}