namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }
        public double ValorTotal
        {
            get
            {
                double valor_Adultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valor_Criancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;

                double total = (valor_Adultos + valor_Criancas) * Estadia;

                return total;
            }
        }
    }
}
