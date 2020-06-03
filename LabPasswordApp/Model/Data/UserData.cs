using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPasswordApp.Model.Data
{
    public struct UserData
    {
        public byte[] Username;
        public byte[] Password;
        public bool IsAdmin;
        public bool IsBlocked;
        public bool IsActivePasswordRules;
    }
}
