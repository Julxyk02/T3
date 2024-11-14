using T3;
Cita[] citas = new Cita[0];
int count = 0;
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
            CitaUtil.crearcita(citas, ref count);
            break;
        case 2:
            CitaUtil.listarcitas(citas, count);
            break;
        case 3:
            CitaUtil.modificar(citas, count);
            break;
        case 4:
            Console.WriteLine("Fin del programa");
            break;
        default:
            Console.WriteLine("opcion no valida, vuelva a intentar");
            break;
    }

} while(opcion !=4);
