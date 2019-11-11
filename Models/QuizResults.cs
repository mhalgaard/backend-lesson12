using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class QuizResults
    {
        public string participantName { get; set; }
        public Quiz Quiz { get; set; }
        public List<int> Answers { get; } = new List<int>();

        public QuizResults(string participantName, Quiz quiz)
        {
            this.participantName = participantName;
            this.Quiz = quiz;
        }

        public void AddAnswers(int[] answers)
        {
            this.Answers.AddRange(answers);
        }

        public int CorrectAnswers
        {
            get
            {
                int correct = 0;
                for (int i = 0; i < this.Answers.Count; i++)
                {
                    if (this.Answers[i] == Quiz.Questions[i].CorrectAnswerIndex)
                    {
                        correct++;
                    }
                }
                return correct;
            }
        }

        public int WrongAnswers
        {
            get
            {
                return this.Answers.Count - this.CorrectAnswers;
            }
        }
    }
}
