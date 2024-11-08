using Entity;
using Entity.Model;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class TareaDao
    {
        private static AppDbContext getAppDbContext()
        {
            AppDbContextFactory appDbContextFactory = new AppDbContextFactory();
            AppDbContext appDbConext = appDbContextFactory.CreateDbContext(null);
            return appDbConext;
        }

        public void crearNuevaTarea(TareaEntity tarea)
        {
            try
            {
                using (var appDbContext = getAppDbContext())
                {
                    Tarea nuevaTarea = TareaMapper.Map(tarea);
                    appDbContext.Tareas.Add(nuevaTarea);
                    appDbContext.SaveChanges();
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
                using (var appDbContext = getAppDbContext())
                {
                    Tarea tareaToUpdate = appDbContext.Tareas.Where(t => t.IdTarea == idTarea).FirstOrDefault()!;
                    tareaToUpdate.DescripcionTarea = nuevaDescripcion;
                    tareaToUpdate.FechaTarea = nuevaFecha;
                    appDbContext.SaveChanges();
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
                using (var appDbContext = getAppDbContext())
                {
                    Tarea tareaToRemove = appDbContext.Tareas.Where(t => t.IdTarea == idTarea).FirstOrDefault()!;
                    appDbContext.Tareas.Remove(tareaToRemove);
                    appDbContext.SaveChanges();
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
                using(var appDbContext = getAppDbContext())
                {
                    List<Tarea> listaTareas = appDbContext.Tareas.ToList();
                    return listaTareas.Select(t => TareaMapper.Map(t)).ToList();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
