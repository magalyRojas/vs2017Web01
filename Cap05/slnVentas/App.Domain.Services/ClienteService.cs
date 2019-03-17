using App.Data.DataBase;
using App.Data.Repository;
using App.Domain.Services.Interfaces;
using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services
{
    public class ClienteService : IClienteService
    {
        public IEnumerable<Cliente> GetAll(string nombre)
        {
            List<Cliente> results;

            using (var unitOfWork = new AppUnitOfWork())
            {
                results = unitOfWork.ClienteRepository.GetAll(
                    item => item.Nombre.Contains(nombre)
                    ).ToList();

            }
            return results;
        }

        public Cliente GetById(int id)
        {
            Cliente results;

            using (var unitOfWork = new AppUnitOfWork())
            {
                results = unitOfWork.ClienteRepository.GetById(id);
            }
            return results;
        }

        public bool Save(Cliente entity)
        {
            bool result = false;

            try
            {
                using (var unitOfWork = new AppUnitOfWork())
                {
                    if (entity.ClienteID == 0) //cuando es nuevo registro
                    {
                        unitOfWork.ClienteRepository.Add(entity);
                    }
                    else //en modo edición
                    {
                        unitOfWork.ClienteRepository.Update(entity);
                    }
                    unitOfWork.Complete();
                }
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

    }
}
