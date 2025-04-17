namespace ggt
{
    internal interface IModel
    {
        IView View { set; }
        IController Controller { set; }
    }
}