using Spectre.Console;
using VeterinariaApp.Models;
using VeterinariaApp.Services;

MascotaService servicio = new MascotaService();

// Datos iniciales en memoria
servicio.Agregar(new Mascota(1, "Firulais", "Perro", 3));
servicio.Agregar(new Mascota(2, "Michi", "Gato", 2));
servicio.Agregar(new Mascota(3, "Piolin", "Canario", 1));
servicio.Agregar(new Mascota(4, "Nemo", "Pez", 1));
servicio.Agregar(new Mascota(5, "Toby", "Conejo", 4));
servicio.Agregar(new Mascota(6, "Luna", "Tortuga", 5));

bool salir = false;

while (!salir)
{
    Console.Clear();

    var opcion = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
        .Title("[green]=== SISTEMA DE VETERINARIA ===[/]")
        .AddChoices(
            "1. Listar mascotas",
            "2. Registrar mascota",
            "3. Eliminar mascota",
            "4. Salir"
        ));

    switch (opcion)
    {
        case "1. Listar mascotas":

            var mascotas = servicio.ObtenerTodas();

            var tabla = new Table();

            tabla.Border(TableBorder.Rounded);
            tabla.AddColumn("[yellow]ID[/]");
            tabla.AddColumn("[yellow]Nombre[/]");
            tabla.AddColumn("[yellow]Especie[/]");
            tabla.AddColumn("[yellow]Edad[/]");

            foreach (var mascota in mascotas)
            {
                tabla.AddRow(
                    mascota.Id.ToString(),
                    mascota.Nombre,
                    mascota.Especie,
                    mascota.Edad.ToString()
                );
            }

            AnsiConsole.Write(tabla);
            Console.ReadKey();

            break;

        case "2. Registrar mascota":

            int id = AnsiConsole.Ask<int>("Ingrese el ID:");
            string nombre = AnsiConsole.Ask<string>("Ingrese el nombre:");
            string especie = AnsiConsole.Ask<string>("Ingrese la especie:");
            int edad = AnsiConsole.Ask<int>("Ingrese la edad:");

            servicio.Agregar(
                new Mascota(id, nombre, especie, edad)
            );

            AnsiConsole.MarkupLine(
                "[green]Mascota registrada correctamente.[/]"
            );

            Console.ReadKey();

            break;

        case "3. Eliminar mascota":

            int idEliminar = AnsiConsole.Ask<int>(
                "Ingrese el ID de la mascota a eliminar:"
            );

            if (servicio.Eliminar(idEliminar))
            {
                AnsiConsole.MarkupLine(
                    "[green]Mascota eliminada correctamente.[/]"
                );
            }
            else
            {
                AnsiConsole.MarkupLine(
                    "[red]No existe una mascota con ese ID.[/]"
                );
            }

            Console.ReadKey();

            break;

        case "4. Salir":

            salir = true;

            break;
    }
}  