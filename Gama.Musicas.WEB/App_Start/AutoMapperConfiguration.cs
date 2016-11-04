using AutoMapper;
using Gama.Musicas.Dominio;
using Gama.Musicas.WEB.ViewModels.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gama.Musicas.WEB.App_Start
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            /* cfg.CreateMap<OrderDto, Order>()
                 .ForMember(d => d.Name, opt => opt.MapFrom(s => s.FullName));

             cfg.CreateMap<Order, OrderDto>()
                 .ForMember(d => d.FullName, opt => opt.MapFrom(s => s.Name));

             cfg.CreateMap<Customer, CustomerDto>()
                 .ForMember(c => c.Orders, opt => opt.Ignore())
                 .ReverseMap();*/

            // cfg.AddProfile<FooProfile>();
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Album, AlbumIndexViewModel>()
                .ForMember(p => p.Nome,
                opt =>
                {
                    opt.MapFrom(src => string.Format("{0} ({1})", src.Nome, src.Ano));
                }
                    );

            
                cfg.CreateMap<AlbumViewModel, Album>();

                cfg.CreateMap<Album, AlbumViewModel>();
            });

        }
    }
}