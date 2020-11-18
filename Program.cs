using System;

namespace calculadora_simplees
{
    class Program
    {
        static void Main(string[] args)
        {

            //perdir operação 
            //pedir o 1º numero
            //pedir o 2º numero


            //para quebrar linha = /n
            Console.WriteLine("Digite a operaçao que deseja fazer \n Soma , Subtracao , Multiplicacao , Divisao");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o 1º número");
            float num1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o 2º número");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;

            //IF / ELSE PADRÃO
        
            // if(operacao == "Soma"){
            //     resultado = num1 + num2; 

            // }else if( operacao == "Subtracao"){
            //     resultado = num1 - num2;

            // }else if(operacao == "Multiplicacao"){
            //     resultado = num1 * num2;
                
            // }else if(operacao == "Divisao"){
            //     resultado = num1 / num2;
            // }else{
            //     Console.WriteLine("Operação inválida!");
            // }


                // swuitch / Case
            switch(operacao){
                case "Soma" :
                    resultado = num1+num2;
                    break;

                case "Subtracao":
                    resultado = num1-num2;
                    break;

                case  "Multiplicacao":
                    resultado = num1*num2;
                    break;
                    
                case "Divisao" :
                    resultado = num1/num2;
                    break;
                
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            
            }
                            //Concatenação
            //Console.WriteLine("Calculo : "+num1+" e "+num2+" = Resultado :" +resultado );

                            // interpolação
            Console.WriteLine($"Calculo : {num1} e {num2} = Resultado : {resultado}");
        }
    }
}
