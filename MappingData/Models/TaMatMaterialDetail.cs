using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MappingData.Models
{
    [Table("TA_MAT_MATERIAL_DETAIL")]
    public class TaMatMaterialDetail
    {
        [Column("I_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("I_Priority")]
        public int? Priority { get; set; }
        [Column("I_Material_Parent")]
        public int? ParentId { get; set; }
        [Column("I_Material_Child")]
        public int? ChildId { get; set; }
        [Column("I_Unit")]
        public int? MatUnitId { get; set; }
        [Column("F_Val_01")]
        public double? Val01 { get; set; }
        [Column("F_Val_02")]
        public double? Val02 { get; set; }
        [Column("T_Info_01")]
        public string Info01 { get; set; }
        [Column("T_Info_02")]
        public string Info02 { get; set; }
    }
}
