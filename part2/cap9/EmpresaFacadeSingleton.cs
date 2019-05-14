using System;

namespace DesignPatterns.Cap9
{
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facade = new EmpresaFacade();

        public EmpresaFacade Instancia { get { return facade; } }
    }
}