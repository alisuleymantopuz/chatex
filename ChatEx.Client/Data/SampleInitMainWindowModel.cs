using ChatEx.Client.Models;
using ChatEx.Client.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ChatEx.Client.Data
{
    public class SampleInitMainWindowModel : ViewModelBase
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Participant> _participants = new ObservableCollection<Participant>();
        public ObservableCollection<Participant> Participants
        {
            get { return _participants; }
            set
            {
                _participants = value;
                OnPropertyChanged();
            }
        }

        private Participant _selectedParticipant;
        public Participant SelectedParticipant
        {
            get { return _selectedParticipant; }
            set
            {
                _selectedParticipant = value;
                if (SelectedParticipant.HasSentNewMessage) SelectedParticipant.HasSentNewMessage = false;
                OnPropertyChanged();
            }
        }

        public SampleInitMainWindowModel()
        {
            ObservableCollection<ChatMessage> someChatter = new ObservableCollection<ChatMessage>();

            someChatter.Add(new ChatMessage
            {
                Author = "Naci",
                Message = "Lorem ipsum dolor sit amet 1?",
                Time = DateTime.Now,
                IsOriginNative = true
            });
            someChatter.Add(new ChatMessage
            {
                Author = "Naci",
                Message = "Lorem ipsum dolor sit amet 2?",
                Time = DateTime.Now,
                IsOriginNative = true
            });
            someChatter.Add(new ChatMessage
            {
                Author = "Niyazi",
                Message = "Lorem ipsum dolor sit amet 3",
                Time = DateTime.Now
            });
            someChatter.Add(new ChatMessage
            {
                Author = "Naci",
                Message = "I'm rich. That's my superpower.",
                Time = DateTime.Now,
                IsOriginNative = true
            });
            someChatter.Add(new ChatMessage
            {
                Author = "Niyazi",
                Message = ":D Lorem Ipsum something blah blah blah blah blah blah blah blah. Lorem Ipsum something blah blah blah blah.",
                Time = DateTime.Now
            });
            someChatter.Add(new ChatMessage
            {
                Author = "Naci",
                Message = "I have no feelings",
                Time = DateTime.Now,
                IsOriginNative = true
            });
            someChatter.Add(new ChatMessage
            {
                Author = "Naci",
                Message = "How's Martha?",
                Time = DateTime.Now,
                IsOriginNative = true
            });

            Participants.Add(new Participant { Name = "Niyazi", Chatter = someChatter, IsTyping = true, IsLoggedIn = true });
            Participants.Add(new Participant { Name = "Sahika", Chatter = someChatter, IsLoggedIn = false });
            Participants.Add(new Participant { Name = "Sahin", Chatter = someChatter, HasSentNewMessage = true });
            Participants.Add(new Participant { Name = "Rustu", Chatter = someChatter, HasSentNewMessage = true });
            Participants.Add(new Participant { Name = "Sukru", Chatter = someChatter, IsTyping = true });

            SelectedParticipant = Participants.First();
        }
    }
}
