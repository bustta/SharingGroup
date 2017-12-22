using System;

namespace TemplateHomework
{
    public abstract class AbstractMail : IMail
    {
        protected string Receiver { get; set; }
        protected string Title { get; set; }
        protected string Body { get; set; }

        public AbstractMail(string reciever, string title, string body)
        {
            this.Receiver = reciever;
            this.Title = title;
            this.Body = body;
        }

        public virtual void MakeMailBody()
        {
            Console.WriteLine("開始寫信 - 內容");
            Console.WriteLine("信件內容:" + this.Body);
        }

        public virtual void MakeMailReceiver()
        {
            Console.WriteLine("收件人:" + Receiver);
        }

        public virtual void MakeMailTitle()
        {
            Console.WriteLine("標題:" + Title);
        }

        public virtual void Send()
        {
            Console.WriteLine("寄信完成");
        }

        public virtual void SendProcess()
        {
            this.MakeMailTitle();
            this.MakeMailReceiver();
            this.MakeMailBody();
        }
    }
}