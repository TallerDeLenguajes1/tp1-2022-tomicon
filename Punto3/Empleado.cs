// See https://aka.ms/new-console-template for more information


public class Empleado
{
    private int dni;
    private string nombre;
    private string apellido;
    private string direccion;
    private double sueldoBase;
    DateTime ingresoEmpresa;
    DateTime nacimiento;

    public Empleado()
    {
    }

    public Empleado(int dni, string nombre, string apellido, string direccion, double sueldoBase, DateTime ingresoEmpresa, DateTime nacimiento, int dni, string nombre, string apellido, string direccion, DateTime ingresoEmpresa, DateTime nacimiento, double sueldoBase)
    {
        this.Dni = dni;
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Direccion = direccion;
        this.SueldoBase = sueldoBase;
        this.IngresoEmpresa = ingresoEmpresa;
        this.Nacimiento = nacimiento;
    }

    public int Dni { get => dni; set => dni = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public DateTime IngresoEmpresa { get => ingresoEmpresa; set => ingresoEmpresa = value; }
    public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
    public double SueldoBase { get => sueldoBase; set => sueldoBase = value; }

    public int calcularAntiguedad(){
        int antiguedad = DateTime.Now.Year - this.IngresoEmpresa.Year;
        if (DateTime.Now.Month == this.IngresoEmpresa.Month && DateTime.Now.Day < this.IngresoEmpresa.Day || DateTime.Now.Month < this.IngresoEmpresa.Month)
        {
            antiguedad--;
        }
        return antiguedad;
    }

    public int calcularEdad(){
        int edad = DateTime.Now.Year - this.Nacimiento.Year;
        if (DateTime.Now.Month == this.Nacimiento.Month && DateTime.Now.Day < this.Nacimiento.Day || DateTime.Now.Month < this.Nacimiento.Month)
        {
            edad--;
        }
        return edad;
    }

    public double calcularDescuento(){
        return this.SueldoBase * 0.15;
    }

    public double calcularAdicional(){
        if (this.calcularAntiguedad()>= this.SueldoBase)
        {
            return this.SueldoBase * 0.25;
        } else
        {
            return ((double)this.calcularAntiguedad())*0.01* this.SueldoBase;
        }
    }

    public double calcularSalario(){
        return this.SueldoBase + this.calcularAdicional() + this.calcularDescuento();
    }

}
