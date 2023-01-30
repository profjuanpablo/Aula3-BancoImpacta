using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Aluno
    {
        public string Nome;
        public string Turma;
        public int Idade;
        public int NMat;
        public decimal Mensalidade;


        public void ExibirAluno() {
            Console.WriteLine($"Aluno: {Nome} - Turma: {Turma} - Mensalidade: {Mensalidade:0.00} ");

        }

        //método que vair efetuar a troca de turma do aluno requerente
        public void TrocarTurma(string novaTurma) {
            Turma = novaTurma;
        }

        public void Desconto(decimal desconto) { 
                //500   =    500      - (10 /100 = 0.1) * 500 = 50  = 450
            Mensalidade = Mensalidade - (desconto /100)*Mensalidade;
        }

    }


}
