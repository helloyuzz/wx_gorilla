using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.Models {
    [Table("sm_project")]
    public class Project {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Display(Name ="项目全称"),Required]
        public string Project_name { get; set; }

        [DataType(DataType.Date),Display(Name ="注册日期"),Required]
        public DateTime? Sign_date { get; set; }
        [Display(Name ="简称"), Required]
        public string Short_name { get; set; }
        [Display(Name ="省/直辖市"), Required]
        public int? Provinceid { get; set; }
        [Display(Name = "市/区"),Required]
        public int? Cityid { get; set; }
        [Display(Name ="详细地址"),DisplayFormat(NullDisplayText ="未设置")]
        public string Address { get; set; }
        [Display(Name ="联系电话")]
        public string Phone { get; set; }
        [Column("fk_province_id")]
        public Province Province { get; set; }
        [Column("fk_city_id")]
        public City City { get; set; }
        [Display(Name ="当前进度"),DisplayFormat(NullDisplayText ="未知")]
        public string Current_progress { get; set; }
        [Display(Name ="实施人员")]
        public string Project_imple { get; set; }
    }
}
