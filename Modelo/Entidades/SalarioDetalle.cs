using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class SalarioDetalle

    {
        //JALE LA EMPRESA, SALARIO, ROLES
        public int SalarioDetalleId { get; set; }
        public int? EmpresaId { get; set; }
        public Empresa Empresa { get; set; }

        public int? SalarioId { get; set; }
        public Salario Salarios { get; set; }

        public int? RolesId { get; set; }
        public Roles Roles { get; set; }

    }
}
