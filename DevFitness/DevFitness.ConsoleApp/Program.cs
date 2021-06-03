using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFitness.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name?");
            var name = Console.ReadLine();

            Console.WriteLine("Whats your heigth?");
            var heigth = Console.ReadLine();

            Console.WriteLine("Whats your weight?");
            var weight = Console.ReadLine();

            var listaRefeicoes = new List<Refeicao>();
            var option = "-1";

            while (option != "0")
            {
                ShowOptions();
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine($"Name: {name}, Heigth: {heigth}, Weight: {weight}");
                        break;
                    case "2":
                        RegisterMeal(listaRefeicoes);
                        break;
                    case "3":
                        ListarRefeicoes(listaRefeicoes);
                        break;
                    default:
                        Console.WriteLine("Please, choose an option!");
                        break;

                }
            }

            //var bebida = new Bebida("Leite Integral", 500, true);
            //var comida = new Comida("Sanduiche Integral", 150, 0.5M);

            //var listaComidas = new List<Refeicao> { bebida, comida };

            //ListarRefeicoes(listaComidas);

            Console.Read();

        }




        public static void ShowOptions()
        {
            Console.WriteLine("Wellcome to DevFitness!!!");
            Console.WriteLine("1 - Show user details");
            Console.WriteLine("2 - Register new meal");
            Console.WriteLine("3 - List meals");
            Console.WriteLine("0 - Close application");
        }

        public static void RegisterMeal(List<Refeicao> refeicoes)
        {
            Console.WriteLine("Tipo de registo:");
            Console.WriteLine("1 - Refeição");
            Console.WriteLine("2 - Refeição com preço");
            Console.WriteLine("3 - Bebida");

            var tipo = Console.ReadLine();

            switch (tipo)
            {
                case "1":
                    addRefeicao(refeicoes);
                    break;
                case "2":
                    addRefeicaoComPreco(refeicoes);
                    break;
                case "3":
                    addBebida(refeicoes);
                    break;
                default:
                    Console.WriteLine("Escolha uma opção");
                    break;
            }
            

        }

        public static void addRefeicao(List<Refeicao> refeicoes)
        {

            Console.WriteLine("Description of meal");
            var descricao = Console.ReadLine();

            Console.WriteLine("Calories?");
            var calorias = Console.ReadLine();

            if (int.TryParse(calorias, out int caloriasInt))
            {
                var refeicao = new Refeicao(descricao, caloriasInt);

                refeicoes.Add(refeicao);

                Console.WriteLine("Meal added!!!");
            }
            else
            {
                Console.WriteLine("invalid calory number!!!");
            }
        }


        public static void addRefeicaoComPreco(List<Refeicao> refeicoes)
        {

            Console.WriteLine("Description of meal");
            var descricao = Console.ReadLine();

            Console.WriteLine("Calories?");
            var calorias = Console.ReadLine();

            Console.WriteLine("Preço?");
            var preco = Console.ReadLine();

            if (int.TryParse(calorias, out int caloriasInt))
            {

                decimal result;
                if (decimal.TryParse(preco, out result))
                {
                    var refeicao = new Comida(descricao, caloriasInt, result);

                    refeicoes.Add(refeicao);

                    Console.WriteLine("Meal added!!!");

                }
                else
                {
                    Console.WriteLine("invalid value try again");
                }
               
            }
            else
            {
                Console.WriteLine("invalid calory number!!!");
            }
        }

        public static void addBebida(List<Refeicao> refeicoes)
        {

            Console.WriteLine("Description of meal");
            var descricao = Console.ReadLine();

            Console.WriteLine("Calories?");
            var calorias = Console.ReadLine();

            Console.WriteLine("Contem Lactose? S ou N");
            var lactose = Console.ReadLine();
            bool temLactose = false;

            if(lactose == "S" || lactose == "s") {
                temLactose = true;
            }else if (lactose == "N" || lactose == "N")
            {
                temLactose = false;
            }
            else
            {
                Console.WriteLine("Por favor insira se há lactose!");
            }

            if (temLactose == true || temLactose == false)
            {
                if (int.TryParse(calorias, out int caloriasInt))
                {
                    var refeicao = new Bebida(descricao, caloriasInt, temLactose);

                    refeicoes.Add(refeicao);

                    Console.WriteLine("Meal added!!!");
                }
                else
                {
                    Console.WriteLine("invalid calory number!!!");
                }
            }
        }

        public static void ListarRefeicoes(List<Refeicao> refeicoes)
        {
            foreach(var refeicao in refeicoes)
            {
                refeicao.ImprimirMensagem();
            }
        }




    }
}


//if(option == "1")
//{
//    Console.WriteLine($"Name: {name}, Heigth: {heigth}, Weight: {weight}");
//}else if(option == "2")
//{
//    //RegisterMeal();
//}else if(option == "3")
//{
//    //ShowMeals();
//}
//else
//{
//    Console.WriteLine("Please, choose an option!");
//}



//List<int> notas = new List<int> { 10, 1, 4, 2 , 8, 9, 3, 2, 10 };
//var anyNumberBiggerThan3 = notas.Any(n => n > 3); //true or false
//var firstNota = notas.First(n => n == 2); //will show the first element nota = 2
//var singleNota = notas.Single(n => n == 9); //search one value = 9
//var ordered = notas.OrderBy(n => n);


//var numerosString = "0 1 2 3 4 5 6 7 8 9";
//var numeros = numerosString.Split(" ");

//for(var i = 0; i > numeros.Length; i++)
//{ 
//    Console.WriteLine(numeros[i]);
//}

//var counter = 0;
//while(counter < numeros.Length)
//{
//    Console.WriteLine(numeros[counter]);

//    counter++;
//}

//foreach (var numero in numeros) 
//{
//    Console.WriteLine(numero);
//}