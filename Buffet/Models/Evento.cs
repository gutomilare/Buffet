using Buffet.Models;

namespace Buffet
{
    public class Evento
    {
        public Evento NomeUsuario { get; set; }

        public string NomeEvento { get; set; }

        public Salao SalaoSelecionado { get; set; }

        public DateTime DataInicio { get; set; }
        
        public DateTime DataFinal { get; set; }

        public int Duracao
        {
            get => (DataFinal - DataInicio).Days;
        }

    }
}
