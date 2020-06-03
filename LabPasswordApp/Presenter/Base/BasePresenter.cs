using LabPasswordApp.View.Base;
using LabPasswordApp.Model.Base;
using LabPasswordApp.Presenter.Common;

namespace LabPasswordApp.Presenter.Base
{
    abstract class BasePresenter<View, Model> : IPresenter
        where View : IView
        where Model : IModel
    {
        protected readonly View _view;
        protected readonly Model _model;

        public BasePresenter(View view, Model model)
        {
            _view = view;
            _model = model;
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
