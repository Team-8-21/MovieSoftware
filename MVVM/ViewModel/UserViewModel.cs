using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSoftware.MVVM.Model.Classes;
using MovieSoftware.MVVM.Model.Repositories;
using MovieSoftware.Parent_classes;

namespace MovieSoftware.MVVM.ViewModel
{
    public class UserViewModel : ViewModelBasic
    {
        //Arbejder vi med CSV, så skal det ændres fx clients.csv
        private readonly IUserRepository userRepository = new FileUserRepository("clients.txt");

        public ObservableCollection<User> Users { get; }
        public ICollectionView UsersCollectionView {get;}

        private string name;
        public string Name { get => name; set { name = value; OnPropertyChanged(); } }

    }
}
