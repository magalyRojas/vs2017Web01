﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Data.DataBase;
using App.Data.Repository;
using App.Domain.Services.Interfaces;
using App.Entities.Base;


namespace App.Domain.Services
{
    public class UnidadMedidaService : IUnidadMedidaService
    {
        public IEnumerable<UnidadMedida> GetAll(string nombre)
        {
            List<UnidadMedida> results;
            using (var unitOfWork = new AppUnitOfWork())
            {
                results = unitOfWork.UnidadMedidaRepository.GetAll(item => item.Nombre.Contains(nombre)).ToList();
            }
            return results;
        }

        public UnidadMedida GetById(int id)
        {
            UnidadMedida results;
            using(var unitOfWork = new AppUnitOfWork())
            {
                results = unitOfWork.UnidadMedidaRepository.GetById(id);
            }
            return results;
        }

        public bool Save(UnidadMedida entity)
        {
            bool result = false;

            try
            {
                using (var unitOfWork = new AppUnitOfWork())
                {
                    if (entity.UnidadMedidaID == 0)
                    {
                        unitOfWork.UnidadMedidaRepository.Add(entity);
                    }
                    else
                    {
                        unitOfWork.UnidadMedidaRepository.Update(entity);
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