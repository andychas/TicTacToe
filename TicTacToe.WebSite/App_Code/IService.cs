using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

//[ServiceContract(/*CallbackContract = typeof(ICallBack),*/ SessionMode = SessionMode.Required)]
//[ServiceContract(CallbackContract = typeof(ICallBack), SessionMode = SessionMode.Required)]
[ServiceContract]

// Calls from client to Server
public interface IService
{

    [OperationContract(IsOneWay = true)]
    void GetData(string x, string y);

    [OperationContract]
    void AddPlayer(string firstName, string lastName);

    [OperationContract]
    string NewTurn(int col, int row);

    [OperationContract]
    void GameInfo(int size, string option);

    [OperationContract]
    bool IfWinner(string sign, int row, int col);

    [OperationContract]
    void ResetGame();

    [OperationContract]
    IEnumerable<Tuple<int, string, string>> GetPlayer(string firstName, string lastName);

}

// Return Values from Server to Client

/*public interface ICallBack
{
    [OperationContract(IsOneWay = true)] // void is not enough
    void Result(int col, int row, string res);

}*/