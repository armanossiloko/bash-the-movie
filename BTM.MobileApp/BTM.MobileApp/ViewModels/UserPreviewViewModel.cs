using BTM.Models;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BTM.MobileApp.ViewModels
{
    public class UserPreviewViewModel : INotifyPropertyChanged
    {
        public int Id { get; set; }
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        private string _middleName;
        public string MiddleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                if (_middleName != value)
                {
                    _middleName = value;
                    OnPropertyChanged("MiddleName");
                }
            }
        }

        public string _lastName { get; set; }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged("Username");
                }
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        private string _avatar;
        public string Avatar
        {
            get
            {
                return _avatar;
            }
            set
            {
                if (_avatar != value)
                {
                    _avatar = value;
                    OnPropertyChanged("Avatar");
                }
            }
        }

        private DateTime _birthdate;
        public DateTime DateOfBirth
        {
            get
            {
                return _birthdate;
            }
            set
            {
                if (_birthdate != value)
                {
                    _birthdate = value;
                    OnPropertyChanged("DateOfBirth");
                }
            }
        }

        private DateTime _joinDate;
        public DateTime JoinDate
        {
            get
            {
                return _joinDate;
            }
            set
            {
                if (_joinDate != value)
                {
                    _joinDate = value;
                    OnPropertyChanged("JoinDate");
                }
            }
        }

        public UserPreviewViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async Task Init()
        {
            var user = await $"{APIService._apiUrl}/Users/userid/{APIService.Username}".GetJsonAsync<User>();
            Id = user.Id;
            Username = user.Username;
            LastName = user.LastName;
            MiddleName = user.MiddleName;
            FirstName = user.FirstName;
            Email = user.Email;
            Avatar = $"{APIService._apiUrl}/Users/avatars/{Id}";
            DateOfBirth = user.DateOfBirth;
            JoinDate = user.JoinDate;
        }
    }
}
