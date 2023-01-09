using Newtonsoft.Json;
using QuizKulhavy.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizKulhavy.Decks
{
    internal class Deck
    {
        #region Properties
        public string? Name { get; set; }
        public string? Date { get; set; }
        public string FilePath { get; set; }
        public List<QuizItem>? Items { get; set; }
        #endregion

        #region Constructors
        public Deck(string filePath)
        {
            FilePath = filePath;
            Items = new List<QuizItem>();
        }
        #endregion

        #region Methods
        public void Fetch()
        //fetches the deck from the file
        {
            //set items of the deck and check for errors
            var json = File.ReadAllText(FilePath);
            Items = JsonConvert.DeserializeObject<List<QuizItem>>(json);
            if (Items == null)
                throw new Exception($"Error in {FilePath}. Items are null");

            //set date of the deck
            Date = File.GetCreationTime(FilePath).ToString();
            if (Date == null)
                throw new Exception($"Error in {FilePath}. Date is null");

            //set name of the deck and capitalize the first letter
            var name = Path.GetFileName(FilePath);
            Name = name.First().ToString().ToUpper() + name[1..].Replace(".json", "");
            if (Name == null)
                throw new Exception($"Error in {FilePath}. Name is null");
        }

        public void Save()
        //saves the deck to json file
        {
            var json = JsonConvert.SerializeObject(Items, Formatting.Indented);
            var file = File.CreateText(FilePath);
            file.Write(json);
            file.Close();
        }

        public override string ToString()
        {
            if (Name == null || Date == null || Items == null)
                throw new Exception("Deck is not complete");
            return $"{Name} ({Date} - {Items.Count} items)";
        }

        public string ToHTML()
        //returns the deck as HTML
        {
            if (Name == null || Date == null || Items == null)
                throw new Exception("Deck is not complete");
            var html = new StringBuilder();
            html.Append($"<h1>{Name}</h1>");
            html.Append($"<p>{Date}</p>");
            html.Append($"<p>{Items.Count}</p>");
            foreach (var item in Items)
            {
                html.Append(item.ToHTML());
            }
            return html.ToString();
        }

        public string ToMarkdown()
        //returns the deck as Markdown
        {
            if (Name == null || Date == null || Items == null)
                throw new Exception("Deck is not complete");
            var md = new StringBuilder();
            md.AppendLine($"# {Name}");
            md.AppendLine($"Created: {Date}");
            md.AppendLine($"Number of items: {Items.Count}");
            foreach (var item in Items)
            {
                md.Append(item.ToMarkdown());
            }
            return md.ToString();
        }
        #endregion
    }
}
