using System.ComponentModel.DataAnnotations.Schema;

namespace ExiManager.Shared.Model
{
    public class Folder
    {
        [Column("Folder_Id")]
        public int FolderId { get; set; }

        [Column("Folder_Name")]
        public string FolderName { get; set; }

        [Column("Path")]
        public string Path { get; set; }
    }
}
