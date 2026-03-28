using ClinicaSalud.Models;

//var id = id;
//string name = name;

/*Console.Write(new Pacientes(123,"szapatar",12, "diarrea").Name);
Console.Write(new Pacientes(123,"szapatar",12, "diarrea").Id);
Console.Write(new Pacientes(123,"szapatar",12, "diarrea").Edad);
Console.Write(new Pacientes(123,"szapatar",12, "diarrea").Sintoma);*/
bool system = false;

List<string> nombrePacientes = new List<string>();

bool exit = false;
bool repeat = false;


{
    string Options =  "Please Enter The Number Do You Want\n" +
                      "1.Register Patient\n"+
                     "2. List Patients\n" +
                     "3. Search Patients\n" +
                     "4.Exit\n";
    Console.WriteLine(Options);


    ConsoleKeyInfo choose = new ConsoleKeyInfo();

    choose = Console.ReadKey(true);


    switch (choose.Key )
    {
        case ConsoleKey.D1:
        {
            Console.WriteLine("Enter Data Of Patient");
            string paciente = Console.ReadLine();
            nombrePacientes.Add(paciente);
            Console.Clear();
            Console.WriteLine(Options);
            repeat = true;
            break;
        }

        case ConsoleKey.D2:
        {
            foreach (var pacientes in nombrePacientes)
            {
                Console.WriteLine($"El paciente {pacientes}");
            }
            Console.ReadLine();
            break;
        }

        case ConsoleKey.D3:
        {
            Console.Write("Do You Want Search Any Patient And\n");
            break;
        }

        case ConsoleKey.D4:
        {
            Console.Write("Do You Want Exit Of The System And\n");
            exit = true;
            break;
        }
        
    }
    
}



   















/*string Form = "Choose An Option";

Console.Write(Form);
Console.ReadLine();
*/
