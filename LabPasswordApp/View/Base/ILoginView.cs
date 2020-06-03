using LabPasswordApp.Presenter.Common;
using System;

namespace LabPasswordApp._view.Base
{
    public interface ILoginView : IView
    {
        string Username { get; }
        string Password { get; }
        event Action Login;
    }
}
