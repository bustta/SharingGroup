using System;

namespace TemplateHomework
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("========================通知信============================");
            NotifyMail notifyMail = new NotifyMail("通知信", "peterji@gmail.com;", "這是一封通知信");
            notifyMail.SendProcess();

            Console.WriteLine("========================警告信============================");
            ErrorMail errorMail = new ErrorMail("警告信", "peterji@gmail.com;", "這是一封警告信");
            errorMail.SendProcess();

            Console.WriteLine("========================警告信============================");
            ErrorMail errorMail2 = new ErrorMail("警告信", "peterji@gmail.com;", "這是一封警告信2", true);
            errorMail2.SendProcess();
            Console.ReadLine();
        }
    }
}