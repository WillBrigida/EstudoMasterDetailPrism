using EstudoMasterDetail.ViewModels;
using EstudoMasterDetail.Views;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EstudoMasterDetail
{
    public partial class App : PrismApplication
    {
        public App()
            : this(null)
        {

        }

        public App(IPlatformInitializer initializer)
            : this(initializer, true)
        {

        }

        public App(IPlatformInitializer initializer, bool setFormsDependencyResolver)
            : base(initializer, setFormsDependencyResolver)
        {

        }


        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"/MenuPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MyNavigationPage>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainViewModel>();
            containerRegistry.RegisterForNavigation<MenuPage, MenuViewModel>();
            containerRegistry.RegisterForNavigation<SegundaPage, SegundaViewModel>();
            containerRegistry.RegisterForNavigation<TerceiraPage, TerceiraViewModel>();
        }
    }
}
