using System;

namespace TurmaDeAlunos{
    class InterfaceDoUsuario{
        public InterfaceDoUsuario(){
            Interacao();
        }

        private void Interacao(){
            int opcao = 0;
            Turma minhaTurma;
            string nomeDoAluno;
            int matriculaDoAluno;

            Console.Write("Digite a discipina da turma: ");
            string disciplina = Console.ReadLine();

            Console.Write("Digite o codigo da turma: ");
            string codigo = Console.ReadLine();
            Console.Clear();

            minhaTurma = new Turma(codigo, disciplina);

            while(opcao != 5){
                Console.WriteLine("\n(1)Cadastrar Aluno na Turma\n(2)Buscar aluno");
                Console.WriteLine("(3)Lancar notas\n(4)Visualizar Resultados\n(5)Sair");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1:
                        Console.Write("Digite o nome do aluno: ");
                        nomeDoAluno = Console.ReadLine();

                        Console.Write("Digite a matricula: ");
                        matriculaDoAluno = int.Parse(Console.ReadLine());
                        Console.Clear();

                        minhaTurma.AdicionarAluno(new Aluno(nomeDoAluno, matriculaDoAluno));
                        break;

                    case 2:
                        Console.Write("Digite a matricula do aluno: ");
                        matriculaDoAluno = int.Parse(Console.ReadLine());
                        Console.Clear();
                        minhaTurma.BuscarAluno(matriculaDoAluno);
                        break;

                    case 3:
                        minhaTurma.LancarNotas();
                        break;

                    case 4:
                        Console.WriteLine(minhaTurma);
                        break;

                    case 5:
                        Console.WriteLine("Digite Enter para sair...");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Opcao Invalida\nTente Novamente");
                        break;
                }
            }
        }
    }
}