﻿using System.Diagnostics;

namespace CH3.Coupling
{
    /// <summary>
    /// This class demonstrates an example of loose coupling.
    /// </summary>
    public class LooseCouplingB
    {
        /// <summary>
        /// In the constructor it is not possile to access the _name property in
        /// LooseCouplingA, and so we have loose coupling.
        /// </summary>
        public LooseCouplingB()
        {
            LooseCouplingA lca = new LooseCouplingA();
            lca = null;
            Debug.WriteLine($"Name is {lca.Name}");
        }
    }
}
