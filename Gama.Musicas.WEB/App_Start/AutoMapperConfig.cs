using AutoMapper;
using Gama.Musicas.Dominio;
using Gama.Musicas.WEB.AutoMapper;
using Gama.Musicas.WEB.ViewModels.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gama.Musicas.WEB.App_Start
{
    public class AutoMapperConfig
    {
        public void Configurar() {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Album, AlbumIndexViewModel>();
                cfg.AddProfile<DominioParaViewModelProfile>();
            });
        }
    }
}