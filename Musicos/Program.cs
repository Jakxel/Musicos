abstract class Musico
{
    public string? Nombre {get; set;}
    public Musico(string n){Nombre = n;}
    public string? Instrumentos {get; set;}
    public void Saludar(){Console.WriteLine($"Hola soy {Nombre}");}
    public /*virtual*/ abstract void Tocar(){Console.WriteLine($"{Nombre} tocando su isntrumento");}
   
}
 class Bajista : Musico
    {
        public string bajo{get; set;}
        public Bajista(string n, string b): base(n)
        {
            bajo=b;
        }
        public override void Tocar()
        {
            Console.WriteLine($"{Nombre}tocando su {bajo}");
        }
    }


class Program
{
    private static void Main(string[] args)
    {
        List<Musico>grupo=new List<Musico>();
        grupo.Add(new Musico("Chalino Sanchez"));
        grupo.Add(new Bajista("El bajista de Cjhalino Sanchez", "Bajo"));

        foreach(var m in grupo)
            m.Saludar();

        foreach(var m in grupo)
            m.Tocar();
    }
}
