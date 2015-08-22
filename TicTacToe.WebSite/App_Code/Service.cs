using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
public class Service : IService
{
    private static Dictionary<string, IserviceCallback> clients =
                new Dictionary<string, IserviceCallback>();
    private static object locker = new object();

    private DataClassesDataContext db = new DataClassesDataContext();
    private static bool turn = true;
    private static string[,] boardGame;
    private static int boardSize;
    private static string computerOrplayer;

    public void GetData(string firstName, string lastName)
    {
 //       string res = firstName + " " + lastName + " add to database";
 //       ICallBack channel = OperationContext.Current.GetCallbackChannel<ICallBack>();
 //       channel.Result(res);
    }

    #region database

    /**
     * Add Player to Players teble 
     */
    public Player AddPlayer(string firstName, string lastName)
    {
        Player player = new Player();
        player.First_Name = firstName;
        player.Last_Name = lastName;
        db.Players.InsertOnSubmit(player);
        db.SubmitChanges();
        return player;
    }

    /**
     * return Player by first name and last name
     */
    public Player GetPlayer(string firstName, string lastName)
    {
        var x =
            from p in db.Players
            where p.First_Name.Equals(firstName) && p.Last_Name.Equals(lastName)
            select p;
        try
        {
            return (Player)x.First();
        }
        catch
        {
            return null;
        }
    }

    /**
     * return all players
     */

    public Player[] GetPlayers()
    {
        var x =
            from p in db.Players
            select p;
        return x.ToArray();
    }

    /**
     * return all players played in the this game
     */
    public Player[] GetAllGamePlayer(string gameId)
    {
        var x =
            (from g in db.Games
             where g.Id == Convert.ToInt32(gameId)
             select g).ToArray().SingleOrDefault();
        string firstNameP1 = x.Player1.Substring(0, x.Player1.IndexOf(" "));
        string lastNameP1;
        try
        {
            lastNameP1 = x.Player1.Substring(x.Player1.IndexOf(" "), x.Player1.Length);
        }
        catch
        {
            lastNameP1 = "";
        }

        string firstNameP2 = x.Player2.Substring(0, x.Player2.IndexOf(" "));
        string lastNameP2;
        try
        {
            lastNameP2 = x.Player2.Substring(x.Player2.IndexOf(" "), x.Player2.Length);
        }
        catch
        {
            lastNameP2 = "";
        }
        Player p1 = GetPlayer(firstNameP1, lastNameP1);
        Player p2 = GetPlayer(firstNameP2, lastNameP2);
        List<Player> players = new List<Player>();
        players.Add(p1);
        players.Add(p2);
        return players.ToArray();
    }

    /**
     * return all players played in this championship
     */
    public Player[] GetPlayersByChampionshipId(int champId)
    {
        var x =
            from ptc in db.PlayerToChampionships
            from p in db.Players
            where ptc.Championship_Id == champId && ptc.Player_Id == p.Id
            select p;
        return x.ToArray();
    }

    public void AddAdvisor(Player player, Advisor[] advisors, int gameId)
    {
        foreach (Advisor a in advisors)
        {
            Advisor advisor = new Advisor();
            advisor.First_Name = a.First_Name;
            advisor.Last_Name = a.Last_Name;
            db.Advisors.InsertOnSubmit(advisor);
            db.SubmitChanges();
            
            PlayerToAdvisor p = new PlayerToAdvisor();
            p.Player = player.Id;
            p.Advisor = advisor.Id;
            p.Game = gameId;
            db.PlayerToAdvisors.InsertOnSubmit(p);
            db.SubmitChanges();
        }
    }

    public Championship[] GetChampionships()
    {
        var x =
            from p in db.Championships
            where p.Start_date <= DateTime.Now && p.End_date >= DateTime.Now
            select p;
        return x.ToArray();
    }

    public Championship[] GetChampionshipsByPlayerId(Player player)
    {
        var x =
            from ptc in db.PlayerToChampionships
            from c in db.Championships
            where ptc.Championship_Id == c.Id && ptc.Player_Id == player.Id
            select c;
        return x.ToArray();
    }

    public int AddChampionship(DateTime start, DateTime end, string city)
    {
        Championship champ = new Championship();
        champ.Start_date = start;
        champ.End_date = end;
        champ.City = city;
        db.Championships.InsertOnSubmit(champ);
        db.SubmitChanges();
        return champ.Id;
    }

    public Championship[] GetAllChampionships()
    {
        var x =
            from c in db.Championships
            select c;
        return x.ToArray();
    }

    public string[] GetAllCities()
    {
        var x =
            (from c in db.Championships.Distinct()
            select c.City).Distinct();
        return x.ToArray();
    }

    public CustomChampionship GetNumOfChampionships(string city)
    {
        var x =
            (from c in db.Championships
            where c.City.Equals(city) && DateTime.Now > c.Start_date
            select c).Count();
        return new CustomChampionship { city = city, numOfChamp = x };
    }

    public CustomPlayer GetNumOfGames(string name)
    {
        var x =
            (from g in db.Games
            where g.Player1.Equals(name) || g.Player2.Equals(name)
            select g).Count();
        return new CustomPlayer { name = name, numOfGames = x };
    }

    public CustomAdvisorToPlayer[] GetAdvisorToPlayer(int gameId)
    {
        var x =
            (from g in db.PlayerToAdvisors
            join a in db.Advisors on g.Advisor equals a.Id
            join p in db.Players on g.Player equals p.Id
            where g.Game == gameId
            select new CustomAdvisorToPlayer
            {
                advisorName = a.First_Name + " " + a.Last_Name,
                playerName = p.First_Name + " " + p.Last_Name
            }).ToArray();
        return x;

    }

    public void UpdateChampionship(int id, DateTime start, DateTime end, string city, string imageUrl)
    {
        var x =
            (from c in db.Championships
             where c.Id == id
             select c).SingleOrDefault();
        x.Start_date = start;
        x.End_date = end;
        x.City = city;
        x.Picture = imageUrl;
        db.SubmitChanges();
    }

    public void AddPlayerToChamp(Player player, int champId)
    {
        var x =
            (from p in db.Players
             where p.First_Name.Equals(player.First_Name) && p.Last_Name.Equals(player.Last_Name)
             select p.Id).SingleOrDefault();

        PlayerToChampionship playerToChamp = new PlayerToChampionship();
        int id = Convert.ToInt32(x);
        playerToChamp.Player_Id = id;
        playerToChamp.Championship_Id = champId;
        db.PlayerToChampionships.InsertOnSubmit(playerToChamp);
        db.SubmitChanges();
    }

    public void RemovePlayerToChampionship(Player player, int champId)
    {
        var x =
            (from p in db.PlayerToChampionships
             where p.Player_Id == player.Id && p.Championship_Id == champId
             select p).ToList();
        db.PlayerToChampionships.DeleteAllOnSubmit(x);
        db.SubmitChanges();
    }

    /**
     * return all games
     */
    public Game[] GetGames()
    {
        var x =
            from g in db.Games
            select g;
        return x.ToArray();
    }

    /**
     * return all games for this player
     */
    public Game[] GetPlayerGames(Player player)
    {
        var x =
            from g in db.Games
            where g.Player1.Equals(player.First_Name + " " + player.Last_Name) ||
            g.Player2.Equals(player.First_Name + " " + player.Last_Name)
            select g;
        return x.ToArray();
    }

    /**
     * Add game to database and return gameId
     */
    public int AddGame(int champId, Player player1, Player player2, int boardSize)
    {
        Game game = new Game();
        game.Date = DateTime.Now;
        game.Chapmpionship = champId;
        game.Player1 = player1.First_Name + " " + player1.Last_Name;
        if (player2 == null)
        {
            game.Player2 = "computer ";
        }
        else
        {
            game.Player2 = player2.First_Name + " " + player2.Last_Name;
        }
        game.Board_Size = boardSize;
        db.Games.InsertOnSubmit(game);
        db.SubmitChanges();
        return game.Id;
    }

    public void AddGameToPlayer(int gameId, Player player)
    {
        GameToPlayer gameToPlayer = new GameToPlayer();
        gameToPlayer.PlayerId = player.Id;
        gameToPlayer.GameId = gameId;
        db.GameToPlayers.InsertOnSubmit(gameToPlayer);
        db.SubmitChanges();
    }

    public void AddMove(int gameId, string sign, int row, int col)
    {
        GameMove move = new GameMove();
        move.Game_Id = gameId;
        move.Sign = sign;
        move.row = row;
        move.col = col;
        db.GameMoves.InsertOnSubmit(move);
        db.SubmitChanges();
    }

    public int[] GetRecordGameId()
    {
        var x =
            (from g in db.GameMoves
             select Convert.ToInt32(g.Game_Id)).Distinct().ToArray();
        return x;
    }

    public GameMove[] GetGameMoves(int gameId)
    {
        var x =
            from g in db.GameMoves
            where g.Game_Id == gameId
            select g;
        return x.ToArray();
    }

    #endregion

    #region "Game Logic"
    public void ResetGame()
    {
        initializeGame(boardSize);
    }

    public string NewTurn(int col, int row)
    {
        string res;
        if (turn)
            res = "X";
        else
            res = "O";
        boardGame[row, col] = res;
        return res;
    }

    public void GameInfo(int size, string option)
    {
        boardGame = new string[size, size];
        boardSize = size;
        initializeGame(boardSize);
        if (option.Equals("computer"))
        {
            computerOrplayer = "computer";
        }
        else
        {
            computerOrplayer = "player";
        }
    }

    public bool IfWinner(string sign, int row, int col)
    {
        if (checkRow(sign, row, col))
        {
            changeTurn();
            return true;
        }
        if (checkCol(sign, row, col))
        {
            changeTurn();
            return true;
        }
        if (checkFirstDiagonal(sign, row, col))
        {
            changeTurn();
            return true;
        }
        if (checkSecondDiagonal(sign, row, col))
        {
            changeTurn();
            return true;
        }
        changeTurn();
        return false;
    }

    /**
     * Check current row
     */
    private bool checkRow(string sign, int row, int col)
    {
        for (int j = 0; j < boardSize; j++)
        {
            if (!boardGame[row, j].Equals(sign))
                return false;
        }
        return true;
    }

    /**
     * Check current column
     */
    private bool checkCol(string sign, int row, int col)
    {
        for (int i = 0; i < boardSize; i++) 
        {
            if (!boardGame[i, col].Equals(sign))
                return false;
        }
        return true;
    }

    /**
     * Check Diagonal -> \
     */
    private bool checkFirstDiagonal(string sign, int row, int col)
    {
        for (int i = 0; i < boardSize; i++) 
        {
            if(!boardGame[i,i].Equals(sign))
            {
                return false;
            }
        }
        return true;
    }

    /**
     * Check Diagonal -> /
     */
    private bool checkSecondDiagonal(string sign, int row, int col)
    {
        for (int i = 0 ; i < boardSize; i++)
        {
            if (!boardGame[i, boardSize - 1 - i].Equals(sign))
            {
                return false;
            }
        }
        return true;
    }

    /**
     * check if board is full
     */
    private bool fullBoard()
    {
        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                if (!boardGame[i, j].Equals(""))
                {
                    return false;
                }
            }
        }
        return true;
    }

    /**
     * Change turn 
     */
    private void changeTurn()
    {
        if (turn)
            turn = false;
        else
            turn = true;
    }

    /**
     * initialize game
     */
    void initializeGame(int size)
    {
        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                boardGame[i, j] = "";
            }
        }
        turn = false;
    }


    #endregion 

    public bool RegisterClient(Player player)
    {
        if (player != null)
        {
            try
            {
                IserviceCallback callback = OperationContext.Current.GetCallbackChannel<IserviceCallback>();
                lock (locker)
                {
                    //remove the old client
                    if (clients.Keys.Contains(player.First_Name + player.Last_Name))
                    {
                        return false;
                    }
                      //  clients.Remove(player.First_Name + player.Last_Name);
                    clients.Add(player.First_Name + player.Last_Name, callback);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        return false;
    }

    public void playerConfirmed()
    {
        throw new NotImplementedException();
    }

    public void removeClient()
    {
        IserviceCallback callback = OperationContext.Current.GetCallbackChannel<IserviceCallback>();
        foreach (var item in clients.Where(kvp => kvp.Value == callback))
        {
            clients.Remove(item.Key);
        }
    }

    public void AskPlayerConfirmation(int gameSize, Player player1, Player player2, bool confirmationRequired)
    {
        foreach (KeyValuePair<string, IserviceCallback> kvp in clients)
        {
            if (kvp.Key == player2.First_Name + player2.Last_Name)
            {
                IserviceCallback channel = kvp.Value;
                channel.ConfirmPlayer(gameSize, player1, player2, confirmationRequired);

            }
        }
    }

    public void playerConfirmed(Player player1, Player player2)
    {
        bool isYourTurn = true;
        char sign = 'X';
        foreach (KeyValuePair<string, IserviceCallback> kvp in clients)
        {
            if (kvp.Key == player1.First_Name + player1.Last_Name)
            {
                IserviceCallback channelp1 = kvp.Value;
                channelp1.StartGame(isYourTurn,sign);
                isYourTurn = false;
                sign = 'O';
            }
            else if (kvp.Key == player2.First_Name + player2.Last_Name)
            {
                IserviceCallback channelp2 = kvp.Value;
                channelp2.StartGame(isYourTurn,sign);

            }

        }
    }



    public void UpdatePlayerChampionships(Player player)
    {
        bool flag = false;
        foreach (Championship c in db.Championships)
        {
            foreach (PlayerToChampionship ctp in db.PlayerToChampionships)
            {
                if (c.Id == ctp.Championship_Id)
                {
                    flag = true;
                    break;                    
                }                     
            }
            if (!flag)
            {
                PlayerToChampionship ptc = new PlayerToChampionship();
                ptc.Championship_Id = c.Id;
                ptc.Player_Id = player.Id;
                db.PlayerToChampionships.InsertOnSubmit(ptc);
                db.SubmitChanges();
            }

        }
            
     
    }



    
}
