using MyDictionary;
namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             MyDictionary<int,string> myDictionary= new MyDictionary<int,string>();
            myDictionary.Add(1, "home");
            myDictionary.Add(2, "cat");
            foreach (var item in myDictionary)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}