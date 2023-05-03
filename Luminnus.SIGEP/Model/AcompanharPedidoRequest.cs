using logisticaReversaService;

namespace Luminnus.SIGEP.Model
{
    public class AcompanharPedidoRequest : ModelSIGEP
    {
        public string TipoBusca { get; set; }
        public string TipoSolicitacao { get; set; }
        public string[] NumeroPedido { get; set; }
    }
}
