﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIMC
{
    internal class Pessoa
    {
        public double peso { get; set; }
        public double altura { get; set; }

        public double calculo()
        {
            return peso / (altura * altura);
        }
        public string situacao(double imc)
        {
            string retorno;
            if (imc < 18.5)
            {
                retorno = "Abaixo do peso";
            }
            else if (imc < 25)
            {
                retorno = "Peso normal";
            }
            else if (imc < 30)
            {
                retorno = "Acima do peso";
            }
            else if (imc < 35)
            {
                retorno = "Obesidade I";
            }
            else if (imc < 40)
            {
                retorno = "Obesidade II";
            }
            else
            {
                retorno = "Obesidade III";
            }
            return retorno;
        }
        public void mensagem()
        {
            double obterCalculo = calculo();
            string obterSituacao = situacao(obterCalculo);
            Console.WriteLine($"Seu IMC é de {Math.Round(obterCalculo)}");
            Console.WriteLine( $"Sua situação é {obterSituacao}");
        }
    }
}
