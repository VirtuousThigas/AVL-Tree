using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    public class Paciente
    {
        private int cpf;
        private string nome;
        private string email;
        private string telefone;

        public Paciente(int cpf, string nome, string email, string telefone)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
        }
        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}
