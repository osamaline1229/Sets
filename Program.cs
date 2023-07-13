using Set;
using System.Net.Sockets;

internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(2);
        set.Add(3);
        set.Add(4);
        set.Add(5);
        set.Add(6);

        foreach (int i in set)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(set.Contains(1));

        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4,6 };
        HashSet<int> set2 = new HashSet<int>() { 9, 3, 4, 10, 11 };

        HashSet<int> set3 = set1.Intersect(set2).ToHashSet();

        Person person1 = new Person(1100, "Osama", "Male");
        Person person2 = new Person(110, "Rahma", "Female");
        Person person3 = new Person(1100, "Nora", "Female");

        Dictionary<long, Person> personMap = new Dictionary<long, Person>();
        //personMap.Add(person1.Id,person1);
        //personMap.Add(person2.Id, person2);
        //personMap.Add(person3.Id, person3);

        personMap[person1.Id] = person1;
        personMap[person2.Id] = person2;
        personMap[person3.Id] = person3;

        person1.gender = "Female";
        personMap[person1.Id] = person2;
        //personMap.TryAdd(person1.Id, person1);
        Person? result = null;
        if(personMap.TryGetValue(1102, out result))
        {
            Console.WriteLine(result);
        }

    }
}