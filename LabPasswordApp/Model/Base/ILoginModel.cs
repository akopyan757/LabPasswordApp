using LabPasswordApp.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPasswordApp.Model.Base
{
    interface ILoginModel : IModel
    {
        UserData Login(string usename, string password);
    }
}
