namespace MVCEcommerceo1.Models
{
    public class PaginationViewModel
    {
        public List<Product> Items { get; set; } // Cambia el tipo de lista según tus items
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string? SearchValue { get; set; }
    }
}
