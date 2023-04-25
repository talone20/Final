using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public interface IFinal
    {
        IQueryable <Entertainer> Entertainers { get; }

        void CreateEntertainer(Entertainer entertainer);
        void EditEntertainer(Entertainer entertainer);
        void DeleteEntertainer(double entertainerId);
    }
}
