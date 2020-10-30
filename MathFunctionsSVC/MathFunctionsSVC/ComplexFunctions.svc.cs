using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathFunctionsSVC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ComplexFunctions" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ComplexFunctions.svc or ComplexFunctions.svc.cs at the Solution Explorer and start debugging.
    public class ComplexFunctions : IComplexFunctions
    {
     
        public void DoWork()
        {
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        /*public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch
            {
                throw new FaultException("No se puede dividir por cero");
            }
        }*/
        
        //Contrato de falla en WCF
        public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch
            {
                ExceptionFaultContract faultContract = new ExceptionFaultContract();
                faultContract.StatusCode = "OPERACION INVALIDA";
                faultContract.Message = "NO SE PUEDE DIVIDIR POR CERO";
                faultContract.Description = "OCURRIO UN ERROR EN EL SERVICIO";

                throw new FaultException<ExceptionFaultContract>(faultContract);
            }
        }
    }
}
