using System.Diagnostics.Metrics;

namespace Test
{
    public record Person(string FirstName, string LastName)//record
    {
        public string[] PhoneNumbers { get; init; }//string array
    }
    class A
    {
        public static void Main(String[] args)
        {
            Person person1 = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };
            Console.WriteLine(person1);
          
            Person person2 = person1 with { FirstName = "John" };
            Console.WriteLine(person2);
           
            Console.WriteLine(person1 == person2); // output: False

            person2 = person1 with { PhoneNumbers = new string[1] };
            Console.WriteLine(person2);
           
            Console.WriteLine(person1 == person2); // output: False

            person2 = person1 with { };
            Console.WriteLine(person1 == person2); // output: True
            int? a = null;
            int b = a ?? 6;
            Console.WriteLine(b);
            Console.WriteLine(a);//null
            string str = "Hello";
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = i; j < len; j++)
                {
                    try
                    {


                        Console.Write(str.Substring(i, (j - i) + 1) + ",");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                }
                Console.WriteLine();
            }
        }
    }
}