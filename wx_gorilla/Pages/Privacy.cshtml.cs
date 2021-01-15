using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.Pages {
    public class PrivacyModel : PublicPage {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger) {
            _logger = logger;
        }

        public void OnGet() {
            _CrumbList.Add(new Models.CrumbItem("Privacy", true, true));
            _logger.Log(LogLevel.Information, "xxx");
        }
    }
}
