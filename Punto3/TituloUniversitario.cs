// See https://aka.ms/new-console-template for more information

public class TituloUniversitario
{
    private string titulo;
    private string universidad;

    public TituloUniversitario()
    {
    }

    public TituloUniversitario(string carrera, string uni)
    {
        if (string.IsNullOrEmpty(carrera) || string.IsNullOrEmpty(uni))
        {
            throw new ArgumentNullException("faltan campos para crear el titulo universitario");
        } else
        {
            this.Titulo= carrera;
            this.Universidad= uni;
        }
    }

    public string Universidad { get => universidad; set => universidad = value; }
    public string Titulo { get => titulo; set => titulo = value; }
}