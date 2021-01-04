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
        [Display(Name ="登录帐号")]
        public string User_account { get; set; }
        [Display(Name = "类型")]
        public string User_type { get; set; }
        [Display(Name = "所在院区")]
        public int? Projectid { get; set; }
        [Display(Name = "所属科室")]
        public int? Departmentid { get; set; }
        [Display(Name = "关联微信")]
        public string wx_unique_id { get; set; }
        [Display(Name = "角色")]
        public int? Roleid { get; set; }
        [Display(Name = "登录密码")]
        public string User_password { get; set; }
        public string Theme { get; set; }
        [Display(Name = "登录时间")]
        public DateTime? Login_time { get; set; }
        public Department Department { get; set; }
        public Project Project { get; set; }
    }
}
