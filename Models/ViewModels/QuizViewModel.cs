using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models.ViewModels
{
    public class QuizViewModel
    {
        [BindRequired]
        public Quiz Quiz { get; set; }
        public int QuizId { get; set; }

        public QuizViewModel(Quiz quiz)
        {
            this.Quiz = quiz;
        }
    }
}
