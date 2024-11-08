using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TareaEntity
    {
        private int idTarea;
        private string descripcion;
        private DateTime fechaTarea;
        private DateTime fechaRegistro;

        public int IdTarea { get => idTarea; set => idTarea = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaTarea { get => fechaTarea; set => fechaTarea = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
    }
}
