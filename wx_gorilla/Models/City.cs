using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.Models {
    [Table("sm_city")]
    public class City {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "行政区域")]
        public int Provinceid { get; set; }
        [Display(Name ="城市名称"),Required]
        public string City_name { get; set; }
        [Display(Name ="显示排序"),Required]
        public int? Show_index { get; set; }
        public Province Province { get; set; }
    }
}
