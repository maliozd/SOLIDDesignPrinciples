namespace OpenClosedPrinciple.WrongCode
{
    //   WRONG EXAMPLE   
    class MailSender
    {
        void SendWithGmail(string to, string subj, string body)
        {
            Console.WriteLine("Sent with Gmail");
        }
        void SendWithSmtp(string to, string subj, string body)
        {
            Console.WriteLine("Sent with SMTP");
        }
        void SendWithMailchimp(string to, string subj, string body)
        {
            Console.WriteLine("Sent with Mailchimp");
        }
    }
}
