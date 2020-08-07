using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeEssentials.Core;

namespace TimeEssentials.Data
{
    public class InMemoryBaseEssentialsData : IBaseEssentialsData
    {
        List<BaseEssentials> baseEssentials;
        public InMemoryBaseEssentialsData()
        {
            baseEssentials = new List<BaseEssentials>()
            {
                // from DoTerra Ballance Components
                new BaseEssentials {
                    Id = 1,
                    Name = "Spruce",
                    Description = " Grounding effect that helps with emotional release",
                    Cathegory = EsssentialsCathegory.Equilibrium
                },
                new BaseEssentials {
                    Id = 2,
                    Name = "Ho Wood",
                    Description = "Provides calming effect; increases spiritual awareness",
                    Cathegory = EsssentialsCathegory.Equilibrium
                },
                new BaseEssentials {
                    Id = 3,
                    Name = "Frankincense",
                    Description ="Promotes meditation, improves attitude, and uplifts spirits",
                    Cathegory = EsssentialsCathegory.Equilibrium
                },
                new BaseEssentials {
                    Id = 4,
                    Name = "Blue Tansy",
                    Description = "Relieves anger and promotes a feeling of self-control",
                    Cathegory = EsssentialsCathegory.Equilibrium
                },
                new BaseEssentials {
                    Id = 5,
                    Name = "Blue Chamomile",
                    Description = "Calms nerves",
                    Cathegory = EsssentialsCathegory.Equilibrium
                }
            };
        }
        public IEnumerable<BaseEssentials> GetAllEquilibrium()
        {
            return from e in baseEssentials
                   where e.Cathegory == EsssentialsCathegory.Equilibrium
                   orderby e.Name
                   select e;
        }
    }
}
