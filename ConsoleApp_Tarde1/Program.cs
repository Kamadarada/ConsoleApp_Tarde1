// See https://aka.ms/new-console-template for more information
using ConsoleApp_Tarde1;

Console.WriteLine("Hello, World!");


Produto p1 = new Produto(1, "Mouse Razer", 109M);
Produto p2 = new Produto(2, "Fone gamer", 200M);


Console.WriteLine(p1.getId() + " " + p1.getDescricao() + " Valor = " + p1.getValor());

p1.setValor(200M);
p1.setDescricao("Mouse gamer");


Console.WriteLine(p1.getId() + " " + p1.getDescricao() + " Valor = " + p1.getValor());



Cliente c1 = new Cliente(1, "Felipe Kamada", "32524144");

Console.WriteLine(c1.getId() +" Nome: "+ c1.getNome()+ " Contato: "+ c1.getTelefone());


Endereco e1 = new Endereco(1, "15902122","Rua sebastião",71,"Jardim Taquarão","Taquaritinga");
Console.WriteLine(e1.getId() + " Cep: " + e1.getCEP() + " Rua: " + e1.getRua() + " Numero: "+e1.getNumero() + " Bairro: "+e1.getBairro() + " Cidade: " + e1.getCidade());