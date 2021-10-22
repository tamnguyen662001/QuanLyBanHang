using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_HQTCSDL.DTO
{
    public class BillDetailDTO
    {

        public BillDetailDTO(int id, int idhoadon, int idsp,int sl)
        {
            this.Id = id;
            this.Idhoadon = idhoadon;
            this.Idsp = idsp;
            this.Sl = sl;
        }

        public BillDetailDTO(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Idhoadon = (int)row["IDHOADON"];
            this.Idsp = (int)row["IDSP"];
            this.Sl = (int)row["SL"];
        }
        private int idhoadon;
        private int id;
        private int idsp;
        private int sl;

        public int Idhoadon
        {
            get { return idhoadon; }
            set { idhoadon = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Sl
        {
            get { return sl; }
            set { sl = value; }
        }
        public int Idsp
        {
            get { return idsp; }
            set { idsp = value; }
        }
    }
}
