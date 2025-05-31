using DAL.Contracts;
using Domain;
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

        public void Add(Usuario usuario)
        {
            usuarios.Add(usuario);
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
