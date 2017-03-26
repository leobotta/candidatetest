using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstractions
{
    public interface IDeveloperDA
    {
        Task<IEnumerable<IDeveloper>> GetDevelopers(string filePath);
    }

    public interface IDeveloperBC
    {
        Task<IEnumerable<IDeveloper>> GetDevelopers();
        void GetDeveloperBestSkills(ref IEnumerable<IDeveloper> developers);

    }

    public interface IDeveloper
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        IEnumerable<Skill> Skills { get; set; }
    }

    public interface ISkill
    {
        string Name { get; set; }
        string Type { get; set; }
        int Level { get; set; }
    }

}
