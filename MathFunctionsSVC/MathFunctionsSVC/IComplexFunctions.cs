using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathFunctionsSVC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IComplexFunctions" in both code and config file together.
    [ServiceContract]
    public interface IComplexFunctions
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        int Multiply(int a, int b);

        [OperationContract]
        [FaultContract(typeof(ExceptionFaultContract))]
        int Divide(int a, int b);
    }
}
