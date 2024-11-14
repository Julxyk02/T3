int opcion = 0;
do{
    Console.WriteLine("--- Menú de opciones ---");
    Console.WriteLine("1) Crear cita");
    Console.WriteLine("2) Listar citas");
    Console.WriteLine("3) Modificar univerdiad");
    Console.WriteLine("4) Fin");
    Console.Write("Selecciona una opción: ");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion){
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            Console.WriteLine("Fin del programa");
            break;
        default:
            Console.WriteLine("opcion no valida, vuelva a intentar");
            break;
    }

} while(opcion !=4);
