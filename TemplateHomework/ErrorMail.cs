using System;

namespace TemplateHomework
{
    public class ErrorMail : AbstractMail
    {
        private bool _noticeSupervisor;

        public ErrorMail(string title, string reciever, string body, bool noticeSupervisor = false)
            : base(reciever, title, body)
        {
            _noticeSupervisor = noticeSupervisor;
        }

        private void AddReceiverSupervisor()
        {
            this.Receiver += "xxx@gmail.com;";
            Console.WriteLine("收件人:" + this.Receiver);
        }

        public override void SendProcess()
        {
            this.MakeMailTitle();
            this.MakeMailReceiver();
            if (this._noticeSupervisor)
            {
                this.AddReceiverSupervisor();
            }

            this.MakeMailBody();
        }
    }
}