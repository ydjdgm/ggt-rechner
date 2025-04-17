using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ggt
{
    internal class Model:IModel
    {
        private IView view;
        private IController controller;

        public Model()
        {

        }

        public IView View { set => view = value; }
        public IController Controller { set => controller = value; }
    }
}
