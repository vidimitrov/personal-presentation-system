using PPSystem.Models.CV;
using PPSystem.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPSystem.Web.ViewModels.CV
{
    public class CompetitionViewModel : IMapFrom<Competition>
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Reward { get; set; }

        public string Image { get; set; }
    }
}