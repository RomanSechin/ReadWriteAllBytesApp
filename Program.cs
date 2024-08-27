using System.IO;
using System.Text;
using System.Text.Json;
internal class Program
{
    private static void Main(string[] args)
    {
        File.WriteAllText("eureka.txt", "םולש!", Encoding.Unicode);
        File.WriteAllText("elephant1.txt", "\uD83D\uDC18");
        File.WriteAllText("elephant2.txt", "\U0001F418");
        byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
        foreach (byte b in eurekaBytes) {
            Console.Write("{0:x2} ", b);
        }
        Console.WriteLine();
        Console.WriteLine(Encoding.UTF8.GetString(eurekaBytes));
        Console.WriteLine(JsonSerializer.Serialize("ש"));
    }
}