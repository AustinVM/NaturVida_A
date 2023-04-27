using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaPresentacion.Global
{
    public class Cp_MetodGlobal
    {
        public static void ExportarExcel(DataGridView DgvExportar)  // Metodo para exportar a excel
        {
            Microsoft.Office.Interop.Excel.Application Exportar = new Microsoft.Office.Interop.Excel.Application();
            Exportar.Application.Workbooks.Add(true);
            int indexColumna = 0;
            int indexFila = 0;
            foreach (DataGridViewColumn columna in DgvExportar.Columns)
            {
                indexColumna++;
                Exportar.Cells[1, indexColumna] = columna.Name;
            }
            foreach (DataGridViewRow fila in DgvExportar.Rows)
            {
                indexFila++;
                indexColumna = 0;
                foreach (DataGridViewColumn columna in DgvExportar.Columns)
                {
                    indexColumna++;
                    Exportar.Cells[indexFila + 1, indexColumna] = fila.Cells[columna.Name].Value;
                }
            }
            Exportar.Visible = true;
        }

        private void Exportar_pdf(DataGridView DgvExportar)  // Metodo para exportar a pdff
        {
            FileStream Exportar_pdf = new FileStream(@"C:\Users\Sena CSET\Downloads\Naturvida 4\pdfExportado.pdf", FileMode.Create);
            {
                Document document = new Document(PageSize.A9);
                PdfWriter pdfWriter = PdfWriter.GetInstance(document, Exportar_pdf);
                document.Open();
                PdfPTable pdfTable = new PdfPTable(DgvExportar.Columns.Count);

                foreach (DataGridViewColumn columna in DgvExportar.Columns)
                {
                    PdfPCell celda = new PdfPCell(new Phrase(columna.HeaderText));
                    pdfTable.AddCell(celda);
                }

                if (DgvExportar.Rows.Count > 0)
                {
                    foreach (DataGridViewRow fila in DgvExportar.Rows)
                    {
                        foreach (DataGridViewCell celda in fila.Cells)
                        {
                            pdfTable.AddCell(celda.Value?.ToString() ?? "");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }
                document.Open();
                document.Close();
            }
        }

        public static bool ValidarCorreoElectronico(string correoElectronico)  // Metodo encargado de validar un correo electronico
        {
            if (string.IsNullOrEmpty(correoElectronico))
            {
                return false;
            }

            // Expresión regular para validar el correo electrónico
            string patron = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            Match match = Regex.Match(correoElectronico.Trim(), patron);

            return match.Success;
        }

        public static void validarCampos(Form Formulario, TextBox soloNum)
        {
            bool val = false;
            ErrorProvider error = new ErrorProvider();

            foreach (char c in soloNum.Text)
            {
                if (!char.IsDigit(c))
                {
                    val = true;
                    break;
                }
            }

            if (val)
            {

            }
        }

        public static bool validarCampos(TextBox soloNum)  // Metodo encargado de validar si un textBox enviado contiene solo numeros
        {
            bool val = false;

            foreach (char c in soloNum.Text)
            {
                if (!char.IsDigit(c))
                {
                    val = true;
                    break;
                }
            }

            return val;
        }

        //public static void NoVacio(object NoVacio)
        //{
        //    TextBox _NoVacio = (TextBox)NoVacio;
        //    if (string.IsNullOrEmpty(_NoVacio.Text))
        //    {
        //        error.SetError(_NoVacio, "Los capos no pueden estar vacios.");
        //    }
        //    else
        //    {
        //        error.SetError(_NoVacio, "");
        //    }
        //}
    }
}