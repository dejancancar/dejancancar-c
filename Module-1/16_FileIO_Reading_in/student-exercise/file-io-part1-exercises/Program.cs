using System;
using System.Collections.Generic;
using System.IO;

namespace file_io_part1_exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            // File Path name ..\..\..\..\sample-quiz-file.txt

            //create a class that can hold quiz questions, the available answers and correct answers

            //try holding each quiz questions in a list of quiz questions


            //program asks user a question

            //user gets multiple choice and is allowed to specify the correct answer

            //program reads the input file during start up

            // questions and answers pipe-delimited | and the correct answer is marked with * in file
            Console.WriteLine("Hello and welcome to the Quiz Maker!");
            Console.WriteLine("You will be asked a series of questions, try and pick the correct answer!");
            List<QuizQuestions> quiz = new List<QuizQuestions>();
            StartQuiz(quiz);
            ExecuteQuiz(quiz);



        }
        private static void StartQuiz(List<QuizQuestions> quiz)
        {
            string path = @"..\..\..\..\sample-quiz-file.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] fields = line.Split("|");
                    QuizQuestions tempQuiz = new QuizQuestions();
                    tempQuiz.Question = fields[0];

                    for (int i = 1; i < fields.Length; i++)
                    {
                        tempQuiz.Answers.Add(fields[i]);
                    }
                    quiz.Add(tempQuiz);

                }
            }
        }
        private static void ExecuteQuiz(List<QuizQuestions> quiz)
        {
            int numberCorrect = 0;
            foreach (QuizQuestions question in quiz)
            {
                Console.WriteLine(question.Question);
                string correctAnswer = "";
                string updatedAnswer = "";
                bool isTrue = question.Answers.Contains("*");
                for (int i = 0; i < question.Answers.Count; i++)
                {
                    if (question.Answers[i].Contains("*"))
                    {
                        correctAnswer = question.Answers[i];
                        updatedAnswer = correctAnswer.Remove(correctAnswer.Length - 1);
                        Console.WriteLine($"{updatedAnswer}");
                    }
                    else
                    {
                        Console.WriteLine($"{question.Answers[i]}");
                    }
                }
                Console.Write($"Please enter your answer: ");
                string userAnswer = Console.ReadLine();
                if (userAnswer.ToLowerInvariant() == updatedAnswer.ToLower())
                {

                    numberCorrect++;
                    Console.WriteLine($"{userAnswer} was correct! You have {numberCorrect} correct answers!");
                }
                else
                {
                    Console.WriteLine($"{userAnswer} was incorrect! You still have {numberCorrect} correct answers!");
                }

            }
        }
    }
}
