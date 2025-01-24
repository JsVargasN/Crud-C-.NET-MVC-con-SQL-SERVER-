using System;
using System.Collections.Generic;

namespace PruebaCrud.Models;

public partial class Empleado
{
    public int Idempleado { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public string NumDocumento { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Area { get; set; } = null!;
}
