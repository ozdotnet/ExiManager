using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExiManager.Shared.Model
{
    [Table("Exi_Info")]
    public class ExiInfo
    {
        [Column("Exi_Info_Id")]
        public int ExiInfoId { get; set; }

        [Column("File_Id")]
        public int FileId { get; set; }

        [Column("Date_Taken")]
        public DateTime DateTaken { get; set; }

        [Column("Date_Taken_Parsed_From_File_Name")]
        public DateTime DateTakenParsedFromFileName { get; set; }
    }
}
