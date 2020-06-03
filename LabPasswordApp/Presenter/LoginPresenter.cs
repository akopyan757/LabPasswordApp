using LabPasswordApp.Model.Base;
using LabPasswordApp.Presenter.Base;
using LabPasswordApp.Presenter.Common;
using LabPasswordApp._view.Base;
using System;

namespace LabPasswordApp.Presenter
{
    class LoginPresenter : BasePresenter<ILoginView>
    {
        public LoginPresenter(IApplicationController controller, ILoginView view, IModel model) : base(controller, view, model)
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
                _controller.Run<AdminPresenter>();
                _view.Close();
            }
            catch (Exception exception)
            {
                _view.ShowError(exception.Message);
            }
             
        }
            
    }
}
