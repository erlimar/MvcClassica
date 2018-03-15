using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MvcClassica.Models
{
    [Bind(Exclude = "Interno")]
    public class PesquisaFormModel
    {
        public PesquisaFormModel()
        {
            Interno = new PesquisaFormInternoModel();
        }

        [DisplayName("Termo da pesquisa")]
        public string Termo { get; set; }

        public int PageIndex { get; set; }
        public int PageCount { get; set; }
        public int PageTotal { get; set; }

        public PesquisaFormInternoModel Interno { get; set; }
    }
}