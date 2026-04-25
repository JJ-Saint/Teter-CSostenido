bool stop = true;

List<string> nombrePacientes = new List<string>();
List<int> edadPacientes = new List<int>();


    string Options =
                      "1.Register Patient\n"+
                     "2. List Patients\n" +
                     "3. Search Patients\n" +
                     "4.Exit\n";
     while (stop)
     {
         Console.WriteLine("Please Enter The Number Do You Want\n"); 
         Console.WriteLine(Options);
         string choose = Console.ReadLine();
         
         Console.Clear();

         switch (choose)
         {
             case "1":
             {
                 Console.WriteLine("Enter Name And LastNames Of The Patient");
                 string paciente = Console.ReadLine();
                 nombrePacientes.Add(paciente);
                 int age = 0;
                 bool ageCorrect = false;
                 while (!ageCorrect)
                 {
                     Console.WriteLine("Enter Age Of Patient");
                     try
                     {
                         age = int.Parse(Console.ReadLine());
                         ageCorrect = true;
                         if (age >=0 && age<=100)
                         {
                             Console.WriteLine("Great \n"+
                                               "Please Press Enter");
                             Console.ReadLine();
                             

                         }
                         else
                         {
                             Console.WriteLine("Please Enter A Real Number"+
                                               "Please Press Enter For Write Again");
                             Console.ReadLine();
                             Console.Clear();
                             break;
                         }
                         
                     }
                     catch (FormatException)
                     {
                         Console.WriteLine("ERROR   PLEASE ENTER A VALID NUMBER");
                     }
                     catch (OverflowException)
                     {
                         Console.WriteLine("ERROR      THE NUMBER IS TOO MUCH LARGUE");
                     }
                     
                 }
                 
                 edadPacientes.Add(age);
                 
                 break;
             }

             case "2":
             {
                 foreach (var pacientes in nombrePacientes)
                 {
                     Console.WriteLine($"The Patients in the system are: \n" +
                                       $"-{pacientes}");
                     Console.WriteLine("       Please Press Enter");
                 }
                 
                 Console.ReadLine();
                 foreach (var edad in edadPacientes)
                 {
                     Console.WriteLine($"The Age Of The Patient is: \n" +
                                       $"-{edad}");
                     Console.WriteLine("     Please Press Enter Again For View The Options");

                 }
                 Console.ReadLine();
                 Console.Clear();

                 break;
             }

             case "3":
             {
                 Console.Write("Search It \n");
                 string s = Console.ReadLine();

                 
                 string Name = nombrePacientes.FirstOrDefault(p =>p == s);
                 if (Name == null)
                 {
                     Console.WriteLine("The Patient Is Not In System");
                     Console.WriteLine("Please Press Enter For Search Again");
                     Console.ReadLine();
                     Console.Clear();
                 }
                 else
                 {
                     Console.WriteLine($"The patient{Name} Is In The System");
                     Console.ReadLine();
                     Console.Clear();
                 }
                 
                 break;
             }

             case "4":
             {
                 stop = false;
                 break;
             }

         }
     }





















/*string Form = "Choose An Option";

Console.Write(Form);
Console.ReadLine();
*/
