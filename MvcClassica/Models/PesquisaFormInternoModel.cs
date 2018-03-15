using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcClassica.Models
{
    public class PesquisaFormInternoModel
    {
        public IEnumerable<CrudItemModel> Resultado { get; set; }
    }
}