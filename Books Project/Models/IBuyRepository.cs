using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_Project.Models
{
    public interface IBuyRepository
    {
        IQueryable<Buy> Buys { get; }

        void SaveBuy(Buy buy);

    }
}
