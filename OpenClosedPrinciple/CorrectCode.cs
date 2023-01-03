namespace OpenClosedPrinciple.CorrectCode
{
    interface IEmailSender
    {
        public void Send(string to, string subj, string body);
        public void SendWithHtmlTemplate(string to, string subj, string body);
    }

    class GmailSender : IEmailSender
    {
        public void Send(string to, string subj, string body)
        {
            Console.WriteLine("Sent with Gmail");
            Console.WriteLine($"To: {to} \t Subject: {subj} \t Message: {body}");
        }

        public void SendWithHtmlTemplate(string to, string subj, string body)
        {
            throw new NotImplementedException();
        }
    }

    class SmtpSender : IEmailSender
    {
        public void Send(string to, string subj, string body)
        {
            Console.WriteLine("Sent with SMTP");
            Console.WriteLine($"To: {to} \t Subject: {subj} \t Message: {body}");
        }

        public void SendWithHtmlTemplate(string to, string subj, string body)
        {
            throw new NotImplementedException();
        }
    }

    class OtherSender : IEmailSender
    {
        public void Send(string to, string subj, string body)
        {
            Console.WriteLine("Sent with Other");
            Console.WriteLine($"To: {to} \t Subject: {subj} \t Message: {body}");
        }

        public void SendWithHtmlTemplate(string to, string subj, string body)
        {
            throw new NotImplementedException();
        }
    }

    class MailChimpSender : IEmailSender
    {
        public void Send(string to, string subj, string body)
        {
            Console.WriteLine("Sent with Mailchimp");
            Console.WriteLine($"To: {to} \t Subject: {subj} \t Message: {body}");
        }

        public void SendWithHtmlTemplate(string to, string subj, string body)
        {
            throw new NotImplementedException();
        }
    }

    class OcpEmailSender : IEmailSender
    {
        private readonly IEmailSender _emailSender;

        public OcpEmailSender(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void Send(string to, string subj, string body)
        {
            _emailSender.Send(to, subj, body);
        }

        public void SendWithHtmlTemplate(string to, string subj, string body)
        {
            throw new NotImplementedException();
        }
    }

    class OcpExample1
    {
        public static void Run()
        {
            var emailSender1 = new OcpEmailSender(new GmailSender());
            emailSender1.Send("...@gmail.com", "Test", "Merhaba");

            var emailSender2 = new OcpEmailSender(new OtherSender());
            emailSender2.Send("...@gmail.com", "Test", "Merhaba");
        }
    }
}
