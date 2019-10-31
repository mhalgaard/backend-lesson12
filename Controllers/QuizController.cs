﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizApp.Data;
using QuizApp.Models;
using QuizApp.Models.ViewModels;

namespace QuizApp.Controllers
{
    public class QuizController : Controller
    {
        private IQuizRepository quizRepository;

        public QuizController(IQuizRepository quizRepository)
        {
            this.quizRepository = quizRepository;
        }

        public IActionResult Index()
        {
            var quizzes = this.quizRepository.GetQuizzes();
            return View(quizzes);
        }

        public IActionResult TakeQuiz(int id)
        {
            return View(this.quizRepository.GetQuiz(id));
        }

        [HttpPost]
        public IActionResult Submit(int QuizId, int[] Answers)
        {
            Quiz quiz = quizRepository.GetQuiz(QuizId);

            int errors = 0;
            for (int i = 0; i < quiz.Questions.Count; i++)
            {
                if (quiz.Questions[i].CorrectAnswerIndex != Answers[i])
                {
                    errors++;
                }
            }

            return View("results", errors);
        }
    }
}