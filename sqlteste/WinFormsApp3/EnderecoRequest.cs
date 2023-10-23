using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace WinFormsApp3
{
    internal class EnderecoRequest
    {
        public async Task<Endereco> GetEndereco(string cep)
        {
            HttpClient cliente = new HttpClient();
            HttpResponseMessage resposta = await cliente.GetAsync($"https://brasilapi.com.br/api/cep/v1/{cep}");
            HttpContent conteudo = resposta.Content;

            string output = await conteudo.ReadAsStringAsync(); 

            Endereco endereco = JsonConvert.DeserializeObject<Endereco>(output);

            return await Task.FromResult<Endereco>(endereco);
        }
    }
}
