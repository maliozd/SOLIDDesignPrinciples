namespace SingleResponsibilityPrinciple.CorrectCode
{
    class DbConnection
    {
        void ConnectDb()
        {
            //........
            Console.Write("Database connected.");
        }
        void DisconnectDb()
        {
            //.......
            Console.Write("Database disconnected.");
        }
    }

    //------------------
    class EmployeeService
    {
        public List<string> GetEmployees()
        {
            //.......
            return new()
            {
                "Mehmet Ali",
                "Elif"
            };
        }
    }
}
