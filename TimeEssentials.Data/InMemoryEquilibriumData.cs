using System;
using System.Collections.Generic;
using System.Text;
using TimeEssentials.Core;

namespace TimeEssentials.Data
{
    public class InMemoryEquilibriumData : IBaseEssentialsData
    {
        private readonly List<Equilibrium> equilibria;
        public InMemoryEquilibriumData()
        {
            equilibria = new List<Equilibrium>()
            {
                // from DoTerra Ballance Components
                new Equilibrium { 
                    Id = 1, 
                    Name = "Spruce", 
                    Description = " Grounding effect that helps with emotional release"
                },
                new Equilibrium { 
                    Id = 2, 
                    Name = "Ho Wood", 
                    Description = "Provides calming effect; increases spiritual awareness"
                },
                new Equilibrium { 
                    Id = 3, 
                    Name = "Frankincense", 
                    Description ="Promotes meditation, improves attitude, and uplifts spirits"
                },
                new Equilibrium { 
                    Id = 4, 
                    Name = "Blue Tansy", 
                    Description = "Relieves anger and promotes a feeling of self-control"
                },
                new Equilibrium {
                    Id = 5,
                    Name = "Blue Chamomile",
                    Description = "Calms nerves"
                }
            };
        }

        public IEnumerable<BaseEssentials> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
