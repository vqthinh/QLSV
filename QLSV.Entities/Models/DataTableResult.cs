namespace QLSV.Entities.Models
{
    public class DataTableResult
    {
        public string draw { get; set; }

        public int recordsTotal { get; set; }

        public int recordsFiltered { get; set; }
        public object data { get; set; }
    }
}