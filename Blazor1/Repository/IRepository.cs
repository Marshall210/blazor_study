using System.Collections.Generic;
using Blazor1.Models;

namespace Blazor1.Repository
{
    public interface IRepository
    {
        List<Page> GetAllPages();
    }
}