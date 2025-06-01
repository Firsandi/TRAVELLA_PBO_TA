using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRAVELLA_PBO_TA.Models;
using TRAVELLA_PBO_TA.Interfaces;


namespace TRAVELLA_PBO_TA.Presenters
{
    internal class UserPresenter
    {
        private IUserView _view;

        public UserPresenter(IUserView view)
        {
            _view = view;
        }

        public void Login(string username, string password)
        {
            bool isValid = UserModels.ValidateUser(username, password);
            _view.ShowLoginResult(isValid);
        }
        public void Register(string nama, string email, string nomorTelepon, string username, string password)
        {
            bool isRegistered = UserModels.RegisterUser(nama, email, nomorTelepon, username, password);
            _view.ShowRegisterResult(isRegistered);
        }

    }
}
