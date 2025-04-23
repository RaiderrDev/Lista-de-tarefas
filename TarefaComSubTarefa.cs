class TarefaComSubTarefa : Tarefa
{
    public static Dictionary<string, List<Tarefa>> tarefaComSubTarefa = new Dictionary<string, List<Tarefa>>(); //Dicionario com lista de objetos

    public static void AdicionarTarefaComSubTarefa()
    {
        Console.WriteLine("Digite o nome da tarefa principal:");
        string nomeTarefa = Console.ReadLine();

        if (!tarefaComSubTarefa.ContainsKey(nomeTarefa))
        {
            tarefaComSubTarefa[nomeTarefa] = new List<Tarefa>();
            Console.WriteLine("Deseja adicionar quantas sub-tarefas?");

            if (!int.TryParse(Console.ReadLine(), out int valorValido) || valorValido <= 0)
            {
                Console.WriteLine("Inválido. Retornando ao menu.");
                return;
            }

            for (int i = 0; i < valorValido; i++)
            {
                Console.WriteLine("Digite o nome da sub-tarefa:");
                string nomeSub = Console.ReadLine();
                Console.WriteLine("Digite a descrição da tarefa");
                string descricaoTarefa = Console.ReadLine();

                tarefaComSubTarefa[nomeTarefa].Add(new Tarefa { Titulo = nomeSub, Descricao = descricaoTarefa, Concluida = false }); //adicionando tarefa no dicionario 
                Console.WriteLine("Adicionada com sucesso!");
            }
        }
        else
        {
            Console.WriteLine("Já existe uma lista de sub-tarefas com esse nome.");
        }
    }

    public static void RemoverSubTarefas()
    {
        Console.WriteLine("Digite o nome da tarefa principal:");
        string nomeTarefa = Console.ReadLine();

        if (!tarefaComSubTarefa.ContainsKey(nomeTarefa))
        {
            Console.WriteLine("Não encontrado!");
        }
        else
        {
            Console.WriteLine("1 - Remover a tarefa principal. 2 - Remover sub-tarefa");
            if (!int.TryParse(Console.ReadLine(), out int escolha) || escolha <= 0 || escolha > 2)
            {
                Console.WriteLine("Escolha inválida.");
            }
            else
            {
                if (escolha == 1)
                {
                    Console.WriteLine("Tarefa principal removida com sucesso!");
                    tarefaComSubTarefa.Remove(nomeTarefa);
                }
                else
                {
                    Console.WriteLine("Digite o ID da sub-tarefa");

                    if (!int.TryParse(Console.ReadLine(), out int idValido) || idValido < 0 || idValido > tarefaComSubTarefa[nomeTarefa].Count() - 1)
                    {
                        Console.WriteLine("ID não encontrado.");
                    }
                    else
                    {
                        Console.WriteLine("Sub-tarefa removida com sucesso!");
                        tarefaComSubTarefa[nomeTarefa].RemoveAt(idValido);
                    }
                }
            }
        }
    }

    public override void MarcarComoConcluida()
    {
        Console.WriteLine("Digite o nome da tarefa principal:");
        string nomeTarefa = Console.ReadLine();

        if (tarefaComSubTarefa.ContainsKey(nomeTarefa))
        {
            Console.WriteLine("Digite o id da sub-tarefa");

            if (!int.TryParse(Console.ReadLine(), out int id) || id < 0)
            {
                Console.WriteLine("ID não encontrado.");
            }
            else
            {
                Console.WriteLine("Tarefa marcada como conclúida com sucesso!");
                tarefaComSubTarefa[nomeTarefa][id].Concluida = true;
            }
        }
        else 
        {
            Console.WriteLine("Nome não encontrado");
        }
    }
}