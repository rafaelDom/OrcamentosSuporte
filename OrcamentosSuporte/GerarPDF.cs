using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace OrcamentosSuporte
{
    class GerarPDF
    {

        public void gerarPDF(string empresa, string servico_realizado)
        {
            Document doc = new Document(PageSize.A4);//cria page A4
            doc.SetMargins(40, 40, 40, 80);//espacamento das margens
            doc.AddCreationDate();//adicionando as configuracoes
            var date = DateTime.Today.ToString("dd-MM-yyyy");

            //caminho onde sera criado o pdf + nome desejado

            string caminho = @"C:\Orcamentos\" + "orc_"+empresa+"-"+date.ToString()+".pdf";

            // criando pdf em branco.
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            //criando string vazia
            string dados = "";
            //criando a variavel para paragrafo
            Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 14));
            //alinhamento
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            //adicionando texto
            paragrafo.Add("TESTE TESTE TESTE"+empresa+"-"+servico_realizado);
            //adicionando paragrafo ao doc
            doc.Add(paragrafo);
            //fechando  documento para que seja salva as alterações
            doc.Close();
            System.Diagnostics.Process.Start(caminho);

        }

    }
}
