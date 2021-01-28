using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.Models {
    [Table("sm_department")]
    [HtmlTree("Id", "Parent_id", "Dept_name")]
    public class Department {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name ="科室/部门名称"),Required]
        public string Dept_name { get; set; }
        [Display(Name = "简称"),Required]
        public string Short_name { get; set; }
        [Display(Name ="显示排序Area_id"),Required]
        public string Area_id { get; set; }
        [Display(Name = "上级科室/部门")]
        public int? Parent_id { get; set; }
        [Display(Name ="所属项目")]
        public int? Projectid { get; set; }
        //public Project Project { get; set; }
    }
}
