namespace Klasse_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Janne", "Johannsen", 179, 79);


            List<Person> list = new List<Person>();
            list.Add(p1);
            list.Add(new Person("Johnny", "Johnson", 175, 88));
            list.Add(new Person("Benny", "Bender", 190, 100));
            list.Add(new Person("Elisa", "Smith", 168, 75));

            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("Sorted by Height: ");
            list.Sort(new PersonSort(PersonCompareEnum.CompHeight));
            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("Sorted by Weight: ");
            list.Sort(new PersonSort(PersonCompareEnum.CompWeight));
            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("Sorted by BMI: ");
            list.Sort(new PersonSort(PersonCompareEnum.CompBMI));
            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadLine();
        }
    }
}
