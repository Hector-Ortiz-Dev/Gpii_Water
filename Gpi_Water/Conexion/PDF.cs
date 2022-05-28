using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gpi_Water.Conexion
{
    class PDF
    {
        static public void reporte_tarifas(List<RepoTarifa> tarifas)
        {
            Document pdfDocument = new Document(); //Creacion del documento PDF
            Page page1 = pdfDocument.Pages.Add(); //Generar una nueva pagina y devolver la instancia de dicha pagina

            BackgroundArtifact bg = new BackgroundArtifact();
            bg.BackgroundImage = File.OpenRead("RepTarifas.png");
            page1.Artifacts.Add(bg);

            int pos = 25;
            for (int i = 0; i < tarifas.Count; i++)
            {
                TextFragment año = generadorTexto(10, tarifas[i].año.ToString(), 65, 600 - (i * pos));
                TextFragment mes = generadorTexto(10, textoMes(tarifas[i].mes), 130, 600 - (i * pos));
                TextFragment zona = generadorTexto(10, tarifas[i].zona.ToString() + i.ToString(), 195, 600 - (i * pos));
                TextFragment cuota = generadorTexto(10, tarifas[i].cuota.ToString(), 260, 600 - (i * pos));

                TextBuilder txtBuilder = new TextBuilder(page1);
                txtBuilder.AppendText(año);
                txtBuilder.AppendText(mes);
                txtBuilder.AppendText(zona);
                txtBuilder.AppendText(cuota);

                TextFragment basico = generadorTexto(10, tarifas[i].basico.ToString(), 370, 600 - (i * pos));
                TextFragment intermedio = generadorTexto(10, tarifas[i].intermedio.ToString(), 435, 600 - (i * pos));
                TextFragment excedente = generadorTexto(10, tarifas[i].excedente.ToString(), 500, 600 - (i * pos));

                TextBuilder txtBuilder2 = new TextBuilder(page1);
                txtBuilder2.AppendText(basico);
                txtBuilder2.AppendText(intermedio);
                txtBuilder2.AppendText(excedente);
            }

            string pdfName = "Tarifas/Reporte_Tarifas-" + tarifas[0].mes.ToString() + "_" + tarifas[0].año.ToString() +".pdf";
            pdfDocument.Save(pdfName);
        }

        static public void reporte_consumos(List<RepoConsumos> consumos)
        {
            Document pdfDocument = new Document(); //Creacion del documento PDF
            Page page1 = pdfDocument.Pages.Add(); //Generar una nueva pagina y devolver la instancia de dicha pagina

            BackgroundArtifact bg = new BackgroundArtifact();
            bg.BackgroundImage = File.OpenRead("RepConsumos.png");
            page1.Artifacts.Add(bg);

            int pos = 25;
            for (int i = 0; i < consumos.Count; i++)
            {
                TextFragment año = generadorTexto(10, consumos[i].año.ToString(), 60, 600 - (i * pos));
                TextFragment mes = generadorTexto(10, textoMes(consumos[i].mes), 130, 600 - (i * pos));
                TextFragment medidor = generadorTexto(10, consumos[i].medidor.ToString(), 200, 600 - (i * pos));
                TextFragment anterior = generadorTexto(10, consumos[i].anterior.ToString(), 340, 600 - (i * pos));
                TextFragment actual = generadorTexto(10, consumos[i].actual.ToString(), 480, 600 - (i * pos));

                TextBuilder txtBuilder = new TextBuilder(page1);
                txtBuilder.AppendText(año);
                txtBuilder.AppendText(mes);
                txtBuilder.AppendText(medidor);
                txtBuilder.AppendText(anterior);
                txtBuilder.AppendText(actual);
            }

            string pdfName = "Consumos/Reporte_Consumos-" + consumos[0].mes.ToString() + "_" + consumos[0].año.ToString() + ".pdf";
            pdfDocument.Save(pdfName);
        }

        static public void reporte_historico(List<RepoHistorico> historico)
        {
            Document pdfDocument = new Document(); //Creacion del documento PDF
            Page page1 = pdfDocument.Pages.Add(); //Generar una nueva pagina y devolver la instancia de dicha pagina

            BackgroundArtifact bg = new BackgroundArtifact();
            bg.BackgroundImage = File.OpenRead("conHistorico.png");
            page1.Artifacts.Add(bg);

            int pos = 25;
            for (int i = 0; i < historico.Count; i++)
            {
                TextFragment año = generadorTexto(10, historico[i].año.ToString(), 60, 600 - (i * pos));
                TextFragment mes = generadorTexto(10, textoMes(historico[i].mes), 120, 600 - (i * pos));
                TextFragment consumo = generadorTexto(10, historico[i].consumo.ToString(), 180, 600 - (i * pos));
                TextFragment total = generadorTexto(10, historico[i].total_pago.ToString("0.00"), 240, 600 - (i * pos));

                TextBuilder txtBuilder = new TextBuilder(page1);
                txtBuilder.AppendText(año);
                txtBuilder.AppendText(mes);
                txtBuilder.AppendText(consumo);
                txtBuilder.AppendText(total);

                TextFragment pagado = generadorTexto(10, historico[i].cant_pagada.ToString("0.00"), 370, 600 - (i * pos));
                TextFragment pendiente = generadorTexto(10, historico[i].pendiente_pago.ToString("0.00"), 500, 600 - (i * pos));

                TextBuilder txtBuilder2 = new TextBuilder(page1);
                txtBuilder2.AppendText(pagado);
                txtBuilder2.AppendText(pendiente);
            }

            string pdfName = "Historico/Consumo Historico-" + historico[0].mes.ToString() + "_" + historico[0].año.ToString() + ".pdf";
            pdfDocument.Save(pdfName);
        }

        static public void reporte_general(List<RepoGeneral> general)
        {
            Document pdfDocument = new Document(); //Creacion del documento PDF
            Page page1 = pdfDocument.Pages.Add(); //Generar una nueva pagina y devolver la instancia de dicha pagina

            BackgroundArtifact bg = new BackgroundArtifact();
            bg.BackgroundImage = File.OpenRead("RepGeneral.png");
            page1.Artifacts.Add(bg);

            int pos = 25;
            for (int i = 0; i < general.Count; i++)
            {
                TextFragment año = generadorTexto(10, general[i].año.ToString(), 60, 600 - (i * pos));
                TextFragment mes = generadorTexto(10, textoMes(general[i].mes), 120, 600 - (i * pos));
                TextFragment zona = generadorTexto(10, general[i].zona.ToString() + i.ToString(), 180, 600 - (i * pos));
                TextFragment tipo = generadorTexto(10, general[i].tipo.ToString(), 240, 600 - (i * pos));

                TextBuilder txtBuilder = new TextBuilder(page1);
                txtBuilder.AppendText(año);
                txtBuilder.AppendText(mes);
                txtBuilder.AppendText(zona);
                txtBuilder.AppendText(tipo);

                TextFragment pagado = generadorTexto(10, general[i].pagado.ToString(), 410, 600 - (i * pos));
                TextFragment pendiente = generadorTexto(10, general[i].pendiente_pago.ToString(), 500, 600 - (i * pos));

                TextBuilder txtBuilder2 = new TextBuilder(page1);
                txtBuilder2.AppendText(pagado);
                txtBuilder2.AppendText(pendiente);
            }

            string pdfName = "General/Reporte_General-" + general[0].mes.ToString() + "_" + general[0].año.ToString() + "_" + general[0].tipo + ".pdf";
            pdfDocument.Save(pdfName);
        }

        static public void reciboPDF(Recibo recibo, Cliente cliente, Contrato contrato, Lectura lectura_ant, Lectura lectura, Tarifa _tarifa)
        {
            Document pdfDocument = new Document(); //Creacion del documento PDF
            Page page1 = pdfDocument.Pages.Add(); //Generar una nueva pagina y devolver la instancia de dicha pagina

            BackgroundArtifact bg = new BackgroundArtifact();
            bg.BackgroundImage = File.OpenRead("reciboV2.png");
            page1.Artifacts.Add(bg);

            //---------------------------------------------------
            string nombre_completo = cliente.nombre;
            string location = contrato.municipio + ", NUEVO LEON";
            string domicilio = contrato.cod_postal + ", " + contrato.colonia + ", " + contrato.calle + ", " + contrato.num_ext;
            string rfc = cliente.rfc;
            string num_ref = contrato.num_ref.ToString();
            TextFragment txtName = generadorTexto(12, nombre_completo, 100, 705, "negro");
            TextFragment txtLocation = generadorTexto(6, location, 110, 695, "negro");
            TextFragment txtDomicilio = generadorTexto(8, domicilio, 110, 685, "negro");
            TextFragment txtRfc = generadorTexto(12, rfc, 80, 665, "negro");
            TextFragment txtNumRef = generadorTexto(10, num_ref, 140, 645, "negro");

            TextBuilder txtBuilder = new TextBuilder(page1);
            txtBuilder.AppendText(txtName);
            txtBuilder.AppendText(txtLocation);
            txtBuilder.AppendText(txtDomicilio);
            txtBuilder.AppendText(txtRfc);
            txtBuilder.AppendText(txtNumRef);

            ////----------------------------------------------------
            string f_vencimiento = "24 - " + textoMes(recibo.mes);
            string mes_fac = textoMes(recibo.mes);
            string localidad_expedicion = contrato.municipio;
            string tarifa = contrato.tipo +" - CAT: " + contrato.categoria;
            string zona = contrato.zona;
            TextFragment txtFVencimiento = generadorTexto(10, f_vencimiento, 420, 705, "negro");
            TextFragment txtMesFac = generadorTexto(10, mes_fac, 440, 685, "negro");
            TextFragment txtExpedicion = generadorTexto(10, localidad_expedicion, 475, 665, "negro");
            TextFragment txtTarifa = generadorTexto(10, tarifa, 380, 645, "negro");
            TextFragment txtZona = generadorTexto(10, zona, 375, 620, "negro");

            TextBuilder txtBuilder2 = new TextBuilder(page1);
            txtBuilder2.AppendText(txtFVencimiento);
            txtBuilder2.AppendText(txtMesFac);
            txtBuilder2.AppendText(txtExpedicion);
            txtBuilder2.AppendText(txtTarifa);
            txtBuilder2.AppendText(txtZona);

            ////----------------------------------------------------
            TextFragment txtMedidor = generadorTexto(10, contrato.medidor.ToString(), 100, 620);

            TextBuilder txtBuilder4 = new TextBuilder(page1);
            txtBuilder4.AppendText(txtMedidor);

            ////----------------------------------------------------
            TextFragment txtLecturaAnterior;
            TextFragment txtConsumo;
            if (lectura_ant == null)
            {
                txtLecturaAnterior = generadorTexto(10, "0", 155, 535);
                txtConsumo = generadorTexto(10, lectura.consumo.ToString(), 190, 495);
            }
            else
            {
                txtLecturaAnterior = generadorTexto(10, lectura_ant.consumo.ToString(), 155, 535);
                txtConsumo = generadorTexto(10, (lectura.consumo - lectura_ant.consumo).ToString(), 190, 495);
            }
            TextFragment txtLectura = generadorTexto(10, lectura.consumo.ToString(), 145, 515);
            TextFragment txtMeses = generadorTexto(10, recibo.meses_adeudo.ToString(), 450, 535);

            TextBuilder txtBuilder5 = new TextBuilder(page1);
            txtBuilder5.AppendText(txtLecturaAnterior);
            txtBuilder5.AppendText(txtLectura);
            txtBuilder5.AppendText(txtConsumo);
            txtBuilder5.AppendText(txtMeses);

            ////----------------------------------------------------
            TextFragment sub1 = generadorTexto(12, "$ "+recibo.subtotal1.ToString("0.00"), 500, 250, "negro");
            TextFragment sub2 = generadorTexto(12, "$ " + recibo.subtotal2.ToString("0.00"), 500, 225, "negro");
            TextFragment cuota = generadorTexto(12, "$ " + _tarifa.cuota.ToString("0.00"), 500, 200, "negro");
            TextFragment total = generadorTexto(12, "$ " + recibo.subtotal3.ToString("0.00"), 500, 175, "negro");
            TextFragment iva = generadorTexto(12, "$ " + recibo.iva.ToString("0.00"), 500, 150, "negro");

            TextBuilder txtBuilder3 = new TextBuilder(page1);
            txtBuilder3.AppendText(sub1);
            txtBuilder3.AppendText(sub2);
            txtBuilder3.AppendText(cuota);
            txtBuilder3.AppendText(total);
            txtBuilder3.AppendText(iva);

            TextFragment deuda = generadorTexto(12, "$ " + recibo.pendiente_pago.ToString("0.00"), 500, 125, "negro");
            TextFragment totalPagar = generadorTexto(12, "$ "+recibo.total_pago.ToString("0.00"), 500, 100, "negro");
            int temp = (int)recibo.total_pago;
            float centavos = (recibo.total_pago - temp) * 10;
            TextFragment totalLetras = generadorTexto(9, NumeroALetras(recibo.total_pago) + "PESOS CON " + NumeroALetras(centavos) + " CENTAVOS", 200, 75, "negro");

            TextBuilder txtBuilder6 = new TextBuilder(page1);
            txtBuilder6.AppendText(deuda);
            txtBuilder6.AppendText(totalPagar);
            txtBuilder6.AppendText(totalLetras);
            //----------------------------------------------------

            string pdfName = "Recibos/" + "GpiiRecibo-" + cliente.id + "_" + contrato.num_ref + "_" + recibo.mes + "_" + recibo.año +".pdf";
            pdfDocument.Save(pdfName);
        }

        static private TextFragment generadorTexto(int tamañoFuente, string dato, int x, int y)
        {
            TextFragment txtFragment = new TextFragment(dato);
            txtFragment.Position = new Position(x, y);
            txtFragment.TextState.FontSize = tamañoFuente;
            txtFragment.TextState.Font = FontRepository.FindFont("Arial");
            txtFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            return txtFragment;
        }

        static private TextFragment generadorTexto(int tamañoFuente, string dato, int x, int y, string color)
        {
            TextFragment txtFragment = new TextFragment(dato);
            txtFragment.Position = new Position(x, y);
            txtFragment.TextState.FontSize = tamañoFuente;
            txtFragment.TextState.Font = FontRepository.FindFont("Arial");
            if (color == "blanco")
                txtFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.White);
            else if (color == "negro")
                txtFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            return txtFragment;
        }

        static private string textoMes(int mes)
        {
            string texto = "Error";
            switch (mes)
            {
                case 1:
                    texto = "Enero";
                    break;
                case 2:
                    texto = "Febrero";
                    break;
                case 3:
                    texto = "Marzo";
                    break;
                case 4:
                    texto = "Abril";
                    break;
                case 5:
                    texto = "Mayo";
                    break;
                case 6:
                    texto = "Junio";
                    break;
                case 7:
                    texto = "Julio";
                    break;
                case 8:
                    texto = "Agosto";
                    break;
                case 9:
                    texto = "Septiembre";
                    break;
                case 10:
                    texto = "Octubre";
                    break;
                case 11:
                    texto = "Noviembre";
                    break;
                case 12:
                    texto = "Diciembre";
                    break;
            }
            return texto;
        }

        static private string YesNo(bool var)
        {
            if (var)
                return "Si";
            else
                return "No";
        }

        static private string NumeroALetras(double value)
        {
            string num2Text; value = Math.Truncate(value);
            if (value == 0) num2Text = "CERO";
            else if (value == 1) num2Text = "UNO";
            else if (value == 2) num2Text = "DOS";
            else if (value == 3) num2Text = "TRES";
            else if (value == 4) num2Text = "CUATRO";
            else if (value == 5) num2Text = "CINCO";
            else if (value == 6) num2Text = "SEIS";
            else if (value == 7) num2Text = "SIETE";
            else if (value == 8) num2Text = "OCHO";
            else if (value == 9) num2Text = "NUEVE";
            else if (value == 10) num2Text = "DIEZ";
            else if (value == 11) num2Text = "ONCE";
            else if (value == 12) num2Text = "DOCE";
            else if (value == 13) num2Text = "TRECE";
            else if (value == 14) num2Text = "CATORCE";
            else if (value == 15) num2Text = "QUINCE";
            else if (value < 20) num2Text = "DIECI" + NumeroALetras(value - 10);
            else if (value == 20) num2Text = "VEINTE";
            else if (value < 30) num2Text = "VEINTI" + NumeroALetras(value - 20);
            else if (value == 30) num2Text = "TREINTA";
            else if (value == 40) num2Text = "CUARENTA";
            else if (value == 50) num2Text = "CINCUENTA";
            else if (value == 60) num2Text = "SESENTA";
            else if (value == 70) num2Text = "SETENTA";
            else if (value == 80) num2Text = "OCHENTA";
            else if (value == 90) num2Text = "NOVENTA";
            else if (value < 100) num2Text = NumeroALetras(Math.Truncate(value / 10) * 10) + " Y " + NumeroALetras(value % 10);
            else if (value == 100) num2Text = "CIEN";
            else if (value < 200) num2Text = "CIENTO " + NumeroALetras(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) num2Text = NumeroALetras(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) num2Text = "QUINIENTOS";
            else if (value == 700) num2Text = "SETECIENTOS";
            else if (value == 900) num2Text = "NOVECIENTOS";
            else if (value < 1000) num2Text = NumeroALetras(Math.Truncate(value / 100) * 100) + " " + NumeroALetras(value % 100);
            else if (value == 1000) num2Text = "MIL";
            else if (value < 2000) num2Text = "MIL " + NumeroALetras(value % 1000);
            else if (value < 1000000)
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value % 1000);
                }
            }
            else if (value == 1000000)
            {
                num2Text = "UN MILLON";
            }
            else if (value < 2000000)
            {
                num2Text = "UN MILLON " + NumeroALetras(value % 1000000);
            }
            else if (value < 1000000000000)
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000) * 1000000);
                }
            }
            else if (value == 1000000000000) num2Text = "UN BILLON";
            else if (value < 2000000000000) num2Text = "UN BILLON " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
                }
            }
            return num2Text;
        }
    }
}
