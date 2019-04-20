using System.Collections.Generic;
using DesignPatterns.Cap5;

namespace DesignPatterns.Cap4
{
    public interface IExpressao
    { 
        int Avalia();
        void Aceita(IVisitor Impressora);
    } 
}