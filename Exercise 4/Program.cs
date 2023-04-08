using MyNamespace;
namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.MyProperty = 1;
            Console.WriteLine(myClass.MyProperty);
            Console.ReadKey();
        }
    }
}