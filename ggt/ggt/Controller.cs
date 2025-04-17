using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ggt
{
    internal class Controller:IController
    {
        private IModel model;
        private IView view;
        public Controller()
        {

        }

        public IController controller { set => controller = value; }
        IView IController.view { set => view = value; }

        public void gGTBestimmen(int zahl1, int zahl2)
        {
            int rest = zahl1 % zahl2;
            if (rest != 0)
            {
                do
                {
                    zahl1 = zahl2;
                    zahl2 = rest;
                    rest = zahl1 % zahl2;
                }while (rest>0);
            }
            view.anzeigen(zahl2);
        }
    }
}
