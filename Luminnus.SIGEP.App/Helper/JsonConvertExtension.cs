using Newtonsoft.Json;

namespace Luminnus.SIGEP.App.Helper
{
    public static class JsonConvertExtension
    {
        public static T TryDeserializeObject<T>(this string? json)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(json)) throw ThrowExceptionParamInvalid();

                var objJson = JsonConvert.DeserializeObject<T>(json);

                if(objJson == null) throw ThrowExceptionParamInvalid();

                return objJson;
            }
            catch
            {
                throw ThrowExceptionParamInvalid();
            }
        }

        static Exception ThrowExceptionParamInvalid()
        {
            return new Exception("Valor do parâmetro é inváido");
        }
    }
}
