using logisticaReversaService;

namespace Luminnus.SIGEP.Model
{
    public class SolicitarPostagemReversaRequest : ModelSIGEP
    {
        public destinatario Destinatario { get; set; }
        public coletaReversa[] Coletas_Solicitadas { get; set; }
    }
}
