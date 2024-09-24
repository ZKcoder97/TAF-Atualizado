using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaTafNovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool erro = true; string nomeGuerra = null; int variavelIdade = 0; string variavelGenero = null; string carreira = null; double corrida = 0; int fleca = 0; int abd = 0; int barra = 0; string posto = null; bool aptoParaBarra = false; string saida = null;
            inicio:
            Console.WriteLine("Nota Do TAF!\n");
            //função que informa o nome de guerra dos militares
                do
                {
                    try
                    {
                        Console.Write("Nome de guerra: ");
                        nomeGuerra = Console.ReadLine();
                        erro = false;
                    }
                    catch (Exception errado)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ocorreu um erro: {errado}\n");
                        erro = false;
                    }
                } while (erro);
            //Fim da função nome de guerra

            //função que informa a idade dos militares
                do
                {
                    try
                    {
                        Console.Write("Idade: ");
                        variavelIdade = int.Parse(Console.ReadLine());
                        if(variavelIdade >= 18 && variavelIdade <= 66) { erro = false; }
                        else { Console.Clear(); Console.WriteLine("O militar deve ter entre 18 anos a 60 anos"); erro = true; }
                    }
                    catch (Exception errado)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ocorreu um erro: {errado}\n");
                        erro = true;
                    }
                } while (erro);
            //Fim da função idade

            //Função definir o genero
                do
                {
                    try
                    {
                        Console.Write("Genero[M - Masculino||F - Feminino]: ");
                        variavelGenero = Console.ReadLine();
                    variavelGenero = variavelGenero.ToLower();
                        switch (variavelGenero)
                        {
                            case "m":
                            aptoParaBarra = true;
                            erro = false;
                            break;
                            case "f":
                            aptoParaBarra = false;
                            erro = false;
                            break;
                            default:
                                Console.Clear(); erro = true;
                                break;
                        }

                    }
                    catch (Exception errado)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ocorreu um erro: {errado}\n");
                        erro = true;
                    }
                } while (erro);
            //Fim da função genero

            //Função Posto de graduação
            do
            {
                try
                {
                    Console.WriteLine("Posto de graduação: ");
                    Console.WriteLine("Gen - General\nCel - Coronel\nTc - Tenente Coronel\nMaj - Major\nCap - Capitão\nTen - Tenente\nST - Sub-Tenete\nSGT - Sargento\nCb - Cabo\nEP - Soldado EP\nEV - Soldado EV");
                    Console.Write("Insira: ");
                    posto = Console.ReadLine();
                    posto = posto.ToLower();
                    switch (posto)
                    {
                        case "gen":
                            erro = false;
                            break;
                        case "cel":
                            erro = false;
                            break;
                        case "tc":
                            erro = false;
                            break;
                        case "maj":
                            erro = false;
                            break;
                        case "cap":
                            erro = false;
                            break;
                        case "ten":
                            erro = false;
                            break;
                        case "st":
                            erro = false;
                            break;
                        case "sgt":
                            erro = false;
                            break;
                        case "cb":
                            erro = false;
                            break;
                        case "ep":
                            erro = false;
                            break;
                        case "ev":
                            erro = false;
                            break;
                        default:
                            Console.Clear(); erro = true;
                            break;
                    }

                }
                catch (Exception errado)
                {
                    Console.Clear();
                    Console.WriteLine($"Ocorreu um erro: {errado}\n");
                    erro = true;
                }
            } while (erro);
            //Fim da Posto de graduação

            //Função saber se ele é de carreira, temporario, tecnico
            do
            {
                try
                {
                    Console.WriteLine("Situação militar: ");
                    Console.WriteLine("1 - Carreira\n2 - Temporario\n3 - Técnico");
                    Console.Write("Insira: ");
                    carreira = Console.ReadLine();
                    carreira = carreira.ToLower();
                    switch (carreira)
                    {
                        case "1":
                            erro = false;
                            aptoParaBarra = true;
                            break;
                        case "2":
                            erro = false;
                            aptoParaBarra = true;
                            break;
                        case "3":
                            erro = false;
                            aptoParaBarra = false;
                            break;
                        default:
                            Console.Clear(); erro = true;
                            break;
                    }

                }
                catch (Exception errado)
                {
                    Console.Clear();
                    Console.WriteLine($"Ocorreu um erro: {errado}\n");
                    erro = true;
                }
            } while (erro);
            //Fim da situacao militar

            //função que informa a corrida dos militares
            do
            {
                try
                {
                    Console.Write("Corrida: ");
                    corrida = double.Parse(Console.ReadLine());
                    if (corrida >= 1600 && corrida <= 3250) { erro = false; }
                    else { Console.Clear(); Console.WriteLine("Valor inválido, Corrida é de 1600 a 3250 metros"); erro = true; }
                }
                catch (Exception errado)
                {
                    Console.Clear();
                    Console.WriteLine($"Ocorreu um erro: {errado}\n");
                    erro = true;
                }
            } while (erro);
            //Fim da função corrida

            //função que informa a fleca dos militares
            do
            {
                try
                {
                    Console.Write("Flexão: ");
                    fleca = int.Parse(Console.ReadLine());
                    if (fleca >= 0 && fleca <= 80) { erro = false; }
                    else { Console.Clear(); Console.WriteLine("Valor inválido, Flexão é de 0 a 80"); erro = true; }
                }
                catch (Exception errado)
                {
                    Console.Clear();
                    Console.WriteLine($"Ocorreu um erro: {errado}\n");
                    erro = true;
                }
            } while (erro);
            //Fim da função fleca

            //função que informa a abd dos militares
            do
            {
                try
                {
                    Console.Write("Abdominal: ");
                    abd = int.Parse(Console.ReadLine());
                    if (abd >= 0 && fleca <= 100) { erro = false; }
                    else { Console.Clear(); Console.WriteLine("Valor inválido, Abdominal é de 0 a 100"); erro = true; }
                }
                catch (Exception errado)
                {
                    Console.Clear();
                    Console.WriteLine($"Ocorreu um erro: {errado}\n");
                    erro = true;
                }
            } while (erro);
            //Fim da função abd

            //função que informa a barra dos militares
            do
            {
                try
                {
                    Console.Write("Barra: ");
                    barra = int.Parse(Console.ReadLine());
                    if (barra >= 0 && barra <= 30) { erro = false; }
                    else { Console.Clear(); Console.WriteLine("Valor inválido, Barra é de 0 a 30"); erro = true; }
                }
                catch (Exception errado)
                {
                    Console.Clear();
                    Console.WriteLine($"Ocorreu um erro: {errado}\n");
                    erro = true;
                }
            } while (erro);
            //Fim da função barra

            //Chamando função
            resumo(nomeGuerra, variavelIdade, posto, variavelGenero, carreira, corrida, fleca, abd, barra, aptoParaBarra);


            //Sair
            do
            {
                try
                {
                    Console.Write("Gerar nova nota[S - Sim||N - Não]: ");
                    saida = Console.ReadLine();
                    saida = saida.ToLower();
                    switch (saida)
                    {
                        case "s": Console.Clear(); erro = false; goto inicio;
                        case "n": Console.WriteLine("Encerrando app"); erro = false; break;
                        default: Console.Clear(); erro = true; break;
                    }
                }
                catch (Exception errado)
                {
                    Console.Clear();
                    Console.WriteLine($"Ocorreu um erro: {errado}\n");
                    erro = true;
                }
            } while (erro);
            //Fim da função barra

        }

        //Resumo
        static void resumo(string nome, int idade, string pg, string genero, string situacao, double corrida, int fleca, int abd, int barra, bool aptoBarra)
        {
            string notaCorrida=null; string notaFleca=null; string notaAbd = null; string notaBarra = null;

            Console.Clear();
            Console.WriteLine("Resumo: ");
            Console.WriteLine($"Nome de guerra: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Posto de graduação: {pg}");
            Console.WriteLine($"Genero: {genero}");
            Console.WriteLine($"Corrida: {corrida}");
            Console.WriteLine($"Flexão: {fleca}");
            Console.WriteLine($"Abdominaç: {abd}");
            Console.WriteLine($"Barra: {barra}");
            //Inicio das codinções para as notas
            //Pessoa que efetuam a barra
            if(aptoBarra == true)
            {
                //Idade 18 a 21
                if(idade >= 18 && idade <= 21)
                {
                    //Corrida
                    if(corrida <= 2599) { notaCorrida = "I - Insuficiente"; }
                    if (corrida >= 2600 && corrida <= 2799) { notaCorrida = "R - Regular"; }
                    if (corrida >= 2800 && corrida <= 3149) { notaCorrida = "B - Bom"; }
                    if (corrida >= 3150 && corrida <= 3199) { notaCorrida = "MB - Muito Bom"; }
                    if (corrida >= 3200) { notaCorrida = "E - Echo"; }
                    //Fleca
                    if (fleca <= 21) { notaFleca = "I - Insuficiente"; }
                    if (fleca >= 22 && fleca <= 24) { notaFleca = "R - Regular"; }
                    if (fleca >= 25 && fleca <= 33) { notaFleca = "B - Bom"; }
                    if (fleca >= 34 && fleca <= 38) { notaFleca = "MB - Muito Bom"; }
                    if (fleca >= 39) { notaFleca = "E - Echo"; }
                    //Abdominal
                    if (abd <= 34) { notaAbd = "I - Insuficiente"; }
                    if (abd >= 35 && abd <= 44) { notaAbd = "R - Regular"; }
                    if (abd >= 45 && abd <= 63) { notaAbd = "B - Bom"; }
                    if (abd >= 64 && abd <= 73) { notaAbd = "MB - Muito Bom"; }
                    if (abd >= 74) { notaAbd = "E - Echo"; }
                    //Barra
                    if (barra <= 4) { notaBarra = "I - Insuficiente"; }
                    if (barra >= 5 && barra <= 6) { notaBarra = "R - Regular"; }
                    if (barra >= 7 && abd <= 9) { notaBarra = "B - Bom"; }
                    if (barra >= 10 && barra <= 11) { notaBarra = "MB - Muito Bom"; }
                    if (barra >= 12) { notaBarra = "E - Echo"; }
                }

                //Idade 22 a 25
                if (idade >= 22 && idade <= 25)
                {
                    //Corrida
                    if (corrida <= 2699) { notaCorrida = "I - Insuficiente"; }
                    if (corrida >= 2700 && corrida <= 2849) { notaCorrida = "R - Regular"; }
                    if (corrida >= 2850 && corrida <= 3099) { notaCorrida = "B - Bom"; }
                    if (corrida >= 3100 && corrida <= 3249) { notaCorrida = "MB - Muito Bom"; }
                    if (corrida >= 3250) { notaCorrida = "E - Echo"; }
                    //Fleca
                    if (fleca <= 23) { notaFleca = "I - Insuficiente"; }
                    if (fleca >= 24 && fleca <= 26) { notaFleca = "R - Regular"; }
                    if (fleca >= 27 && fleca <= 35) { notaFleca = "B - Bom"; }
                    if (fleca >= 36 && fleca <= 40) { notaFleca = "MB - Muito Bom"; }
                    if (fleca >= 41) { notaFleca = "E - Echo"; }
                    //Abdominal
                    if (abd <= 41) { notaAbd = "I - Insuficiente"; }
                    if (abd >= 42 && abd <= 51) { notaAbd = "R - Regular"; }
                    if (abd >= 52 && abd <= 68) { notaAbd = "B - Bom"; }
                    if (abd >= 69 && abd <= 78) { notaAbd = "MB - Muito Bom"; }
                    if (abd >= 79) { notaAbd = "E - Echo"; }
                    //Barra
                    if (barra <= 5) { notaBarra = "I - Insuficiente"; }
                    if (barra >= 6 && barra <= 7) { notaBarra = "R - Regular"; }
                    if (barra >= 8 && abd <= 10) { notaBarra = "B - Bom"; }
                    if (barra >= 11 && barra <= 12) { notaBarra = "MB - Muito Bom"; }
                    if (barra >= 13) { notaBarra = "E - Echo"; }
                }

                //Idade 26 a 29
                if (idade >= 26 && idade <= 29)
                {
                    //Corrida
                    if (corrida <= 2599) { notaCorrida = "I - Insuficiente"; }
                    if (corrida >= 2600 && corrida <= 2749) { notaCorrida = "R - Regular"; }
                    if (corrida >= 2750 && corrida <= 2999) { notaCorrida = "B - Bom"; }
                    if (corrida >= 3000 && corrida <= 3149) { notaCorrida = "MB - Muito Bom"; }
                    if (corrida >= 3150) { notaCorrida = "E - Echo"; }
                    //Fleca
                    if (fleca <= 21) { notaFleca = "I - Insuficiente"; }
                    if (fleca >= 22 && fleca <= 24) { notaFleca = "R - Regular"; }
                    if (fleca >= 25 && fleca <= 33) { notaFleca = "B - Bom"; }
                    if (fleca >= 34 && fleca <= 38) { notaFleca = "MB - Muito Bom"; }
                    if (fleca >= 39) { notaFleca = "E - Echo"; }
                    //Abdominal
                    if (abd <= 37) { notaAbd = "I - Insuficiente"; }
                    if (abd >= 38 && abd <= 48) { notaAbd = "R - Regular"; }
                    if (abd >= 49 && abd <= 65) { notaAbd = "B - Bom"; }
                    if (abd >= 66 && abd <= 75) { notaAbd = "MB - Muito Bom"; }
                    if (abd >= 76) { notaAbd = "E - Echo"; }
                    //Barra
                    if (barra <= 4) { notaBarra = "I - Insuficiente"; }
                    if (barra >= 5 && barra <= 6) { notaBarra = "R - Regular"; }
                    if (barra >= 7 && abd <= 9) { notaBarra = "B - Bom"; }
                    if (barra >= 10 && barra <= 11) { notaBarra = "MB - Muito Bom"; }
                    if (barra >= 12) { notaBarra = "E - Echo"; }
                }

                //Idade 30 a 33
                if (idade >= 18 && idade <= 21)
                {
                    //Corrida
                    if (corrida <= 2549) { notaCorrida = "I - Insuficiente"; }
                    if (corrida >= 2550 && corrida <= 2649) { notaCorrida = "R - Regular"; }
                    if (corrida >= 2650 && corrida <= 2899) { notaCorrida = "B - Bom"; }
                    if (corrida >= 2900 && corrida <= 3099) { notaCorrida = "MB - Muito Bom"; }
                    if (corrida >= 3100) { notaCorrida = "E - Echo"; }
                    //Fleca
                    if (fleca <= 20) { notaFleca = "I - Insuficiente"; }
                    if (fleca >= 21 && fleca <= 23) { notaFleca = "R - Regular"; }
                    if (fleca >= 24 && fleca <= 31) { notaFleca = "B - Bom"; }
                    if (fleca >= 32 && fleca <= 36) { notaFleca = "MB - Muito Bom"; }
                    if (fleca >= 37) { notaFleca = "E - Echo"; }
                    //Abdominal
                    if (abd <= 33) { notaAbd = "I - Insuficiente"; }
                    if (abd >= 34 && abd <= 42) { notaAbd = "R - Regular"; }
                    if (abd >= 43 && abd <= 60) { notaAbd = "B - Bom"; }
                    if (abd >= 61 && abd <= 69) { notaAbd = "MB - Muito Bom"; }
                    if (abd >= 70) { notaAbd = "E - Echo"; }
                    //Barra
                    if (barra <= 4) { notaBarra = "I - Insuficiente"; }
                    if (barra >= 5) { notaBarra = "R - Regular"; }
                    if (barra >= 6 && abd <= 8) { notaBarra = "B - Bom"; }
                    if (barra >= 9 && barra <= 10) { notaBarra = "MB - Muito Bom"; }
                    if (barra >= 11) { notaBarra = "E - Echo"; }
                }

                //Idade 34 q 37
                if (idade >= 34 && idade <= 37)
                {
                    //Corrida
                    if (corrida <= 2449) { notaCorrida = "I - Insuficiente"; }
                    if (corrida >= 2450 && corrida <= 2549) { notaCorrida = "R - Regular"; }
                    if (corrida >= 2550 && corrida <= 2799) { notaCorrida = "B - Bom"; }
                    if (corrida >= 2800 && corrida <= 2949) { notaCorrida = "MB - Muito Bom"; }
                    if (corrida >= 2950) { notaCorrida = "E - Echo"; }
                    //Fleca
                    if (fleca <= 17) { notaFleca = "I - Insuficiente"; }
                    if (fleca >= 18 && fleca <= 20) { notaFleca = "R - Regular"; }
                    if (fleca >= 21 && fleca <= 28) { notaFleca = "B - Bom"; }
                    if (fleca >= 29 && fleca <= 33) { notaFleca = "MB - Muito Bom"; }
                    if (fleca >= 34) { notaFleca = "E - Echo"; }
                    //Abdominal
                    if (abd <= 30) { notaAbd = "I - Insuficiente"; }
                    if (abd >= 31 && abd <= 39) { notaAbd = "R - Regular"; }
                    if (abd >= 40 && abd <= 56) { notaAbd = "B - Bom"; }
                    if (abd >= 57 && abd <= 65) { notaAbd = "MB - Muito Bom"; }
                    if (abd >= 66) { notaAbd = "E - Echo"; }
                    //Barra
                    if (barra <= 3) { notaBarra = "I - Insuficiente"; }
                    if (barra >= 4) { notaBarra = "R - Regular"; }
                    if (barra >= 5 && abd <= 6) { notaBarra = "B - Bom"; }
                    if (barra >= 7 && barra <= 8) { notaBarra = "MB - Muito Bom"; }
                    if (barra >= 9) { notaBarra = "E - Echo"; }
                }

                //Idade 38 a 41
                if (idade >= 38 && idade <= 41)
                {
                    //Corrida
                    if (corrida <= 2349) { notaCorrida = "I - Insuficiente"; }
                    if (corrida >= 2350 && corrida <= 2449) { notaCorrida = "R - Regular"; }
                    if (corrida >= 2450 && corrida <= 2699) { notaCorrida = "B - Bom"; }
                    if (corrida >= 2700 && corrida <= 2849) { notaCorrida = "MB - Muito Bom"; }
                    if (corrida >= 2850) { notaCorrida = "E - Echo"; }
                    //Fleca
                    if (fleca <= 16) { notaFleca = "I - Insuficiente"; }
                    if (fleca >= 17 && fleca <= 19) { notaFleca = "R - Regular"; }
                    if (fleca >= 20 && fleca <= 27) { notaFleca = "B - Bom"; }
                    if (fleca >= 28 && fleca <= 31) { notaFleca = "MB - Muito Bom"; }
                    if (fleca >= 32) { notaFleca = "E - Echo"; }
                    //Abdominal
                    if (abd <= 28) { notaAbd = "I - Insuficiente"; }
                    if (abd >= 29 && abd <= 37) { notaAbd = "R - Regular"; }
                    if (abd >= 38 && abd <= 54) { notaAbd = "B - Bom"; }
                    if (abd >= 55 && abd <= 63) { notaAbd = "MB - Muito Bom"; }
                    if (abd >= 64) { notaAbd = "E - Echo"; }
                    //Barra
                    if (idade >= 38 && idade <= 39)
                    {
                        if (barra <= 2) { notaBarra = "I - Insuficiente"; }
                        if (barra >= 3) { notaBarra = "R - Regular"; }
                        if (barra >= 4 && abd <= 5) { notaBarra = "B - Bom"; }
                        if (barra >= 6 && barra <= 7) { notaBarra = "MB - Muito Bom"; }
                        if (barra >= 8) { notaBarra = "E - Echo"; }
                    }
                    if(idade >= 40 && idade <= 41)
                    {
                        if(barra >= 2) { notaBarra = "Suficiente";}
                        else { notaBarra = "Insuficiente"; }
                    }
                }

                //Idade 42 a 45
                if (idade >= 42 && idade <= 45)
                {
                    //Corrida
                    if (corrida <= 2249) { notaCorrida = "I - Insuficiente"; }
                    if (corrida >= 2250 && corrida <= 2399) { notaCorrida = "R - Regular"; }
                    if (corrida >= 2400 && corrida <= 2599) { notaCorrida = "B - Bom"; }
                    if (corrida >= 2600 && corrida <= 2749) { notaCorrida = "MB - Muito Bom"; }
                    if (corrida >= 2750) { notaCorrida = "E - Echo"; }
                    //Fleca
                    if (fleca <= 14) { notaFleca = "I - Insuficiente"; }
                    if (fleca >= 15 && fleca <= 17) { notaFleca = "R - Regular"; }
                    if (fleca >= 18 && fleca <= 24) { notaFleca = "B - Bom"; }
                    if (fleca >= 25 && fleca <= 28) { notaFleca = "MB - Muito Bom"; }
                    if (fleca >= 29) { notaFleca = "E - Echo"; }
                    //Abdominal
                    if (abd <= 26) { notaAbd = "I - Insuficiente"; }
                    if (abd >= 27 && abd <= 35) { notaAbd = "R - Regular"; }
                    if (abd >= 36 && abd <= 52) { notaAbd = "B - Bom"; }
                    if (abd >= 53 && abd <= 61) { notaAbd = "MB - Muito Bom"; }
                    if (abd >= 62) { notaAbd = "E - Echo"; }
                    //Barra
                    if (barra >= 2) { notaBarra = "Suficiente"; }
                    else if(barra <= 1){ notaBarra = "Insuficiente"; }
                }

                //Idade 46 a 49
                if (idade >= 46 && idade <= 49)
                {
                    //Corrida
                    if (corrida <= 2149) { notaCorrida = "I - Insuficiente"; }
                    if (corrida >= 2150 && corrida <= 2299) { notaCorrida = "R - Regular"; }
                    if (corrida >= 2300 && corrida <= 2499) { notaCorrida = "B - Bom"; }
                    if (corrida >= 2500 && corrida <= 2649) { notaCorrida = "MB - Muito Bom"; }
                    if (corrida >= 2650) { notaCorrida = "E - Echo"; }
                    //Fleca
                    if (fleca <= 11) { notaFleca = "I - Insuficiente"; }
                    if (fleca >= 12 && fleca <= 14) { notaFleca = "R - Regular"; }
                    if (fleca >= 15 && fleca <= 21) { notaFleca = "B - Bom"; }
                    if (fleca >= 22 && fleca <= 25) { notaFleca = "MB - Muito Bom"; }
                    if (fleca >= 26) { notaFleca = "E - Echo"; }
                    //Abdominal
                    if (abd <= 24) { notaAbd = "I - Insuficiente"; }
                    if (abd >= 25 && abd <= 33) { notaAbd = "R - Regular"; }
                    if (abd >= 34 && abd <= 50) { notaAbd = "B - Bom"; }
                    if (abd >= 51 && abd <= 59) { notaAbd = "MB - Muito Bom"; }
                    if (abd >= 60) { notaAbd = "E - Echo"; }
                    //Barra
                    if (barra >= 1) { notaBarra = "Suficiente"; }
                    else if(barra <= 0){ notaBarra = "Insuficiente"; }
                }

                //Idade 50 a 53
                if (idade >= 50 && idade <= 53)
                {
                    //Corrida
                    if(corrida >= 1900) { notaCorrida = "Suficiente"; }
                    else if(corrida <= 1899) { notaCorrida = "Insuficiente"; }
                    //Fleca
                    if (fleca >= 11) { notaFleca = "Suficiente"; }
                    else if (fleca <= 10) { notaFleca = "Insuficiente"; }
                    //Abdominal
                    if (abd >= 23) { notaAbd = "Suficiente"; }
                    else if (abd <= 22) { notaAbd = "Insuficiente"; }
                    //Barra
                    notaBarra = "Não Realiza";
                }

                //Idade 54 a 57
                if (idade >= 54 && idade <= 57)
                {
                    //Corrida
                    if (corrida >= 1800) { notaCorrida = "Suficiente"; }
                    else if (corrida <= 1799) { notaCorrida = "Insuficiente"; }
                    //Fleca
                    if (fleca >= 9) { notaFleca = "Suficiente"; }
                    else if (fleca <= 8) { notaFleca = "Insuficiente"; }
                    //Abdominal
                    if (abd >= 21) { notaAbd = "Suficiente"; }
                    else if (abd <= 20) { notaAbd = "Insuficiente"; }
                    //Barra
                    notaBarra = "Não Realiza";
                }

                //Idade 58 a 61
                if (idade >= 58 && idade <= 61)
                {
                    //Corrida
                    if (corrida >= 1600) { notaCorrida = "Suficiente"; }
                    else if (corrida <= 1599) { notaCorrida = "Insuficiente"; }
                    //Fleca
                    if (fleca >= 8) { notaFleca = "Suficiente"; }
                    else if (fleca <= 7) { notaFleca = "Insuficiente"; }
                    //Abdominal
                    if (abd >= 19) { notaAbd = "Suficiente"; }
                    else if (abd <= 18) { notaAbd = "Insuficiente"; }
                    //Barra
                    notaBarra = "Não Realiza";
                }

                //Idade 62 a 65
                if (idade >= 62 && idade <= 65)
                {
                    //Corrida
                    if (corrida >= 1400) { notaCorrida = "Suficiente"; }
                    else if (corrida <= 1399) { notaCorrida = "Insuficiente"; }
                    //Fleca
                    if (fleca >= 6) { notaFleca = "Suficiente"; }
                    else if (fleca <= 5) { notaFleca = "Insuficiente"; }
                    //Abdominal
                    if (abd >= 17) { notaAbd = "Suficiente"; }
                    else if (abd <= 16) { notaAbd = "Insuficiente"; }
                    //Barra
                    notaBarra = "Não Realiza";
                }
            }
            //Fim Das Pessoas que efetuam a barra

            //Exibir Resumo
            Console.WriteLine($"Nota Corrida: {notaCorrida}");
            Console.WriteLine($"Nota Flexão: {notaFleca}");
            Console.WriteLine($"Nota Abdominal: {notaAbd}");
            Console.WriteLine($"Nota Barra: {notaBarra}\n");


        }












    }
}