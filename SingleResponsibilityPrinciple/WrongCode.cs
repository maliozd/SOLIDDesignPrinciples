namespace SingleResponsibilityPrinciple.WrongCode
{
    //   WRONG EXAMPLE   
    class DbConnection
    {
        void ConnectDb()
        {
            Console.Write("Database connected.");
        }
        void DisconnectDb()
        {
            Console.Write("Database disconnected.");
        }
        public List<string> GetEmployees()
        {

            return new()
            {
                "Mehmet Ali",
                "Elif"
            };
        }
    }
}
