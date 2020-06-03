using LabPasswordApp.Model.Data;

namespace LabPasswordApp.Model.Base
{
    public interface IModel
    {
        UserData Login(string usename, string password);
    }
}
