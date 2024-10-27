namespace ApplicationCore.Entities;

public class Purchase
{
    public int MovieId { get; set; }
    public int UserId { get; set; }
    public DateTime PurchaseDate { get; set; }
    public string? PurchaseNumber { get; set; }
    public decimal TotalPrice { get; set; }
}