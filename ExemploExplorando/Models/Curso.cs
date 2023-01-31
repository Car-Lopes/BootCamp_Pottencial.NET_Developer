using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
            
        public void AdicionarAluno(Pessoa aluno) //Void retorna vazio
        {                                       // não precisa de return 
            Alunos.Add(aluno);             //Pois declaramos como void
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;  //Return é obrigatorio pois declaramos como int
        }                       //o metodo q quando passamos o void não precisa
                             // de return
        
        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno); 
        }
        
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
             // Usando a Concatenação
             // int exibirNumSequencia = count + 1;
             // string texto = "N° " + exibirNumSequencia + " - " + Alunos[count].NomeCompleto;  
             
             // Usando interpolação de String
             string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}"; 
              Console.WriteLine(texto);  
            }
            
           // foreach (Pessoa aluno in Alunos)
           // {
             //   Console.WriteLine(aluno.NomeCompleto);
           // }
        }
    }                                
}