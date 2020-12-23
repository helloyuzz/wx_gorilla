using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.Models {
    [Table("sm_province")]
    public class Province {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "地理位置")]
        public string Province_area { get; set; }
        [Display(Name = "行政区类型")]
        public string Province_type { get; set; }
        [Display(Name = "行政区名称")]
        public string Province_name { get; set; }

    }
}
