using System;
//using System.Security.Cryptography;

public class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Digite as informações do seu aniversário:");
            Console.Write("Informe o dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Infome o mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Infome o ano: ");
            int ano = int.Parse(Console.ReadLine());
            
            DateTime Niver = new DateTime(ano, mes, dia);

            Pessoa pessoa = new Pessoa(Niver);

            Console.WriteLine("Seu signo é: " + pessoa.Signo);
    }
}

public class Pessoa
{
    public Pessoa(DateTime Niver)
    {
        this.Niver = Niver;
    }

    public DateTime Niver{get; set;}
    public string Signo
    {
        get {
            int ano = Niver.Year;
            (DateTime start, DateTime end) Aries = (new DateTime(ano, 03, 21), new DateTime(ano, 04, 19));
            (DateTime start, DateTime end) Touro = (new DateTime(ano, 04, 20), new DateTime(ano, 05, 20));
            (DateTime start, DateTime end) Gemeos = (new DateTime(ano, 05, 20), new DateTime(ano, 06, 20));
            (DateTime start, DateTime end) Cancer = (new DateTime(ano, 07, 21), new DateTime(ano, 07, 22));
            (DateTime start, DateTime end) Leao = (new DateTime(ano, 07, 23), new DateTime(ano, 08, 22));
            (DateTime start, DateTime end) Virgem = (new DateTime(ano, 08, 23), new DateTime(ano, 09, 22));
            (DateTime start, DateTime end) Libra = (new DateTime(ano, 09, 23), new DateTime(ano, 10, 22));
            (DateTime start, DateTime end) Escorpiao = (new DateTime(ano, 10, 23), new DateTime(ano, 11, 22));
            (DateTime start, DateTime end) Sagitario = (new DateTime(ano, 11, 23), new DateTime(ano, 12, 21));
            (DateTime start, DateTime end) Capricornio = (new DateTime(ano, 12, 22), new DateTime(ano, 01, 19));
            (DateTime start, DateTime end) Aquario = (new DateTime(ano, 01, 20), new DateTime(ano, 02, 18));
            (DateTime start, DateTime end) Peixes = (new DateTime(ano, 02, 19), new DateTime(ano, 03, 20));

            return Niver switch
            {
                var n when n >= Aries.start && n <= Aries.end => "Aries",
                var n when n >= Touro.start && n <= Touro.end => "Touro",
                var n when n >= Gemeos.start && n <= Gemeos.end => "Gêmeos",
                var n when n >= Cancer.start && n <= Cancer.end => "Câncer",
                var n when n >= Leao.start && n <= Leao.end => "Leão",
                var n when n >= Virgem.start && n <= Virgem.end => "Virgem",
                var n when n >= Libra.start && n <= Libra.end => "Libra",
                var n when n >= Escorpiao.start && n <= Escorpiao.end => "Escorpião",
                var n when n >= Sagitario.start && n <= Sagitario.end => "Escorpião",
                var n when n >= Capricornio.start && n <= Capricornio.end => "Carpicórnio",
                var n when n >= Aquario.start && n <= Aquario.end => "Aquário",
                var n when n >= Peixes.start && n <= Peixes.end => "Peixes",
                _ => "Signo desconhecido!"
            };
        }
        private set{}
    }
}