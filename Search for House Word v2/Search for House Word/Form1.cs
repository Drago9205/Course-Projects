using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Security;

namespace Search_for_House_Word
{
    public partial class searchForHouse : Form
    {
        public searchForHouse()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        void searchHouseButton_Click(object sender, EventArgs e)
        {
            SetDefaultResults();
            IndexFinder indF = new IndexFinder(inputBox.Text);
            indF.WordFoundEvent += ResultsInput;
            indF.FindAllIndexes(inputBox.Text, "house");
            indF.WordFoundEvent -= ResultsInput;
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenDialogMethod(openFileDialog1, inputBox);
        }

        //Here are some default sets for the StatusLabel and the HowManyHouses textbox, 
        private void SetDefaultResults()
        {
            resultStatusLabel.Text = "The word house appeared at positions: ";
            count = 0;
            howManyHouses.Text = count.ToString();
        }

        //Also a ResultsInput method that manipulates the StatusLabel and the HowManyHouses textbox when the event occurs.
        private void ResultsInput(IndexFinder.IndexVariableReachedEvent e)
        {
                resultStatusLabel.Text += " " + e.Index;
                count += 1;
                howManyHouses.Text = count.ToString();
        }

        //Here is a method for opening file dialong with a try/catch block,
        private void OpenDialogMethod(FileDialog fd, TextBox tb)
        {
            try
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    tb.Text = File.ReadAllText(fd.FileName);
                }
            }
            catch (SecurityException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        //Global count variable so that it can be reset to 0 from any method
        int count = 0;
    }
}
