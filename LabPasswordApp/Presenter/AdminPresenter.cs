using LabPasswordApp.Model.Base;
using LabPasswordApp.Presenter.Base;
using LabPasswordApp.Presenter.Common;
using LabPasswordApp._view.Base;

namespace LabPasswordApp.Presenter
{
    class AdminPresenter : BasePresenter<IAdminView>
    {
        public AdminPresenter(IApplicationController controller, IAdminView view, IModel model) : base(controller, view, model)
        {
        }

        public new void Run()
        {
            _view.Show();
        }
    }
}
