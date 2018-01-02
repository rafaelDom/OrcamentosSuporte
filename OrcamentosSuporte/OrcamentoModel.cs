using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentosSuporte
{
    public class OrcamentoModel
    {
        private String empresa;
        private String equipamento;
        private String data_orc;
        private String servico_realizado;
        private String valor;
        private String garantia;
        private String responsavel;
        private String email;
        private String telefone;

        public string Empresa
        {
            get
            {
                return empresa;
            }

            set
            {
                empresa = value;
            }
        }

        public string Equipamento
        {
            get
            {
                return equipamento;
            }

            set
            {
                equipamento = value;
            }
        }

        public string Data_orc
        {
            get
            {
                return data_orc;
            }

            set
            {
                data_orc = value;
            }
        }

        public string Servico_realizado
        {
            get
            {
                return servico_realizado;
            }

            set
            {
                servico_realizado = value;
            }
        }

        public string Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public string Garantia
        {
            get
            {
                return garantia;
            }

            set
            {
                garantia = value;
            }
        }

        public string Responsavel
        {
            get
            {
                return responsavel;
            }

            set
            {
                responsavel = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }
    }
}
