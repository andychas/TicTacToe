using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract(CallbackContract = typeof(IserviceCallback))]
// Calls from client to Server
public interface IService
{
    [OperationContract]
    bool RegisterClient(Player  player);

    [OperationContract(IsOneWay = true)]
    void GetData(string x, string y);

    [OperationContract]
    
    Player AddPlayer(string firstName, string lastName);

    [OperationContract]
    string NewTurn(int col, int row);

    [OperationContract]
    void GameInfo(int size, string option);

    [OperationContract]
    bool IfWinner(string sign, int row, int col);

    [OperationContract]
    void ResetGame();

    [OperationContract]
    Player GetPlayer(string firstName, string lastName);

    [OperationContract]
    Player[] GetPlayers();

    [OperationContract]
    void AddAdvisor(Player player, Advisor[] advisors);

    [OperationContract]
    Championship[] GetChampionships();

    [OperationContract]
    void AddPlayerToChamp(Player player, int champId);

    [OperationContract(IsOneWay=true)]
    void AskPlayerConfirmation(int gameSize,Player player1, Player player2, bool confirmationRequired);

    [OperationContract(IsOneWay= true)]
    void playerConfirmed(Player player1, Player player2);

    [OperationContract(IsOneWay = true)]
    void removeClient();
    


}