using System;

namespace DesignPatterns.Cap9
{
    //Repsentação Código legado
    public class ClienteDao
    {
        public Cliente BuscaPorCpf(string CPF)
        {
            return new Cliente();
        }
    }
}