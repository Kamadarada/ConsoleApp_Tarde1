// See https://aka.ms/new-console-template for more information
using ConsoleApp_Tarde1;

Console.WriteLine("Hello, World!");


Produto p1 = new Produto(1, "Mouse Razer", 109M);
Produto p2 = new Produto(2, "Fone gamer", 200M);


Console.WriteLine(p1.getId() + " " + p1.getDescricao() + " Valor = " + p1.getValor());

p1.setValor(200M);
p1.setDescricao("Mouse gamer");


Console.WriteLine(p1.getId() + " " + p1.getDescricao() + " Valor = " + p1.getValor());