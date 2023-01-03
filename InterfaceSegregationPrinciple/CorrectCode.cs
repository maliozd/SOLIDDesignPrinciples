namespace InterfaceSegregationPrinciple.CorrectCode
{
    //ISP => Interface Segregation Principle
    // Many client-specific interfaces are better than one general-purpose interface.

    interface ICodeable
    {
        string Code();
    }

    interface ITestable
    {
        string Test();
    }

    class Programmer : ICodeable, ITestable
    {
        public string Code()
        {
            return "coding";
        }
        public string Test()
        {
            return "testing in localhost";
        }
    }
    class Tester : ITestable
    {
        public string Test()
        {
            return "testing in test server";
        }
    }
    class ProjectManagement
    {
        public void ProcessCode(ICodeable member)
        {
            Console.WriteLine(member.Code());
        }
    }
    public class IspExample1
    {
        public static void Run()
        {
            var pm = new ProjectManagement();
            pm.ProcessCode(new Programmer());

        }
    }