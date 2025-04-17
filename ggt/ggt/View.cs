namespace ggt
{
    public partial class View : Form, IView
    {
        private IModel model;
        private IController controller;
        public View()
        {
            InitializeComponent();
        }

        IModel IView.model { set => model = value; }
        IController IView.controller { set => controller = value; }

        public void anzeigen(int ggt)
        {

        }

        void IView.anzeigen(int ggt)
        {
            textBoxGGT.Text = ggt.ToString();
        }

        private void buttonGGTBerechnen_Click(object sender, EventArgs e)
        {
            controller.gGTBestimmen(Int32.Parse(textBoxZahl1.Text), Int32.Parse(textBoxZahl2.Text));
        }
    }
}
