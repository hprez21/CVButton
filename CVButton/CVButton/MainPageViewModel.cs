using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CVButton
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Person> People { get; set; }
        public ICommand ClickedCommand { get; set; }

        public MainPageViewModel()
        {
            People = new ObservableCollection<Person>
            {
                new Person
                {
                    Id = 1,
                    Name = "Héctor"
                },
                new Person
                {
                    Id = 2,
                    Name = "Peter"
                },
                new Person
                {
                    Id = 3,
                    Name = "John"
                }
            };

            ClickedCommand = new Command((data) =>
            {
                var i = data;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
