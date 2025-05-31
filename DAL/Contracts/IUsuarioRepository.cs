using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IUsuarioRepository
    {
        void Add(Usuario usuario);
        List<Usuario> GetAll();
        Usuario GetByName(string name);
    }
}
