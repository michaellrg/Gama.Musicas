using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gama.Musicas.WEB.Annotations
{
    public class EmailTreinaWeb :ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value.ToString().EndsWith("@treinaweb.com.br");
        }
    }
}