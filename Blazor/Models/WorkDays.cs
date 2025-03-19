namespace Blazor.Models;

public class WorkDays
{
    public int Id { get; set; }
    public DateTime FromTime { get; set; }
    public DateTime ToTime { get; set; }
    public DateTime BrakeTime { get; set; }
    public TimeSpan Balance { get; set; }
}