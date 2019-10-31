using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public string Title { get; set; }
        public IList<Question> Questions { get; } = new List<Question>();

        public Quiz(int quizId, string title)
        {
            QuizId = quizId;
            Title = title;
        }

        public Question CreateQuestion(string text)
        {
            Question newQuestion = new Question(Questions.Count, text);
            this.Questions.Add(newQuestion);
            return newQuestion;
        }
    }
}
