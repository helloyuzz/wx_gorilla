using com.wechat.gorilla.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla {
    public class PublicPage: PageModel {
       protected List<CrumbItem> _CrumbList = new List<CrumbItem>();     
    }
}
