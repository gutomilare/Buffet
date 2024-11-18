using Buffet.Models;

namespace Buffet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Home());
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 700;

            return window;
        }

        public List<Salao> lista_salao = new List<Salao>
        {
            new Salao()
            {
                Descricao = "Salão Memories",
            },
            new Salao()
            {
                Descricao = "Salão Origin",
            },
            new Salao()
            {
                Descricao = "Salão Essence",
            }
        };


    }
}
