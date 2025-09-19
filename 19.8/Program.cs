namespace _19._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> voti = new List<float>();
            float voto;
            Console.WriteLine("Inserisci i voti (da 0 a 10), per uscire premere INVIO");
            while (float.TryParse(Console.ReadLine(), out voto))
            {
                if (voto < 0 || voto > 10)
                    break;
                voti.Add(voto);
            }
            float media = 0;
            media = voti.Average();
            int count = 0;
            foreach (float v in voti)
            {
                if (v < media)
                    count++;
            }
            Console.WriteLine($"Media: {media}, Voti sotto la media: {count}");
        }
    }
}
