using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public IList<string> Answers { get; } = new List<string>();
        public int CorrectAnswerIndex { get; set; }

        public Question(int questionId, string text)
        {
            QuestionId = questionId;
            Text = text;
        }

        public void AddAnswer(string text)
        {
            this.Answers.Add(text);
        }
    }
}
