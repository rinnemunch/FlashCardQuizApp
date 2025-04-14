string[] questions = {
    "What is 5 + 3?",
    "What is the capital of France?",
    "What color is the sky on a clear day?"
};

string[] answers = {
    "8",
    "Paris",
    "Blue"
};

for (int i = 0; i < questions.Length; i++)
{
    Console.WriteLine(questions[i]);
    string userAnswer = Console.ReadLine() ?? "";

    if (userAnswer.ToLower() == answers[i].ToLower())
    {
        Console.WriteLine("Correct!\n");
    }
    else
    {
        Console.WriteLine($"Wrong. The correct answer is: {answers[i]}\n");
    }
}