using QuizKulhavy.Decks;
using QuizKulhavy.Parsing;
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
    internal partial class Editor : Form
    {
        #region Properties
        public MainForm MainForm { get; set; }
        public Deck Deck { get; set; }
        #endregion

        #region Constructors
        public Editor(MainForm mainForm, string path)
        {
            MainForm = mainForm;
            if (GetDeckName() == "" || GetDeckName() == null) Close();
            Deck = new Deck($"{path}\\Quiz\\{GetDeckName()}.json");
            Console.WriteLine(Deck.FilePath);
            InitializeComponent();
            ShowItems();
        }

        public Editor(MainForm mainForm, Deck deck)
        {
            MainForm = mainForm;
            Deck = deck;
            InitializeComponent();
            ShowItems();
        }
        #endregion

        #region Methods
        private void ShowItems()
        // shows all the items in the deck in listview
        {
            if (Deck.Items == null)
                return;
            foreach (var item in Deck.Items)
            {
                LstViewEditor.Items.Add(item.Question);
            }
        }

        private string GetDeckName()
        // gets the name of the deck from the user
        {
            //create window with input and get the name of the deck    
            var deckName = Microsoft.VisualBasic.Interaction.InputBox("Please enter the name of the deck", "Deck name", "", 100, 100);

            return deckName;
        }

        private void BtnEditorCancel_Click(object sender, EventArgs e)
        // closes the editor without saving
        {
            Close();
        }

        private void BtnEditorSave_Click(object sender, EventArgs e)
        //saves the deck and closes the editor
        {
            Deck.Save();
            MainForm.LoadDecks();
            MainForm.ShowDecks();
            Close();
        }

        private void LstViewEditor_SelectedIndexChanged(object sender, EventArgs e)
        // shows the selected item in the editor
        // if no item is selected, the editor is disabled
        {
            if (LstViewEditor.SelectedItems.Count > 0)
            {
                var item = LstViewEditor.SelectedItems[0];
                if (Deck.Items == null)
                    return;
                var deckItem = Deck.Items.Find(x => x.Question == item.Text);
                EditItemGroup.Enabled = true;

                TbxEditorCorrAnswer.Text = string.Join("_", deckItem.Answer);
                TbxEditorQuestion.Text = deckItem.Question;
                var falseAnswers = deckItem.Options.Where(x => !deckItem.Answer.Contains(x));
                RtxEditorFalseAnswers.Text = string.Join("\n", falseAnswers);
                BtnEditorSaveAddItem.Text = "Save";
                BtnEditorRemoveItem.Enabled = true;
                

            }
            else
            {
                TbxEditorCorrAnswer.Text = "";
                TbxEditorQuestion.Text = "";
                RtxEditorFalseAnswers.Text = "";
                EditItemGroup.Enabled = false;
                BtnEditorRemoveItem.Enabled = false;
            }

        }

        private void BtnEditorAddItem_Click(object sender, EventArgs e)
        //clears the fields and enables the edit item group
        {
            TbxEditorCorrAnswer.Text = "";
            TbxEditorQuestion.Text = "";
            RtxEditorFalseAnswers.Text = "";
            EditItemGroup.Enabled = true;
            BtnEditorSaveAddItem.Text = "Add";

        }

        private void BtnEditorSaveAddItem_Click(object sender, EventArgs e)
        //This method is used for both saving and adding items in/to deck
        {
            var question = TbxEditorQuestion.Text;
            var answers = TbxEditorCorrAnswer.Text.Split('_');
            var falseAnswers = RtxEditorFalseAnswers.Text;
            var falseAnswersList = falseAnswers.Split('\n');

            //if something isnt filled
            if (question == "" || answers == null || falseAnswers == "")
            {
                MessageBox.Show("Fill all the fields");
                return;
            }

            //if the question is already in the deck
            if (Deck.Items != null && Deck.Items.Exists(x => x.Question == question))
            {
                var item = Deck.Items.Find(x => x.Question == question);
                var index = Deck.Items.IndexOf(item);
                item.Answer = answers;
                item.Options = CombineLists(answers, falseAnswersList);
                Deck.Items[index] = item;

            }
            else
            {
                var item = CreateItem(question, answers, falseAnswersList);
                if (Deck.Items == null)
                    return;
                Deck.Items.Add(item);
            }
            LstViewEditor.Items.Clear();
            ShowItems();
        }
        private QuizItem CreateItem(string question, string[] answers, string[] falseAnswersList)
        //creates a new item and returns it
        {
            var item = new QuizItem();
            if (Deck.Items == null)
                item.Id = 1;
            else
                item.Id = Deck.Items.Count + 1;

            item.Question = question;
            item.Answer = answers;
            item.Options = CombineLists(answers, falseAnswersList);
            return item;
        }

        private void BtnEditorRemoveItem_Click(object sender, EventArgs e)
        //removes the selected item from the deck and from the listview
        {
            var item = LstViewEditor.SelectedItems[0];
            if (Deck.Items == null)
            {
                MessageBox.Show("No items in the deck");
                return;
            }
            var deckItem = Deck.Items.Find(x => x.Question == item.Text);
            if (deckItem == null)
            {
                MessageBox.Show("Item not found");
                return;
            }
            Deck.Items.Remove(deckItem);
            LstViewEditor.Items.Clear();
            ShowItems();
        }

        private string[] CombineLists(string[] answers, string[] falseAnswersList)
        //combines the correct answers and the false answers into one array
        {
            var list = new List<string>();
            list.AddRange(answers);
            list.AddRange(falseAnswersList);
            return list.ToArray();

        }
        #endregion
    }
}
