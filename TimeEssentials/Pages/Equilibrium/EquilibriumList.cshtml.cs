using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Localization;
using TimeEssentials.Core;
using TimeEssentials.Data;

namespace TimeEssentials.Pages.Equilibrium
{
    public class EquilibriumListModel : PageModel
    {
        private readonly IBaseEssentialsData baseEssentialsData;
        private readonly IStringLocalizer<_Pages_Equilibrium_EquilibriumList> _stringLocalizer;

        public IEnumerable<BaseEssentials> Equilibria { get; set; }

        public EquilibriumListModel(IBaseEssentialsData baseEssentialsData, 
            IStringLocalizer<_Pages_Equilibrium_EquilibriumList> stringLocalizer)
        {
            this.baseEssentialsData = baseEssentialsData;
            _stringLocalizer = stringLocalizer;
        }
        public void OnGet()
        {
            Equilibria = baseEssentialsData.GetAllEquilibrium(); 
        }
    }
}
