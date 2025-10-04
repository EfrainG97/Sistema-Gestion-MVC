namespace P2_SistemaDeGestion.ViewModel
{
    public class ProductoConMarca
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public string? MarcaDescripcion { get; set; }
    }
}