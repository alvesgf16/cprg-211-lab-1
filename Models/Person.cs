namespace Lab1.Models;

internal class Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
{
    public int PersonId { get; } = personId;
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    public string FavoriteColour { get; set; } = favoriteColour;
    public int Age { get; } = age;
    public bool IsWorking { get; } = isWorking;
    public string Name => $"{FirstName} {LastName}";
    private int AgeIn10Years => Age + 10;

    public void DisplayPersonInfo() => Console.WriteLine($"{PersonId}: {Name}'s favorite colour is: {FavoriteColour}");

    public void ChangeFavoriteColour() => FavoriteColour = "White";

    public void GetAgeInTenYears() => Console.WriteLine($"{Name}'s Age in 10 years is: {AgeIn10Years}");


    public override string ToString() => $@"PersonId: {PersonId}
FirstName: {FirstName}
LastName: {LastName}
FavoriteColour: {FavoriteColour}
Age: {Age}
IsWorking: {IsWorking}";
}
