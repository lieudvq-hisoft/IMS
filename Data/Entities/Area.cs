namespace Data.Entities;
public class Area : BaseEntity
{
    public string Name { get; set; }
    public int RowCount { get; set; }
    public int ColumnCount { get; set; }

    public ICollection<Rack> Racks { get; set; }
}
