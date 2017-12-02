using System.Net;
using Newtonsoft.Json;

namespace Cejen.Client
{
    public class ClientBase
    {
        private readonly WebClient _client;
        private readonly string _value;

        public ClientBase()
        {
            const string url = "http://www.precodoscombustiveis.com.br/mapa/atualiza?swlat=-20.509836929816302&swlng=-54.67620849609375&nelat=-20.42942579865923&nelng=54.56411361694336&zoom=13";
            _client = new WebClient();
            _value = _client.DownloadString(url);
        }

        public dynamic GetAllPostos()
        {
            var res = _value;
            dynamic dyn = JsonConvert.DeserializeObject(res);

            return dyn;
        }
    }
}