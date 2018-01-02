using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentosSuporte
{
    class ServicoValidation {
        

        public bool validar(String descricao)
        {
             bool validado=false;

            if (descricao != "")
            {
                validado = true;
            }

            return validado;
        }
    }


    
}
