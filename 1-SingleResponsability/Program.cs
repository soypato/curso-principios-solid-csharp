using SingleResponsability;

StudentRepository studentRepository = new();
StudentHelper.Export(studentRepository);
Console.WriteLine("Proceso Completado");