using System;

class FriendsGreeting
{
    static void Main()
    {
        string friend1 = "John";
        string friend2 = "Emily";
        string friend3 = "Mike";

        GreetFriend(friend1);
        GreetFriend(friend2);
        GreetFriend(friend3);
    }

    static void GreetFriend(string friendName)
    {
        Console.WriteLine($"Hi {friendName}, my friend!");
    }
}
