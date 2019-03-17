using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Interfaces
{
    public interface IClienteService
    {
        IEnumerable<Cliente> GetAll(string nombre);
        bool Save(Cliente entity);
        Cliente GetById(int id);
    }
}
