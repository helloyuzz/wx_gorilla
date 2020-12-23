using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.Models {
    [Table("Sm_User")]
    public class Account {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "用户名")]
        public string User_Name { get; set; }
        public string User_Type { get; set; }
        public int Fk_Project_Id { get; set; }
        public int Fk_Department_Id { get; set; }
        public string Wx_Unique_Id { get; set; }
        public int Fk_Role_Id { get; set; }
        public string User_Pwd { get; set; }
    }
}
