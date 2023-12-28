using System;
class No
{
    public int elemento;
    public No esq;
    public No dir;
    public No(int elemento, No esq, No dir)
    {
        this.elemento = elemento;
        this.esq = esq;
        this.dir = dir;
    }
    public No(int elemento)
    {
        this.elemento = elemento;
        this.esq = null;
        this.dir = null;
    }
}
class ArvoreBinaria
{
    public No raiz;
    public ArvoreBinaria()
    {
        raiz = null;
    }
    public No Inserir(int x, No i)
    {
        if (i == null)
        {
            i = new No(x);
        }
        else if (x < i.elemento)
        {
            i.esq = Inserir(x, i.esq);
        }
        else if (x > i.elemento)
        {
            i.dir = Inserir(x, i.dir);
        }
        else
        {
            throw new Exception("Erro!");
        }
        return i;
    }
    public void Inserir(int x)
    {
        raiz = Inserir(x, raiz);
    }
    public void InserirPai(int x, No i, No pai)
    {
        if (i == null)
        {
            if (x < pai.elemento)
            {
                pai.esq = new No(x);
            }
            else
            {
                pai.dir = new No(x);
            }
        }
        else if (x < i.elemento)
        {
            InserirPai(x, i.esq, i);
        }
        else if (x > i.elemento)
        {
            InserirPai(x, i.dir, i);
        }
        else
        {
            throw new Exception("Erro!");
        }
    }
    public void InserirPai(int x)
    {
        if (raiz == null)
        {
            raiz = new No(x);
        }
        else if (x < raiz.elemento)
        {
            InserirPai(x, raiz.esq, raiz);
        }
        else if (x > raiz.elemento)
        {
            InserirPai(x, raiz.dir, raiz);
        }
        else
        {
            throw new Exception("Erro!");
        }
    }
    public bool Pesquisar(int x, No i)
    {
        bool resp;
        if (i == null)
        {
            resp = false;
        }
        else if (x == i.elemento)
        {
            resp = true;
        }
        else if (x < i.elemento)
        {
            resp = Pesquisar(x, i.esq);
        }
        else
        {
            resp = Pesquisar(x, i.dir);
        }
        return resp;
    }
    public bool Pesquisar(int x)
    {
        return Pesquisar(x, raiz);
    }
    public void InOrdem(No i)
    {
        if (i != null)
        {
            InOrdem(i.esq);
            Console.Write(i.elemento + " ");
            InOrdem(i.dir);
        }
    }
    public void PreOrdem(No i)
    {
        if (i != null)
        {
            Console.Write(i.elemento + " ");
            InOrdem(i.esq);
            InOrdem(i.dir);
        }
    }
    public void PosOrdem(No i)
    {
        if (i != null)
        {
            InOrdem(i.esq);
            InOrdem(i.dir);
            Console.Write(i.elemento + " ");
        }
    }
    public No MaiorEsq(No i, No j)
    {
        if (j.dir == null)
        {
            i.elemento = j.elemento;
            j = j.esq;
        }
        else
        {
            j.dir = MaiorEsq(i, j.dir);
        }
        return j;
    }
    public No Remover(int x, No i)
    {
        if (i == null)
        {
            throw new Exception("Erro!");
        }
        else if (x < i.elemento)
        {
            i.esq = Remover(x, i.esq);
        }
        else if (x > i.elemento)
        {
            i.dir = Remover(x, i.dir);
        }
        else if (i.dir == null)
        {
            i = i.esq;
        }
        else if (i.esq == null)
        {
            i = i.dir;
        }
        else
        {
            i.esq = MaiorEsq(i, i.esq);
        }
        return i;
    }
    public void Remover(int x)
    {
        raiz = Remover(x, raiz);
    }

    public int Contador(){
        return Contador(raiz);
    }

    public int Contador(No i){
        
       if (i == null){
            return 0;
        }
        
        else{
            int alturaDir = Altura(i.dir);
            int alturaEsq = Altura(i.esq);

            return alturaDir - alturaEsq;
        }
    }

    public int Altura(No no){
    if (no == null){
        return 0;
    }
    else{
            int alturaDir = Altura(no.dir);
            int alturaEsq = Altura(no.esq);

            return 1 + Math.Max(alturaEsq, alturaDir);
         }
    }

}

class Program
{
    static void Main()
    {
        ArvoreBinaria ab = new ArvoreBinaria();

        ab.Inserir(8);
        ab.Inserir(10);
        ab.Inserir(9);
        ab.Inserir(11);

        
        int x = ab.Contador();
        Console.WriteLine(x);
        if(x > 1 || x < -1){
            Console.WriteLine("A arvore não é AVL");
        }
        else{
            Console.WriteLine("A arvore é AVL");
        }
    }
}