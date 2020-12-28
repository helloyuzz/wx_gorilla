using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;

namespace com.wechat.gorilla.Pages.Provinces {
    public class IndexModel : PageModel {
        private readonly com.wechat.gorilla.DbContexts.ProvinceContext _context;

        public IndexModel(com.wechat.gorilla.DbContexts.ProvinceContext context) {
            _context = context;
        }

        public IList<Province> Province { get; set; }


        public async Task OnGetAsync() {
            if ("全部类型".Equals(SearchType) && "地理位置".Equals(SearchArea)) {
            RecordCount = _context.Province.Count();
                Province = await _context.Province.Skip((PageIndex-1)*PageSize).Take(PageSize).ToListAsync();
            } else {
                if (SearchType.Equals("全部类型") == false && SearchArea.Equals("地理位置") == false) {
                    RecordCount = _context.Province.Where(A => A.Province_type.Equals(SearchType)).Where(B => B.Province_area.Equals(SearchArea)).Count();
                    Province = await _context.Province.Where(A => A.Province_type.Equals(SearchType)).Where(B => B.Province_area.Equals(SearchArea)).Skip((PageIndex-1)*PageSize).Take(PageSize).ToListAsync();
                } else if (SearchArea.Equals("地理位置")) {
                    RecordCount = _context.Province.Where(A => A.Province_type.Equals(SearchType)).Count();
                    Province = await _context.Province.Where(A => A.Province_type.Equals(SearchType)).Skip((PageIndex - 1) * PageSize).Take(PageSize).ToListAsync();
                } else {
                    RecordCount = _context.Province.Where(A => A.Province_area.Equals(SearchArea)).Count();
                    Province = await _context.Province.Where(A => A.Province_area.Equals(SearchArea)).Skip((PageIndex - 1) * PageSize).Take(PageSize).ToListAsync();
                }
            }
            PageCount = RecordCount / PageSize;
            if (RecordCount % PageSize > 0) {
                PageCount++;
            }
        }
        [BindProperty(SupportsGet = true)]
        public string SearchType { get; set; } = "全部类型";
        [BindProperty(SupportsGet = true)]
        public string SearchArea { get; set; } = "地理位置";
        [BindProperty(SupportsGet = true)]
        public int PageSize { get; set; } = 12;
        [BindProperty(SupportsGet = true)]
        public int PageIndex { get; set; } = 1;
        [BindProperty(SupportsGet = true)]
        public int PageCount { get; set; }
        [BindProperty(SupportsGet =true)]
        public int RecordCount { get; set; }
    }
}
