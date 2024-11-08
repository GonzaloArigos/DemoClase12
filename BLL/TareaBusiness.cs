using DAL;
using Entity.Model;
using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Transactions;

namespace BLL
{
    public class TareaBusiness
    {
        private TareaDao TareaDao = new TareaDao();

        public void crearNuevaTarea(TareaEntity tarea)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    if (tarea.Descripcion.Length <= 5)
                    {
                        throw new Exception("La descripcion de la tarea debe tener mas de 5 caracteres");
                    }
                    if (tarea.FechaTarea < DateTime.Today)
                    {
                        throw new Exception("La fecha de la tarea debe ser posterior a la fecha de hoy");
                    }
                    tarea.FechaRegistro = DateTime.Today;
                    TareaDao.crearNuevaTarea(tarea);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void modificarTarea(int idTarea, string nuevaDescripcion, DateTime nuevaFecha)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    if (nuevaDescripcion.Length <= 5)
                    {
                        throw new Exception("La descripcion de la tarea debe tener mas de 5 caracteres");
                    }
                    if (nuevaFecha < DateTime.Today)
                    {
                        throw new Exception("La fecha de la tarea debe ser posterior a la fecha de hoy");
                    }
                    TareaDao.modificarTarea(idTarea, nuevaDescripcion, nuevaFecha);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void eliminarTarea(int idTarea)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    TareaDao.eliminarTarea(idTarea);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public List<TareaEntity> GetAll()
        {
            try
            {
                return TareaDao.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
