﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde1
{
    public class Endereco
    {

        private int Id;
        private string CEP;
        private string Rua;
        private int Numero;
        private string Bairro;
        private string Cidade;

        public Endereco(int id, string cep, string rua, int numero, string bairro, string cidade)
        {
            Id = id;
            CEP = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;


        }


        public int getId()
        {
            return Id;
        }
        
        public string getCEP()
        {
            return CEP;
        }

        public string getRua()
        {
            return Rua;
        }

        public int getNumero()
        {
            return Numero;
        }

        public string getBairro()
        {
            return Bairro;
        }

        public string getCidade()
        {
            return Cidade;
        }


        public void setId(int id)
        {
            Id = id;
        }

        public void setCEP(string cep)
        {
            CEP = cep;
        }

        public void setRua(string rua)
        {
            Rua = rua;
        }

        public void setNumero(int numero)
        {
            Numero = numero;
        }

        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }

        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }




    }
}
