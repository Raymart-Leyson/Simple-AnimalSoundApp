using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// [Abstraction]
    /// Animal is considered an abstract because we will need an abstact methods cause we only need to implement it to its child
    /// </summary>
    internal abstract class Animal
    {
        public abstract string sound();
    }
}
