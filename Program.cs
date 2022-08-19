// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Se você não inicializar no C# o atributo no construtor, terá o erro de compilação.
//Mas, no caso do C# 11, este código irá compilar sem problemas.
public struct MinhaStruct
{
    public int Numero { get; set; }

    public MinhaStruct()
    {
    }
}