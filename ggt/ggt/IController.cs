namespace ggt
{
    internal interface IController
    {
        IController controller { set; }
        IView view { set; }
        void gGTBestimmen(int zahl1, int zahl2);
    }
}