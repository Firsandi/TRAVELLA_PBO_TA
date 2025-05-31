using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAVELLA_PBO_TA.Interfaces
{
    public interface IUserView
    {
        void ShowLoginResult(bool success);  // Menampilkan hasil login
        void ShowRegisterResult(bool success);  // Menampilkan hasil registrasi
    }
}
