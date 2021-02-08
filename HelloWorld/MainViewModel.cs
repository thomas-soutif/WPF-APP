using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class MainViewModel : BaseViewModel
    {

        public string MaChaine
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value); }
        }

        public int MonEntier
        {
            get { return GetProperty<int>(); }
            set { SetProperty(value); }
        }

        public ObservableCollection<string> MaListe
        {
            get => GetProperty<ObservableCollection<string>>();
            set => SetProperty(value);
        }

        public ObservableCollection<ObjetComplexe> MesObjetsComplexes
        {
            get => GetProperty<ObservableCollection<ObjetComplexe>>();
            set => SetProperty(value);
        }

        public string MaChaineSelectionnee
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
        public ObjetComplexe MonObjetComplexeSelectionnee
        {
            get => GetProperty<ObjetComplexe>();
            set => SetProperty(value);
        }

        public MainViewModel() : base()
        {
            MaListe = new ObservableCollection<string>();
            MesObjetsComplexes = new ObservableCollection<ObjetComplexe>();
        }
    }

}
