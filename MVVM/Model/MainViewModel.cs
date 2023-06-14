using ChatAppWithWPF.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppWithWPF.MVVM.Model
{
    internal class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        /* Commands */
        public RelayCommand SendCommand { get; set; }

        private ContactModel _selectedContact;
        public ContactModel SelectedContact 
        { 
            get => _selectedContact;
            set 
            { 
                _selectedContact = value;
                OnPropertyChanged();
            }
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();
            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel()
                {
                    Message = Message,
                    FirstMessage = false

                });
                Message = "";
            });

            Messages.Add(new MessageModel
            {
                UserName = "Batman",
                UserNameColor = "#44496f",
                ImageSource = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/5ae5d7c2-dc1f-488d-b323-5c538d95f8cf/dcrjz7r-793ec899-7ec1-4f64-9e17-01d80a2d6c66.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzVhZTVkN2MyLWRjMWYtNDg4ZC1iMzIzLTVjNTM4ZDk1ZjhjZlwvZGNyano3ci03OTNlYzg5OS03ZWMxLTRmNjQtOWUxNy0wMWQ4MGEyZDZjNjYuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.39kErI5nq_HlYaFD5YjfB1pJjNNjBbQ-VLlTOwy9aPM",
                Message = "I am Batman",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });
            Messages.Add(new MessageModel
            {
                UserName = "Joker",
                UserNameColor = "#44496f",
                ImageSource = "https://i.pinimg.com/736x/33/68/05/3368057c8f532a8042365e6267a6ebc9--the-joker-colors.jpg",
                Message = "Hi Batsy!",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = false
            });

            Contacts.Add(new ContactModel
            {
                UserName = "Batman",
                ImageSource = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/5ae5d7c2-dc1f-488d-b323-5c538d95f8cf/dcrjz7r-793ec899-7ec1-4f64-9e17-01d80a2d6c66.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzVhZTVkN2MyLWRjMWYtNDg4ZC1iMzIzLTVjNTM4ZDk1ZjhjZlwvZGNyano3ci03OTNlYzg5OS03ZWMxLTRmNjQtOWUxNy0wMWQ4MGEyZDZjNjYuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.39kErI5nq_HlYaFD5YjfB1pJjNNjBbQ-VLlTOwy9aPM",
                Messages = Messages
            });
            Contacts.Add(new ContactModel
            {
                UserName = "Joker",
                ImageSource = "https://i.pinimg.com/736x/33/68/05/3368057c8f532a8042365e6267a6ebc9--the-joker-colors.jpg",
                Messages = Messages
            });
        }
    }
}
