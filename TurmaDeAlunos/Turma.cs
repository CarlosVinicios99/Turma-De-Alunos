using System;
using System.Collections.Generic;

namespace TurmaDeAlunos{
    class Turma{
        private string _disciplina;
        private string _codigo;
        private List<Aluno> _listaDeAlunos = new List<Aluno>();

        public Turma(string codigo, string disciplina){
            _codigo = codigo;
            _disciplina = disciplina;
        }

        public void AdicionarAluno(Aluno aluno){
            _listaDeAlunos.Add(aluno);
        }

        public bool BuscarAluno(int matricula){
            bool isMatriculado = false;

            foreach(Aluno aluno in _listaDeAlunos){
                if(aluno.Matricula == matricula){
                    Console.WriteLine(aluno.DadosDoAluno());
                    isMatriculado = true;
                }
            }
            return isMatriculado;
        }

        public void LancarNotas(){
            foreach(Aluno aluno in _listaDeAlunos){
                Console.WriteLine("\nNome: " + aluno.Nome);
                Console.Write("Nota1: ");
                aluno.Nota1 = double.Parse(Console.ReadLine());
                Console.Write("Nota2: ");
                aluno.Nota2 = double.Parse(Console.ReadLine());
            }
        }

        public override string ToString(){
            string resultadoDaTurma = "Disciplina: " + _disciplina + "\nCodigo: " + _codigo
            + "\nResultado dos alunos\n---------------------------------------------------\n";
            foreach(Aluno aluno in _listaDeAlunos){
                resultadoDaTurma += aluno.ToString();
            }
            return resultadoDaTurma;
        }
    }
}