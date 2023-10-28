namespace Controlador;
using Biblioteca;
using Newtonsoft.Json;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello there!");
        Aluno p1 = new Aluno("Aluno", 10);
        Professor p2 = new Professor("Professor", 30, 4000);

        Aluno a1 = new Aluno("nome");
        a1.notas.Add(3);
        a1.notas.Add(7);
        a1.notas.Add(5);

        p1.notas.Add(6);

        a1.GetInfo();
        p1.GetInfo();
        p2.GetInfo();

        List<Tuple<Aluno, Professor>> novaLista = new List<Tuple<Aluno, Professor>>();
        Tuple<Aluno, Professor> tuple = new Tuple<Aluno, Professor>(a1, p2);
        Tuple<Aluno, Professor> tuple2 = new Tuple<Aluno, Professor>(p1, p2);

        novaLista.Add(tuple);
        novaLista.Add(tuple2);

        string serialized = JsonConvert.SerializeObject(novaLista, Formatting.Indented);

        File.WriteAllText(@"C:\DIODotNet\SolutionSQL\file.json", serialized);

        Console.ReadKey();
        
    }
}
