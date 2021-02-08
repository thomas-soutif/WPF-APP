using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel vm;
       
        public MainWindow()
        {
            vm = new MainViewModel();
            vm.MaChaine = "Bonjour";
            for (int i = 1; i <= 5; i++)
                vm.MaListe.Add($"Chaine n°{i}");
            
            for (int i = 1; i <= 5; i++)
            {
                vm.MesObjetsComplexes.Add(new ObjetComplexe()
                {
                    Titre = "Titre n°" + i,
                    Description = "Description n°" + i
                });
            }
                
            this.DataContext = vm;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.MaChaine = "Un autre texte";
        }

        private void Ajouter_Chaine(object sender, RoutedEventArgs e)
        {
            vm.MaListe.Add($"Chaine n°{vm.MaListe.Count + 1}");
        }

        private void Supprimer_Chaine(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(vm.MaChaineSelectionnee))
                vm.MaListe.Remove(vm.MaChaineSelectionnee);
        }
    }
}
