using LabPasswordApp.Model;
using LabPasswordApp.Model.Base;
using LabPasswordApp.Presenter.Base;
using LabPasswordApp.View.Base;
using System;

namespace LabPasswordApp.Presenter
{
    class LoginPresenter : BasePresenter<ILoginView, ILoginModel>
    {
        public LoginPresenter(ILoginView view, ILoginModel model) : base(view, model)
        {
            _view.Login += () => Login();
        }

        /**
         * Метод авторизации пользователя
         */
        void Login()
        {
            if (String.IsNullOrEmpty(_view.Username))
            {
                _view.ShowError("Введите имя пользователя!");
                return;
            }

            if (String.IsNullOrEmpty(_view.Password))
            {
                _view.ShowError("Введите пароль!");
                return;
            } 
            
            try
            {
                var user = _model.Login(_view.Username, _view.Password);
                
            }
            catch (Exception exception)
            {
                _view.ShowError(exception.Message);
            }
             
        }
            
    }
}
