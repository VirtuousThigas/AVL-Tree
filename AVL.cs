using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    public class AVL
    {
        private No raiz;

        public AVL()
        {
            raiz = null;
        }
        public bool Pesquisar(int x)
        {
            return Pesquisar(x, raiz);
        }
        private bool Pesquisar(int x, No i)
        {
            bool resp;
            if (i == null)
            {
                resp = false;
            }
            else if (x == i.Elemento.Cpf)
            {
                resp = true;
                Console.WriteLine(i.Elemento.Cpf);
                Console.WriteLine(i.Elemento.Nome);
                Console.WriteLine(i.Elemento.Email);
                Console.WriteLine(i.Elemento.Telefone);
            }
            else if (x < i.Elemento.Cpf)
            {
                resp = Pesquisar(x, i.Esq);
            }
            else
            {
                resp = Pesquisar(x, i.Dir);
            }
            return resp;
        }
        public void CaminharCentral()
        {
            CaminharCentral(raiz);
        }
        private void CaminharCentral(No i)
        {
            if (i != null)
            {
                CaminharCentral(i.Esq);
                Console.Write(i.Elemento.Nome + " ");
                CaminharCentral(i.Dir);
            }
        }
        public void CaminharPre()
        {
            CaminharPre(raiz);
        }
        private void CaminharPre(No i)
        {
            if (i != null)
            {
                Console.Write(i.Elemento.Email + " ");
                CaminharPre(i.Esq);
                CaminharPre(i.Dir);
            }
        }
        public void CaminharPos()
        {
            CaminharPos(raiz);
        }
        private void CaminharPos(No i)
        {
            if (i != null)
            {
                CaminharPre(i.Esq);
                CaminharPos(i.Dir);
                Console.Write(i.Elemento.Cpf + " ");
            }
        }
        public void Inserir(Paciente x)
        {
            raiz = Inserir(x, raiz);
        }
        private No Inserir(Paciente x, No i)
        {
            if (i == null)
            {
                i = new No(x);
            }
            else if (x.Cpf < i.Elemento.Cpf)
            {
                i.Esq = Inserir(x, i.Esq);

            }
            else if (x.Cpf > i.Elemento.Cpf)
            {
                i.Esq = Inserir(x, i.Dir);
            }
            else
            {
                throw new Exception("Erro ao inserir");
            }
            return Balancear(i);
        }
        public void Remover(int x)
        {
            raiz = Remover(x, raiz);
        }
        private No Remover(int x, No i)
        {
            if (i != null)
            {
                throw new Exception("Erro ao remover!");
            }
            else if (x < i.Elemento.Cpf)
            {
                i.Esq = Remover(x, i.Esq);
            }
            else if (x > i.Elemento.Cpf)
            {
                i.Dir = Remover(x, i.Dir);
            }
            else if (i.Dir == null)
            {
                i = i.Esq;
            }
            else if (i.Esq == null)
            {
                i = i.Dir;
            }
            else
            {
                i.Esq = MaiorEsq(i, i.Esq);
            }
            return Balancear(i);
        }
        private No MaiorEsq(No i, No j)
        {
            if (j.Dir == null)
            {
                i.Elemento = j.Elemento;
                j = j.Esq;
            }
            else
            {
                j.Dir = MaiorEsq(i, j.Dir);
            }
            return Balancear(j);
        }
        private No Balancear(No no)
        {
            if (no != null)
            {
                int fator = No.GetNivel(no.Dir) - No.GetNivel(no.Esq);

                if (fator == 0 || fator == 1 || fator == -1)
                {
                    no.SetNivel();
                }
                else if (fator == 2)
                {
                    int fatorFilhoDir = No.GetNivel(no.Dir.Dir) - No.GetNivel(no.Dir.Esq);
                    if (fatorFilhoDir == -1)
                    {
                        no.Dir = RotacionarDir(no.Dir);
                    }
                    no = RotacionarEsq(no);
                }
                else if (fator == -2)
                {
                    int fatorFilhoEsq = No.GetNivel(no.Esq.Dir) - No.GetNivel(no.Esq.Esq);
                    if (fatorFilhoEsq == 1)
                    {
                        no.Esq = RotacionarEsq(no.Esq);
                    }
                    no = RotacionarDir(no);
                }
                else
                {
                    throw new Exception(
                    "Erro no No(" + no.Elemento + ") com fator de balanceamento (" +
                    fator + ") invalido!");
                }
            }
            return no;
        }

        private No RotacionarDir(No no)
        {
            Console.WriteLine("Rotacionar DIR(" + no.Elemento + ")");
            No noEsq = no.Esq;
            No noEsqDir = noEsq.Dir;

            noEsq.Dir = no;
            no.Esq = noEsqDir;
            no.SetNivel();
            noEsq.SetNivel();
            return noEsq;
        }
        private No RotacionarEsq(No no)
        {
            Console.WriteLine("Rotacionar ESQ(" + no.Elemento + ")");
            No noDir = no.Dir;
            No noDirEsq = noDir.Esq;

            noDir.Esq = no;
            no.Dir = noDirEsq;

            no.SetNivel();
            noDir.SetNivel();
            return noDir;
        }
    }
}
