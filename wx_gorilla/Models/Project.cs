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
        [Display(Name ="项目名称"),Required]
        public string Project_name { get; set; }

        [DataType(DataType.Date),Display(Name ="注册日期"),Required]
        public DateTime? Sign_date { get; set; }
        [Display(Name ="项目简称"), Required]
        public string Short_name { get; set; }
        [Display(Name ="省"), Required]
        public int? fk_province_id { get; set; }
        [Display(Name = "市"),Required]
        public int? fk_city_id { get; set; }
        [Display(Name ="详细地址")]
        public string Address { get; set; }
        [Display(Name ="联系电话")]
        public string Phone { get; set; }
        [Column("fk_province_id")]
        public Province Province { get; set; }
        [Column("fk_city_id")]
        public City City { get; set; }
    }
}
