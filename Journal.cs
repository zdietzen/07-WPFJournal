using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace _07_WPFJournal
{
    public class Journal
    {
        public Journal(string title)
        {
            Title = title;
            Entries = new ObservableCollection<JournalEntry>();
        }
        public string Title { get; private set; }
        public ObservableCollection<JournalEntry> Entries { get; set; }
    }
}