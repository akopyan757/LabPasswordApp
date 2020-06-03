using LabPasswordApp.Forms;
using LabPasswordApp.Model;
using LabPasswordApp.Model.Base;
using LabPasswordApp.Presenter;
using LabPasswordApp.Presenter.Common;
using LabPasswordApp._view.Base;
using System;
using System.Windows.Forms;

namespace LabPasswordApp
{
    static class Program
    {

        public static readonly ApplicationContext Context = new ApplicationContext();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new ApplicationController(new LightInjectAdapder())
                 .RegisterView<ILoginView, LoginForm>()
                 .RegisterView<IAdminView, AdminForm>()
                 .RegisterService<IModel, ModelImpl>()
                 .RegisterInstance(new ApplicationContext());

            controller.Run<LoginPresenter>();
        }
    }
}
