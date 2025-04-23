class TarefaSimples : Tarefa //Herdando da classe base (Tarefa)
{
    public static void AdicionarTarefa()
    {
        Console.WriteLine("Qual o nome da tarefa?:");
        string nomeTarefa = Console.ReadLine();
        Console.WriteLine("Qual a descrição da tarefa?:");
        string descricaoTarefa = Console.ReadLine();

        tarefaSimples.Add(new Tarefa { Titulo = nomeTarefa, Descricao = descricaoTarefa, Concluida = false }); //adicionando tarefa a lista de tarefas simples
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    public static void RemoverTarefaSimples()
    {
        Console.WriteLine("Digite o nome da tarefa:");
        string nomeTarefa = Console.ReadLine();

        var tarefa = from tarefas in tarefaSimples
                     where tarefas.Titulo == nomeTarefa
                     select tarefas;

        List<Tarefa> listaTemp = tarefa.ToList(); //lista temporaria
        
        if (listaTemp.Count() > 0)
        {
            Console.WriteLine($"Tarefa: {listaTemp[0].Titulo} Removida com sucesso!");
            tarefaSimples.Remove(listaTemp[0]);
        }
        else 
        {
            Console.WriteLine("Nenhuma tarefa com esse nome.");
        }
    }

    public override void MarcarComoConcluida()
    {
        Console.WriteLine("Digite o id da tarefa:");

        if (!int.TryParse(Console.ReadLine(), out int id) || id < 0 || id > tarefaSimples.Count() -1)
        {
            Console.WriteLine("Não existe uma tarefa com esse id.");
        }
        else 
        {
            Console.WriteLine("Tarefa concluída com sucesso!");
            tarefaSimples[id].Concluida = true;
        }
    }
}