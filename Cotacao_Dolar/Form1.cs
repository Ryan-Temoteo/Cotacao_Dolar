using Newtonsoft.Json;
using System.Globalization;

namespace Cotacao_Dolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string url = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=04da3872";

            try
            {

                using (HttpClient client = new HttpClient())
                {
                    var Response = client.GetAsync(url).Result;


                    if (Response.IsSuccessStatusCode)
                    {
                        var result = Response.Content.ReadAsStringAsync().Result;

                        Mercado mercado = JsonConvert.DeserializeObject<Mercado>(result);

                        lblCompra.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", mercado.Moeda.Compra);
                        lblVenda.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", mercado.Moeda.Venda);
                        lblVariacao.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", mercado.Moeda.Variacao / 100);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel conectar com a API, tente novamente mais tarde...");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblCompra.Text = "Sem Resultado";
                lblVenda.Text = "Sem Resultado";
                lblVariacao.Text = "Sem Resultado";
                throw;
            }
        }
    }
}