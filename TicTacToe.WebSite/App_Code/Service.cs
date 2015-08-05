using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class Service : IService
{
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

    public void AddPlayer(string firstName, string lastName)
    {
        Player player = new Player();
        player.First_Name = firstName;
        player.Last_Name = lastName;
        db.Players.InsertOnSubmit(player);
        db.SubmitChanges();
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
        if(checkFirstDiagonal(sign, row, col))
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

    public Player[] GetPlayers()
    {
        var x =
            from p in db.Players
            select p;
        return x.ToArray();
    }


    public void AddAdvisor(Player player, Advisor[] advisors)
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
            p.Game = 1; // add game id 
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

    public void AddPlayerToChamp(string firstName, string lastName, int champId)
    {
        var x =
            (from p in db.Players
             where p.First_Name.Equals(firstName) && p.Last_Name.Equals(lastName)
             select p.Id).SingleOrDefault();

        PlayerToChampionship playerToChamp = new PlayerToChampionship();
        int id = Convert.ToInt32(x);
        playerToChamp.Player_Id = id;
        playerToChamp.Championship_Id = champId;
        db.PlayerToChampionships.InsertOnSubmit(playerToChamp);
        db.SubmitChanges();
    }

    public void ResetGame()
    {
        initializeGame(boardSize);
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
}
