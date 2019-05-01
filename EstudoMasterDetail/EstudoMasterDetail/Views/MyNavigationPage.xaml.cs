using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EstudoMasterDetail.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyNavigationPage : NavigationPage, INavigationPageOptions, IDestructible
    {
        public MyNavigationPage()
        {
            InitializeComponent();
        }

        public bool ClearNavigationStackOnNavigation
        {
            get { return true; }
        }

        public void Destroy()
        {
        }
    }
}