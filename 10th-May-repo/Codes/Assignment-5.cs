using System;

class Chatbot
{
    // Respond to greetings like "Hello" or "Hey"
    public void Respond(string greeting)
    {
        if (greeting.Contains("Hello") || greeting.Contains("Hey"))
        {
            Console.WriteLine("Hello! How are you?");
        }
        else
        {
            Console.WriteLine("I didn't recognize the greeting.");
        }
    }

    // Respond to questions with a formal or informal reply
    public void Respond(string question, bool isformal)
    {
        if (isformal)
        {
            Console.WriteLine($"Here's a formal reply to: {question}");
        }
        else
        {
            Console.WriteLine($"Here's an informal reply to: {question}");
        }
    }

    // Respond to numerical queries
    public void Respond(int numerical_query)
    {
        Console.WriteLine($"Your answer to your numerical query is: {numerical_query}");
    }

    public static void Main()
    {
        Chatbot obj1 = new Chatbot();

        // Calls Respond(string) - greeting
        obj1.Respond("Hey, how are you doing?");

        // Calls Respond(string, bool) - question with formality
        obj1.Respond("What is politics?", true);

        // Calls Respond(int) - numerical query
        obj1.Respond(25);
    }
}