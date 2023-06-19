using System;
namespace c_sharp_getting_started
{
	public static class QuizApp
	{
		public static void RunQuiz()
		{
            Console.Write("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            SetUpInputStream(entry);

            // Type your code below
            string[] questions = { "Is Guatemala located in South America?", "Is brazil a bigger country than Peru?", "Is Costa Rica surrounded by Panama and Colombia?" };
            bool[] answers = { false, true, false };
            bool[] responses = new bool[questions.Length];
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning, your answers do not match the amount of questions asked!");
            }
            int askingIndex = 0;
            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Console.Write("True of false? ");
                string input = Console.ReadLine();
                bool isBool = Boolean.TryParse(input, out bool inputBool);
                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex++;
            }
            int scoringIndex = 0;
            int score = 0;
            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"Input: {answer} | Answer: {response}");
                if (answer == response)
                {
                    score++;
                }
                scoringIndex++;
            }
            Console.WriteLine($"\nYou got {score} out of {questions.Length} correct!");
        }

        private static void SetUpInputStream(string sample)
        {
            if (sample == null)
            {
                Console.SetIn(new StreamReader("true.txt"));
            }
        }
    }
}

