using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.Models {
    [Table("sm_department")]
    public class Department {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name ="科室名称"),Required]
        public string Dept_name { get; set; }
        [Display(Name = "科室简称"),Required]
        public string Short_name { get; set; }
        [Display(Name ="科室条码")]
        public string Barcode { get; set; }
        [Display(Name ="所属项目")]
        public int Projectid { get; set; }
        //public Project Project { get; set; }
    }
}
