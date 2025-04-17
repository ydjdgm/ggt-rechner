namespace ggt
{
    internal interface IView
    {
        public IModel model { set; }
        public IController controller { set; }
        void anzeigen(int ggt);
    }
}