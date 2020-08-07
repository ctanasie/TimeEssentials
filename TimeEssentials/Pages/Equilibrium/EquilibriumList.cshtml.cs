using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeEssentials.Core;
using TimeEssentials.Data;

namespace TimeEssentials.Pages.Equilibrium
{
    public class EquilibriumListModel : PageModel
    {
        private readonly IBaseEssentialsData baseEssentialsData;

        public IEnumerable<BaseEssentials> Equilibria { get; set; }

        public EquilibriumListModel(IBaseEssentialsData baseEssentialsData)
        {
            this.baseEssentialsData = baseEssentialsData;
        }
        public void OnGet()
        {
            Equilibria = baseEssentialsData.GetAllEquilibrium(); 
        }
    }
}
