﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Cliente
    {
        public string nome;
        public string cpf;
        public string rg;
        public string endereco;
        public int idade;

        public bool EhMaiorDeIdade() {
            //if (this.idade > 18) {
            //    return true;
            //}else{
            //    return false;
            //}
            return this.idade >= 18;
            
        }
    }
}
