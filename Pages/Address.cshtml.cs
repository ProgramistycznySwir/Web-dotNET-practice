using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

using HelloWorld.Models;

namespace HelloWorld.Pages
{
    public class AddressModel : PageModel
    {
        public Address address;

        public void OnGet()
        {
            var sessionAddress = HttpContext.Session.GetString("SessionAddress");
            if (sessionAddress != null)
                address = JsonConvert.DeserializeObject<Address>(sessionAddress);
        }
    }
}
