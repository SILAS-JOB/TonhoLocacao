namespace TonhoLocacao.Models
{
    public class PdfContent
    {
        public Guid Protocol { get; set; }
        public string Name { get; set; }
        public List<Products> pdfproducts { get; set; }
        
    }
}