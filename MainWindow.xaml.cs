using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _07_WPFJournal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Journal currentJournal;
        public MainWindow()
        {
            InitializeComponent();
            currentJournal = new Journal("My Journal");

            dataGrid_JournalEntries.ItemsSource = currentJournal.Entries;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string title = textBox_Title.Text;
            string entry = textBox_Entry.Text;
            DateTime currentDate = DateTime.Now;

            JournalEntry newEntry = new JournalEntry();
            newEntry.Id = currentJournal.Entries.Count + 1;
            newEntry.Title = title;
            newEntry.Entry = entry;
            newEntry.EntryDate = currentDate;

            currentJournal.Entries.Add(newEntry);

            textBox_Title.Text = textBox_Entry.Text = "";
        }

      



    }
}
