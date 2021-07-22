using SD_WebSite_DashBoardApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Business
{
    public interface IComponenteBusiness
    {
        object UpdateComponentes(List<Componente> componentes);
        object UpdateComponente(Componente componente);
    }
}
