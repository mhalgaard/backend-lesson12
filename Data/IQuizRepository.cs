using QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Data
{
    public interface IQuizRepository
    {
        IList<Quiz> GetQuizzes();
        Quiz GetQuiz(int id);
        Quiz CreateQuiz(string name);
    }
}
