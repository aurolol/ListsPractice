class Program
{
    public static void Main(string[] args)
    {

        List<string> davetliler = new List<string>()
        {
            "Bülent Ersoy",
            "Ajda Pekkan",
            "Ebru Gündeş",
            "Hadise",
            "Hande Yener",
            "Tarkan",
            "Funda Arar",
            "Demet Akalın"
        };

        Console.WriteLine("** Davetliler **");

        for (int i = 0; i < davetliler.Count; i++)
        {
            Console.WriteLine(i+1 + "-" + davetliler[i]);
        }

    }




}