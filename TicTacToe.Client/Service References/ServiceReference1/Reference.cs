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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Advisor", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Advisor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Championship", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Championship : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> End_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TicTacToe.Client.ServiceReference1.Binary PictureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> Start_dateField;
        
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
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> End_date {
            get {
                return this.End_dateField;
            }
            set {
                if ((this.End_dateField.Equals(value) != true)) {
                    this.End_dateField = value;
                    this.RaisePropertyChanged("End_date");
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
        public TicTacToe.Client.ServiceReference1.Binary Picture {
            get {
                return this.PictureField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureField, value) != true)) {
                    this.PictureField = value;
                    this.RaisePropertyChanged("Picture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Start_date {
            get {
                return this.Start_dateField;
            }
            set {
                if ((this.Start_dateField.Equals(value) != true)) {
                    this.Start_dateField = value;
                    this.RaisePropertyChanged("Start_date");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Binary", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Linq")]
    [System.SerializableAttribute()]
    public partial class Binary : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] BytesField;
        
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
        public byte[] Bytes {
            get {
                return this.BytesField;
            }
            set {
                if ((object.ReferenceEquals(this.BytesField, value) != true)) {
                    this.BytesField = value;
                    this.RaisePropertyChanged("Bytes");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService", CallbackContract=typeof(TicTacToe.Client.ServiceReference1.IServiceCallback))]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RegisterClient", ReplyAction="http://tempuri.org/IService/RegisterClientResponse")]
        bool RegisterClient(TicTacToe.Client.ServiceReference1.Player player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RegisterClient", ReplyAction="http://tempuri.org/IService/RegisterClientResponse")]
        System.Threading.Tasks.Task<bool> RegisterClientAsync(TicTacToe.Client.ServiceReference1.Player player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/GetData")]
        void GetData(string x, string y);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/GetData")]
        System.Threading.Tasks.Task GetDataAsync(string x, string y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddPlayer", ReplyAction="http://tempuri.org/IService/AddPlayerResponse")]
        TicTacToe.Client.ServiceReference1.Player AddPlayer(string firstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddPlayer", ReplyAction="http://tempuri.org/IService/AddPlayerResponse")]
        System.Threading.Tasks.Task<TicTacToe.Client.ServiceReference1.Player> AddPlayerAsync(string firstName, string lastName);
        
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
        TicTacToe.Client.ServiceReference1.Player GetPlayer(string firstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetPlayer", ReplyAction="http://tempuri.org/IService/GetPlayerResponse")]
        System.Threading.Tasks.Task<TicTacToe.Client.ServiceReference1.Player> GetPlayerAsync(string firstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetPlayers", ReplyAction="http://tempuri.org/IService/GetPlayersResponse")]
        TicTacToe.Client.ServiceReference1.Player[] GetPlayers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetPlayers", ReplyAction="http://tempuri.org/IService/GetPlayersResponse")]
        System.Threading.Tasks.Task<TicTacToe.Client.ServiceReference1.Player[]> GetPlayersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddAdvisor", ReplyAction="http://tempuri.org/IService/AddAdvisorResponse")]
        void AddAdvisor(TicTacToe.Client.ServiceReference1.Player player, TicTacToe.Client.ServiceReference1.Advisor[] advisors, int gameId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddAdvisor", ReplyAction="http://tempuri.org/IService/AddAdvisorResponse")]
        System.Threading.Tasks.Task AddAdvisorAsync(TicTacToe.Client.ServiceReference1.Player player, TicTacToe.Client.ServiceReference1.Advisor[] advisors, int gameId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetChampionships", ReplyAction="http://tempuri.org/IService/GetChampionshipsResponse")]
        TicTacToe.Client.ServiceReference1.Championship[] GetChampionships();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetChampionships", ReplyAction="http://tempuri.org/IService/GetChampionshipsResponse")]
        System.Threading.Tasks.Task<TicTacToe.Client.ServiceReference1.Championship[]> GetChampionshipsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetChampionshipsByPlayerId", ReplyAction="http://tempuri.org/IService/GetChampionshipsByPlayerIdResponse")]
        TicTacToe.Client.ServiceReference1.Championship[] GetChampionshipsByPlayerId(TicTacToe.Client.ServiceReference1.Player player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetChampionshipsByPlayerId", ReplyAction="http://tempuri.org/IService/GetChampionshipsByPlayerIdResponse")]
        System.Threading.Tasks.Task<TicTacToe.Client.ServiceReference1.Championship[]> GetChampionshipsByPlayerIdAsync(TicTacToe.Client.ServiceReference1.Player player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddChampionship", ReplyAction="http://tempuri.org/IService/AddChampionshipResponse")]
        int AddChampionship(System.DateTime start, System.DateTime end, string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddChampionship", ReplyAction="http://tempuri.org/IService/AddChampionshipResponse")]
        System.Threading.Tasks.Task<int> AddChampionshipAsync(System.DateTime start, System.DateTime end, string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateChampionship", ReplyAction="http://tempuri.org/IService/UpdateChampionshipResponse")]
        void UpdateChampionship(int id, System.DateTime start, System.DateTime end, string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateChampionship", ReplyAction="http://tempuri.org/IService/UpdateChampionshipResponse")]
        System.Threading.Tasks.Task UpdateChampionshipAsync(int id, System.DateTime start, System.DateTime end, string city);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/UpdatePlayerChampionships")]
        void UpdatePlayerChampionships(TicTacToe.Client.ServiceReference1.Player player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/UpdatePlayerChampionships")]
        System.Threading.Tasks.Task UpdatePlayerChampionshipsAsync(TicTacToe.Client.ServiceReference1.Player player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddPlayerToChamp", ReplyAction="http://tempuri.org/IService/AddPlayerToChampResponse")]
        void AddPlayerToChamp(TicTacToe.Client.ServiceReference1.Player player, int champId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddPlayerToChamp", ReplyAction="http://tempuri.org/IService/AddPlayerToChampResponse")]
        System.Threading.Tasks.Task AddPlayerToChampAsync(TicTacToe.Client.ServiceReference1.Player player, int champId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemovePlayerToChampionship", ReplyAction="http://tempuri.org/IService/RemovePlayerToChampionshipResponse")]
        void RemovePlayerToChampionship(TicTacToe.Client.ServiceReference1.Player player, int champId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemovePlayerToChampionship", ReplyAction="http://tempuri.org/IService/RemovePlayerToChampionshipResponse")]
        System.Threading.Tasks.Task RemovePlayerToChampionshipAsync(TicTacToe.Client.ServiceReference1.Player player, int champId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddGame", ReplyAction="http://tempuri.org/IService/AddGameResponse")]
        int AddGame(int champId, TicTacToe.Client.ServiceReference1.Player player1, TicTacToe.Client.ServiceReference1.Player player2, int boardSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddGame", ReplyAction="http://tempuri.org/IService/AddGameResponse")]
        System.Threading.Tasks.Task<int> AddGameAsync(int champId, TicTacToe.Client.ServiceReference1.Player player1, TicTacToe.Client.ServiceReference1.Player player2, int boardSize);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/AddGameToPlayer")]
        void AddGameToPlayer(int gameId, TicTacToe.Client.ServiceReference1.Player player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/AddGameToPlayer")]
        System.Threading.Tasks.Task AddGameToPlayerAsync(int gameId, TicTacToe.Client.ServiceReference1.Player player);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/AskPlayerConfirmation")]
        void AskPlayerConfirmation(int gameSize, TicTacToe.Client.ServiceReference1.Player player1, TicTacToe.Client.ServiceReference1.Player player2, bool confirmationRequired);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/AskPlayerConfirmation")]
        System.Threading.Tasks.Task AskPlayerConfirmationAsync(int gameSize, TicTacToe.Client.ServiceReference1.Player player1, TicTacToe.Client.ServiceReference1.Player player2, bool confirmationRequired);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/playerConfirmed")]
        void playerConfirmed(TicTacToe.Client.ServiceReference1.Player player1, TicTacToe.Client.ServiceReference1.Player player2);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/playerConfirmed")]
        System.Threading.Tasks.Task playerConfirmedAsync(TicTacToe.Client.ServiceReference1.Player player1, TicTacToe.Client.ServiceReference1.Player player2);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/removeClient")]
        void removeClient();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/removeClient")]
        System.Threading.Tasks.Task removeClientAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/UpdateClientBoard")]
        void UpdateClientBoard(int col, int row);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/ConfirmPlayer")]
        void ConfirmPlayer(int gameSize, TicTacToe.Client.ServiceReference1.Player player1, TicTacToe.Client.ServiceReference1.Player player2, bool confirmationRequired);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/StartGame")]
        void StartGame(bool isYourTurn, char sign);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : TicTacToe.Client.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.DuplexClientBase<TicTacToe.Client.ServiceReference1.IService>, TicTacToe.Client.ServiceReference1.IService {
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public bool RegisterClient(TicTacToe.Client.ServiceReference1.Player player) {
            return base.Channel.RegisterClient(player);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterClientAsync(TicTacToe.Client.ServiceReference1.Player player) {
            return base.Channel.RegisterClientAsync(player);
        }
        
        public void GetData(string x, string y) {
            base.Channel.GetData(x, y);
        }
        
        public System.Threading.Tasks.Task GetDataAsync(string x, string y) {
            return base.Channel.GetDataAsync(x, y);
        }
        
        public TicTacToe.Client.ServiceReference1.Player AddPlayer(string firstName, string lastName) {
            return base.Channel.AddPlayer(firstName, lastName);
        }
        
        public System.Threading.Tasks.Task<TicTacToe.Client.ServiceReference1.Player> AddPlayerAsync(string firstName, string lastName) {
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
        
        public TicTacToe.Client.ServiceReference1.Player GetPlayer(string firstName, string lastName) {
            return base.Channel.GetPlayer(firstName, lastName);
        }
        
        public System.Threading.Tasks.Task<TicTacToe.Client.ServiceReference1.Player> GetPlayerAsync(string firstName, string lastName) {
            return base.Channel.GetPlayerAsync(firstName, lastName);
        }
        
        public TicTacToe.Client.ServiceReference1.Player[] GetPlayers() {
            return base.Channel.GetPlayers();
        }
        
        public System.Threading.Tasks.Task<TicTacToe.Client.ServiceReference1.Player[]> GetPlayersAsync() {
            return base.Channel.GetPlayersAsync();
        }
        
        public void AddAdvisor(TicTacToe.Client.ServiceReference1.Player player, TicTacToe.Client.ServiceReference1.Advisor[] advisors, int gameId) {
            base.Channel.AddAdvisor(player, advisors, gameId);
        }
        
        public System.Threading.Tasks.Task AddAdvisorAsync(TicTacToe.Client.ServiceReference1.Player player, TicTacToe.Client.ServiceReference1.Advisor[] advisors, int gameId) {
            return base.Channel.AddAdvisorAsync(player, advisors, gameId);
        }
        
        public TicTacToe.Client.ServiceReference1.Championship[] GetChampionships() {
            return base.Channel.GetChampionships();
        }
        
        public System.Threading.Tasks.Task<TicTacToe.Client.ServiceReference1.Championship[]> GetChampionshipsAsync() {
            return base.Channel.GetChampionshipsAsync();
        }
        
        public TicTacToe.Client.ServiceReference1.Championship[] GetChampionshipsByPlayerId(TicTacToe.Client.ServiceReference1.Player player) {
            return base.Channel.GetChampionshipsByPlayerId(player);
        }
        
        public System.Threading.Tasks.Task<TicTacToe.Client.ServiceReference1.Championship[]> GetChampionshipsByPlayerIdAsync(TicTacToe.Client.ServiceReference1.Player player) {
            return base.Channel.GetChampionshipsByPlayerIdAsync(player);
        }
        
        public int AddChampionship(System.DateTime start, System.DateTime end, string city) {
            return base.Channel.AddChampionship(start, end, city);
        }
        
        public System.Threading.Tasks.Task<int> AddChampionshipAsync(System.DateTime start, System.DateTime end, string city) {
            return base.Channel.AddChampionshipAsync(start, end, city);
        }
        
        public void UpdateChampionship(int id, System.DateTime start, System.DateTime end, string city) {
            base.Channel.UpdateChampionship(id, start, end, city);
        }
        
        public System.Threading.Tasks.Task UpdateChampionshipAsync(int id, System.DateTime start, System.DateTime end, string city) {
            return base.Channel.UpdateChampionshipAsync(id, start, end, city);
        }
        
        public void UpdatePlayerChampionships(TicTacToe.Client.ServiceReference1.Player player) {
            base.Channel.UpdatePlayerChampionships(player);
        }
        
        public System.Threading.Tasks.Task UpdatePlayerChampionshipsAsync(TicTacToe.Client.ServiceReference1.Player player) {
            return base.Channel.UpdatePlayerChampionshipsAsync(player);
        }
        
        public void AddPlayerToChamp(TicTacToe.Client.ServiceReference1.Player player, int champId) {
            base.Channel.AddPlayerToChamp(player, champId);
        }
        
        public System.Threading.Tasks.Task AddPlayerToChampAsync(TicTacToe.Client.ServiceReference1.Player player, int champId) {
            return base.Channel.AddPlayerToChampAsync(player, champId);
        }
        
        public void RemovePlayerToChampionship(TicTacToe.Client.ServiceReference1.Player player, int champId) {
            base.Channel.RemovePlayerToChampionship(player, champId);
        }
        
        public System.Threading.Tasks.Task RemovePlayerToChampionshipAsync(TicTacToe.Client.ServiceReference1.Player player, int champId) {
            return base.Channel.RemovePlayerToChampionshipAsync(player, champId);
        }
        
        public int AddGame(int champId, TicTacToe.Client.ServiceReference1.Player player1, TicTacToe.Client.ServiceReference1.Player player2, int boardSize) {
            return base.Channel.AddGame(champId, player1, player2, boardSize);
        }
        
        public System.Threading.Tasks.Task<int> AddGameAsync(int champId, TicTacToe.Client.ServiceReference1.Player player1, TicTacToe.Client.ServiceReference1.Player player2, int boardSize) {
            return base.Channel.AddGameAsync(champId, player1, player2, boardSize);
        }
        
        public void AddGameToPlayer(int gameId, TicTacToe.Client.ServiceReference1.Player player) {
            base.Channel.AddGameToPlayer(gameId, player);
        }
        
        public System.Threading.Tasks.Task AddGameToPlayerAsync(int gameId, TicTacToe.Client.ServiceReference1.Player player) {
            return base.Channel.AddGameToPlayerAsync(gameId, player);
        }
        
        public void AskPlayerConfirmation(int gameSize, TicTacToe.Client.ServiceReference1.Player player1, TicTacToe.Client.ServiceReference1.Player player2, bool confirmationRequired) {
            base.Channel.AskPlayerConfirmation(gameSize, player1, player2, confirmationRequired);
        }
        
        public System.Threading.Tasks.Task AskPlayerConfirmationAsync(int gameSize, TicTacToe.Client.ServiceReference1.Player player1, TicTacToe.Client.ServiceReference1.Player player2, bool confirmationRequired) {
            return base.Channel.AskPlayerConfirmationAsync(gameSize, player1, player2, confirmationRequired);
        }
        
        public void playerConfirmed(TicTacToe.Client.ServiceReference1.Player player1, TicTacToe.Client.ServiceReference1.Player player2) {
            base.Channel.playerConfirmed(player1, player2);
        }
        
        public System.Threading.Tasks.Task playerConfirmedAsync(TicTacToe.Client.ServiceReference1.Player player1, TicTacToe.Client.ServiceReference1.Player player2) {
            return base.Channel.playerConfirmedAsync(player1, player2);
        }
        
        public void removeClient() {
            base.Channel.removeClient();
        }
        
        public System.Threading.Tasks.Task removeClientAsync() {
            return base.Channel.removeClientAsync();
        }
    }
}
