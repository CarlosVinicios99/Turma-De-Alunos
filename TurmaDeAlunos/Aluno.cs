namespace TurmaDeAlunos{
    class Aluno{
        public string Nome{get; set;}
        public int Matricula{get; set;}
        public double Nota1{get; set;}
        public double Nota2{get; set;}

        public Aluno(string nome, int matricula){
            Nome = nome;
            Matricula = matricula;
        }

        private double Media(){
            return (Nota1 + Nota2) / 2;
        }

        public string DadosDoAluno(){
            return $"Nome: {Nome}\nMatricula: {Matricula}";
        }

        public override string ToString(){
            string resultado = Media() > 6.0 ? "Aprovado!" : "Reprovado";

            return "\n\nNome: " + Nome + "\nMatricula: " + Matricula + "\nNota1: " + Nota1.ToString("F2") +
            "\nNota2: " + Nota2.ToString("F2") + "\nMedia: " + Media().ToString("F2") + "\nResultado Final: " +
            resultado;
        }

    }
}