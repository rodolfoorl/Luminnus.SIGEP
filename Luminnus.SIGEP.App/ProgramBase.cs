using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Luminnus.SIGEP.App
{
    public class ProgramBase
    {
        protected static string CustomResponse(object model, bool error = false)
        {
            if (error)
            {
                return JsonConvert.SerializeObject(new
                {
                    cod_erro = "0",
                    msg_erro = model
                });
            }
            else
            {
                return JsonConvert.SerializeObject(model);
            }
        }

        protected static ISIGEP ConfigureService()
        {
            var serviceProvider = new ServiceCollection()
                    .AddTransient<ISIGEP, SIGEP>()
                    .BuildServiceProvider();

            return serviceProvider.GetRequiredService<ISIGEP>();
        }
    }
}
