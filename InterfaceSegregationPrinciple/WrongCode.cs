namespace InterfaceSegregationPrinciple.WrongCode
{


    interface IWorkable
    {
        bool CanCode();
        string Code();
        string Test();
    }

    class Programmer : IWorkable
    {
        public bool CanCode()
        {
            return true;
        }

        public string Code()
        {
            return "coding";
        }

        public string Test()
        {
            return "testing in localhost";
        }
    }

    class Tester : IWorkable
    {
        public bool CanCode()
        {
            return false;
        }

        public string Code()
        {
            throw new Exception("Opps! I can not code");
        }

        public string Test()
        {
            return "testing in test server";
        }
    }

    class ProjectManagement
    {
        public void ProcessCode(IWorkable member)
        {
            if (member.CanCode())
            {
                Console.WriteLine(member.Code());
            }
        }
    }
}