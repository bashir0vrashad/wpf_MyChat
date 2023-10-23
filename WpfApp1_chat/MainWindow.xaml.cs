using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1_chat
{

    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<Chat> _chats;

        public ObservableCollection<Chat> chats { get; set; }
       
         
        public MainWindow()
        {
            InitializeComponent();
            chats = new ObservableCollection<Chat>();
            DataContext = this;
        }
       

        public event PropertyChangedEventHandler? PropertyChanged;

        private void send_button(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(text.Text)) 
            {
               
                chats.Add(new Chat(text.Text,DateTime.Now));
             
            }
            text.Text = "";
        }
      
    }
}
