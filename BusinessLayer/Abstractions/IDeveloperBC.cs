using Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstractions
{
    public interface IDeveloperBC
    {
        Task<IEnumerable<IDeveloper>> GetDevelopers();
        void GetDeveloperBestSkills(ref IEnumerable<IDeveloper> developers);

    }
}
