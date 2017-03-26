using Entities;
using Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DeveloperBC : IDeveloperBC
    {
        private readonly IDeveloperDA _developerDA;
        public DeveloperBC(IDeveloperDA developerDA) : base()
        {
            if (developerDA == null)
                throw new ArgumentNullException("developerDA == null");

            this._developerDA = developerDA;
        }

        public async Task<IEnumerable<IDeveloper>> GetDevelopers()
        {
            string filePath = ConfigManager.AppSettingsProvider.JsonFilePath;

            if (string.IsNullOrEmpty(filePath)) return null;

            return await this._developerDA.GetDevelopers(filePath);
        }

        public void GetDeveloperBestSkills(ref IEnumerable<IDeveloper> developers)
        {
            int minSkillLevel = ConfigManager.AppSettingsProvider.MinSkillLevel;

            developers = developers?.Where(d => d.Skills.Any(s => s.Level >= minSkillLevel)).Select(t => new Developer()
            {
                Age = t.Age,
                FirstName = t.FirstName,
                LastName = t.LastName,
                Skills = t.Skills.Where(x => x.Type == t.Skills.FirstOrDefault(s => s.Level >= minSkillLevel)?.Type)
            });
        }
    }
}
