using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRAVELLA_PBO_TA.Models;
using TRAVELLA_PBO_TA.Interfaces;


namespace TRAVELLA_PBO_TA.Presenters
{
    internal class AdminPresenter
    {
        private IAdminView _view;
        public AdminPresenter(IAdminView view)
        {
            _view = view;
        }
        public void Login(string username, string password)
        {
            bool isValid = AdminModels.ValidateAdmin(username, password);
            _view.ShowAdminLoginResult(isValid);
        }
    }
}
