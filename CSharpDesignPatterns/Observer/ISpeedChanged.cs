using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// not needed using CSharpDesignPatterns, inside system/events;

namespace Observer
{
    public interface ISpeedChanged
    {
        //method declaration that takes 2 types/parameters sender/EventArgs=predefined
        void ValueHasChanged(object sender, EventArgs args);

    }
}
