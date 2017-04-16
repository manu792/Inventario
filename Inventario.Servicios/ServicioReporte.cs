using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Commons.Modelos;
using Microsoft.Office.Interop.Excel;

namespace Inventario.Servicios
{
    public class ServicioReporte
    {
        Application xla = null;
        Workbooks workbooks = null;
        Workbook wb = null;
        Sheets worksheets = null;
        Worksheet ws = null;
        Range range = null;
        Font font = null;

        public void GenerarReporte(List<Reporte> reportes)
        {
            int ordenesFila;
            xla = new Application();

            try
            {
                workbooks = xla.Workbooks;
                wb = workbooks.Add();

                worksheets = wb.Sheets;

                foreach (Reporte reporte in reportes)
                {
                    ws = worksheets.Add();
                    ws.Name = reporte.Proyecto.Nombre;

                    range = ws.Range[ws.Cells[1, 1], ws.Cells[1, 8]];
                    range.Merge();

                    range = ws.get_Range("A1", "H1");
                    range.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    ws.Cells[1, 1] = reporte.Proyecto.Nombre;
                    range = ws.get_Range("A1");
                    font = range.Font;
                    font.Bold = true;
                    font.Size = 25;

                    ws.Cells[2, 2] = "Nombre";
                    ws.Cells[2, 3] = "Encargado";
                    ws.Cells[2, 4] = "Direccion";
                    ws.Cells[2, 5] = "Descripcion";
                    ws.Cells[2, 6] = "Fecha Inicio";
                    ws.Cells[2, 7] = "Fecha Fin";
                    range = ws.get_Range("B2", "G2");
                    range.Font.Bold = true;

                    ws.Cells[3, 2] = reporte.Proyecto.Nombre;
                    ws.Cells[3, 3] = reporte.Proyecto.Encargado;
                    ws.Cells[3, 4] = reporte.Proyecto.Direccion;
                    ws.Cells[3, 5] = reporte.Proyecto.Descripcion;
                    ws.Cells[3, 6] = reporte.Proyecto.FechaInicio.ToString();
                    ws.Cells[3, 7] = reporte.Proyecto.FechaFin.ToString();

                    range = ws.Range[ws.Cells[5, 3], ws.Cells[5, 6]];
                    range.Merge();
                    range = ws.get_Range("C5", "G5");
                    range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    ws.Cells[5, 3] = "Articulos en Inventario";
                    range = ws.get_Range("C5", "G5");
                    range.Font.Bold = true;
                    range.Font.Size = 12;

                    ws.Cells[6, 3] = "Nombre";
                    ws.Cells[6, 4] = "Cantidad";
                    ws.Cells[6, 5] = "Total";
                    range = ws.get_Range("C6", "G6");
                    range.Font.Bold = true;
                    int row = 7;
                    foreach (InventarioProyecto inventario in reporte.Inventario)
                    {
                        ws.Cells[row, 3] = inventario.Articulo.Nombre;
                        ws.Cells[row, 4] = inventario.Cantidad;
                        ws.Cells[row, 5] = inventario.Total;

                        row++;
                    }

                    row += 2;
                    ordenesFila = row;
                    ws.Cells[row, 1] = "Ordenes de Entrada";
                    range = ws.get_Range("A" + row, "C" + row);
                    range.Merge();
                    range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    range.Font.Bold = true;
                    range.Font.Size = 12;

                    foreach (Orden ordenEntrada in reporte.OrdenesEntrada)
                    {
                        row++;
                        ws.Cells[row, 1] = "Id Entrada";
                        ws.Cells[row, 2] = "Fecha";
                        ws.Cells[row, 3] = "Comentario";
                        range = ws.get_Range("A" + row, "C" + row);
                        range.Font.Bold = true;

                        row++;
                        ws.Cells[row, 1] = ordenEntrada.Id;
                        ws.Cells[row, 2] = ordenEntrada.Fecha.ToString();
                        ws.Cells[row, 3] = ordenEntrada.Comentario;

                        row++;
                        ws.Cells[row, 1] = "Detalles";
                        range = ws.get_Range("A" + row, "C" + row);
                        range.Merge();
                        range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        range.Font.Bold = true;
                        range.Font.Size = 12;

                        row++;
                        ws.Cells[row, 1] = "Nombre";
                        ws.Cells[row, 2] = "Cantidad";
                        ws.Cells[row, 3] = "Total";
                        range = ws.get_Range("A" + row, "C" + row);
                        range.Font.Bold = true;
                        foreach (Detalle detalle in ordenEntrada.Detalles)
                        {
                            row++;
                            ws.Cells[row, 1] = detalle.Articulo.Nombre;
                            ws.Cells[row, 2] = detalle.Cantidad;
                            ws.Cells[row, 3] = detalle.Total;
                        }
                        row++;
                    }

                    row = ordenesFila;
                    ws.Cells[row, 5] = "Ordenes de Salida";
                    range = ws.get_Range("E" + row, "G" + row);
                    range.Merge();
                    range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    range.Font.Bold = true;
                    range.Font.Size = 12;

                    foreach (Orden ordenSalida in reporte.OrdenesSalida)
                    {
                        row++;
                        ws.Cells[row, 5] = "Id Salida";
                        ws.Cells[row, 6] = "Fecha";
                        ws.Cells[row, 7] = "Comentario";
                        range = ws.get_Range("E" + row, "G" + row);
                        range.Font.Bold = true;

                        row++;
                        ws.Cells[row, 5] = ordenSalida.Id;
                        ws.Cells[row, 6] = ordenSalida.Fecha.ToString();
                        ws.Cells[row, 7] = ordenSalida.Comentario;

                        row++;
                        ws.Cells[row, 5] = "Detalles";
                        range = ws.get_Range("E" + row, "G" + row);
                        range.Merge();
                        range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        range.Font.Bold = true;
                        range.Font.Size = 12;

                        row++;
                        ws.Cells[row, 5] = "Nombre";
                        ws.Cells[row, 6] = "Cantidad";
                        ws.Cells[row, 7] = "Total";
                        range = ws.get_Range("E" + row, "G" + row);
                        range.Font.Bold = true;
                        foreach (Detalle detalle in ordenSalida.Detalles)
                        {
                            row++;
                            ws.Cells[row, 5] = detalle.Articulo.Nombre;
                            ws.Cells[row, 6] = detalle.Cantidad;
                            ws.Cells[row, 7] = detalle.Total;
                        }
                        row++;
                    }
                    ws.Columns.AutoFit();
                }
                xla.Visible = true;
            }
            finally
            {
                ws = null;
                range = null;
                wb = null;
            }
        }
    }
}
