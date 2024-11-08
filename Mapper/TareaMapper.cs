using Entity;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class TareaMapper
    {
        public static Tarea Map(TareaEntity tarea)
        {
            return new Tarea
            {
                IdTarea = tarea.IdTarea,
                DescripcionTarea = tarea.Descripcion,
                FechaRegistro = tarea.FechaRegistro,
                FechaTarea = tarea.FechaTarea
            };
        }

        public static TareaEntity Map(Tarea tarea)
        {
            return new TareaEntity
            {
                IdTarea = tarea.IdTarea,
                Descripcion = tarea.DescripcionTarea,
                FechaRegistro = tarea.FechaRegistro,
                FechaTarea = tarea.FechaTarea
            };
        }
    }
}
