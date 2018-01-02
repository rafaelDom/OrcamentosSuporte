using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrcamentosSuporte
{
    class OrcamentoValidation
    {

        public bool validar(OrcamentoModel orcamentoModel)
        {
            bool validado = false;

            if (orcamentoModel.Empresa != "" && orcamentoModel.Equipamento != "" && orcamentoModel.Data_orc != "" && orcamentoModel.Responsavel != "")
            {
                validado = true;
            }

            return validado;
        }
    }
}
