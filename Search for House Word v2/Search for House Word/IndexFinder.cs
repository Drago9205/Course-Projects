using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Search_for_House_Word
{
    class IndexFinder
    {
        //Field that represents the text that we will manipulate
        string textToSearch;

        //Constructor that initializes a searchText for the IndexFinder class
        public IndexFinder(string inputText)
        {
            textToSearch = inputText;
        }

        //Class that inherits eventArgs with a field index that stores the "house" word index on event occurance
        public class IndexVariableReachedEvent : EventArgs
        {
            public int Index { get; set; }
        }
        
        //The method that finds indexes and raises an event
        public void FindAllIndexes(string givenTextToSearchIn, string inputWordPattern)
        {
            int prevIndex = -inputWordPattern.Length; // so we start at index 0
            int index;
            string indexesString = "";
            while ((index = givenTextToSearchIn.IndexOf(inputWordPattern, prevIndex + inputWordPattern.Length)) != -1)
            {
                prevIndex = index;
                indexesString += " " + index;
                IndexVariableReachedEvent indexArgs = new IndexVariableReachedEvent();
                indexArgs.Index = index;
                OnWordFound(indexArgs);
            }
        }

        //Here is the delegate of the event and the event declaration itself, as well as OnWordFound Method that checks for subscribers to the event
        public delegate void WordFoundHandler(IndexVariableReachedEvent e);
        public event WordFoundHandler WordFoundEvent;
        protected void OnWordFound(IndexVariableReachedEvent e)
        {
            if(WordFoundEvent != null)
                WordFoundEvent(e);  
        }
    }
}
