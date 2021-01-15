using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.Models {
    [Table("sm_user")]
    public class User {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "登录帐号"),Required]
        public string User_account { get; set; }
        [Display(Name ="姓名"),Required]
        public string User_name { get; set; }
        [Display(Name = "类型"),Required]
        public string User_type { get; set; }
        [Display(Name = "单位/院区"),Required]
        public int? Projectid { get; set; }
        [Display(Name = "部门/科室"),Required]
        public int? Departmentid { get; set; }
        [Display(Name = "关联微信")]
        public string wx_unique_id { get; set; }
        [Display(Name = "角色")]
        public int? Roleid { get; set; }
        [Display(Name = "登录密码")]
        public string User_password { get; set; }
        public string Theme_url { get; set; }
        [Display(Name = "最近登录")]
        public DateTime? Login_time { get; set; }
        [Display(Name ="人员条码")]
        public string Barcode { get; set; }
        public Department Department { get; set; }
        public Project Project { get; set; }
    }
}
