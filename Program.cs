using Lab1.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Person ian = new(1, "Ian", "Brooks", "Red", 30, true);
        Person gina = new(2, "Gina", "James", "Green", 18, false);
        Person mike = new(3, "Mike", "Briscoe", "Blue", 45, true);
        Person mary = new(4, "Mary", "Beals", "Yellow", 28, true);

        gina.DisplayPersonInfo();

        Console.WriteLine(mike);

        ian.ChangeFavoriteColour();
        ian.DisplayPersonInfo();

        mary.GetAgeInTenYears();

        Relation sister = new(Relationship.Sister);
        Relation brother = new(Relationship.Brother);
        sister.ShowRelationship(gina, mary);
        brother.ShowRelationship(ian, mike);

        List<Person> people = [ian, gina, mike, mary];
        Console.WriteLine($"Average age is: {people.Select(Ages).Average()}");
        Console.WriteLine($"The youngest person is: {people.OrderBy(Ages).ElementAt(0).FirstName}");
        Console.WriteLine($"The oldest person is: {people.OrderByDescending(Ages).ElementAt(0).FirstName}");
        people.FindAll(WhoseFirstNameStartWithM).ForEach(Console.WriteLine);
        Console.WriteLine(people.Find(WhoseFavoriteColourIsBlue));
    }

    private static int Ages(Person person) => person.Age;
    
    private static bool WhoseFirstNameStartWithM(Person person)
    {
        Range firstLetter = ..1;
        return person.FirstName[firstLetter] == "M";
    }

    private static bool WhoseFavoriteColourIsBlue(Person person) => person.FavoriteColour == "Blue";

}
