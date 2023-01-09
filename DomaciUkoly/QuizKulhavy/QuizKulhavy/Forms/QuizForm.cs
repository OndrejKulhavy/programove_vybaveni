using QuizKulhavy.Decks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizKulhavy.Forms
{
    internal partial class QuizForm : Form
    {
        #region Properties
        private int currentQuestionIndex = 0;

        private int correctAnswers = 0;

        public Deck QuizDeck { get; set; }
        #endregion

        #region Constructors
        public QuizForm(Deck quizDeck)
        {
            InitializeComponent();
            QuizDeck = quizDeck;
        }
        #endregion

        #region Methods
        private void QuizForm_Load(object sender, EventArgs e)
        //shows the first question when the form is loaded
        {
            ShowItem();
        }

        private void ShowItem()
        //shows the current question
        {
            //error handling
            if(QuizDeck.Items == null || QuizDeck.Items.Count == 0)
            {
                MessageBox.Show("No questions");
                return;
            }
            if (currentQuestionIndex > QuizDeck.Items.Count)
            {
                MessageBox.Show("No more questions");
                return;
            }
            var item = QuizDeck.Items[currentQuestionIndex];
            LblQuestion.Text = item.Question;
            foreach (var option in item.Options)
            {
                CheckList.Items.Add(option);
            }
            TspProgress.Text = $"{currentQuestionIndex + 1} / {QuizDeck.Items.Count}";
        }

        private void BtnQuizNext_Click(object sender, EventArgs e)
        //shows the next question
        //checks if the answer is correct
        //shows the result when the last question is reached
        //closes the form when the last question is reached
        {
            //error handling
            if (QuizDeck.Items == null)
            {
                MessageBox.Show("No questions");
                return;
            }
            if (currentQuestionIndex > QuizDeck.Items.Count)
            {
                MessageBox.Show("No more questions");
                return;
            }
            if (CheckList.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one option");
                return;
            }
            if (IsAnswerCorrect())
            {
                correctAnswers++;
            }
            if (currentQuestionIndex == QuizDeck.Items.Count - 1)
            {
                MessageBox.Show($"Correct answers: {correctAnswers} / {QuizDeck.Items.Count} ({Math.Round((double)correctAnswers / QuizDeck.Items.Count * 100, 2)} %)");
                Close();
            }
            else
            {
                currentQuestionIndex++;
                CheckList.Items.Clear();
                ShowItem();
            }
        }

        private bool IsAnswerCorrect()
        //checks if the answers are correct
        {
            //error handling
            if (QuizDeck.Items == null)
            {
                MessageBox.Show("No questions");
                return false;
            }

            var item = QuizDeck.Items[currentQuestionIndex];
            foreach (var answer in item.Answer)
            {
                if (!CheckList.CheckedItems.Contains(answer))
                {
                    return false;
                }
            }
            return true;

        }
        #endregion
    }
}
