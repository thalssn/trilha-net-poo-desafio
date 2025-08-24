namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        //Implementado
        public string Numero { get; set; }
        public string Modelo { get; }
        public string IMEI { get; }

        public int Memoria { get; }


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            //Implementado
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}