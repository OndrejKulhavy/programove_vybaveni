namespace Cviceni_07._11._2022
{
    class QandA
    {
        private string question;
        private string answer;

        public string Question
        {
            get => question;
            set => question = value;
        }

        public string Answer
        {
            get => answer;
            set => answer = value;
        }

        public QandA(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
    }
}