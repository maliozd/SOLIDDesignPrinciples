namespace DependencyInversionPrinciple.CorrectCode;

//DIP => Dependency Inversion Principle
//�st seviye s�n�flar alt seviye s�n�flara ba��ml� olmamal�d�r.
//Somut nesneler yerine Soyut nesneler ba��ml� olmam�z gerekir.

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