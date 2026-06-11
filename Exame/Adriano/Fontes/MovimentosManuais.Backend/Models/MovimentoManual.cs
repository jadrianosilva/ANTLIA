namespace MovimentosManuais.Backend.Models
{
    public class MovimentoManual
    {
        public int DatMes { get; set; }
        public int DatAno { get; set; }
        public int NumLancamento { get; set; }
        public string CodProduto { get; set; }
        public string CodCosif { get; set; }
        public decimal ValValor { get; set; }
        public string DesDescricao { get; set; }
        public DateTime DatMovimento { get; set; }
        public string CodUsuario { get; set; }
    }
}
