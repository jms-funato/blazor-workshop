using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADPHI.Shared.Models.DL45
{
    /// <summary>
    /// 45度線ユーザ権限
    /// 各ライン配置データを管理する。
    /// 製品ラベル発行システムでも使用
    /// </summary>
    [Table("PM_DT08_USER_MASTER")]
    public class User
    {

        [Key]
        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string USER_ID { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string NAME { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string BU { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string PLANT { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string KA { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string LINE { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(4)]
        public string WORK_ZONE { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string WORK_POS { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(4)]
        public string INPUT_K { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(4)]
        public string MENTE_K { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(4)]
        public string KENTO_K { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(4)]
        public string SHONIN_K { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string BU_CODE { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string PLANT_CODE { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string KA_CODE { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string BUMON_CODE { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string DBS_STATUS { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(60)]
        public string DBS_CREATE_USER { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string DBS_CREATE_DATE { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(60)]
        public string DBS_UPDATE_USER { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string DBS_UPDATE_DATE { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string PASSWD { get; set; }

        [Timestamp]
        public byte[] PASS_DATE { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string PM_KOSU_SYS { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string S_LABEL_SYS { get; set; }



        public virtual List<User> Users { get; set; }
    }
}
