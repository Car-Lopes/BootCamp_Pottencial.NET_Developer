using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        //Criando  Metodo Construtor tem que ter o mesmo nome da classe
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        
        private string _nome; //criando esse campo para fazer validação se o nome for vazio
        private int _idade;//criando esse campo para fazer validação com idade negativo
        
        public string Nome //criando a propriedade
        {    //get(Acão) obtendo um valor 
            get => _nome.ToUpper();// retornando nome com letras maiusculas
            
            set 
            {        //valor que esta sendo recebendo na variel Nome
                if (value == "")
                { //Exceção do codigo que vai gerar e para o programa
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            } 
        } 

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();//Apenas GET

        public int Idade 
        { 
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que ZERO");
                }
                _idade = value;
            } 
            
        } //set(Ação) setando (Atribuindo) um valor 

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}