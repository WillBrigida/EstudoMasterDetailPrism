using EstudoMasterDetail.Behaviors;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EstudoMasterDetail.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public ObservableCollection<Behaviors.MenuItem> ListaMenu { get; set; }
        private DelegateCommand<Behaviors.MenuItem> _navigationCommand;
        public DelegateCommand<Behaviors.MenuItem> NavigationCommand => _navigationCommand ??
            (_navigationCommand = new DelegateCommand<Behaviors.MenuItem>(async (menu) => await OnNavigacaoMenu(menu), (menu) => !IsBusy));


        public MenuViewModel(INavigationService navigationService,
                IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            ListaMenu = new ObservableCollection<Behaviors.MenuItem>
            {
                new Behaviors.MenuItem (FontAwesome.Building, "Portaria", "#49a4aa"),
                new Behaviors.MenuItem (FontAwesome.Briefcase,  "Reparos / Obras", "#e1c27f"),
                new Behaviors.MenuItem (FontAwesome.Calculator,  "Balancetes", "#000000"),
            };
        }

        private async Task OnNavigacaoMenu(Behaviors.MenuItem menu)
        {
            switch (menu.Titulo)
            {
                case "Portaria":
                    await NavigationService.NavigateAsync("SegundaPage");
                    break;
                case "Reparos":
                    await NavigationService.NavigateAsync("TerceiraPage");
                    break;
                case "Avisos":
                    await NavigationService.NavigateAsync("MainPage");
                    break;
            }

        }
    }
}
