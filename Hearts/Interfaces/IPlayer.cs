using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts.Interfaces
{
    interface IPlayer
    {
        IEnumerable<ICard> Cards { get; }
    }
}
