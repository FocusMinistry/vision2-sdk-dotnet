using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api {
    public class Vision2Options {
        public Vision2Options() {
            IsStaging = false;
        }

        public bool IsStaging { get; set; }

        public string TenantCode { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
