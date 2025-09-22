using System;
using System.Collections.Generic;

namespace DCP_ACCOUNTS_Test.Model;

public partial class TblExpend
{
    public int? ExpenditurId { get; set; }

    public string? ExpSubCode { get; set; }

    public DateOnly? ExpDate { get; set; }

    public string? Uid { get; set; }

    public DateTime? EntryDate { get; set; }
}
