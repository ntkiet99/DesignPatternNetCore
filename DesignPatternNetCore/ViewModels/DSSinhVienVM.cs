using DesignPatternNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternNetCore.ViewModels
{
    public class DSSinhVienVM
    {
        public string ChuNhiemKhoa { get; set; }
        public List<User> ListSV { get; set; }
        public string TenKhoa { get; set; }
    }
}
