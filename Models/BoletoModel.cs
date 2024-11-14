namespace Practica1_CINECO.Models
{
    public class BoletoModel
    {
        public required string Comprador { get; set; }
        public int CantidadCompradores { get; set; }
        public bool TieneTarjetaCineco { get; set; }
        public int CantidadBoletos { get; set; }
        public double TotalPagar { get; set; }
    }
}