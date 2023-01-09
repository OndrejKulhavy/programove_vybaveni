using QuizKulhavy.Forms;
using QuizKulhavy.Decks;
using System;
using System.Diagnostics;
namespace QuizKulhavy
{
    public partial class MainForm : Form
    {
        #region Properties
        public string FolderPath = "";
        private DataManager? dataManager;
        #endregion

        #region Constructors
        public MainForm()
        {
            InitializeComponent();
            SetFolderPath();
            LoadDecks();
            ShowDecks();
        }
        #endregion

        #region Methods
        public void LoadDecks()
        // This method loads the decks from the folder
        {
            try
            {
                dataManager = new DataManager(FolderPath);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error occurred while loading data from source folder with this error message: {e.Message}");
            }
        }
        public void ShowDecks()
        // This method shows existing decks in the ListView
        // It is called every time the data is loaded
        // It is also called when the user adds a new deck
        {
            ListView.Items.Clear();
            if (dataManager == null)
                return;
            foreach (var deck in dataManager.Decks)
            {
                var item = new ListViewItem(deck.Name);
                item.SubItems.Add(deck.Date);
                if (deck.Items != null)
                    item.SubItems.Add($"{deck.Items.Count + 1}");
                else
                    item.SubItems.Add("0");
                item.SubItems.Add(deck.FilePath);
                ListView.Items.Add(item);
            }
        }

        private void SetFolderPath()
        //This method asks the user for the path to the folder with the decks
        //It is called when the application starts
        {
            FolderBrowserDialog folderBrowserDialog = new();
            folderBrowserDialog.ShowDialog();
            FolderPath = folderBrowserDialog.SelectedPath;
            ToolStripFolderPath.Text = FolderPath;
        }



        private void SelectedDeckChanged(object sender, EventArgs e)
        // This method enables the buttons when the user selects a deck in the ListView
        // also disables the buttons when no deck is selected
        {
            if (ListView.SelectedItems.Count > 0)
            {
                BtnEditQuiz.Enabled = true;
                BtnRemoveQuiz.Enabled = true;
                BtnOpenQuiz.Enabled = true;
            }
            else
            {
                BtnEditQuiz.Enabled = false;
                BtnRemoveQuiz.Enabled = false;
                BtnOpenQuiz.Enabled = false;
            }

        }

        private void BtnOpenQuizClicked(object sender, EventArgs e)
        // This method opens the selected deck in the QuizForm
        {
            if (ListView.SelectedItems.Count > 0)
            {
                var item = ListView.SelectedItems[0];
                var quizDeck = dataManager?.Decks.FirstOrDefault(x => x.Name == item.Text);
                if (quizDeck != null)
                {
                    var quizForm = new QuizForm(quizDeck);
                    quizForm.Show();
                }

            }
        }

        private void BtnExportAsMdClicked(object sender, EventArgs e)
        // This method is called when the user clicks the export button
        // It exports the decks to the markdown format file
        {
            if (dataManager == null)
                return;
            dataManager.ExportDecks("md");
        }

        private void BtnExportAsHTMLClicked(object sender, EventArgs e)
        // This method is called when the user clicks the export button
        // It exports the decks to the html format file
        {
            if (dataManager == null)
                return;
            dataManager.ExportDecks("html");
        }

        private void BtnAddDeckClicked(object sender, EventArgs e)
        // This method opens the Editor form
        {
            Form editor = new Editor(this, FolderPath);
            editor.Show();
        }

        private void BtnEditDeckClicked(object sender, EventArgs e)
        // This method opens the Editor form with the selected deck for editing
        {
            if (ListView.SelectedItems.Count > 0)
            {
                var item = ListView.SelectedItems[0];
                var quizDeck = dataManager?.Decks.FirstOrDefault(x => x.Name == item.Text);
                if (quizDeck != null)
                {
                    var editor = new Editor(this, quizDeck);
                    editor.Show();
                }

            }
        }

        private void BtnRemoveDeck(object sender, EventArgs e)
        // This method removes the selected deck from the ListView, from the dataManager and the file
        {
            if (ListView.SelectedItems.Count > 0)
            {
                var item = ListView.SelectedItems[0];
                var quizDeck = dataManager?.Decks.FirstOrDefault(x => x.Name == item.Text);
                if (quizDeck != null)
                {
                    dataManager?.DeleteDeck(quizDeck);
                    LoadDecks();
                    ShowDecks();
                }

            }
        }
        #endregion
    }
}