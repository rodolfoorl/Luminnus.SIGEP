namespace Luminnus.SIGEP.Model
{
    public class ModelSIGEP
    {
        public string CodAdministrativo { get; set; }
        public string Codigo_Servico { get; set; }
        public string Cartao { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public Metodos Metodo { get; set; }
        public Ambientes Ambiente { get; set; }
    }

    public enum Ambientes
    {
        Homologacao,
        Producao
    }

    public enum Metodos
    {
        AcompanharPedido,
        AcompanharPedidoPorData,
        CalcularDigitoVerificador,
        CancelarPedido,
        ConsultarResumoColeta,
        RevalidarPrazoAutorizacaoPostagem,
        SobreWebService,
        SolicitarPostagemReversa,
        SolicitarPostagemSimultanea,
        SolicitarRange,
        ValidarPostagemReversa,
        ValidarPostagemSimultanea
    }
}
