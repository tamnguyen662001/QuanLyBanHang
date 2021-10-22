using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_HQTCSDL.DTO
{
    public class BillDTO
    {
        public BillDTO(int id,int idban, DateTime ngayden, DateTime ngaydi, int trangthai)
        {
            this.Id = id;
            this.Idban = idban;
            this.Ngayden = ngayden;
            this.Ngaydi = ngaydi;
            this.Trangthai = trangthai;
        }

        public BillDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Idban = (int)row["IDBAN"];
            this.Ngayden = (DateTime?)row["NGAYDEN"];
            var tmp = row["NGAYDI"];
            if (tmp.ToString() != "")
                this.Ngaydi = (DateTime?)row["NGAYDI"];
            
            this.Trangthai = (int)row["TRANGTHAI"];
        }

        private int id;
        private DateTime? ngayden;

        public DateTime? Ngayden 
        { 
            get { return ngayden; } 
            set { ngayden = value; } 
        }


        private DateTime? ngaydi;

        public DateTime? Ngaydi
        {
            get { return ngaydi; }
            set { ngaydi = value; }
        }
        private int idban;

        public int Idban
        {
            get { return idban; }
            set { idban = value; }
        }

        private int trangthai;

        public int Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
