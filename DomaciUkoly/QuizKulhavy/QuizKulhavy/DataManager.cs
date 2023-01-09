using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using QuizKulhavy.Decks;

namespace QuizKulhavy
{
    internal class DataManager
    {
        #region Properties
        public string FolderPath { get; set; }
        public List<Deck> Decks { get; set; }
        #endregion

        #region Constructors
        public DataManager(string folderPath)
        {
            Console.WriteLine(folderPath);
            FolderPath = folderPath;
            if (IsFolderEmpty())
                Directory.CreateDirectory(FolderPath + "\\Quiz");
            Decks = new List<Deck>();
            LoadDecks();
        }
        #endregion

        #region Methods
        private bool IsFolderEmpty()
        //This method checks if the folder is empty = if it contains the Quiz folder
        {
            var folders = Directory.GetDirectories(FolderPath);
            Console.WriteLine(folders.Contains("Quiz"));
            return !folders.Contains("Quiz");
        }

        public void LoadDecks()
        //This method loads all decks from the Quiz folder
        {
            var quizFiles = Directory.GetFiles(FolderPath + "\\Quiz", "*.json");
            foreach (var file in quizFiles)
            {
                Deck deck = new Deck(file);
                deck.Fetch();
                Console.WriteLine(deck);
                Decks.Add(deck);
            }
        }

        public void DeleteDeck(Deck deck)
        //This method deletes the deck from the list and from the file
        {
            Decks.Remove(deck);
            File.Delete(deck.FilePath);
        }

        public void ExportDecks(string type)
        //This method exports all decks to a file in the selected format
        {
            //open save dialog and let the user choose the path and name of the file
            SaveFileDialog saveFileDialog = new();
            if (type == "md")
                saveFileDialog.Filter = "Markdown file (*.md)|*.md";
            else if (type == "html")
                saveFileDialog.Filter = "HTML file (*.html)|*.html";
            saveFileDialog.ShowDialog();
            var path = saveFileDialog.FileName;
            if (path == "")
                return;
            var file = File.CreateText(path);

            //create file based on the selected format
            if (type == "md")
            {
                foreach (var deck in Decks)
                {
                    file.Write(deck.ToMarkdown());
                }
            }
            else if (type == "html")
            {
                file.WriteLine("<body>");
                foreach (var deck in Decks)
                {
                    file.Write(deck.ToHTML());
                }
                file.WriteLine("</body>");
            }
            file.Close();
            //open file in file explorer
            Process.Start("explorer.exe", "/select," + path);
        }
        #endregion
    }
}
