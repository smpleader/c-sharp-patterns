using modData.Memories.Pointer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modData.Memories.Record
{
    internal class VatLieu : ARecord
    {
        protected int HMId;
        protected int CVId;
        public VatLieu(int CongViecId) : this(CongViecId, 0) { }

        public VatLieu(int CongViecId, int HangMucId)
        {
            CongViec? r = Current.CV.load(CongViecId);
            if (r == null)
            {
                throw new Exception("Invalid CongViec " + CongViecId);
            }

            if (0 == HangMucId)
            {
                HangMucId = r.HMId;
            }
            else if (HangMucId != r.HMId)
            {
                throw new Exception("Invalid HangMuc " + HangMucId + " vs CongViec " + CongViecId);
            }

            HMId = HangMucId;
            CVId = CongViecId;

            Id = Current.NC.id(true);
            setDefault();
        }
        public override string Path { get { return "HangMuc." + HMId + ".CongViec." + CVId + ".VatLieu." + Id; } }
        public void setDefault()
        {
            ColText["stt"] = "";
            ColText["ma"] = "";
            ColText["ten"] = "";
            ColText["donvi"] = "";
            ColText["loai"] = "";

            ColNum["haophi"] = 0;
            ColNum["giagoc"] = 0;
            ColNum["giatb"] = 0;
            ColNum["giaht"] = 0;
            ColNum["haophikhac"] = 0;
        }

    }
}