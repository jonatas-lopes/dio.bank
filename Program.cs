﻿using System;
using System.Collections.Generic;

namespace dio.bank
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            
            

            string escolha = OpcaoUsuario();

            while(escolha.ToUpper() != "X")
            {
                switch (escolha)
                {
                    case "1" :
                    ListarContas();
                    break;

                    case "2" :

                    Depositar();
                    break;

                    case "3" :
                    Sacar();
                    break;

                    case "4" :
                    Transferir();
                    break;

                    case "5" :
                    
                    InserirConta();
                    
                    break;

                    case "C" :
                    Console.Clear();
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();

                }

                escolha = OpcaoUsuario();
            }
        }

        private static void Transferir()
        {
            Console.Write("Digite o numero da conta partida : ");
            int indicecontapartida = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero da conta destino : ");
            int indicecontadestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
			double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indicecontapartida].Transferir(listContas[indicecontapartida],listContas[indicecontadestino],valorTransferencia);
        }

        private static void Sacar()
        {
            Console.Write("Digite o numero da conta: ");
            int indiceconta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceconta].Sacar(valorSaque);
        }

        private static void Depositar()
        {
            Console.Write("Digite o numero da conta: ");
            int indiceconta = int.Parse(Console.ReadLine());

            
            Console.Write("Digite o valor a ser depositado : ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceconta].Depositar(valorDeposito);
        }

        private static void InserirConta()
        {
            Console.WriteLine("Cadastro de nova conta ");

            Console.Write("Tipo de conta 1 - Pessoas Fisica / 2 - Pessoa Juridica : ");
            int entradatipoconta = int.Parse(Console.ReadLine());

            Console.Write("Nome do Titular : ");
            string nomeconta = Console.ReadLine();
          
            Console.Write("Saldo inicial da conta : ");
            double saldoconta = double.Parse(Console.ReadLine());

            Console.Write("Credito inicial da conta : ");
            double creditoconta = double.Parse(Console.ReadLine());

            Conta novaconta = new Conta(tipoconta : (TipoConta)entradatipoconta,
            nome  : nomeconta,
            saldo  : saldoconta,
            credito : creditoconta 
            );  

            listContas.Add(novaconta);

            
            
        }

        private static void ListarContas()
        {
            if(listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada\n");
                return;
            }

            for(int i = 0; i < listContas.Count; i++)
            {
               Conta conta = listContas[i];
               Console.Write(" #{0} - ", i);
               Console.Write(conta);
            }

        }

        private static string OpcaoUsuario()
         {

             Console.WriteLine("\nBem-vindo !!");
             Console.WriteLine("Escolha a opção desejada!");
             Console.WriteLine("1 - Listar Contas");
             Console.WriteLine("2 - Depositar");
             Console.WriteLine("3 - Sacar");
             Console.WriteLine("4 - Transferir");
             Console.WriteLine("5 - Inserir Conta");
             Console.WriteLine("C - Limpar Tela");
             Console.WriteLine("X - Sair");
             Console.WriteLine();

             string OpcaoUsuario = Console.ReadLine().ToUpper();
             Console.WriteLine();
             return OpcaoUsuario;

         }
    }

    
}
