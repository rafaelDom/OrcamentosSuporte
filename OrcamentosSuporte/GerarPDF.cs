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

        public void gerarPDF(string empresa, string servico_realizado, string responsavel, string modelo, string valor, string nf)
        {
            
            Document doc = new Document(PageSize.A4);//cria page A4
            doc.SetMargins(40, 40, 40, 80);//espacamento das margens
            doc.AddCreationDate();//adicionando as configuracoes
            var date = DateTime.Today.ToString("dd-MM-yyyy");
            var datedia = DateTime.Today.ToString("dd");
            var dateano = DateTime.Today.ToString("yyyy");
            var datemes = DateTime.Today.ToString("MM");
            var hora = DateTime.Now.ToShortTimeString();
            var hrs=hora.ToString().Replace(":","");
            int mes = int.Parse(datemes);

            string mesExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToLower();

            //caminho onde sera criado o pdf + nome desejado

            string caminho = @"C:\Orcamentos\" + "orc_"+empresa+"-"+date.ToString()+"-"+hrs+".pdf";

            // criando pdf em branco.
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();
            Image imgcabecalho = Image.GetInstance(@"C:\Orcamentos\img\cabecalho.png");
            imgcabecalho.ScaleToFit(520,120);
            doc.Add(imgcabecalho);
            

            //criando string vazia
            string dados = "";
            var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
            var normalFont1 = FontFactory.GetFont(FontFactory.HELVETICA, 8);
            //criando a variavel para paragrafo
            Paragraph paragrafonormal = new Paragraph(dados, normalFont);
            //alinhamento
            paragrafonormal.Alignment = Element.ALIGN_JUSTIFIED;
            //adicionando texto
            paragrafonormal.Add("Jundiaí, "+ datedia+" de "+ mesExtenso+" de " + dateano + " .");
            //adicionando paragrafo ao doc
            doc.Add(paragrafonormal);
            paragrafonormal.Add(new Paragraph(" "));
            doc.Add(new Chunk("\n"));


            var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
            boldFont.SetStyle(Font.UNDERLINE);
            Paragraph paragrafoempresa = new Paragraph(dados, boldFont);
            paragrafoempresa.Alignment = Element.ALIGN_CENTER;
            paragrafoempresa.Add("Empresa: "+empresa);
            doc.Add(paragrafoempresa);
            paragrafoempresa.Add(new Paragraph(" "));
            doc.Add(new Chunk("\n"));


            Paragraph paragraforesponsavel = new Paragraph(dados, normalFont);
            paragraforesponsavel.Add("A/C: " + responsavel);
            doc.Add(paragraforesponsavel);
            paragraforesponsavel.Add(new Paragraph(" "));
            doc.Add(new Chunk("\n"));

            var boldFont1 = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            boldFont1.SetStyle(Font.UNDERLINE);
            Paragraph paragraforcamento = new Paragraph(dados, boldFont1);
            paragraforcamento.Alignment = Element.ALIGN_CENTER;
            paragraforcamento.Add("Orçamento Conserto Relógio de Ponto");
            paragraforcamento.Add(new Paragraph(" "));
            doc.Add(paragraforcamento);
            


            var boldFont2 = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            Paragraph paragrafomodelo = new Paragraph(dados, boldFont2);
            paragrafomodelo.Add("Modelo: "+ modelo);
            doc.Add(paragrafomodelo);
            paragraforcamento.Add(new Paragraph(" "));
            doc.Add(new Chunk("\n"));

            Paragraph paragrafodescmnt = new Paragraph(dados, boldFont2);
            paragrafodescmnt.Add("Descrição da manutenção: ");
            doc.Add(paragrafodescmnt);
            

            Paragraph servicos = new Paragraph(dados, normalFont);
            servicos.Add(servico_realizado + ".");
            doc.Add(servicos);
            paragraforesponsavel.Add(new Paragraph(" "));


            var fontValor = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            fontValor.SetColor(255, 0, 0);
            Paragraph paragravalor = new Paragraph(dados, fontValor);
            paragravalor.Add("Valor total: R$" + valor);
            doc.Add(paragravalor);
            paragraforcamento.Add(new Paragraph(" "));
            doc.Add(new Chunk("\n"));


            
            Paragraph paragrafocp = new Paragraph(dados, boldFont1);
            paragrafocp.Alignment = Element.ALIGN_CENTER;
            paragrafocp.Add("Condições de Pagamento e Garantia do Serviço");
            paragrafocp.Add(new Paragraph(" "));
            doc.Add(paragrafocp);

        
            Paragraph dadoscp= new Paragraph(dados, normalFont);
            dadoscp.Add("Forma de Pagamento: 21 dias boleto a vista.");
            doc.Add(dadoscp);

            Paragraph dadoscp1 = new Paragraph(dados, normalFont);
            dadoscp1.Add("Validade da proposta: 10 dias a partir da apresentação desta.");
            doc.Add(dadoscp1);

            Paragraph dadoscp2 = new Paragraph(dados, normalFont);

            if (nf.ToString() == "")
            {
                dadoscp2.Add("Entrega do equipamento: 5 dias úteis. ");
            }
            else
            {
                dadoscp2.Add("Entrega do equipamento: 30 dias. ");
            }      
            doc.Add(dadoscp2);

            Paragraph dadoscp3 = new Paragraph(dados, normalFont);
            dadoscp3.Add("Garantia do serviço: 3 meses (90 dias).");
            doc.Add(dadoscp3);

            Paragraph linha = new Paragraph(dados, normalFont);
            linha.Add("_____________________________________________________________________________");
            doc.Add(linha);
            doc.Add(new Chunk("\n"));

            Paragraph dadosass = new Paragraph(dados, normalFont1);
            dadosass.Add("Atenciosamente,");
            doc.Add(dadosass);
            doc.Add(new Chunk("\n"));

            Paragraph dadosass1 = new Paragraph(dados, normalFont1);
            dadosass1.Add("Vicente Alves");
            doc.Add(dadosass1);

            Paragraph dadosass2 = new Paragraph(dados, normalFont1);
            dadosass2.Add("Depto. Tecnico");
            doc.Add(dadosass2);

            Paragraph dadosass3 = new Paragraph(dados, normalFont1);
            dadosass3.Add("Tel. (11) 4586-9291 / (11) 4523-0999");
            doc.Add(dadosass3);

            Paragraph dadosass4 = new Paragraph(dados, normalFont1);
            dadosass4.Add("e-mail: suporte@pardinirelogios.com.br");
            doc.Add(dadosass4);

            //rodape
            Paragraph footer = new Paragraph("RAZAO SOCIAL: WAGNER COSTA PARDINI RELÓGIOS ME / Endereço: Av. Henrique Andrés, nº 91 Bairro : Vl. Municipal – Jundiaí – SP Cep:13.201-048", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            
            //footer.Alignment = Element.ALIGN_LEFT;
            PdfPTable footerTbl = new PdfPTable(1);
            footerTbl.WidthPercentage = 100f;
            footerTbl.TotalWidth = 1000f;
            footerTbl.HorizontalAlignment = 0;
            PdfPCell cell = new PdfPCell(footer);
            cell.Border = 0;
            cell.Colspan = 1;
            cell.PaddingLeft = 0;
            cell.HorizontalAlignment = 0;
            footerTbl.DefaultCell.HorizontalAlignment = 0;
            footerTbl.WidthPercentage = 100;
            footerTbl.AddCell(cell);
            footerTbl.WriteSelectedRows(0, -60, 10, 30, writer.DirectContent);



            //fechando  documento para que seja salva as alterações
            doc.Close();
            System.Diagnostics.Process.Start(caminho);

        }

    }
}
