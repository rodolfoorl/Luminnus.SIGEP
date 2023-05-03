using logisticaReversaService;
using Luminnus.SIGEP.Model;
using Newtonsoft.Json;

namespace Luminnus.SIGEP
{
    public class SIGEP : ISIGEP
    {
        public async Task<string> SolicitarPostagemReversa(SolicitarPostagemReversaRequest request)
        {
            using (var client = new logisticaReversaWSClient(request.Ambiente))
            {
                client.ClientCredentials.UserName.UserName = request.Usuario;
                client.ClientCredentials.UserName.Password = request.Senha;

                var response = await client.solicitarPostagemReversaAsync(
                    request.CodAdministrativo,
                    request.Codigo_Servico,
                    request.Cartao,
                    request.Destinatario,
                    request.Coletas_Solicitadas);

                return JsonConvert.SerializeObject(response.solicitarPostagemReversa);
            }
        }

        public async Task<string> AcompanharPedido(AcompanharPedidoRequest request)
        {
            using (var client = new logisticaReversaWSClient(request.Ambiente))
            {
                client.ClientCredentials.UserName.UserName = request.Usuario;
                client.ClientCredentials.UserName.Password = request.Senha;

                var response = await client.acompanharPedidoAsync(
                    request.CodAdministrativo,
                    request.TipoBusca,
                    request.TipoSolicitacao,
                    request.NumeroPedido);

                return JsonConvert.SerializeObject(response.acompanharPedido);
            }
        }

        public async Task<string> SobreWebService(SobreWebServiceRequest request)
        {
            using (var client = new logisticaReversaWSClient(request.Ambiente))
            {
                client.ClientCredentials.UserName.UserName = request.Usuario;
                client.ClientCredentials.UserName.Password = request.Senha;

                var response = await client.sobreWebServiceAsync();

                return JsonConvert.SerializeObject(response.sobreWebService);
            }
        }
    }
}