using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChurchConnectLite.Core.Entities
{
   public class ApplicationUser:IdentityUser
    {
        public string ChurchName { get; set; }

        public Church Churches { get; set; }
    }
}
