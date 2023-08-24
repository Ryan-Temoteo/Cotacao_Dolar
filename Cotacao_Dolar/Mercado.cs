using Newtonsoft.Json;

namespace Cotacao_Dolar
{
    public class Mercado
    {
        public Mercado() 
        {

            this.Moeda = new Moeda();
        }

        [JsonProperty(PropertyName = "currencies")]
        public Moeda Moeda { get; set; }

    }
}
