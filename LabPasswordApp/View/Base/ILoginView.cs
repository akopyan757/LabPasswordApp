using LabPasswordApp.Presenter.Common;
using System;

namespace LabPasswordApp.View.Base
{
    public interface ILoginView : IView
    {
        string Username { get; }
        string Password { get; }
        event Action Login;
    }
}
