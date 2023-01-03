namespace LiskovSubstitutionPrinciple.CorrectCode
{
    class Rectangle
    {
        public decimal Area(decimal a, decimal b)
        {
            return a * b;
        }
    }
    class Square : Rectangle
    {
    }

    public class LspExample1
    {
        public static void Run()
        {
            var square = new Square();
            //var sq1 = (Rectangle)(new Square());
            Console.WriteLine(square.Area(4, 6));
        }
    }
}