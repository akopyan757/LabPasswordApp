using LabPasswordApp._view.Base;
using LabPasswordApp.Model.Base;
using LabPasswordApp.Presenter.Common;

namespace LabPasswordApp.Presenter.Base
{
    abstract class BasePresenter<View> : IPresenter where View : IView
    {
        protected readonly View _view;
        protected readonly IModel _model;
        protected readonly IApplicationController _controller;

        public BasePresenter(IApplicationController controller, View view, IModel model)
        {
            _view = view;
            _model = model;
            _controller = controller;
        }

        public void Run()
        {
            _view.Show();
        }
    }


    abstract class BasePresenter<View, Arg> : IPresenter<Arg> 
        where View : IView
    {
        protected readonly View _view;
        protected readonly IModel _model;
        protected readonly IApplicationController _controller;

        public BasePresenter(IApplicationController controller, View view, IModel model)
        {
            _view = view;
            _model = model;
            _controller = controller;
        }

        public abstract void Run(Arg argument);
    }
}
