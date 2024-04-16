using System;
using System.Drawing.Printing;
using System.Windows.Forms;

public class CrearPDF
{
    private PrintPreviewDialog printPreviewDialog;
    private DataGridView salaryDGV; // Nueva propiedad para almacenar SalaryDGV

    public void ImprimirDesdeNombre(DataGridView SalaryDGV, PrintDocument printDocument)
    {
        if (SalaryDGV.SelectedRows.Count > 0)
        {
            salaryDGV = SalaryDGV; // Asignar SalaryDGV a la propiedad

            printDocument.PrintPage += (sender, args) => Doc_PrintPage(sender, args, SalaryDGV);
            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        else
        {
            MessageBox.Show("No hay ninguna fila seleccionada para imprimir.");
        }
    }

    private void Doc_PrintPage(object sender, PrintPageEventArgs e, DataGridView SalaryDGV)
    {
        if (SalaryDGV.SelectedRows.Count > 0)
        {
            e.Graphics.DrawString("Empresa Carlos Ltd", new Font("Arial", 12, FontStyle.Bold), Brushes.Red, new Point(160, 25));
            e.Graphics.DrawString("Sistema de Planillas de Pago 1.0", new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(125, 45));

            string SalNum = SalaryDGV.SelectedRows[0].Cells[0].Value.ToString();
            string EmpId = SalaryDGV.SelectedRows[0].Cells[1].Value.ToString();
            string EmpName = SalaryDGV.SelectedRows[0].Cells[2].Value.ToString();
            string BasSal = SalaryDGV.SelectedRows[0].Cells[3].Value.ToString();
            string Bonus = SalaryDGV.SelectedRows[0].Cells[4].Value.ToString();
            string Advance = SalaryDGV.SelectedRows[0].Cells[5].Value.ToString();
            string Tax = SalaryDGV.SelectedRows[0].Cells[6].Value.ToString();
            string Balance = SalaryDGV.SelectedRows[0].Cells[7].Value.ToString();
            string Period = SalaryDGV.SelectedRows[0].Cells[8].Value.ToString();

            e.Graphics.DrawString("Numero de Salario: " + SalNum, new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 100));
            e.Graphics.DrawString("Id del empleado: " + EmpId, new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 150));
            e.Graphics.DrawString("Nombre del Empleado: " + EmpName, new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(250, 150));
            e.Graphics.DrawString("Salario base: " + BasSal, new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 180));
            e.Graphics.DrawString("Bono: $ " + Bonus, new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 210));
            e.Graphics.DrawString("Adelanto en salario: $ " + Advance, new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 240));
            e.Graphics.DrawString("Impuesto (IVA+ISSS+Renta) : $ " + Tax, new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 270));
            e.Graphics.DrawString("Total: $ " + Balance, new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 300));
            e.Graphics.DrawString("Periodo: " + Period, new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 330));

            e.Graphics.DrawString("Desarollado por estudiantes de UNICAES" + Period, new Font("Arial", 8, FontStyle.Bold), Brushes.Crimson, new Point(150, 420));
            e.Graphics.DrawString("Version Final" + Period, new Font("Arial", 8, FontStyle.Bold), Brushes.Crimson, new Point(100, 435));
        }
        else
        {
            MessageBox.Show("No hay ninguna fila seleccionada para imprimir.");
        }
    }
}