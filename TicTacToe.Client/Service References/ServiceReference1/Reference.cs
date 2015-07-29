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
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string First_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Last_NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string First_Name {
            get {
                return this.First_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.First_NameField, value) != true)) {
                    this.First_NameField = value;
                    this.RaisePropertyChanged("First_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Last_Name {
            get {
                return this.Last_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Last_NameField, value) != true)) {
                    this.Last_NameField = value;
                    this.RaisePropertyChanged("Last_Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GameInfo", ReplyAction="http://tempuri.org/IService/GameInfoResponse")]
        void GameInfo(int size, string option);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GameInfo", ReplyAction="http://tempuri.org/IService/GameInfoResponse")]
        System.Threading.Tasks.Task GameInfoAsync(int size, string option);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IfWinner", ReplyAction="http://tempuri.org/IService/IfWinnerResponse")]
        bool IfWinner(string sign, int row, int col);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IfWinner", ReplyAction="http://tempuri.org/IService/IfWinnerResponse")]
        System.Threading.Tasks.Task<bool> IfWinnerAsync(string sign, int row, int col);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ResetGame", ReplyAction="http://tempuri.org/IService/ResetGameResponse")]
        void ResetGame();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ResetGame", ReplyAction="http://tempuri.org/IService/ResetGameResponse")]
        System.Threading.Tasks.Task ResetGameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetPlayer", ReplyAction="http://tempuri.org/IService/GetPlayerResponse")]
        TicTacToe.Client.ServiceReference1.Player GetPlayer(string FirstName, string LastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetPlayer", ReplyAction="http://tempuri.org/IService/GetPlayerResponse")]
        System.Threading.Tasks.Task<TicTacToe.Client.ServiceReference1.Player> GetPlayerAsync(string FirstName, string LastName);
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
        
        public void GameInfo(int size, string option) {
            base.Channel.GameInfo(size, option);
        }
        
        public System.Threading.Tasks.Task GameInfoAsync(int size, string option) {
            return base.Channel.GameInfoAsync(size, option);
        }
        
        public bool IfWinner(string sign, int row, int col) {
            return base.Channel.IfWinner(sign, row, col);
        }
        
        public System.Threading.Tasks.Task<bool> IfWinnerAsync(string sign, int row, int col) {
            return base.Channel.IfWinnerAsync(sign, row, col);
        }
        
        public void ResetGame() {
            base.Channel.ResetGame();
        }
        
        public System.Threading.Tasks.Task ResetGameAsync() {
            return base.Channel.ResetGameAsync();
        }
        
        public TicTacToe.Client.ServiceReference1.Player GetPlayer(string FirstName, string LastName) {
            return base.Channel.GetPlayer(FirstName, LastName);
        }
        
        public System.Threading.Tasks.Task<TicTacToe.Client.ServiceReference1.Player> GetPlayerAsync(string FirstName, string LastName) {
            return base.Channel.GetPlayerAsync(FirstName, LastName);
        }
    }
}
