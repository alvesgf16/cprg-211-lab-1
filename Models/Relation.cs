namespace Lab1.Models;

internal class Relation(Relationship relationshipType)
{
    private readonly Relationship _relationshipType = relationshipType;

    public void ShowRelationship(Person person1, Person person2) => Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: {_relationshipType}hood");
}
