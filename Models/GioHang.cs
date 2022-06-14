using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using NguyenTienDat.Models;

namespace NguyenTienDat.Models
{
    public class GioHang
    {
        RubikStoreContext data = new RubikStoreContext();
        public int id { get; set; }
        [Display(Name = "Ten:")]
        public string ten { get; set; }
        [Display(Name = "Anh bia:")]
        public string hinh { get; set; }
        [Display(Name = "Gia ban:")]
        public Double gia { get; set; }
        [Display(Name = "So luong:")]
        public int iSoluong { get; set; }
        [Display(Name = "Thanh tien:")]
        public Double dTHanhTien
        {
            get { return iSoluong * gia; }
        }
        public GioHang(int id)
        {
            this.id = id;
            Rubik rubik = data.Rubiks.Single(n => n.id == id);
            ten = rubik.ten;
            hinh = rubik.hinh;
            gia = double.Parse(rubik.gia.ToString());
            iSoluong = 1;
        }
    }
}