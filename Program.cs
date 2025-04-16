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

Console.WriteLine("=== Flashcard Quiz ===\n");

int score = 0;

for (int i = 0; i < questions.Length; i++)
{
    Console.WriteLine($"Q{i + 1}: {questions[i]}");
    Console.Write("Your answer: ");
    string userAnswer = Console.ReadLine() ?? "";

    if (userAnswer.ToLower() == answers[i].ToLower())
    {
        Console.WriteLine("✅ Correct!\n");
        score++;
    }
    else
    {
        Console.WriteLine($"❌ Wrong. Correct answer: {answers[i]}\n");
    }
}

Console.WriteLine("=== Quiz Complete ===");
Console.WriteLine($"Score: {score} / {questions.Length}");

