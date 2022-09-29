using EssenceCompare.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace EssenceCompare.Controllers
{
    public class ApiGetter
    {

        public static async Task<List<PrixEssence?>?> GetEssence()
        {
            
            var client = new HttpClient();
            var stringTask = client.GetStringAsync("https://data.opendatasoft.com/api/records/1.0/search/?dataset=prix-carburants-fichier-instantane-test-ods-copie%40opendatamef&q=ville+%3D+bolbec+%26+prix_nom+%3D+gazole");

            var msg = await stringTask;

            var Root = JsonConvert.DeserializeObject<Root>(msg);

            if (Root != null && Root.records != null)
            {   
            return Root.records.Select(x => x.fields).ToList();
            }
            else
            {
                return null;
            }
            

        }

    }
}
