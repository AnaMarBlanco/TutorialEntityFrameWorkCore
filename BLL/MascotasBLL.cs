using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TutorialEntityFrameWorkCore.Model;

namespace TutorialEntityFrameWorkCore.BLL
{
    public class MascotasBLL
    {
        public static bool Insertar(Mascotas mascotas) 
        { 
            EjemploEntityContext contexto = new EjemploEntityContext(); 
            bool paso = false;
            try
            {
                contexto.Mascotas.Add(mascotas);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso; 
        }
        public static bool Modificar(Mascotas mascotas) 
        { 
            EjemploEntityContext contexto = new EjemploEntityContext(); 
            bool paso = false;
            try
            {
                contexto.Entry(mascotas).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso; 
        }
        public static bool Eliminiar(int id) 
        { 
            EjemploEntityContext contexto = new EjemploEntityContext(); 
            bool paso = false;
            Mascotas mascota;
            try
            {
                mascota = contexto.Mascotas.Find(id);
                contexto.Mascotas.Remove(mascota);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso; 
        }
        public static Mascotas Buscar(int id)
        {
            EjemploEntityContext contexto = new EjemploEntityContext();
            Mascotas mascota;
            try
            {
                mascota = contexto.Mascotas.Find(id);
                
            }
            catch (Exception)
            {

                throw;
            }
            return mascota;
        }

        public static List<Mascotas> GetList(Expression<Func<Mascotas,bool>>expression)
        {
            EjemploEntityContext contexto = new EjemploEntityContext();
            List<Mascotas> list;
            try
            {
                list = contexto.Mascotas.Where(expression).ToList();

            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }
    }
}
