using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Interfaces
{
    interface ICredit
    {
        long Credit { get; protected set; }
    }
}
