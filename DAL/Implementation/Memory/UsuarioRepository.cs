﻿using DAL.Contracts;
using Domain;
using Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.Memory
{
    public class UsuarioRepository : IUsuarioRepository
    {
        List<Usuario> usuarios = new List<Usuario>();

        #region
        // Instancia privada estatica y de solo lectura para el Singleton
        private static readonly UsuarioRepository instance = new UsuarioRepository();

        // Metodo publico con acceso global
        public static UsuarioRepository Current
        {
            get { return instance; }
        }

        // Constructor privado para evitar instanciación externa
        private UsuarioRepository()
        {
        }
        #endregion

        public void Add(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            // Buscamos el usuario por nombre dentro de usuarios y luego actualizamos la lista de ciudades suscritas
            var usuarioExistente = usuarios.FirstOrDefault(u => u.Nombre == usuario.Nombre);
            if (usuarioExistente != null)
            {
                usuarioExistente.CiudadesSuscritas = usuario.CiudadesSuscritas;
            }
            else
            {
                throw new UsuarioNoEncontrado();
            }
        }

        public List<Usuario> GetAll()
        {
            return usuarios;
        }

        public Usuario GetByName(string nombre)
        {
            return usuarios.FirstOrDefault(u => u.Nombre == nombre);
        }
    }
}
