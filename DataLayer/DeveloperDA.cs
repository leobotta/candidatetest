using DataLayer.Abstractions;
using Entities;
using Entities.Abstractions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DeveloperDA : IDeveloperDA
    {
        public DeveloperDA() : base()
        {
        }

        public async Task<IEnumerable<IDeveloper>> GetDevelopers(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) return null;

            IEnumerable<Developer> developers = null;

            using (StreamReader sr = new StreamReader($@"{filePath}"))
            {
                string jsonString = await sr.ReadToEndAsync();
                developers = JsonConvert.DeserializeObject<List<Developer>>(jsonString);
                sr.Close();
            }

            return developers;
        }
    }
}
