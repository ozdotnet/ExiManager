using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExiManager.Shared.Model
{
    public class Folder : IDomainObject
    {
        [Column("Folder_Id")]
        public int Id { get; set; }

        [Column("Folder_Name")]
        public string FolderName { get; set; }

        [Column("Path")]
        public string Path { get; set; }

        public List<File> Files { get; set; }
    }
}
