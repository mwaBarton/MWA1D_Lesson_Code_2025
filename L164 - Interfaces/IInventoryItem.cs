using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L164___Interfaces
{
    public interface IInventoryItem
    {
        string getDescription();
    }

    public interface IConsumable
    {
        void consume();
    }

    public interface IBreakable
    {
        void breakABit();
        bool isBroken();
    }

    public interface IDoDamage
    {
        double attack();
    }
}
