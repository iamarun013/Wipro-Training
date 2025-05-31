using System;
using System.Collections.Generic;

namespace QuizApplication
{
    // Question class with text, options, and correct answer
    public class Question
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public int CorrectOptionIndex { get; set; } // zero-based index

        public Question(string text, List<string> options, int correctOptionIndex)
        {
            Text = text;
            Options = options;
            CorrectOptionIndex = correctOptionIndex;
        }

        // Method to display the question and options
        public void Display()
        {
            Console.WriteLine(Text);
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Options[i]}");
            }
        }

        // Method to check if user's answer is correct
        public bool IsCorrect(int userChoice)
        {
            return userChoice - 1 == CorrectOptionIndex;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of questions
            List<Question> questions = new List<Question>
            {
                new Question(
                    "What is the capital of France?",
                    new List<string> { "Berlin", "London", "Paris", "Madrid" },
                    2 // Paris
                ),
                new Question(
                    "Which planet is known as the Red Planet?",
                    new List<string> { "Earth", "Mars", "Jupiter", "Saturn" },
                    1 // Mars
                ),
                new Question(
                    "What is the largest ocean on Earth?",
                    new List<string> { "Atlantic", "Indian", "Arctic", "Pacific" },
                    3 // Pacific
                ),
                new Question(
                    "Who wrote 'Romeo and Juliet'?",
                    new List<string> { "William Shakespeare", "Mark Twain", "Charles Dickens", "Jane Austen" },
                    0 // William Shakespeare
                )
            };

            int score = 0;
            Random rand = new Random();

            Console.WriteLine("Welcome to the Quiz!\n");

            // Shuffle questions
            List<Question> questionsShuffled = new List<Question>(questions);
            for (int i = questionsShuffled.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                var temp = questionsShuffled[i];
                questionsShuffled[i] = questionsShuffled[j];
                questionsShuffled[j] = temp;
            }

            // Ask each question
            foreach (var question in questionsShuffled)
            {
                question.Display();

                int userAnswer = 0;
                while (true)
                {
                    Console.Write("Your answer (enter the option number): ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out userAnswer) && userAnswer >= 1 && userAnswer <= question.Options.Count)
                        break;
                    Console.WriteLine("Invalid input. Please enter a valid option number.");
                }

                if (question.IsCorrect(userAnswer))
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was: {question.Options[question.CorrectOptionIndex]}\n");
                }
            }

            Console.WriteLine($"Quiz finished! Your score: {score}/{questions.Count}");
        }
    }
}