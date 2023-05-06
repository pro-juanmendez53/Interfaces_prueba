



using interfaces_prueba.MisClases;

Console.WriteLine("Ingresa tu nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine("Ingresa tu edad: ");
int edad = Convert.ToInt32(Console.ReadLine());




Persona per = new Persona(nombre, edad);
per.cumplirAños();
per.DecirMiNombre();





