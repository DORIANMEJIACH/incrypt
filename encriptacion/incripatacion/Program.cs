using encripcion;
using System.Text.Json;

class Program
{
    public class UserInfo
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
    static void Main(string[] args)
    {
        string jsonString = "{\"Usuario\":\"User02420\",\"Password\":\"Inc0melS@\",\"Token\":\"aJkL9xPzT72QsW3V\"}";

        

       
        Encryptmd5 encriptador = new Encryptmd5();

     /* string mensajeOriginal = "Hola123";
        string mensajeEncriptado = encriptador.Encrypt(jsonString);
        Console.WriteLine($"Mensaje Encriptado: {mensajeEncriptado}");*/
     Console.WriteLine("ingresa el incryptado");
        string mensajeEncriptado = Console.ReadLine();
        string mensajeDesencriptado = encriptador.Decrypt(mensajeEncriptado);
        Console.WriteLine($"Mensaje Desencriptado: {mensajeDesencriptado}");
        var userInfo = JsonSerializer.Deserialize<UserInfo>(jsonString);
        Console.WriteLine(userInfo);


        Console.ReadKey();
    }
   
}