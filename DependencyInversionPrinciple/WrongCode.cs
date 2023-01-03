namespace DependencyInversionPrinciple.WrongCode;
class Mailer
{
    public void Send()
    {
        Console.WriteLine("Sent Mail");
    }
}
class SendWelcomeMessage
{
    private Mailer _mailer;

    public SendWelcomeMessage(Mailer mailer)
    {
        _mailer = mailer;
    }
    public void Send()
    {
        _mailer.Send();
    }
}