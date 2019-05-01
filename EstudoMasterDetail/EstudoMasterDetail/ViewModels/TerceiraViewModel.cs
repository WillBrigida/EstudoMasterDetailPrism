using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoMasterDetail.ViewModels
{
    class TerceiraViewModel : BaseViewModel
    {
        public TerceiraViewModel(INavigationService navigationService,
                IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            this.Title = "Terceira Page";
            pageDialogService.DisplayAlertAsync("", "Teste realizado com sucesso", "ok");
        }

    }
}
