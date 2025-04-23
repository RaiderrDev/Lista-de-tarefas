
class Tarefa //classe base das tarefas
{

    public static List<Tarefa> tarefaSimples = new List<Tarefa>(); //Lista de tarefas

    private string _titulo;
    private string _descricao;
    public bool Concluida { get; set; }

    //Propriedades da classe
    public string Titulo
    {
        get { return _titulo; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                _titulo = "Não especificado.";
            }
            else
            {
                _titulo = value;
            }
        }
    }

    public string Descricao
    {
        get { return _descricao; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                _descricao = "Não especificado";
            }
            else
            {
                _descricao = value;
            }
        }
    }

    public virtual void MarcarComoConcluida()
    {
        Console.WriteLine("Marcar como concluida da classe base");
    }


    public static void ListarTarefas()
    {
        int idTarefaSimples = 0;
        int idTarefaSubTarefa = 0;

        if (tarefaSimples.Count() == 0)
        {
            Console.WriteLine("Nenhuma tarefa simples.");
        }
        else
        {
            Console.WriteLine("Tarefas simples:");
            foreach (var tarefa in tarefaSimples)
            {
                Console.WriteLine($" ID: {idTarefaSimples} Tarefa: {tarefa.Titulo}. Descrição: {tarefa.Descricao}. Conclúida: {tarefa.Concluida}");
                idTarefaSimples++;
            }
        }
        if (TarefaComSubTarefa.tarefaComSubTarefa.Count() == 0)
        {
            Console.WriteLine("Nenhuma tarefa com sub-tarefa");
        }
        else
        {
            foreach (var tarefa in TarefaComSubTarefa.tarefaComSubTarefa)
            {
                Console.WriteLine($"Tarefa: {tarefa.Key}");
                foreach (var sub in tarefa.Value)
                {
                    Console.WriteLine($" ID: {idTarefaSubTarefa} Titulo: {sub.Titulo}. Descrição: {sub.Descricao}. Concluída: {sub.Concluida}");
                    idTarefaSubTarefa++;
                }
            }
        }
    }
}
