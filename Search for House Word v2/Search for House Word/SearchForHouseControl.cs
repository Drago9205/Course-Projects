using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

namespace Search_for_House_Word
{
    public partial class SearchForHouseControl : UserControl
    {
        public SearchForHouseControl()
        {
            InitializeComponent();
        }

        private void searchHouseButton_Click(object sender, EventArgs e)
        {

            SearchHouseThreadedMethod();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenDialogMethod(openFileDialog1, inputBox);
        }

        public void SearchHouseThreadedMethod()
        {
            Task alabala = Task.Factory.StartNew(()=>SearchHouse());
            //ThreadPool.QueueUserWorkItem(new WaitCallback(SearchHouse));
        }

        //Here is the Method that is being executed on searchHouseButton_click
        private void SearchHouse()//object a)
        {
            this.Enabled = false;
            sb.Clear();
            sb.Insert(sb.Length, "The word house appeared at positions: ");
            SetDefaultResults();
            IndexFinder indF = new IndexFinder(this.inputBox.Text);
            indF.WordFoundEvent += ResultsInput;
            indF.FindAllIndexes(this.inputBox.Text, "house");
            this.Enabled = true;
            //Calls an event when the local progress bars are done/full
            EventArgs parasiteArgs = null;
            longResultBox.Text = sb.ToString();
            //unsubscribes so that on second button press we dont stack the labes and textboxes with += text
            indF.WordFoundEvent -= ResultsInput;
            OnProgressBarUpdated(parasiteArgs);
        }

        //Here are some default sets for the StatusLabel and the HowManyHouses textbox, 
        private void SetDefaultResults()
        {
            wordSearchProgress.Value = 0;
            MatchCollection matches = Regex.Matches(inputBox.Text, "house");
            wordSearchProgress.Maximum = matches.Count;
            longResultBox.Text = sb.ToString();
            count = 0;
            howManyHouses.Text = count.ToString();
        }

        //Also a ResultsInput method that manipulates the StatusLabel and the HowManyHouses textbox when the event occurs.
        private void ResultsInput(IndexFinder.IndexVariableReachedEvent e)
        {
                wordSearchProgress.Value++;
                resultStatusLabel.Text = "The word house appeared last at position: " + e.Index;
                sb.Insert(sb.Length, " " + e.Index);
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
        StringBuilder sb = new StringBuilder();

        //Delegate and event that anounce when local progress bar is finished loading this is being subscribed to in Form3 class in checkAll_Click method
        public delegate void ProgressBarUpdatedHandler(EventArgs e);
        public event ProgressBarUpdatedHandler ProgressBarUpdatedEvent;
        protected void OnProgressBarUpdated(EventArgs e)
        {
            if (ProgressBarUpdatedEvent != null)
                ProgressBarUpdatedEvent(e);
        }

        public void ClearSubscribers()
        {
            ProgressBarUpdatedEvent = (ProgressBarUpdatedHandler)Delegate.RemoveAll(ProgressBarUpdatedEvent, ProgressBarUpdatedEvent);// Then you will find ProgressBarUpdatedEvent is set to null.
        }

        //Making the Method that is being executed on searchHouseButton_click be executed on a particular keypress: the "S" key
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.S))
            {
                Task alabala = Task.Factory.StartNew(() => SearchHouse());
                //ThreadPool.QueueUserWorkItem(new WaitCallback(SearchHouse));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }        
    }
}
