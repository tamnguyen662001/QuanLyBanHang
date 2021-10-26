using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_HQTCSDL.DTO
{
    public class BillCheckOutDTO
    {

        public BillCheckOutDTO (int idhoadon, string tensp, int sl, float dongia, float tongtien = 0)
        {
            this.Idhoadon = idhoadon;
            this.Tensp = tensp;
            this.Sl = sl;
            this.Dongia = dongia;
            this.Tongtien = tongtien;
        }
        public BillCheckOutDTO(DataRow row)
        {
            this.Idhoadon = (int)row["Số hoá đơn"];
            this.Tensp = row["Món"].ToString();
            this.Sl = (int)row["SL"];
            this.Dongia = (float)Convert.ToDouble(row["Đơn giá"].ToString());
            this.Tongtien = (float)Convert.ToDouble(row["Tổng tiền"].ToString());
        }
        private float dongia;
        public float Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        private string tensp;
        private int idhoadon;
        private int sl;
        private float tongtien;
        public float Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        public int Sl
        {
            get { return sl; }
            set { sl = value; }
        }
        public int Idhoadon
        {
            get { return idhoadon; }
            set { idhoadon = value; }
        }
        public string Tensp
        {
            get { return tensp; }
            set { tensp = value; }
        }
    }

}