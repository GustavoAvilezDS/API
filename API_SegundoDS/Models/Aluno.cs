namespace API_SegundoDS.Models
{

    public class Aluno

    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? RMA { get; set; }
        public string? PAI { get; set; }
        public string? MAE { get; set; }
        public ESCOLA ESCOLA { get; set; }
        public Professor Professor { get; set; }




    }
}

