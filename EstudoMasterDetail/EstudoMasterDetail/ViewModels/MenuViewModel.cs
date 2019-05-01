using EstudoMasterDetail.Behaviors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EstudoMasterDetail.ViewModels
{
    public class MenuViewModel
    {
        public ObservableCollection<MenuItem> ListaMenu { get; set; }


        public MenuViewModel()
        {
            ListaMenu = new ObservableCollection<MenuItem>
            {
                new MenuItem (FontAwesome.Building, "Portaria", "#49a4aa"),
                new MenuItem (FontAwesome.Briefcase,  "Reparos / Obras", "#e1c27f"),
                new MenuItem (FontAwesome.Calculator,  "Balancetes", "#000000"),
            };
        }
    }
}
