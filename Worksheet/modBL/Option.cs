using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL
{
    public class Option
    {
        public static PPTGiaVatLieu PPTGiaVatLieu { get; set; } = PPTGiaVatLieu.NhapTay;
        public static PPTCuocOto PPTCuocOto { get; set; } = PPTCuocOto.TheoTongCuLy;
        public static PPTCuocSong PPTCuocSong { get; set; } = PPTCuocSong.MauChung;
        public static PPTCuocTC PPTCuocTC { get; set; } = PPTCuocTC.TheoTT12_2021;

        public static PPTGiaNhanCong PPTGiaNhanCong { get; set; } = PPTGiaNhanCong.NhapTay;
        public static PPTGiaMay PPTGiaMay { get; set; } = PPTGiaMay.NhapTay;
    }
    public enum PPTGiaVatLieu
    {
        NhapTay, CongCuocVanChuyen, NhanHeSo, NhanHeSoCongCuocVanChuyen
    }
    public enum PPTGiaNhanCong
    {
        NhapTay, TinhTrucTiep, NhanHeSo
    }
    public enum PPTGiaMay
    {
        NhapTay, BuGia, TinhTrucTiep, NhanHeSo, NhanHeSoCongBuGia
    }
    public enum PPTCuocOto
    {
        TheoTongCuLy, TheoLoaiPhuongTien, MauTinhCaoBang, MauTinhCaoBangThem, MauTinhQuangBinh,
        TT10, TT12, Theo588, QuangNam38_2021, QuangNam24_22022
    }
    public enum PPTCuocSong 
    {
        MauChung, MauCaMau, MauDongThap
    }
    public enum PPTCuocTC 
    { 
        TheoTT12_2021, TheoTT10_2019, TheoDM588_2014, MauLaoCai, MauDienBien, MauCuocTCChung, TheoDM1778
    }
    public enum PPTChietTinh
    {
        TheoMauTHKPHM, DuThauDocChuan, DuThauDocThongThuong, DuThauDocTachCongTac, DuThauDocThuyLoi, DuThauNgang
    }
    public enum MauTHKPHM
    {
        TrucTiep, ThuyLoiThuGon, ThuyLoiEta, ThuyLoi, QuanDoi2022, QuanDoi, MoiTruongThaiNguyen, QuangNinhCV544, NghiDinh32_2015_NDCP, 
        DuToanG8, DuToanAcitt, ThongTuSo17_2017_TTBXD, MauTT11_2021_TTBXD_TrucTiep, MauTT11_2021_TTBXD_BuGiaMienNam, MauTT11_2021_TTBXD_BuGia,
        TT09_2021_TTBXD_TrucTiep, KhaoSatTT09_2019_TTBXD_TrucTiep, KhaoSatTT09_2019_TTBXD_BuGia,
        TT09_2019_TTBXD_BuGia, 
        TT06_2016_TTBXD_TrucTiep_HangMucChung_DuPhong, TT06_2016_TTBXD_TrucTiep_HangMucChung, TT06_2016_TTBXD_TrucTiep_DuPhong, TT06_2016_TTBXD_TrucTiep,
        TT06_2016_TTBXD_DongThap, TT06_2016_TTBXD_BuGia_HangMucChung_DuPhong, TT06_2016_TTBXD_BuGia_HangMucChung, TT06_2016_TTBXD_BuGia_DuPhong, TT06_2016_TTBXD_BuGia,
        TT02_2020_TTBXD_TrucTiep, TT02_2020_TTBXD_BuGia,
        QuyetDinhSo02_HDSXD_SoXayDungDongNai, ND68_2019_NDCP_TrucTiep_MauSo1, ND68_2019_NDCP_TrucTiep, ND68_2019_NDCP_DongThap, ND68_2019_NDCP_BuGia_MauSo1, ND68_2019_NDCP_BuGia,
        KS_TT11_2021_TTBXD_TrucTiep_GopHMC, KS_TT11_2021_TTBXD_TrucTiep, KS_TT11_2021_TTBXD_BuGia_MienNam, KS_TT11_2021_TTBXD_BuGiaGopHMC, 
        KS_TT11_2021_TTBXD_BuGia,
        KS_TT17_2013_TTBXD, KS_TT17_2020_TTBXD_TrucTiep, KS_TT17_2020_TTBXD_BuGia, KS_TT17_2017_TTBXD_TT, KS_TT17_2017_TTBXD,
        BV_CB,
        BuGiaRutGon, BugGiaDayDu, NhanHeSoDieuChinhMayTruocBuGiaNhienLieu, MauBuGia, BinhDinh2015_THNL, BinhDinh2015
    }

}
