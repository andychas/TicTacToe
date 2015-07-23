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
    public void GetData(string firstName, string lastName)
    {
        string res = firstName + " " + lastName + " add to database";
        ICallBack channel = OperationContext.Current.GetCallbackChannel<ICallBack>();
        channel.Result(res);
    }

    public void AddPlayer(string firstName, string lastName)
    {
        Player player = new Player();
        player.First_Name = firstName;
        player.Last_Name = lastName;
        db.Players.InsertOnSubmit(player);
        db.SubmitChanges();
    }

}
