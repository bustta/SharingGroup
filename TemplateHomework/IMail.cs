namespace TemplateHomework
{
    public interface IMail
    {
        void MakeMailBody();
        void MakeMailReceiver();
        void MakeMailTitle();
        void Send();
        void SendProcess();
    }
}