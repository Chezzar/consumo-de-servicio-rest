using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMVC.Models;

namespace TestMVC.InfoServices
{
    public class InfoPaises
    {
        public Pais ObetenerPais() {

            Pais resultado = new Pais() { name = "Capadochia",tamanio = 17000, gobierno = "La monarquia Española" };

            return resultado;
        }

        public List<Pais> ObetenerPaises()
        {
            List<Pais> resultado = new List<Pais>();

            Pais resultado1 = new Pais() { name = "Capadochia", tamanio = 17000, gobierno = "La monarquia Española" };

            Pais resultado2 = new Pais() { name = "Caperuzas", tamanio = 35001, gobierno = "El Paies del pinche chino loco" };

            resultado.Add(resultado1);
            resultado.Add(resultado2);

            return resultado;
        }
    }
}
