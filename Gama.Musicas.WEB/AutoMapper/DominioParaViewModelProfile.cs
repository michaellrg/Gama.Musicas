using AutoMapper;
using Gama.Musicas.Dominio;
using Gama.Musicas.WEB.ViewModels.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gama.Musicas.WEB.AutoMapper
{
    public class DominioParaViewModelProfile : Profile
    {
       public DominioParaViewModelProfile()
        {
            CreateMap<Album, AlbumIndexViewModel>();
           
        }
    }
}