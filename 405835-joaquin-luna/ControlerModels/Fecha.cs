namespace _405835_joaquin_luna.ControlerModels
{
    public class Fecha
    {
        public int DiaMes { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public string DiaSemana { get; set; }
        public Fecha()
        {
            DiaMes = DateTime.Today.Day;
            Mes = DateTime.Today.Month;
            Anio = DateTime.Today.Year;
            DiaSemana=DateTime.Today.DayOfWeek.ToString();
        }



    }
}
