﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int p;
            Console.WriteLine("Digite o programa q vc deseja ? ");
            p = int.Parse(Console.ReadLine());

            switch (p)
            {
                case 1:

                    int np, preco, total = 0;

                    while (true)
                    {

                        Console.WriteLine("quantos produtos vc deseja comprar ? ");
                        np = int.Parse(Console.ReadLine());
                        if (np == 0)
                        {
                            break;
                        }
                        Console.WriteLine("digite o preço do produto: ");
                        preco = int.Parse(Console.ReadLine());

                        total = preco * np + total;

                        if (total == 0)
                        {
                            break;
                        }





                    }
                    Console.WriteLine("Sua compra ficou em:" + total);


                    break;

                case 2:


                    double vl, qq, vtt, vm, vmm;

                    string nom, nm, nmm;

                    Console.WriteLine("digite o nome do produto (digite '0' para parar)");

                    nom = Console.ReadLine();

                    if (nom == "0")

                    {

                        break;

                    }

                    Console.WriteLine("digite o valor do produto");

                    vl = double.Parse(Console.ReadLine());

                    Console.WriteLine("digite o a quantidade de produtos");

                    qq = double.Parse(Console.ReadLine());

                    vtt = qq * vl;

                    vm = vtt;

                    nm = nom;

                    vmm = vtt;

                    nmm = nom;

                    while (nom != "0")

                    {

                        Console.WriteLine("digite o nome do produto (digite '0' para parar)");

                        nom = Console.ReadLine();

                        if (nom == "0")

                        {

                            break;

                        }

                        Console.WriteLine("digite o valor de cada produto");

                        vl = double.Parse(Console.ReadLine());

                        Console.WriteLine("digite o a quantidade de produtos");

                        qq = double.Parse(Console.ReadLine());

                        vtt = qq * vl;

                        if (vtt > vm)

                        {

                            nm = nom;

                        }

                        if (vtt < vmm)

                        {

                            nmm = nom;

                        }
                        int k = 0;
                        k++;
                    }

                    Console.WriteLine("o produto com maior valor é: " + nm + " com um com valor de R$" + vm + " e o de menor valor é: " + nmm + " com um valor de R$" + vmm);

                    break;

                case 3:

                    double avali, peso, pesototal;

                    Console.WriteLine("Digite quantas avaliações terão neste bimestre: ");

                    avali = double.Parse(Console.ReadLine());

                    pesototal = 0;
                    int i = 0;
                    while (i < avali)

                    {

                        Console.WriteLine("Qual o peso q esta avaliação tera no bimestre?");

                        peso = double.Parse(Console.ReadLine());

                        pesototal = pesototal + peso;
                        i++;

                    }

                    pesototal = pesototal * 10;

                    if (pesototal > 100)

                    {

                        Console.WriteLine("\nOs pesos ultrapassam 100%");

                        break;

                    }

                    if (pesototal == 100)

                    {

                        Console.WriteLine("\nOs pesos dão em 100%");

                        break;

                    }

                    if (pesototal > 100)

                    {

                        Console.WriteLine("\nOs pesos nao atingem 100%");

                        break;

                    }

                    break;

                case 4:

                    string estado;

                    Console.WriteLine("Digite a sigla de algum estado");

                    estado = Console.ReadLine();

                    switch (estado)

                    {

                        case "AC":

                            Console.WriteLine("o estado é: Acre");

                            break;

                        case "AL":

                            Console.WriteLine("o estado é: Alagoas");

                            break;

                        case "AP":

                            Console.WriteLine("o estado é: Amapá");

                            break;

                        case "AM":

                            Console.WriteLine("o estado é: Amazonas");

                            break;

                        case "BA":

                            Console.WriteLine("o estado é: Bahia");

                            break;

                        case "CE":

                            Console.WriteLine("o estado é: Ceará");

                            break;

                        case "DF":

                            Console.WriteLine("Distrito Federal, porém não é classificado como estado");

                            break;

                        case "ES":

                            Console.WriteLine("o estado é: Espírito Santo");

                            break;

                        case "GO":

                            Console.WriteLine("o estado é: Goiás");

                            break;

                        case "MA":

                            Console.WriteLine("o estado é: Maranhão");

                            break;

                        case "MT":

                            Console.WriteLine("o estado é: Mato Grosso");

                            break;

                        case "MS":

                            Console.WriteLine("o estado é: Mato Grosso do Sul");

                            break;

                        case "MG":

                            Console.WriteLine("o estado é: Minas Gerais");

                            break;

                        case "PA":

                            Console.WriteLine("o estado é: Pará");

                            break;

                        case "PB":

                            Console.WriteLine("o estado é: Paraíba");

                            break;

                        case "PR":

                            Console.WriteLine("o estado é: Paraná");

                            break;

                        case "PE":

                            Console.WriteLine("o estado é: Pernambuco");

                            break;

                        case "PI":

                            Console.WriteLine("o estado é: Piauí");

                            break;

                        case "RJ":

                            Console.WriteLine("o estado é: Rio de Janeiro");

                            break;

                        case "RN":

                            Console.WriteLine("o estado é: Rio Grande do Norte");

                            break;

                        case "RS":

                            Console.WriteLine("o estado é: Rio Grande do Sul");

                            break;

                        case "RO":

                            Console.WriteLine("o estado é: Rondônia");

                            break;

                        case "RR":

                            Console.WriteLine("o estado é: Roraima");

                            break;

                        case "SC":

                            Console.WriteLine("o estado é: Santa Catarina");

                            break;

                        case "SP":

                            Console.WriteLine("o estado é: São Paulo");

                            break;

                        case "SE":

                            Console.WriteLine("o estado é: Sergipe");

                            break;

                        case "TO":

                            Console.WriteLine("o estado é: Tocantins");

                            break;

                        default:

                            Console.WriteLine("nao existe estado com essa sigla");

                            break;

                    }

                    break;

                case 5:

                    int mes, dia;

                    Console.WriteLine("digite o mês");

                    mes = int.Parse(Console.ReadLine());

                    switch (mes)

                    {

                        case 1:

                            Console.WriteLine("a estação desse mês é: verão");

                            break;

                        case 2:

                            Console.WriteLine("a estação desse mês é: verão");

                            break;

                        case 3:

                            Console.WriteLine("qual é o dia?");

                            dia = int.Parse(Console.ReadLine());

                            if (dia < 20 && dia > 1)

                                Console.WriteLine("a estação desse mês é: verão");

                            if (dia >= 20 && dia < 31)

                                Console.WriteLine("a estação desse mês é: outono");

                            break;

                        case 4:

                            Console.WriteLine("a estação desse mês é: verão");

                            break;

                        case 5:

                            Console.WriteLine("a estação desse mês é: verão");

                            break;

                        case 6:

                            Console.WriteLine("qual é o dia?");

                            dia = int.Parse(Console.ReadLine());

                            if (dia < 21 && dia > 1)

                                Console.WriteLine("a estação desse mês é: outono");

                            if (dia >= 21 && dia < 30)

                                Console.WriteLine("a estação desse mês é: inverno");

                            break;

                        case 7:

                            Console.WriteLine("a estação desse mês é: inverno");

                            break;

                        case 8:

                            Console.WriteLine("a estação desse mês é: inverno");

                            break;

                        case 9:

                            Console.WriteLine("qual é o dia?");

                            dia = int.Parse(Console.ReadLine());

                            if (dia < 23 && dia > 1)

                                Console.WriteLine("a estação desse mês é: inverno");

                            if (dia >= 23 && dia < 30)

                                Console.WriteLine("a estação desse mês é: primavera");

                            break;

                        case 10:

                            Console.WriteLine("a estação desse mês é: primavera");

                            break;

                        case 11:

                            Console.WriteLine("a estação desse mês é: primavera");

                            break;

                        case 12:

                            Console.WriteLine("qual é o dia?");

                            dia = int.Parse(Console.ReadLine());

                            if (dia < 22 && dia > 1)

                                Console.WriteLine("a estação desse mês é: primavera");

                            if (dia >= 22 && dia < 30)

                                Console.WriteLine("a estação desse mês é: verão");

                            break;

                        default:

                            Console.WriteLine("não compreendi oq vc escreveu");

                            break;

                    }

                    break;

                case 6:

                    double altura, kg, imc;

                    Console.WriteLine("Digite sua altura (em metros): ");

                    altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite seu peso (em kilos): ");

                    kg = double.Parse(Console.ReadLine());

                    imc = kg / (altura * altura);

                    if (imc < 18.5)

                    {

                        Console.WriteLine("seu peso esta baixo");

                        break;

                    }

                    if (imc >= 18.5 && imc <= 24.9)

                    {

                        Console.WriteLine("Seu peso esta na média");

                        break;

                    }

                    if (imc >= 25 && imc <= 29.9)

                    {

                        Console.WriteLine("você está acima do peso");

                        break;

                    }

                    if (imc >= 30 && imc < 34.9)

                    {

                        Console.WriteLine("você está com obesidade grau 1");

                        break;

                    }

                    if (imc >= 35 && imc < 39.9)

                    {

                        Console.WriteLine("você está com obesidade grau 2");

                        break;

                    }

                    if (imc >= 40)

                    {

                        Console.WriteLine("você está com obesidade grau 3");

                        break;

                    }

                    break;

                case 7:

                    int num;


                    Console.WriteLine("digite um numero");

                    num = int.Parse(Console.ReadLine());
                    int b = 1;
                    while (b < num)

                    {
                        b++;
                        if (num % b == 0)

                            Console.WriteLine("i");

                        else
                        {
                             //i++;
                        }
                    }

                    break;

                default:

                    Console.WriteLine("Número inválido");

                    break;

            }

        }

    }

}
