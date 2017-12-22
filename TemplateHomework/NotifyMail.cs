namespace TemplateHomework
{
    public class NotifyMail : AbstractMail
    {
        public NotifyMail(string title, string reciever,  string body)
            : base(reciever, title, body)
        {
        }        
    }
}