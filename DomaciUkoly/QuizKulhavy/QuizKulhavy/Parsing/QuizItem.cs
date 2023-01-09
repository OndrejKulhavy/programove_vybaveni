using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizKulhavy.Parsing
{
    internal class QuizItem
    {
        #region Properties
        public int? Id { get; set; }
        public string? Question { get; set; }
        public string[]? Options { get; set; }
        public string[]? Answer { get; set; }
        #endregion

        #region Constructors
        public string ToMarkdown()
        //returns the Markdown representation of the quiz item
        {
            if (Id == null || Question == null || Options == null || Answer == null)
                throw new Exception("QuizItem is not complete");
            var sb = new StringBuilder();

            sb.AppendLine($"### {Id}. {Question}");
            sb.AppendLine();
            foreach (var option in Options)
            {
                sb.AppendLine($"- {option}");
            }
            sb.AppendLine();
            sb.AppendLine("Correct answer(s):");
            sb.AppendLine("```");
            foreach (var answer in Answer)
            {
                sb.AppendLine(answer);
            }
            sb.AppendLine("```");
            return sb.ToString();
        }
        #endregion

        #region Methods
        public string ToHTML()
        //returns the HTML representation of the quiz item
        {
            if (Id == null || Question == null || Options == null || Answer == null)
                throw new Exception("QuizItem is not complete");
            var sb = new StringBuilder();

            sb.AppendLine($"<h3>{Id}. {Question}</h3>");
            sb.AppendLine("<ul>");
            foreach (var option in Options)
            {
                sb.AppendLine($"    <li>{option}</li>");
            }
            sb.AppendLine("</ul>");
            sb.AppendLine("<p>Correct answer(s):</p>");
            sb.AppendLine("<p><b>");
            foreach (var answer in Answer)
            {
                sb.AppendLine(answer);
            }
            sb.AppendLine("</b></p>");
            return sb.ToString();
        }

        public override string? ToString()
        //returns the string representation of the quiz item
        {
            if (Id == null || Question == null || Options == null || Answer == null)
                throw new Exception("QuizItem is not complete");
            return $"Id: {Id}, Question: {Question}, Options: {Options.Cast<string>()}, Answer: {Answer.Cast<string>()}";
        }
        #endregion
    }
}
