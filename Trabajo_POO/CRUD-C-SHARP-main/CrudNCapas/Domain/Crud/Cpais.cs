using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess.Entities;
using Common.Attributes;

namespace Domain.Crud
{
    public class Cpais
    {
        Procedimientos PRO = new Procedimientos();

        public DataTable Mostrar()
        {
            DataTable td = new DataTable();
            td = PRO.Mostrar();
            return td;
        }

        public DataTable Buscar(string Buscar)
        {
            DataTable td = new DataTable();
            td = PRO.Buscar(Buscar);
            return td;
        }


        public void Insertar(AttributesPeople obj)
        {
            PRO.Insertar(obj);
        }

        public void Modificar(AttributesPeople obj)
        {
            PRO.Modificar(obj);
        }

        public void Eliminar(AttributesPeople obj)
        {
            PRO.Eliminar(obj);
        }
    }
}
