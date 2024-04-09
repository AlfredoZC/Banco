
bool fin = false;

while (fin == false){

    Cliente cliente = new Cliente();

    Console.WriteLine("Ingresa el nombre del cliente");
    cliente.Nombre = Console.ReadLine();

    Console.WriteLine("Ingresa el CI de la persona");
    cliente.NumeroCedula = Console.ReadLine();

    cliente.SaldoTotal = 0;

    Random random = new Random();
    cliente.NroCuenta = random.Next(0,1001);

    Console.WriteLine($"El nombre de la persona es: {cliente.Nombre}");
    Console.WriteLine($"El CI de la persona es: {cliente.NumeroCedula}");
    Console.WriteLine($"El Saldo Inicial de la persona es: {cliente.SaldoTotal}");
    Console.WriteLine($"El número de cuenta de la persona es: {cliente.NroCuenta}");

    Console.WriteLine("___________________________________________________");

    Console.WriteLine("¿Desea agregar los datos de otra persona? Seleccione 1: Si / Seleccione 2: No ");

    int option = int.Parse(Console.ReadLine());

    if(option == 1) {

        string Nombre_2 = "";
         string NumeroCedula_2 = "";
        decimal SaldoTotal_2 = 0;
        int NroCuenta_2 = 0;

        
        Console.WriteLine("Ingresa el nombre del cliente");
        Nombre_2 = Console.ReadLine();

        Console.WriteLine("Ingresa el CI de la persona");
        NumeroCedula_2 = Console.ReadLine();

        SaldoTotal_2 = 0;
        NroCuenta_2 = random.Next(0,1001);

        Console.WriteLine($"El nombre de la persona 2 es: {Nombre_2}");
        Console.WriteLine($"El CI de la persona 2 es: {NumeroCedula_2}");
        Console.WriteLine($"El Saldo Inicial de la persona 2 es: {SaldoTotal_2}");
        Console.WriteLine($"El número de cuenta de la persona 2 es: {NroCuenta_2}");    

    }
    else if(option == 2) {
        Console.WriteLine("Gracias por usar nuestros servicios, tus datos han sido guardados");
    }
    else {
        Console.WriteLine("Ingresaste valores diferentes a 1 y 2. Ingresa 1 para registrar a otra persona o 2 para terminar el programa ");
        option = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Deseas continuar agregando usuarios? 1 = si ; 2 = no");
    int continuar = int.Parse(Console.ReadLine());

    if( continuar == 2) {
    fin = true; 

    }

} //Fin del While

struct Cliente {
    public string Nombre;
    public string NumeroCedula;
    public decimal SaldoTotal;
    public int NroCuenta;
}


