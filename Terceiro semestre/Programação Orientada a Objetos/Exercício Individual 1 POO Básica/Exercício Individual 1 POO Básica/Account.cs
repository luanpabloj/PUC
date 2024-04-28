using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Individual_1_POO_Básica
{
    internal class Account
    {
        private int cpf;
        private double balance;
        private double limit;
        private int cont;

        Extrato extrato = new Extrato();

        public Account(int cpf, double balance) { 
            if(cpf.ToString().Length != 5)
            {
                throw new Exception("O CPF deve conter apenas 5 dígitos");
            }
            this.cpf = cpf;
            this.balance = balance;
            this.limit = 100;
            this.cont = 0;
        }

        public int getCpf()
        {
            return cpf;
        }

        public double getBalance()
        {
            return balance;
        }

        public double getLimit()
        {
            return limit;
        }

        public void setLimit(double limit)
        {
            this.limit = limit;
        }

        public void deposit(double value)
        {
            if (limit == 100)
            {
                balance += value;
                string aux = "Depósito realizado: " + value + " Saldo: " + balance;
                extrato.adicionar(aux);
                Console.WriteLine("Depósito realizado: " + balance);
            }
            else
            {
                balance += value;
                double aux2 = balance * 0.03;
                balance *= 0.97;
                limit += aux2;
                string aux = "Depósito realizado: " + value + " Saldo: " + balance;
                extrato.adicionar(aux);
                Console.WriteLine("Depósito realizado com taxa: " + balance);
            }
        }

        public void withdraw(double value)
        {
            if(value > (balance + limit))
            {
                Console.WriteLine("Saque não completado: saldo insuficiente");
            }
            else if(value > balance)
            {
                balance = balance - value - limit;
                string aux = "Saque realizado: " + value + " Saldo: " + balance;
                extrato.adicionar(aux);
                Console.WriteLine("Saque com limite realizado: " + balance);
            }
            else
            {
                balance -= value;
                string aux = "Saque realizado: " + value + " Saldo: " + balance;
                extrato.adicionar(aux);
                Console.WriteLine("Saque realizado: " + balance);
            }
        }

        public void impressão()
        {

           Console.WriteLine("\n\nExtrato bancário: ");
           foreach(var i in extrato.getStack())
            {
                Console.WriteLine(i);
            }

            extrato.ultimaMovimentacao();
        }
    }
}
