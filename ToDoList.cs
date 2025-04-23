using System;
using System.Collections.Generic;
using System.Linq;

class ToDoList //classe que chamará todos métodos responsaveis
{
    static void Main()
    {
        TarefaSimples tarefa = new TarefaSimples();
        TarefaComSubTarefa tarefaSub = new TarefaComSubTarefa();

        while (true)
        {
            Console.WriteLine("1 - Adicionar tarefa simples");
            Console.WriteLine("2 - Adicionar tarefa com Sub-Tarefas");
            Console.WriteLine("3 - Remover Tarefa simples");
            Console.WriteLine("4 - Remover tarefa com Sub-Tarefas");
            Console.WriteLine("5 - Listar Todas tarefas");
            Console.WriteLine("6 - Marcar tarefa simples como concluída");
            Console.WriteLine("7 - Marcar tarefa com sub-tarefas como concluída");
            Console.WriteLine("8 - Sair");

            string escolha = Console.ReadLine(); //Aqui eu não trato a entrada com tryParse, pois o default ja vai se encarregar de entradas inválida

            //switch que trata a escolha
            switch (escolha)
            {
                case "1":
                    TarefaSimples.AdicionarTarefa();
                    break;
                case "2":
                    TarefaComSubTarefa.AdicionarTarefaComSubTarefa();
                    break;
                case "3":
                    TarefaSimples.RemoverTarefaSimples();
                    break;
                case "4":
                    TarefaComSubTarefa.RemoverSubTarefas();
                    break;
                case "5":
                    Tarefa.ListarTarefas();
                    break;
                case "6":
                    tarefa.MarcarComoConcluida();
                    break;
                case "7": tarefaSub.MarcarComoConcluida();
                    break;
                case "8":
                    Console.Clear();
                    Console.WriteLine("Encerrado.");
                    return; //encerra o programa
                default:
                    Console.WriteLine("Escolha inválida. Tente novamente");
                    break;
            }
        }
    }
}