using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using System.Data;
using QulixTestApp.Logic;

namespace QulixTestApp.Logic
{
    public class GenerateHTML
    {
        public static void Generate(DataTable _dt, Table _t)
        {
            _t.CssClass = "table";

            TableHeaderRow thRow = new TableHeaderRow();
            thRow.CssClass = "th";

            foreach (DataColumn column in _dt.Columns)
            {
                // creating cell
                TableCell newCell = new TableCell();
                newCell.Style.Add("border-style", "solid");
                newCell.Text = column.ColumnName.ToString();

                // adding cells to row
                thRow.Cells.Add(newCell);
            }

            // adding last header cell
            TableCell Cell = new TableCell();
            Cell.Text = "Опции";
            thRow.Cells.Add(Cell);

            _t.Rows.Add(thRow);

            int i = 1;
            foreach (DataRow row in _dt.Rows)
            {
                TableRow newRow = new TableRow();
                foreach (DataColumn column in _dt.Columns)
                {
                    // creating cell
                    TableCell newCell = new TableCell();
                    newCell.Text = row[column.ColumnName].ToString();

                    // adding cells to row
                    newRow.Cells.Add(newCell);
                }

                TableCell btnCell = new TableCell();

                Button btn = new Button();
                btn.CssClass = "btnoption";
                btn.ID = "btn_edit" + i;
                btn.Text = "Изменить";
                //btn.Click += new EventHandler();
                btnCell.Controls.Add(btn);

                btn = new Button();
                btn.CssClass = "btnoption";
                btn.ID = "btn_del" + i;
                btn.Text = "Удалить";
                //btn.Click += new EventHandler(;
                btnCell.Controls.Add(btn);

                newRow.Cells.Add(btnCell);

                _t.Rows.Add(newRow);
                i++;
            }
        }
    }
}