using Luminnus.SIGEP.Model;

namespace Luminnus.SIGEP
{
    public interface ISIGEP
    {
        Task<string> AcompanharPedido(AcompanharPedidoRequest request);
        Task<string> SobreWebService(SobreWebServiceRequest request);
        Task<string> SolicitarPostagemReversa(SolicitarPostagemReversaRequest request);
    }
}