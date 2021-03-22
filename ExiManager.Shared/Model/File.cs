using System.ComponentModel.DataAnnotations.Schema;

namespace ExiManager.Shared.Model
{
    public class File
    {
        [Column("File_Id")]
        public int FileId { get; set; }

        [Column("Folder_Id")]
        public int FolderId { get; set; }

        [Column("File_Name")]
        public string FileName { get; set; }

        public ExiInfo ExiInfo { get; set; }
    }
}
