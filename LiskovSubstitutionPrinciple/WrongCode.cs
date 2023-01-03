namespace LiskovSubstitutionPrinciple;

// Bir program içerisinde Square, Rectangle'in alt tipi ise;
// Rectangle tipindeki objeler Square tipindeki objeler ile özellikleri değiştirilmeden yer değiştirilebilir olmalıdır.
/* Simply put, the Liskov Substitution Principle (LSP) states that objects of a superclass should be replaceable with objects of its subclasses without breaking the application. In other words, what we want is to have the objects of our subclasses behaving the same way as the objects of our superclass.
 * */
class Rectangle
{
    public decimal Area(decimal a, decimal b)
    {
        return a * b;
    }
}
class Square
{
    public decimal Area(decimal a)
    {
        return a * a;
    }
}
class LSPExampleWrong
{
    public static void Run()
    {
        //Rectangle ex1 = new Square();
        //ex1.Area();
    }
}