public class Televisao
{
    private const int(VOL_MaX)
    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
    }

    public float Tamanho { get; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; set; }
    public int Estado { get; set; }

    public void AumentarVolume()
    {
        if (Volume < 100)
            Volume = Volume++;
        else
            Console.Write("TV já esta no max.");
    }
}