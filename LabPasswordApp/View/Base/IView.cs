using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPasswordApp.View.Base
{
    interface IView
    {
        void Show();
        void Close();
        void ShowError(string messageError);
    }
}
