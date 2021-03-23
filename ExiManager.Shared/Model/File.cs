using System.ComponentModel.DataAnnotations.Schema;

namespace ExiManager.Shared.Model
{
    public class File : IDomainObject
    {
        [Column("File_Id")]
        public int Id { get; set; }

        [Column("Folder_Id")]
        public int FolderId { get; set; }

        [Column("File_Name")]
        public string FileName { get; set; }

        public ExiInfo ExiInfo { get; set; }
    }
}
