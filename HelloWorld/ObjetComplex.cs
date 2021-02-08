using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class ObjetComplexe : BaseViewModel
    {
        public string Titre
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
        public string Description
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        public override string ToString()
        {
            return Titre + " - " + Description;
        }
        


    }
}
