using System;
using System.Reflection;
using System.Windows.Forms;

namespace SmileHotel.Compoentns
{
    public class ExtendedDataGridView : DataGridView
    {
        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
        {
            if ((this.Rows[e.RowIndex].DataBoundItem != null) &&
                (this.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = this.BindProperty(this.Rows[e.RowIndex].DataBoundItem, this.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        private string BindProperty(object property, string propertyName)
        {
            string retValue = "";

            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;

                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = this.BindProperty(
                            propertyInfo.GetValue(property, null),
                            propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;

                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }

            return retValue;
        }
    }
}