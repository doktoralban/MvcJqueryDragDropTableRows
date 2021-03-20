using System.ComponentModel.DataAnnotations;

namespace WebMvcPlusJqueryDragDropTableRows.Models
{
    public partial  class tbMvcDragDropTableRows
    {
        [Key]
      public int    id { get; set; }
      public string Name { get; set; }
        public int RowNo { get; set; }
        public int CellNo { get; set; }



    }
}