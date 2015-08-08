using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

/// <summary>
/// Summary description for IserviceCallbacks
/// </summary>
public interface IserviceCallback
{
    [OperationContract(IsOneWay = true)] // void is not enough
    void UpdateClientBoard(int col, int row);

    [OperationContract(IsOneWay = true)]
    void ConfirmPlayer(int gameSize, Player player1, Player player2);

    [OperationContract(IsOneWay = true)]
    void StartGame();

}