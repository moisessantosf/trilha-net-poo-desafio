namespace DesafioPOO.Models
{    
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Preparando {Modelo} para instalação de aplicativo:");
            Console.WriteLine($"Instalando {nomeApp} ...");
            Console.WriteLine($"{nomeApp} instalado com sucesso em {Modelo}!");
        }
    }
}