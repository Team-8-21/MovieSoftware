using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSoftware.Models;

namespace MovieSoftware.ViewModels
{
    public class AddMovieViewModel : INotifyPropertyChanged
    {
        private Genre _selectedGenre;

        public ObservableCollection<Genre> Genres { get; }

        public Genre SelectedGenre
        {
            get => _selectedGenre;
            set
            {
                if (_selectedGenre != value)
                {
                    _selectedGenre = value;
                    OnPropertyChanged(nameof(SelectedGenre));
                }
            }
        }

        public AddMovieViewModel()
        {
            Genres = new ObservableCollection<Genre>((Genre[])Enum.GetValues(typeof(Genre)));
            SelectedGenre = Genre.Ukendt;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
