using Luminnus.SIGEP.App.Helper;
using Luminnus.SIGEP.Model;

namespace Luminnus.SIGEP.App
{
    internal class Program : ProgramBase
    {
        static ISIGEP sIGEP;

        static async Task Main(string[] args)
        {
            try
            {
                sIGEP = ConfigureService();

                var json = string.Join(string.Empty, args) ?? string.Empty;
                var model = json.TryDeserializeObject<ModelSIGEP>();
                var response = await ExecuteMethodRequest(json, model.Metodo);

                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(CustomResponse(ex.Message, true));
            }
            finally
            {
                Environment.Exit(0);
            }
        }

        static async Task<string> ExecuteMethodRequest(string json, Metodos metodo)
        {
            dynamic? request;

            switch (metodo)
            {
                case Metodos.SolicitarPostagemReversa:
                    request = json.TryDeserializeObject<SolicitarPostagemReversaRequest>();
                    return await sIGEP.SolicitarPostagemReversa(request);

                case Metodos.AcompanharPedido:
                    request = json.TryDeserializeObject<AcompanharPedidoRequest>();
                    return await sIGEP.AcompanharPedido(request);

                case Metodos.SobreWebService:
                    request = json.TryDeserializeObject<SobreWebServiceRequest>();
                    return await sIGEP.SobreWebService(request);

                default:
                    throw new Exception("Método não encontrado.");
            }
        }
    }
}