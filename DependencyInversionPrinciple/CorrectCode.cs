namespace DependencyInversionPrinciple.CorrectCode;

//DIP => Dependency Inversion Principle
//Üst seviye sýnýflar alt seviye sýnýflara baðýmlý olmamalýdýr.
//Somut nesneler yerine Soyut nesneler baðýmlý olmamýz gerekir.

interface IMailer
{
    void Send();
}

class SmtpMailer : IMailer
{
    public void Send()
    {
        Console.WriteLine("Sent SMTP");
    }
}

class SendGridMailer : IMailer
{
    public void Send()
    {
        Console.WriteLine("Sent SendGrid");
    }
}

class SendWelcomeMessage
{
    private IMailer _mailer;

    public SendWelcomeMessage(IMailer mailer)
    {
        _mailer = mailer;
    }

    public void Send()
    {
        _mailer.Send();
    }
}

public class DipExample1
{
    public static void Run()
    {
        var msg = new SendWelcomeMessage(new SmtpMailer());
        msg.Send();

        msg = new SendWelcomeMessage(new SendGridMailer());
        msg.Send();
    }
}