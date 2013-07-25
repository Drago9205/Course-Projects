using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_for_House_Word
{
    public partial class searchHouse : Form
    {
        public searchHouse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeNewTab();
        }

        private void removeTab_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                //SearchForHouseControl terminateControl = (SearchForHouseControl)tabControl1.SelectedTab.Controls[0];
            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message + "\nYou have 0 tabs! You cannot remove any.");
            }
        }

        private void checkAll_Click(object sender, EventArgs e)
        {
            this.checkAll.Enabled = false;
            globalProgress.Value = 0;
            globalProgress.Minimum = 0;
            globalProgress.Maximum = tabControl1.TabPages.Count;
            for(int i=0; i<tabControl1.TabPages.Count; i++)
            {
                SearchForHouseControl currentContro = (SearchForHouseControl)tabControl1.Controls[i].Controls[0];
                //clears subscribers from previous iterations on previous button clicks
                currentContro.ClearSubscribers();
                //subscribe to event that anounces ready local progress bars
                currentContro.ProgressBarUpdatedEvent += UpdateGlobalProgress;
                currentContro.SearchHouseThreadedMethod();
            }
        }

        //Method that sets the properties for a new tab and it's user controls
        private void InitializeNewTab()
        {
            string title = "TabPage " + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tabControl1.TabPages.Add(myTabPage);
            SearchForHouseControl shc = new SearchForHouseControl();
            shc.Dock = DockStyle.Fill;
            myTabPage.Controls.Add(shc);
        }

        private void UpdateGlobalProgress(EventArgs e)
        {
            globalProgress.Value ++;
            if (globalProgress.Value == globalProgress.Maximum)
            this.checkAll.Enabled = true;
        }
    }
}
