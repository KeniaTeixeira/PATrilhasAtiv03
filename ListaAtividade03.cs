/*
 * Criado por SharpDevelop.
 * Usuário: Kenia Teixeira
 * Data: 29/01/2025
 * Hora: 09:13
*/
 
using System;
namespace ListaAtividade03{
	class ListaDeAtividade{
		public static void Main(string[] args){
			int sair = 1;
			
			while(sair == 1){
			Console.WriteLine(" \n\n ------ LISTA 03 ------- \nEscolha a atividade: A - B - C - D - E - F - G - H - I - J \n   PRESIONE S PARA SAIR");
			char x = Convert.ToChar(Console.ReadLine());
			char escolha = char.ToLower(x);
			switch(escolha){
					case 'a':
						questaoA();
					break;
					
					case 'b':
						questaoB();
						break;
					
					case 'c':
						questaoC();
						break;
					
					case 'd':
						questaoD();
						break;
						
					case 'e':
						questaoE();
						break;
					case 'f':
						questaoF();
						break;
						
					case 'g':
						questaoG();
						break;
						
					case 'h':
						questaoH();
						break;
						
					case 'i':
						questaoI();
						break;
						
					case 'j':
						questaoJ();
						break;
						
					case 's':
					sair = 0;
					break;
					
					default:
						Console.WriteLine("Opção Invalida!!");
					break;
					}	
			}
			
			Console.Write("Precione qualquer tecla para continuar . . . ");
			Console.ReadKey(true);
		}
		
			static void questaoA(){
				Console.WriteLine(" -------- QUESTAO A --------");
				Console.WriteLine(" Digite o primeiro numero: ");
				int x = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" Digite o segundo numero: ");
				int y = Convert.ToInt32(Console.ReadLine());
				if(x > y){
					Console.WriteLine(x + " é maior que " + y);
				}else{
					Console.WriteLine(x + " é menor que " + y);
				}
			}
		
			static void questaoB(){
				Console.WriteLine(" -------- QUESTAO B --------");
				Console.WriteLine(" Digite o primeiro numero: ");
				int x = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" Digite o segundo numero: ");
				int y = Convert.ToInt32(Console.ReadLine());
				if(x < y){
					Console.WriteLine(x + " é menor que " + y);
				}else{
					Console.WriteLine(x + " é maior que " + y);
				}
			}
			
			static void questaoC(){
				Console.WriteLine(" -------- QUESTAO C --------");
				Console.WriteLine(" Digite o primeiro numero: ");
				int x = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" Digite o segundo numero: ");
				int y = Convert.ToInt32(Console.ReadLine());
				
				if(x == y){
					Console.WriteLine("O numeros são iguais");
				}else{
					Console.WriteLine("O numeros são diferentes");
				}
			}
			
			static void questaoD(){
				Console.WriteLine(" -------- QUESTAO D --------");
				Console.WriteLine(" Digite o primeiro numero: ");
				int x = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" Digite o segundo numero: ");
				int y = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" Digite o terceiro numero: ");
				int z = Convert.ToInt32(Console.ReadLine());
				
				if(x < y && x > z){
					Console.WriteLine("{0} é menor que {1} e maior que {2}", x, y, z);
				}
			}
			
			static void questaoE(){
				Console.WriteLine(" -------- QUESTAO E --------");
				Console.WriteLine(" Digite o primeiro numero: ");
				float x = float.Parse(Console.ReadLine());
				Console.WriteLine(" Digite o segundo numero: ");
				float y = float.Parse(Console.ReadLine());
				
				if(x == y){
					Console.WriteLine("São iguais");
				}else if(x > y){
					Console.WriteLine(x + " é maior que " + y);
				}
			}
			
			static void questaoF(){
				Console.WriteLine(" -------- QUESTAO F --------");
				Console.WriteLine(" Digite um numero: ");
				int x = Convert.ToInt32(Console.ReadLine());
				
				if(x%2 == 0){
					Console.WriteLine("Numero par");
				}else{
					Console.WriteLine("Numero ímpar");
				}		
			}
		
			static void questaoG(){
				Console.WriteLine(" -------- QUESTAO G --------");
				Console.WriteLine(" Digite o primeiro numero: ");
				float x = float.Parse(Console.ReadLine());
				Console.WriteLine(" Digite o segundo numero: ");
				float y = float.Parse(Console.ReadLine());
				
				if(x == y){
					Console.WriteLine("São iguais");
				}else if(x < y){
					Console.WriteLine(x + " é menor que " + y);
				}
			}
		
			static void questaoH(){
				Console.WriteLine(" -------- QUESTAO H --------");
				Console.WriteLine(" Digite um numero: ");
				int x = Convert.ToInt32(Console.ReadLine());
				if(x < 0){
					Console.WriteLine("Valor negativo");
				}else{
					Console.WriteLine("Valor positivo");
				}
			}
		
			static void questaoI(){
				Console.WriteLine(" -------- QUESTAO I --------");
				Console.WriteLine(" Digite o primeiro numero: ");
				int x = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" Digite o segundo numero: ");
				int y = Convert.ToInt32(Console.ReadLine());
				
				if((x-y) < 10){
					Console.WriteLine("A diferença é menor que 10");
				}else if((x-y) == 10){
					Console.WriteLine("A diferença é igual a 10");
				}
				
			}
		
			static void questaoJ(){
				Console.WriteLine(" -------- QUESTAO J --------");
				Console.WriteLine(" Digite um numero: ");
				float x = float.Parse(Console.ReadLine());
				
				if(x == 0.0){
					Console.WriteLine("O valor é igual a zero");
				}
				
			}

	}
}