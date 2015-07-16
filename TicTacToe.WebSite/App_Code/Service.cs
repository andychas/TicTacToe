using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class Service : IService
{
    public void GetData(int x, int y)
    {
        int res = x + y;
        ICallBack channel = OperationContext.Current.GetCallbackChannel<ICallBack>();
        channel.Result(res);

    }
}
