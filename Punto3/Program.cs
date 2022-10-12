using System;
// See https://aka.ms/new-console-template for more information

List<Empleado> listaEmpleados= new List<Empleado>();

System.Console.WriteLine("Cuantos empleados desea cargar?");
int cantEmps= Convert.ToInt32(Console.ReadLine());
int dni;
string nombre;
string apellido;
string direccion;
double sueldoBase;
DateTime ingresoEmpresa;
DateTime nacimiento;
DateTime? fechaDivorcio; 
int cantHijos;
TituloUniversitario? titulo;
string carrera, universidad;

int dia, mes, anio;
Random rand= new Random();

for (int i = 0; i < cantEmps; i++)
{
    System.Console.WriteLine("Empleado nro" + (i+1));
    try
    {
        System.Console.WriteLine("\nNombre:");
        nombre= Console.ReadLine();
        System.Console.WriteLine("Apellido:");
        apellido= Console.ReadLine();
        System.Console.WriteLine("Dni:");
        dni= Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Direccion:");
        direccion= Console.ReadLine();
        System.Console.WriteLine("Sueldo base:");
        sueldoBase= Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Cantidad de hijos:");
        cantHijos= Convert.ToInt32(Console.ReadLine());
        dia= rand.Next(28);
        mes= rand.Next(12);
        anio= rand.Next(1950, 2006);
        nacimiento= new DateTime(anio, mes, dia);
        dia= rand.Next(29);
        mes= rand.Next(13);
        anio= rand.Next(1950, 2006);
        ingresoEmpresa= new DateTime(anio, mes, dia);
        System.Console.WriteLine("Esta divorciado? (si= 1, no= otra tecla)");
        int divor= Convert.ToInt32(Console.ReadLine());
        if (divor==1)
        {
            fechaDivorcio= new DateTime(anio, mes, dia); //se divorcio el mismo dia que ingreso a la empresa :v
        } else
        {
            fechaDivorcio= null;
        }
        System.Console.WriteLine("Tiene titulo? (si= 1, no= otra tecla)");
        int tieneTitulo= Convert.ToInt32(Console.ReadLine());
        if (tieneTitulo== 1)
        {
            System.Console.WriteLine("Cual es su titulo?");
            carrera= Console.ReadLine();
            System.Console.WriteLine("De que universidad se recibio?");
            universidad= Console.ReadLine();
            titulo= new TituloUniversitario(carrera, universidad);
        } else
        {
            titulo= null;
        }
        Empleado nuevo = new Empleado(dni, nombre, apellido, direccion, sueldoBase, ingresoEmpresa,nacimiento, fechaDivorcio, cantHijos, titulo);
        listaEmpleados.Add(nuevo);
    }
    catch(ArgumentNullException)
    {
        System.Console.WriteLine("Debe ingresar todos los datos");
    }
    catch (ArgumentOutOfRangeException)
    {
        System.Console.WriteLine("Alguno de los datos ingresados no es valido");
    }
    catch (IndexOutOfRangeException)
    {
        System.Console.WriteLine("Ya no hay espacio para mas empleados");
    }
    catch (System.Exception ex)
    {
        System.Console.WriteLine("Error:" + ex.Message);
    }

    foreach (Empleado emp in listaEmpleados)
    {
        emp.listarInfo();
    }
}
