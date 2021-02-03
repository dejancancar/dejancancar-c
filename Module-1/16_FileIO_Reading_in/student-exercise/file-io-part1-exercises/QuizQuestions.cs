using System;
using System.Collections.Generic;
using System.Text;

namespace file_io_part1_exercises
{
    public class QuizQuestions
    {
        public string Question { get; set; }
        public List<string> Answers { get; set; } = new List<string>();
        // public  string CorrectAnswer { get; set; }

        //public QuizQuestions(string question, /*string correctAnswer,*/ List<string> answers)
        //{
        //    this.Question = question;
        //   // this.CorrectAnswer = correctAnswer;
        //    this.Answers = answers;

        //}
        public QuizQuestions()
        {

        }

    }
}
