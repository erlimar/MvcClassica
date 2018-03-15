using MvcClassica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcClassica.Services
{
    public class CrudService
    {
        private readonly IList<CrudItemModel> _list;

        public CrudService()
        {
            _list = new List<CrudItemModel>
            {
                new CrudItemModel{Codigo=1, Nome="Item 1"},
                new CrudItemModel{Codigo=2, Nome="Item 2"},
                new CrudItemModel{Codigo=3, Nome="Item 3"},
                new CrudItemModel{Codigo=4, Nome="Item 4"},
                new CrudItemModel{Codigo=5, Nome="Item 5"},
                new CrudItemModel{Codigo=6, Nome="Item 6"},
                new CrudItemModel{Codigo=7, Nome="Item 7"},
                new CrudItemModel{Codigo=8, Nome="Item 8"},
                new CrudItemModel{Codigo=9, Nome="Item 9"}
            };
        }

        public IEnumerable<CrudItemModel> Pesquisa(PesquisaFormModel filtro)
        {
            var all = _list.Where(w => w.Nome.Contains(filtro.Termo ?? string.Empty));

            filtro.PageTotal = all.Count();

            return all.OrderBy(o => o.Nome)
                .Skip(filtro.PageIndex * filtro.PageCount)
                .Take(filtro.PageCount);
        }
    }
}