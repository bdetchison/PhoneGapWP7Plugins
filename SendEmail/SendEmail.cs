using System.Runtime.Serialization;
using Microsoft.Phone.Tasks;

namespace WP7CordovaClassLib.Cordova.Commands
{
    public class sendEmailArgs
    {
        [DataMember]
        public string toRecipients;

        [DataMember]
        public string body;

        [DataMember]
        public string subject;
    }
    public class SendEmail : BaseCommand
    {
        public void send(string args)
        {
            sendEmailArgs myargs = JSON.JsonHelper.Deserialize<sendEmailArgs>(args);
            EmailComposeTask emailTask = new EmailComposeTask();
            emailTask.To = myargs.toRecipients;
            emailTask.Subject = myargs.subject;
            emailTask.Body = myargs.body;
            emailTask.Show();
            this.DispatchCommandResult();
        }
    }
}

