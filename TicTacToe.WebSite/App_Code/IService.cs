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

    [OperationContract]  
    Player AddPlayer(string firstName, string lastName);

    [OperationContract]
    string NewTurn(int col, int row);

    [OperationContract(IsOneWay= true)]
    void SendGameMove(Player p1, Player p2, char sign, int col, int row, int gameId);

    [OperationContract]
    void GameInfo(int size, string option);

    [OperationContract]
    void AddMove(int gameId, string sign, int row, int col);

    [OperationContract]
    int[] GetRecordGameId();

    [OperationContract]
    GameMove[] GetGameMoves(int gameId);

    [OperationContract]
    bool IfWinner(string sign, int row, int col);

    [OperationContract]
    void ResetGame();

    [OperationContract]
    Player GetPlayer(string firstName, string lastName);

    [OperationContract]
    Player[] GetPlayers();

    [OperationContract]
    Player[] GetOnlinePlayers();

    [OperationContract]
    Player[] GetAllGamePlayer(string gameId);

    [OperationContract]
    int GetSizeGame(int gameId);

    [OperationContract]
    Game[] GetGames();

    [OperationContract]
    Game[] GetPlayerGamesQuery(Player player,int delay);

    [OperationContract]
    void AddAdvisor(Player player, Advisor[] advisors, int gameId);

    [OperationContract]
    Championship[] GetChampionships();

    [OperationContract]
    Championship[] GetAllChampionships();

    [OperationContract]
    Championship[] GetAllChampionshipsQuery(int delay);

    [OperationContract]
    Game[] GetGamesQuery(int delay);

    [OperationContract]
    Player[] GetPlayersQuery(int delay);

    [OperationContract]
    Championship[] GetChampionshipsByPlayerId(Player player);

    [OperationContract]
    Player[] GetPlayersByChampionshipId(int champId);

    [OperationContract]
    string[] GetAllCities();

    [OperationContract]
    CustomChampionship GetNumOfChampionships(string city);

    [OperationContract]
    CustomPlayer GetNumOfGames(string name);

    [OperationContract]
    CustomAdvisorToPlayer[] GetAdvisorToPlayer(int gameId);

    [OperationContract]
    int AddChampionship(DateTime start, DateTime end, string city, string imageUrl);

    [OperationContract]
    void UpdateChampionship(int id, DateTime start, DateTime end, string city, string imageUrl);
    
    [OperationContract(IsOneWay=true)]
    void UpdatePlayerChampionships(Player player);

    [OperationContract]
    void AddPlayerToChamp(Player player, int champId);

    [OperationContract]
    void RemovePlayerToChampionship(Player player, int champId);

    [OperationContract]
    int AddGame(int champId, Player player1, Player player2, int boardSize);

    [OperationContract(IsOneWay = true)]
    void AddGameToPlayer(int gameId, Player player);

    [OperationContract(IsOneWay=true)]
    void AskPlayerConfirmation(int gameSize,Player player1, Player player2, bool confirmationRequired,int gameId);

    [OperationContract(IsOneWay= true)]
    void playerConfirmed(Player player1, Player player2);

    [OperationContract(IsOneWay = true)]
    void removeClient();

    [OperationContract]
    void DelayResponse(int delay);


}