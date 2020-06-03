using LabPasswordApp.View.Base;
using LabPasswordApp.Model.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPasswordApp.Presenter.Base
{
    abstract class Presenter<View, Model> 
        where View : IView
        where Model : IModel
    {
        protected readonly View _view;
        protected readonly Model _model;

        public Presenter(View view, Model model)
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
