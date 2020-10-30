﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSComplexFunctionsSVC
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSComplexFunctionsSVC.IComplexFunctions")]
    public interface IComplexFunctions
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexFunctions/DoWork", ReplyAction="http://tempuri.org/IComplexFunctions/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexFunctions/DoWork", ReplyAction="http://tempuri.org/IComplexFunctions/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexFunctions/Multiply", ReplyAction="http://tempuri.org/IComplexFunctions/MultiplyResponse")]
        int Multiply(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexFunctions/Multiply", ReplyAction="http://tempuri.org/IComplexFunctions/MultiplyResponse")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexFunctions/Divide", ReplyAction="http://tempuri.org/IComplexFunctions/DivideResponse")]
        int Divide(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexFunctions/Divide", ReplyAction="http://tempuri.org/IComplexFunctions/DivideResponse")]
        System.Threading.Tasks.Task<int> DivideAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IComplexFunctionsChannel : WSComplexFunctionsSVC.IComplexFunctions, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ComplexFunctionsClient : System.ServiceModel.ClientBase<WSComplexFunctionsSVC.IComplexFunctions>, WSComplexFunctionsSVC.IComplexFunctions
    {
        
        public ComplexFunctionsClient()
        {
        }
        
        public ComplexFunctionsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ComplexFunctionsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ComplexFunctionsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ComplexFunctionsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void DoWork()
        {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync()
        {
            return base.Channel.DoWorkAsync();
        }
        
        public int Multiply(int a, int b)
        {
            return base.Channel.Multiply(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int a, int b)
        {
            return base.Channel.MultiplyAsync(a, b);
        }
        
        public int Divide(int a, int b)
        {
            return base.Channel.Divide(a, b);
        }
        
        public System.Threading.Tasks.Task<int> DivideAsync(int a, int b)
        {
            return base.Channel.DivideAsync(a, b);
        }
    }
}
