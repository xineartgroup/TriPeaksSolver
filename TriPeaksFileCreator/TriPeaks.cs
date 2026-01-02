using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TriPeaksSolver
{
    public partial class TriPeaks : Form
    {
        private string strImage = "";
        private string filePath = "";
        private Dictionary<string, Button> lastCombinations = [];
        private readonly Dictionary<string, Button> usedCombinations = [];
        private readonly List<Dictionary<string, Button>> historyUndo = [];
        private readonly List<Dictionary<string, Button>> historyRedo = [];
        private int lastTabIndex = -1;
        private bool insertLeft = false;
        private bool insertRight = false;
        private bool deleteLeft = false;
        private bool deleteRight = false;

        public TriPeaks()
        {
            InitializeComponent();
        }

        private void TriPeaks_Load(object sender, EventArgs e)
        {
            historyUndo.Add(new Dictionary<string, Button>(lastCombinations));
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                label1.Text = listBox1.SelectedItem.ToString();
                if (string.IsNullOrEmpty(label1.Text))
                {
                    strImage = "";
                    pictureBox1.Image = null;
                }
            }
            else
            {
                label1.Text = "";
                strImage = "";
                pictureBox1.Image = null;
            }
            if (strImage == "Club")
            {
                btnClub.Focus();
            }
            else if (strImage == "Diamond")
            {
                btnDiamond.Focus();
            }
            else if (strImage == "Heart")
            {
                btnHeart.Focus();
            }
            else if (strImage == "Spade")
            {
                btnSpade.Focus();
            }
            else
            {
                btnNone.Focus();
            }
        }

        private void ListBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int nextIndex = -1;
            switch (e.KeyChar)
            {
                case 'a':
                case 'A':
                    nextIndex = lastTabIndex - 1;
                    break;
                case 'd':
                case 'D':
                    nextIndex = lastTabIndex + 1;
                    break;
                case 's':
                case 'S':
                    nextIndex = lastTabIndex;
                    break;
            }
            if (nextIndex >= 0 && nextIndex <= 52)
            {
                for (int i = 0; i < 24; i++)
                {
                    if (Controls.Find("btnPile" + (i + 1), true).FirstOrDefault() is Button btn)
                    {
                        if (btn.TabIndex == nextIndex)
                        {
                            BoardButton_Click(btn, EventArgs.Empty);
                            return;
                        }
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    if (Controls.Find("btnBoard" + (i + 1), true).FirstOrDefault() is Button btn)
                    {
                        if (btn.TabIndex == nextIndex)
                        {
                            BoardButton_Click(btn, EventArgs.Empty);
                            return;
                        }
                    }
                }
            }
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyUndo.Count > 0 && historyRedo.Count <= 1)
            {
                var lastState = historyUndo[^1];
                if (lastState.Count == usedCombinations.Count)
                {
                    // Move the last undo (final) state to redo to maintain history
                    historyUndo.RemoveAt(historyUndo.Count - 1);
                    historyRedo.Clear();
                    historyRedo.Add(lastState);
                }
            }

            if (historyUndo.Count > 0)
            {
                usedCombinations.Clear();
                var lastState = historyUndo[^1];
                historyUndo.RemoveAt(historyUndo.Count - 1);
                historyRedo.Insert(0, lastState);
                foreach (var kvp in lastState)
                {
                    usedCombinations.Add(kvp.Key, kvp.Value);
                }
                // Clear all buttons
                for (int i = 0; i < 24; i++)
                {
                    if (Controls.Find("btnPile" + (i + 1), true).FirstOrDefault() is Button btn)
                    {
                        btn.Image = null;
                        btn.Text = "";
                        btn.Tag = null;
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    if (Controls.Find("btnBoard" + (i + 1), true).FirstOrDefault() is Button btn)
                    {
                        btn.Image = null;
                        btn.Text = "";
                        btn.Tag = null;
                    }
                }
                // Restore last state
                foreach (var kvp in usedCombinations)
                {
                    string ctype = kvp.Key.Split(" of ")[1];
                    if (ctype == "Club")
                        kvp.Value.Image = btnClub.Image;
                    else if (ctype == "Diamond")
                        kvp.Value.Image = btnDiamond.Image;
                    else if (ctype == "Heart")
                        kvp.Value.Image = btnHeart.Image;
                    else if (ctype == "Spade")
                        kvp.Value.Image = btnSpade.Image;
                    kvp.Value.Text = kvp.Key.Split(" of ")[0];
                    kvp.Value.Tag = kvp.Key;
                }
            }
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyRedo.Count > 0 && historyUndo.Count <= 1)
            {
                var lastState = historyRedo[0];
                if (lastState.Count == 0)
                {
                    // Move the first redo (initial) state to undo to maintain history
                    historyRedo.RemoveAt(0);
                    historyUndo.Clear();
                    historyUndo.Add(lastState);
                }
            }

            if (historyRedo.Count > 0)
            {
                usedCombinations.Clear();
                var lastState = historyRedo[0];
                historyRedo.RemoveAt(0);
                historyUndo.Add(lastState);
                foreach (var kvp in lastState)
                {
                    usedCombinations.Add(kvp.Key, kvp.Value);
                }
                // Clear all buttons
                for (int i = 0; i < 24; i++)
                {
                    if (Controls.Find("btnPile" + (i + 1), true).FirstOrDefault() is Button btn)
                    {
                        btn.Image = null;
                        btn.Text = "";
                        btn.Tag = null;
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    if (Controls.Find("btnBoard" + (i + 1), true).FirstOrDefault() is Button btn)
                    {
                        btn.Image = null;
                        btn.Text = "";
                        btn.Tag = null;
                    }
                }
                // Restore last state
                foreach (var kvp in usedCombinations)
                {
                    string ctype = kvp.Key.Split(" of ")[1];
                    if (ctype == "Club")
                        kvp.Value.Image = btnClub.Image;
                    else if (ctype == "Diamond")
                        kvp.Value.Image = btnDiamond.Image;
                    else if (ctype == "Heart")
                        kvp.Value.Image = btnHeart.Image;
                    else if (ctype == "Spade")
                        kvp.Value.Image = btnSpade.Image;
                    kvp.Value.Text = kvp.Key.Split(" of ")[0];
                    kvp.Value.Tag = kvp.Key;
                }
            }
        }

        private void InsertLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertLeft = !insertLeft;
            insertRight = false;
            deleteLeft = false;
            deleteRight = false;
            insertLeftToolStripMenuItem.Checked = insertLeft;
            insertRightToolStripMenuItem.Checked = insertRight;
            deleteLeftToolStripMenuItem.Checked = deleteRight;
            deleteRightToolStripMenuItem.Checked = deleteRight;
        }

        private void InsertRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertRight = !insertRight;
            insertLeft = false;
            deleteLeft = false;
            deleteRight = false;
            insertRightToolStripMenuItem.Checked = insertRight;
            insertLeftToolStripMenuItem.Checked = insertLeft;
            deleteLeftToolStripMenuItem.Checked = deleteRight;
            deleteRightToolStripMenuItem.Checked = deleteRight;
        }

        private void DeleteLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteLeft = !deleteLeft;
            insertLeft = false;
            insertRight = false;
            deleteRight = false;
            insertLeftToolStripMenuItem.Checked = insertLeft;
            insertRightToolStripMenuItem.Checked = insertRight;
            deleteLeftToolStripMenuItem.Checked = deleteLeft;
            deleteRightToolStripMenuItem.Checked = deleteRight;
            BtnNone_Click(sender, e);
        }

        private void DeleteRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteRight = !deleteRight;
            insertLeft = false;
            insertRight = false;
            deleteLeft = false;
            insertLeftToolStripMenuItem.Checked = insertLeft;
            insertRightToolStripMenuItem.Checked = insertRight;
            deleteLeftToolStripMenuItem.Checked = deleteLeft;
            deleteRightToolStripMenuItem.Checked = deleteRight;
            BtnNone_Click(sender, e);
        }

        private void BtnNone_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            strImage = "";
            label1.Text = "";
            listBox1.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = btnClub.Image;
            strImage = "Club";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = btnDiamond.Image;
            strImage = "Diamond";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = btnHeart.Image;
            strImage = "Heart";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = btnSpade.Image;
            strImage = "Spade";
        }

        private void BoardButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (!string.IsNullOrEmpty(label1.Text)
                    && pictureBox1.Image != null)
                {
                    string combination = label1.Text + " of " + strImage;
                    if (!usedCombinations.TryAdd(combination, btn))
                    {
                        if (MessageBox.Show(
                            "This card has already been used. Do you want to swap?",
                            "Used Card",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Button btnUsed = usedCombinations[combination];
                            btnUsed.Image = btn.Image;
                            btnUsed.Text = btn.Text;
                            btnUsed.Tag = btn.Tag;
                            usedCombinations[combination] = btn;
                            if (btn.Tag != null)
                            {
                                // Free up the previous combination
                                usedCombinations.Remove(btn.Tag.ToString()!);
                            }
                            if (insertLeft)
                            {
                                ShiftCardsToLeft(btn.TabIndex, pictureBox1.Image, label1.Text, combination);
                                insertLeft = false;
                                insertLeftToolStripMenuItem.Checked = insertLeft;
                            }
                            else if (insertRight)
                            {
                                ShiftCardsToRight(btn.TabIndex, pictureBox1.Image, label1.Text, combination);
                                insertRight = false;
                                insertRightToolStripMenuItem.Checked = insertRight;
                            }
                            else
                            {
                                btn.Image = pictureBox1.Image;
                                btn.Text = label1.Text;
                                btn.Tag = combination;
                                lastTabIndex = btn.TabIndex;
                                UpdateUndoRedoItems();
                            }
                        }
                    }
                    else
                    {
                        if (btn.Tag != null)
                        {
                            // Free up the previous combination
                            usedCombinations.Remove(btn.Tag.ToString()!);
                        }
                        if (insertLeft)
                        {
                            ShiftCardsToLeft(btn.TabIndex, pictureBox1.Image, label1.Text, combination);
                            insertLeft = false;
                            insertLeftToolStripMenuItem.Checked = insertLeft;
                        }
                        else if (insertRight)
                        {
                            ShiftCardsToRight(btn.TabIndex, pictureBox1.Image, label1.Text, combination);
                            insertRight = false;
                            insertRightToolStripMenuItem.Checked = insertRight;
                        }
                        else
                        {
                            btn.Image = pictureBox1.Image;
                            btn.Text = label1.Text;
                            btn.Tag = combination;
                            lastTabIndex = btn.TabIndex;
                            UpdateUndoRedoItems();
                        }
                    }
                    if (usedCombinations.Count == 51)
                    {
                        if (MessageBox.Show("Do you want to auto-fill?", "Auto-fill", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            AutoFillToolStripMenuItem_Click(sender, e);
                        }
                    }
                }
                else if (string.IsNullOrEmpty(strImage))
                {
                    if (deleteLeft)
                    {
                        ShiftCardsFromLeft(btn.TabIndex);
                        deleteLeft = false;
                        deleteLeftToolStripMenuItem.Checked = deleteLeft;
                    }
                    else if (deleteRight)
                    {
                        ShiftCardsFromRight(btn.TabIndex);
                        deleteRight = false;
                        deleteRightToolStripMenuItem.Checked = deleteRight;
                    }
                    else
                    {
                        btn.Image = null;
                        btn.Text = "";
                        usedCombinations.Remove(btn.Tag?.ToString() ?? "");
                        UpdateUndoRedoItems();
                        btn.Tag = null;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a card from the list.");
                }
            }
            if (strImage == "Club")
            {
                btnClub.Focus();
            }
            else if (strImage == "Diamond")
            {
                btnDiamond.Focus();
            }
            else if (strImage == "Heart")
            {
                btnHeart.Focus();
            }
            else if (strImage == "Spade")
            {
                btnSpade.Focus();
            }
            else
            {
                btnNone.Focus();
            }
        }

        private void ShiftCardsFromLeft(int index)
        {
            bool isFirst = true;
            if (index >= 0 && index <= 52)
            {
                for (int i = 28; i > 0; i--)
                {
                    if (Controls.Find("btnBoard" + (i), true).FirstOrDefault() is Button btn1)
                    {
                        if (Controls.Find("btnBoard" + (i - 1), true).FirstOrDefault() is Button btn2)
                        {
                            if (btn1.TabIndex == index)
                            {
                                if (isFirst)
                                {
                                    isFirst = false;
                                    usedCombinations.Remove(btn1.Tag?.ToString() ?? "");
                                }
                                btn1.Tag = btn2.Tag;
                                btn1.Text = btn2.Text;
                                btn1.Image = btn2.Image;
                                index--;
                            }
                        }
                        else
                        {
                            if (btn1.TabIndex == index)
                            {
                                if (isFirst)
                                {
                                    isFirst = false;
                                    usedCombinations.Remove(btn1.Tag?.ToString() ?? "");
                                }
                                btn1.Tag = null;
                                btn1.Text = "";
                                btn1.Image = null;
                                index--;
                            }
                        }
                    }
                }
                for (int i = 24; i > 0; i--)
                {
                    if (Controls.Find("btnPile" + (i), true).FirstOrDefault() is Button btn1)
                    {
                        if (Controls.Find("btnPile" + (i - 1), true).FirstOrDefault() is Button btn2)
                        {
                            if (btn1.TabIndex == index)
                            {
                                if (isFirst)
                                {
                                    isFirst = false;
                                    usedCombinations.Remove(btn1.Tag?.ToString() ?? "");
                                }
                                btn1.Tag = btn2.Tag;
                                btn1.Text = btn2.Text;
                                btn1.Image = btn2.Image;
                                index--;
                            }
                        }
                        else
                        {
                            if (btn1.TabIndex == index)
                            {
                                if (isFirst)
                                {
                                    isFirst = false;
                                    usedCombinations.Remove(btn1.Tag?.ToString() ?? "");
                                }
                                btn1.Tag = null;
                                btn1.Text = "";
                                btn1.Image = null;
                                index--;
                            }
                        }
                    }
                }
            }
        }

        private void ShiftCardsFromRight(int index)
        {
            bool isFirst = true;
            if (index >= 0 && index <= 52)
            {
                for (int i = 0; i <= 28; i++)
                {
                    if (Controls.Find("btnBoard" + (i), true).FirstOrDefault() is Button btn1)
                    {
                        if (Controls.Find("btnBoard" + (i + 1), true).FirstOrDefault() is Button btn2)
                        {
                            if (btn1.TabIndex == index)
                            {
                                if (isFirst)
                                {
                                    isFirst = false;
                                    usedCombinations.Remove(btn1.Tag?.ToString() ?? "");
                                }
                                btn1.Tag = btn2.Tag;
                                btn1.Text = btn2.Text;
                                btn1.Image = btn2.Image;
                                index++;
                            }
                        }
                        else
                        {
                            if (btn1.TabIndex == index)
                            {
                                if (isFirst)
                                {
                                    isFirst = false;
                                    usedCombinations.Remove(btn1.Tag?.ToString() ?? "");
                                }
                                btn1.Tag = null;
                                btn1.Text = "";
                                btn1.Image = null;
                                index++;
                            }
                        }
                    }
                }
                for (int i = 0; i <= 24; i++)
                {
                    if (Controls.Find("btnPile" + (i), true).FirstOrDefault() is Button btn1)
                    {
                        if (Controls.Find("btnPile" + (i + 1), true).FirstOrDefault() is Button btn2)
                        {
                            if (btn1.TabIndex == index)
                            {
                                if (isFirst)
                                {
                                    isFirst = false;
                                    usedCombinations.Remove(btn1.Tag?.ToString() ?? "");
                                }
                                btn1.Tag = btn2.Tag;
                                btn1.Text = btn2.Text;
                                btn1.Image = btn2.Image;
                                index++;
                            }
                        }
                        else
                        {
                            if (btn1.TabIndex == index)
                            {
                                if (isFirst)
                                {
                                    isFirst = false;
                                    usedCombinations.Remove(btn1.Tag?.ToString() ?? "");
                                }
                                btn1.Tag = null;
                                btn1.Text = "";
                                btn1.Image = null;
                                index++;
                            }
                        }
                    }
                }
            }
        }

        private void ShiftCardsToLeft(int index, System.Drawing.Image image, string text, string tag)
        {
            System.Drawing.Image? imageNext = image;
            string textNext = text;
            string tagNext = tag;
            if (index >= 0 && index <= 52)
            {
                for (int i = 28; i > 0; i--)
                {
                    if (Controls.Find("btnBoard" + (i), true).FirstOrDefault() is Button btn)
                    {
                        if (btn.TabIndex == index)
                        {
                            if (string.IsNullOrEmpty(tagNext))
                                return;

                            System.Drawing.Image? imageTemp = btn.Image;
                            string textTempt = btn.Text;
                            string tagTemp = btn.Tag?.ToString() ?? "";

                            btn.Tag = tagNext;
                            btn.Text = textNext;
                            btn.Image = imageNext;

                            tagNext = tagTemp;
                            textNext = textTempt;
                            imageNext = imageTemp;

                            usedCombinations.TryAdd(tagNext, btn);

                            index--;
                        }
                    }
                }
                for (int i = 24; i > 0; i--)
                {
                    if (Controls.Find("btnPile" + (i), true).FirstOrDefault() is Button btn)
                    {
                        if (btn.TabIndex == index)
                        {
                            if (string.IsNullOrEmpty(tagNext))
                                return;

                            System.Drawing.Image? imageTemp = btn.Image;
                            string textTempt = btn.Text;
                            string tagTemp = btn.Tag?.ToString() ?? "";

                            btn.Tag = tagNext;
                            btn.Text = textNext;
                            btn.Image = imageNext;

                            tagNext = tagTemp;
                            textNext = textTempt;
                            imageNext = imageTemp;

                            usedCombinations.TryAdd(tagNext, btn);

                            index--;
                        }
                    }
                }
            }
        }

        private void ShiftCardsToRight(int index, System.Drawing.Image image, string text, string tag)
        {
            System.Drawing.Image? imageNext = image;
            string textNext = text;
            string tagNext = tag;
            if (index >= 0 && index <= 52)
            {
                for (int i = 0; i <= 28; i++)
                {
                    if (Controls.Find("btnBoard" + (i), true).FirstOrDefault() is Button btn)
                    {
                        if (btn.TabIndex == index)
                        {
                            if (string.IsNullOrEmpty(tagNext))
                                return;

                            System.Drawing.Image? imageTemp = btn.Image;
                            string textTempt = btn.Text;
                            string tagTemp = btn.Tag?.ToString() ?? "";

                            btn.Tag = tagNext;
                            btn.Text = textNext;
                            btn.Image = imageNext;

                            tagNext = tagTemp;
                            textNext = textTempt;
                            imageNext = imageTemp;

                            usedCombinations.TryAdd(tagNext, btn);

                            index++;
                        }
                    }
                }
                for (int i = 0; i <= 24; i++)
                {
                    if (Controls.Find("btnPile" + (i), true).FirstOrDefault() is Button btn)
                    {
                        if (btn.TabIndex == index)
                        {
                            if (string.IsNullOrEmpty(tagNext))
                                return;

                            System.Drawing.Image? imageTemp = btn.Image;
                            string textTempt = btn.Text;
                            string tagTemp = btn.Tag?.ToString() ?? "";

                            btn.Tag = tagNext;
                            btn.Text = textNext;
                            btn.Image = imageNext;

                            tagNext = tagTemp;
                            textNext = textTempt;
                            imageNext = imageTemp;

                            usedCombinations.TryAdd(tagNext, btn);

                            index++;
                        }
                    }
                }
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                SaveFileDialog dlg = new();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    filePath = dlg.FileName;
                    Generate();
                }
            }
            else
            {
                filePath = NewFileName(filePath);
                Generate();
            }
        }
        public static string NewFileName(string input)
        {
            if (string.IsNullOrEmpty(input)) return "_1";

            if (input.ToLower().EndsWith(".txt"))
            {
                input = input[..^4];
            }

            int i = input.Length - 1;

            // 1. Move backwards from the end to find the start of the number
            while (i >= 0 && char.IsDigit(input[i]))
            {
                i--;
            }

            // 2. Extract the numeric part and the prefix part
            // 'i' now points to the last non-digit character
            string prefix = input.Substring(0, i + 1);
            string numberPart = input.Substring(i + 1);

            // 3. If no digits were found at the end
            if (string.IsNullOrEmpty(numberPart))
            {
                return input + "_1.txt";
            }

            // 4. Parse the number, increment it, and preserve leading zeros
            if (long.TryParse(numberPart, out long number))
            {
                number++;

                // "D" + length ensures "012" becomes "013" instead of "13"
                return prefix + number.ToString("D" + numberPart.Length) + ".txt";
            }

            return input + "_1.txt";
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filePath = dlg.FileName;
                try
                {
                    var (board, pile) = Loader.LoadFromFile(filePath);
                    List<Card> boardCards = Loader.GetBoradCards();
                    for (int i = 0; i < boardCards.Count; i++)
                    {
                        if (Controls.Find("btnBoard" + (i + 1), true).FirstOrDefault() is Button btn)
                        {
                            btn.Text = boardCards[i].GetRank();
                            btn.Image = GetCardImage(boardCards[i].GetCardType());
                            btn.Tag = boardCards[i].GetRank() + " of " + boardCards[i].GetCardType().ToString();
                        }
                    }
                    for (int i = 23; i >= 0; i--)
                    {
                        if (Controls.Find("btnPile" + (i + 1), true).FirstOrDefault() is Button btn && pile.HasNextCard())
                        {
                            Card card = pile.GetNextCard()!;
                            btn.Text = card.GetRank();
                            btn.Image = GetCardImage(card.GetCardType());
                            btn.Tag = card.GetRank() + " of " + card.GetCardType().ToString();
                        }
                    }
                    Text = $"TriPeaks Solver - {Path.GetFileName(filePath)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                SaveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                SaveFile(filePath);
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SaveFile(dlg.FileName);
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filePath = "";
            Text = $"TriPeaks Solver";
            ClearBoardToolStripMenuItem_Click(sender, e);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ClearBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strImage = "";
            UpdateUndoRedoItems();
            usedCombinations.Clear();
            for (int i = 0; i < 24; i++)
            {
                if (Controls.Find("btnPile" + (i + 1), true).FirstOrDefault() is Button btn)
                {
                    btn.Image = null;
                    btn.Text = "";
                    usedCombinations.Remove(btn.Tag?.ToString() ?? "");
                    btn.Tag = null;
                }
            }
            for (int i = 0; i < 28; i++)
            {
                if (Controls.Find("btnBoard" + (i + 1), true).FirstOrDefault() is Button btn)
                {
                    btn.Image = null;
                    btn.Text = "";
                    usedCombinations.Remove(btn.Tag?.ToString() ?? "");
                    btn.Tag = null;
                }
            }
        }

        private void AutoFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    string rank = GetRank(i + 1);
                    string suit = j switch
                    {
                        0 => "Club",
                        1 => "Diamond",
                        2 => "Heart",
                        3 => "Spade",
                        _ => ""
                    };
                    string combination = rank + " of " + suit;
                    if (!usedCombinations.ContainsKey(combination))
                    {
                        // Find the next available button
                        for (int k = 0; k < 28; k++)
                        {
                            if (Controls.Find("btnBoard" + (k + 1), true).FirstOrDefault() is Button btn)
                            {
                                if (btn.Tag == null || btn.Tag.ToString() == " of None")
                                {
                                    btn.Text = rank;
                                    btn.Image = suit switch
                                    {
                                        "Club" => btnClub.Image,
                                        "Diamond" => btnDiamond.Image,
                                        "Heart" => btnHeart.Image,
                                        "Spade" => btnSpade.Image,
                                        _ => null
                                    };
                                    btn.Tag = combination;
                                    usedCombinations.Add(combination, btn);
                                    UpdateUndoRedoItems();
                                    break;
                                }
                            }
                        }
                    }
                    if (!usedCombinations.ContainsKey(combination))
                    {
                        // Find the next available button
                        for (int k = 0; k < 24; k++)
                        {
                            if (Controls.Find("btnPile" + (k + 1), true).FirstOrDefault() is Button btn)
                            {
                                if (btn.Tag == null || btn.Tag.ToString() == " of None")
                                {
                                    btn.Text = rank;
                                    btn.Image = suit switch
                                    {
                                        "Club" => btnClub.Image,
                                        "Diamond" => btnDiamond.Image,
                                        "Heart" => btnHeart.Image,
                                        "Spade" => btnSpade.Image,
                                        _ => null
                                    };
                                    btn.Tag = combination;
                                    usedCombinations.Add(combination, btn);
                                    UpdateUndoRedoItems();
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Generate()
        {
            int btnNumber = 0;
            List<int> boardCardCounts = [3, 6, 9, 10];
            string text = "Pile:\n";
            // Generate Pile
            for (int i = 0; i < 24; i++)
            {
                if (Controls.Find("btnPile" + (i + 1), true).FirstOrDefault() is Button btn && btn.Tag != null)
                {
                    if (btn.Tag.ToString() == " of None")
                    {
                        MessageBox.Show("Please assign all pile cards.");
                        return;
                    }
                    else
                    {
                        text += btn.Tag.ToString() + ", ";
                    }
                }
                else
                {
                    MessageBox.Show("Please assign all pile cards.");
                    return;
                }
            }
            text += "\n\nBoard:\n";
            // Generate Board
            for (int row = 0; row < boardCardCounts.Count; row++)
            {
                for (int col = 0; col < boardCardCounts[row]; col++)
                {
                    btnNumber++;
                    if (Controls.Find("btnBoard" + btnNumber, true).FirstOrDefault() is Button btn && btn.Tag != null)
                    {
                        if (btn.Tag.ToString() == " of None")
                        {
                            MessageBox.Show("Please assign all pile cards.");
                            return;
                        }
                        else
                        {
                            text += btn.Tag.ToString() + "  ";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please assign all board cards.");
                        return;
                    }
                }
                text += "\n";
            }

            try
            {
                var filePath1 = filePath.Replace(".txt", "") + ".html";
                var (board, pile) = Loader.LoadFromText(text); // Loader.LoadFromFile(filePath); // Loader.LoadDummy(); // 
                var solution = board.GetSolveOrder(pile);
                File.WriteAllText(filePath, text);
                File.WriteAllText(filePath1, Board.GetString(solution ?? []));
                Text = $"TriPeaks Solver - {Path.GetFileName(filePath)}";
                try
                {
                    //open the generated HTML file
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = filePath1,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Puzzle solved successfully. Could not open the generated file: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void SaveFile(string filePath)
        {
            int btnNumber = 0;
            List<int> boardCardCounts = [3, 6, 9, 10];
            string text = "Pile:\n";
            // Generate Pile
            for (int i = 0; i < 24; i++)
            {
                if (Controls.Find("btnPile" + (i + 1), true).FirstOrDefault() is Button btn && btn.Tag != null)
                {
                    if (btn.Tag.ToString() == " of None")
                    {
                        text += "null, ";
                    }
                    else
                    {
                        text += btn.Tag.ToString() + ", ";
                    }
                }
                else
                {
                    text += "null, ";
                }
            }
            text += "\n\nBoard:\n";
            // Generate Board
            for (int row = 0; row < boardCardCounts.Count; row++)
            {
                for (int col = 0; col < boardCardCounts[row]; col++)
                {
                    btnNumber++;
                    if (Controls.Find("btnBoard" + btnNumber, true).FirstOrDefault() is Button btn && btn.Tag != null)
                    {
                        if (btn.Tag.ToString() == " of None")
                        {
                            text += "null  ";
                        }
                        else
                        {
                            text += btn.Tag.ToString() + "  ";
                        }
                    }
                    else
                    {
                        text += "null  ";
                    }
                }
                text += "\n";
            }

            try
            {
                File.WriteAllText(filePath, text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private static string GetRank(int value)
        {
            return value switch
            {
                1 => "A",
                11 => "J",
                12 => "Q",
                13 => "K",
                _ => value.ToString(),
            };
        }

        private System.Drawing.Image? GetCardImage(CardType type)
        {
            return type switch
            {
                CardType.Club => btnClub.Image,
                CardType.Diamond => btnDiamond.Image,
                CardType.Heart => btnHeart.Image,
                CardType.Spade => btnSpade.Image,
                _ => null,
            };
        }

        private void UpdateUndoRedoItems()
        {
            historyUndo.Add(new Dictionary<string, Button>(lastCombinations));
            lastCombinations = new Dictionary<string, Button>(usedCombinations);
            historyRedo.Clear();
            historyRedo.Add(new Dictionary<string, Button>(lastCombinations));
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TriPeaks Solver\nVersion 1.0\n\nCreated by\nObinna Chikwendu");
        }
    }
}
