using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string UserName;
        private string Pass;

        public TaiKhoan(string UserName, string Pass)
        {
            this.UserName = UserName;
            this.Pass = Pass;
        }

        public string UserName1 { get => UserName; set => UserName = value; }
        public string Pass1 { get => Pass; set => Pass = value; }
    }
    
}
