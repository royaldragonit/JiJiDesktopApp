using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
namespace Ji.Core
{
    public static class GridcontrolDevexpress
    {
        public static void Filter(this GridControl grid, string colName, string criteria, string query_add)
        {
            GridView view = grid.MainView as GridView;
            string query = "";

            criteria = criteria.Trim().ToLower();

            foreach (var item in criteria.Split(' '))
            {
                string subquery = "";

                if (item.Length == 0) continue;

                foreach (GridColumn col in view.Columns)
                {
                    if (col.FieldName == colName)
                    {
                        if (col.FieldName.Length == 0) continue;

                        if (subquery.Length > 0)
                            subquery += " OR ";

                        subquery += String.Format("[{0}] LIKE '%{1}%'", col.FieldName, EscapeLikeValue(item));
                    }
                }

                if (subquery.Length > 0)
                {
                    if (query.Length > 0)
                        query += " AND ";

                    query += String.Format("({0})", subquery);
                }
            }

            if (query_add.Length > 0 && query.Length > 0)
            {
                query += String.Format(" OR ({0})", query_add);
            }

            view.ActiveFilterString = query;
        }

        private static string EscapeLikeValue(string valueWithoutWildcards)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < valueWithoutWildcards.Length; i++)
            {
                char c = valueWithoutWildcards[i];
                if (c == '*' || c == '%' || c == '[' || c == ']')
                    sb.Append("[").Append(c).Append("]");
                else if (c == '\'')
                    sb.Append("''");
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }
        public static void Filter(this GridControl grid, string criteria)
        {
            GridView view = grid.MainView as GridView;

            var columnNames = view.Columns
                .Cast<GridColumn>()
                .Select(c => c.FieldName)
                .ToList();

            FilterGrid(grid, columnNames, criteria, string.Empty);
        }
        public static void FilterGrid(this GridControl grid, System.Collections.Generic.List<string> columnNames, string criteria, string query_add)
        {
            GridView view = grid.MainView as GridView;
            string query = "";

            criteria = criteria.Trim().ToLower();
            if (!string.IsNullOrEmpty(criteria))
            {
                foreach (var item in criteria.Split(' '))
                {
                    string subquery = "";

                    if (item.Length == 0) continue;

                    foreach (GridColumn col in view.Columns) // foreach (GridColumn col in view.VisibleColumns)
                    {
                        if (col.FieldName.Length == 0) continue;
                        if (columnNames.Contains(col.FieldName) == false) continue;

                        if (subquery.Length > 0)
                            subquery += " OR ";

                        subquery += String.Format("[{0}] LIKE '%{1}%'", col.FieldName, EscapeLikeValue(item));
                    }

                    if (subquery.Length > 0)
                    {
                        if (query.Length > 0)
                            query += " AND ";

                        query += String.Format("({0})", subquery);
                    }
                }
            }

            if (query_add.Length > 0 && query.Length > 0)
            {
                query += String.Format(" OR ({0})", query_add);
            }

            view.ActiveFilterString = query;
        }
    }
}
