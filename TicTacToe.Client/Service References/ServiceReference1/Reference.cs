﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicTacToe.Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/GetData")]
        void GetData(string x, string y);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/GetData")]
        System.Threading.Tasks.Task GetDataAsync(string x, string y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddPlayer", ReplyAction="http://tempuri.org/IService/AddPlayerResponse")]
        void AddPlayer(string firstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddPlayer", ReplyAction="http://tempuri.org/IService/AddPlayerResponse")]
        System.Threading.Tasks.Task AddPlayerAsync(string firstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/NewTurn", ReplyAction="http://tempuri.org/IService/NewTurnResponse")]
        string NewTurn(int col, int row);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/NewTurn", ReplyAction="http://tempuri.org/IService/NewTurnResponse")]
        System.Threading.Tasks.Task<string> NewTurnAsync(int col, int row);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SizeGame", ReplyAction="http://tempuri.org/IService/SizeGameResponse")]
        void SizeGame(int size);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SizeGame", ReplyAction="http://tempuri.org/IService/SizeGameResponse")]
        System.Threading.Tasks.Task SizeGameAsync(int size);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IfWinner", ReplyAction="http://tempuri.org/IService/IfWinnerResponse")]
        bool IfWinner(string sign, int row, int col);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IfWinner", ReplyAction="http://tempuri.org/IService/IfWinnerResponse")]
        System.Threading.Tasks.Task<bool> IfWinnerAsync(string sign, int row, int col);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : TicTacToe.Client.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<TicTacToe.Client.ServiceReference1.IService>, TicTacToe.Client.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void GetData(string x, string y) {
            base.Channel.GetData(x, y);
        }
        
        public System.Threading.Tasks.Task GetDataAsync(string x, string y) {
            return base.Channel.GetDataAsync(x, y);
        }
        
        public void AddPlayer(string firstName, string lastName) {
            base.Channel.AddPlayer(firstName, lastName);
        }
        
        public System.Threading.Tasks.Task AddPlayerAsync(string firstName, string lastName) {
            return base.Channel.AddPlayerAsync(firstName, lastName);
        }
        
        public string NewTurn(int col, int row) {
            return base.Channel.NewTurn(col, row);
        }
        
        public System.Threading.Tasks.Task<string> NewTurnAsync(int col, int row) {
            return base.Channel.NewTurnAsync(col, row);
        }
        
        public void SizeGame(int size) {
            base.Channel.SizeGame(size);
        }
        
        public System.Threading.Tasks.Task SizeGameAsync(int size) {
            return base.Channel.SizeGameAsync(size);
        }
        
        public bool IfWinner(string sign, int row, int col) {
            return base.Channel.IfWinner(sign, row, col);
        }
        
        public System.Threading.Tasks.Task<bool> IfWinnerAsync(string sign, int row, int col) {
            return base.Channel.IfWinnerAsync(sign, row, col);
        }
    }
}
