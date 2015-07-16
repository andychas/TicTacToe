using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract(CallbackContract = typeof(ICallBack), SessionMode = SessionMode.Required)]

// Calls from client to Server
public interface IService
{

    [OperationContract(IsOneWay = true)]
    void GetData(int x, int y);
}

// Return Values from Server to Client
public interface ICallBack
{
    [OperationContract(IsOneWay = true)] // void is not enough
    void Result(int res);
}
