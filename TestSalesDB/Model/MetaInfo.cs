using System;

namespace TestSalesDB.Model;

public record MetaInfo
{
    public DateTime CreationDate { get; set; }
    public DateTime UpdatingDate { get; set; }
    public int CreatedById { get; set; }
    public int UpdatedById { get; set; }

    public void UpdateBy(int userId)
    {
        UpdatedById = userId;
        UpdatingDate = DateTime.Now;
    }

    public static MetaInfo CreatingBy(int userId)
        => new MetaInfo
        {
            CreatedById = userId,
            CreationDate = DateTime.Now,
            UpdatedById = userId,
            UpdatingDate = DateTime.Now
        };
}