using LabPasswordApp.Model;
using LabPasswordApp.Model.Base;
using LabPasswordApp.Presenter;
using LabPasswordApp.Presenter.Common;
using LabPasswordApp.View.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                 .RegisterService<ILoginModel, LoginModel>()
                 .RegisterInstance(new ApplicationContext());

            controller.Run<LoginPresenter>();
        }
    }
}
