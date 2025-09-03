namespace QuizApp;

internal class Quiz
{

    private Question[] questions;

    public Quiz(Question[] questions)
    {
        this.questions = questions;
    }

    public void RunQuiz()
    {
        int questionNumber = 1;
        int score = 0;
        Console.WriteLine("Welcome to the Quiz!");

        foreach (Question question in questions)
        {
            Console.WriteLine($"Question {questionNumber}:");
            DisplayQuestion(question);
            questionNumber++;

            int userChoice = getUserChoice();
            score += userChoice == question.CorrectAnswerIndex ? 1 : 0;

            if (userChoice == question.CorrectAnswerIndex)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong! The correct answer is " + question.Answers[question.CorrectAnswerIndex]);
                Console.ResetColor();
            }
        }

        Console.WriteLine($"Your score is {score} out of {questions.Length}");
    }

    private void DisplayQuestion(Question question)
    {
        Console.WriteLine(question.QuestionText);

        for (int i = 0; i < question.Answers.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{i + 1}. ");
            Console.ResetColor();
            Console.WriteLine($"{question.Answers[i]}");
        }


    }

    private int getUserChoice()
    {
        Console.Write("Enter your choice: ");
        string input = Console.ReadLine();
        int choice = 0;

        while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
        {
            Console.Write("Invalid input. Please enter a valid number (between 1 and 4): ");
            input = Console.ReadLine();
        }

        return choice - 1;
    }
}
