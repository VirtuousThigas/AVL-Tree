using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    class No
    {
        private Paciente elemento;
        private No esq;
        private No dir;
        private int nivel;

        public No(Paciente elemento)
        {
            this.elemento = elemento;
            this.esq = null;
            this.dir = null;
            this.nivel = 1;
        }
        public No(Paciente elemento, No esq, No dir, int nivel)
        {
            this.elemento = elemento;
            this.esq = esq;
            this.dir = dir;
            this.nivel = nivel;
        }
        public void SetNivel()
        {
            this.nivel = 1 + Math.Max(GetNivel(esq), GetNivel(dir));

        }
        public static int GetNivel(No no)
        {
            return (no == null) ? 0 : no.nivel;
        }
        public Paciente Elemento
        {
            get { return elemento; }
            set { elemento = value; }
        }
        public No Esq
        {
            get { return esq; }
            set { esq = value; }
        }
        public No Dir
        {
            get { return dir; }
            set { dir = value; }
        }
    }
}
