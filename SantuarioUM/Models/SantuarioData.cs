using System.Text.Json.Serialization;

namespace SantuarioUM.Models;

public class SantuarioData
{
    public string Id { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public List<Area> Areas { get; set; }
}

public class Area
{
    public string Id { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public List<Mueble> Muebles { get; set; }
}

public class Mueble
{
    public string Id { get; set; }
    public string Titulo { get; set; }
    public Dimensiones Dimensiones { get; set; }
}

public class Dimensiones
{
    public Seccion Rito { get; set; }
    public Seccion Cumplimiento { get; set; }
    public Seccion Aplicacion { get; set; }
}

public class Seccion
{
    public string Contenido { get; set; }
    public List<string> Citas { get; set; }
}