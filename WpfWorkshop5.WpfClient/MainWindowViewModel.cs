using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfWorkshop5.Logic;

namespace WpfWorkshop5.WpfClient
{
    public class MainWindowViewModel : ObservableRecipient
    {
        public RestCollection<Message> Messages { get; set; }

        private string message;

        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }

        private string sender;

        public string Sender
        {
            get { return sender; }
            set { SetProperty(ref sender, value); }
        }


        public ICommand SendChatCommand { get; set; }

        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }

        public MainWindowViewModel()
        {
            if (!IsInDesignMode)
            {
                Messages = new RestCollection<Message>("https://localhost:7281/", "message");
                SendChatCommand = new RelayCommand(
                    () => Messages.Add(new Message(Message, DateTime.Now, Sender))
                    );
            }
        }
    }
}
