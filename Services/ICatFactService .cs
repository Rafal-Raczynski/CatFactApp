
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactApp.Services
{
    public interface ICatFactService
    {
        Task<string> GetCatFactAsync();

    }
}
