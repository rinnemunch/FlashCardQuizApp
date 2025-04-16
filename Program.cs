using System;
using System.Collections.Generic;

string[] questions = {
    "What is 5 + 3?",
    "What is the capital of France?",
    "What color is the sky on a clear day?",
    "What planet do we live on?",
    "What is the opposite of cold?"
};

string[] answers = {
    "8",
    "Paris",
    "Blue",
    "Earth",
    "Hot"
};

var flashcards = new List<KeyValuePair<string, string>>();
for (int i = 0; i < questions.Length; i++)
{
    flashcards.Add(new KeyValuePair<string, string>(questions[i], answers[i]));
}

// Shuffle the flashcards
Random rand = new Random();
for (int i = flashcards.Count - 1; i > 0; i--)
{
    int j = rand.Next(i + 1);
    var temp = flashcards[i];
    flashcards[i] = flashcards[j];
    flashcards[j] = temp;
}

// Quiz logic
Console.WriteLine("=== Flashcard Quiz ===\n");
int score = 0;

for (int i = 0; i < flashcards.Count; i++)
{
    Console.WriteLine($"Q{i + 1}: {flashcards[i].Key}");
    Console.Write("Your answer: ");
    string userAnswer = Console.ReadLine() ?? "";

    if (userAnswer.ToLower() == flashcards[i].Value.ToLower())
    {
        Console.WriteLine("✅ Correct!\n");
        score++;
    }
    else
    {
        Console.WriteLine($"❌ Wrong. Correct answer: {flashcards[i].Value}\n");
    }
}

Console.WriteLine("=== Quiz Complete ===");
Console.WriteLine($"Score: {score} / {flashcards.Count}");
