using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.Models {
    [Table("sm_employee")]
    public class Employee {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "员工姓名")]
        public string Employee_name { get; set; }
        [Display(Name = "所属部门")]
        public int? Departmentid { get; set; }
        [Display(Name = "工号")]
        public string Cardno { get; set; }
        [Display(Name = "岗位/职务")]
        public string Duty { get; set; }
        [Display(Name = "性别")]
        public string Sex { get; set; }
        [Display(Name = "联系电话")]
        public string Cellphone { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        public Department Department { get; set; }
    }
}