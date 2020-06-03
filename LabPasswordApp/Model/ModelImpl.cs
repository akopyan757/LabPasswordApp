using LabPasswordApp.Model.Base;
using LabPasswordApp.Model.Data;
using System;
using System.Text;

namespace LabPasswordApp.Model
{
    public class ModelImpl : IModel
    {
        public UserData Login(string username, string password)
        {
            if (String.Equals(username, "albert") && String.Equals(password, "akopyan"))
            {
                return new UserData() {
                    Username = Encoding.ASCII.GetBytes("albert"),
                    Password = Encoding.ASCII.GetBytes("akopyan"),
                    IsAdmin = true,
                    IsBlocked = false,
                    IsActivePasswordRules = true
                };
            }
            else
            {
                throw new Exception("Пользователь не найден!");
            }
        }
    }
}
