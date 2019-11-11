using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizApp.Models;

namespace QuizApp.Data
{
    public class QuizRepositoryMem : IQuizRepository
    {
        private IList<Quiz> quizzes = new List<Quiz>();

        public QuizRepositoryMem()
        {
            Quiz quiz1 = this.CreateQuiz("Min Quiz");
            Quiz quiz2 = this.CreateQuiz("Endnu en quiz");
            Quiz quiz3 = this.CreateQuiz("Sidste quiz");

            Question q1 = quiz1.CreateQuestion("Hvad er meningen med livet?");
            q1.AddAnswer("40"); // 0
            q1.AddAnswer("41"); // 1
            q1.AddAnswer("42"); // 2
            q1.AddAnswer("43"); // 3
            q1.CorrectAnswerIndex = 2;

            Question q2 = quiz1.CreateQuestion("Hvor mange svarmuligheder har denne quiz?");
            q2.AddAnswer("1 muligheder"); // 0
            q2.AddAnswer("2 muligheder"); // 1
            q2.AddAnswer("3 muligheder"); // 2
            q2.AddAnswer("4 muligheder"); // 3
            q2.CorrectAnswerIndex = 3;
        }

        public Quiz CreateQuiz(string name)
        {
            Quiz newQuiz = new Quiz(quizzes.Count, name);
            this.quizzes.Add(newQuiz);
            return newQuiz;
        }

        public Quiz GetQuiz(int id)
        {
            return quizzes.Where(quiz => quiz.QuizId == id).First();
        }

        public IList<Quiz> GetQuizzes()
        {
            return new List<Quiz>(quizzes);
        }
    }
}
