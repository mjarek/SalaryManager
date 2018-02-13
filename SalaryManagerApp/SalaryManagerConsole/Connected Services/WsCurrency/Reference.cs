﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalaryManagerConsole.WsCurrency {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WsCurrency.ICurrencyConverter")]
    public interface ICurrencyConverter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyConverter/GetPolishEuroRate", ReplyAction="http://tempuri.org/ICurrencyConverter/GetPolishEuroRateResponse")]
        double GetPolishEuroRate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyConverter/GetPolishEuroRate", ReplyAction="http://tempuri.org/ICurrencyConverter/GetPolishEuroRateResponse")]
        System.Threading.Tasks.Task<double> GetPolishEuroRateAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyConverter/GetDanishEuroRate", ReplyAction="http://tempuri.org/ICurrencyConverter/GetDanishEuroRateResponse")]
        double GetDanishEuroRate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyConverter/GetDanishEuroRate", ReplyAction="http://tempuri.org/ICurrencyConverter/GetDanishEuroRateResponse")]
        System.Threading.Tasks.Task<double> GetDanishEuroRateAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICurrencyConverterChannel : SalaryManagerConsole.WsCurrency.ICurrencyConverter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CurrencyConverterClient : System.ServiceModel.ClientBase<SalaryManagerConsole.WsCurrency.ICurrencyConverter>, SalaryManagerConsole.WsCurrency.ICurrencyConverter {
        
        public CurrencyConverterClient() {
        }
        
        public CurrencyConverterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CurrencyConverterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CurrencyConverterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CurrencyConverterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double GetPolishEuroRate() {
            return base.Channel.GetPolishEuroRate();
        }
        
        public System.Threading.Tasks.Task<double> GetPolishEuroRateAsync() {
            return base.Channel.GetPolishEuroRateAsync();
        }
        
        public double GetDanishEuroRate() {
            return base.Channel.GetDanishEuroRate();
        }
        
        public System.Threading.Tasks.Task<double> GetDanishEuroRateAsync() {
            return base.Channel.GetDanishEuroRateAsync();
        }
    }
}