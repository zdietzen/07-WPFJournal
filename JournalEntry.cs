using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_WPFJournal
{
   public class JournalEntry
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public string Title { get; set; }
        public string Entry { get; set; }
    }
}
