using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_HQTCSDL.DTO
{
    public class TableDTO
    {

        public TableDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tenban = row["tenban"].ToString();
            this.Trangthai = row["trangthai"].ToString();
        }
        public TableDTO(int id, string tenban, string trangthai)
        {
            this.Id = id;
            this.Tenban = tenban;
            this.Trangthai = trangthai;
        }
        private string trangthai;

        public string Trangthai    
        {   
            get { return trangthai; }
            set { trangthai = value; } 
        }
        private string tenban;

        public string Tenban
        {
            get { return tenban; }
            set { tenban = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        
    }
}
