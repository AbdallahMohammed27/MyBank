using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace Bank
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = Repos.LoadEmpoyees();
            var employees = list.Filter(e=>e.Fname.ToLower().StartsWith('a'));
            foreach (var employee in employees) 
            {
                Console.WriteLine(employee);
            }
        }

    }
}
