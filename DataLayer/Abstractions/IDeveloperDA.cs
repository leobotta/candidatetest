using Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstractions
{
    public interface IDeveloperDA
    {
        Task<IEnumerable<IDeveloper>> GetDevelopers(string filePath);
    }
}
