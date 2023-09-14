using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Services.Menu;

namespace ServiceLibrary.Services
{
    public enum HungerEnum
    {
        UnDefined,
        Full,
        Hungry,
        Starving,
        Dead
    }
    public interface IHungerService
    {
        HungerEnum Hunger(int hungerLevel);
        int GetHungerLevel(ChoiceEnum choice);
        string Starved(HungerEnum hunger);
    }
}
