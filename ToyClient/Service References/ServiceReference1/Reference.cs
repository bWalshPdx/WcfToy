﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToyClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICalcutron")]
    public interface ICalcutron {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcutron/GetRandomValue", ReplyAction="http://tempuri.org/ICalcutron/GetRandomValueResponse")]
        int GetRandomValue(int seedValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcutron/GetRandomValue", ReplyAction="http://tempuri.org/ICalcutron/GetRandomValueResponse")]
        System.Threading.Tasks.Task<int> GetRandomValueAsync(int seedValue);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcutronChannel : ToyClient.ServiceReference1.ICalcutron, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcutronClient : System.ServiceModel.ClientBase<ToyClient.ServiceReference1.ICalcutron>, ToyClient.ServiceReference1.ICalcutron {
        
        public CalcutronClient() {
        }
        
        public CalcutronClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcutronClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcutronClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcutronClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetRandomValue(int seedValue) {
            return base.Channel.GetRandomValue(seedValue);
        }
        
        public System.Threading.Tasks.Task<int> GetRandomValueAsync(int seedValue) {
            return base.Channel.GetRandomValueAsync(seedValue);
        }
    }
}
