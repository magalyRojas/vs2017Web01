using App.Entities.Base;
using App.UI.Web.MVC.Models.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.UI.Web.MVC.App_Start
{
    public class Mappers
    {
        public static void MappingDTO()
        {// para almacenar de una tipo a otro
            Mapper.Initialize(
                cfg =>
                {
                    cfg.CreateMap<ComentarioViewModel, Comentario>();
                    cfg.CreateMap<Comentario, ComentarioViewModel>();
                }
                );
        }
    }
}