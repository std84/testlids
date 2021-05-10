using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lidstest
{
    public partial class Contact : Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

            initData();
        }
        private void initData()
        {
            dt.Clear();
            dt.Columns.Add("Name");
            dt.Columns.Add("amount");
            dt.Columns.Add("sum");
            DataRow _ravi = dt.NewRow();
            _ravi["Name"] = "ravi";
            _ravi["amount"] = "500";
            dt.Rows.Add(_ravi);
            _ravi = dt.NewRow();
            _ravi["Name"] = "eddi";
            _ravi["amount"] = "250";
            dt.Rows.Add(_ravi);
            _ravi = dt.NewRow();
            _ravi["Name"] = "asd";
            _ravi["amount"] = "100";
            dt.Rows.Add(_ravi);
            _ravi = dt.NewRow();
            _ravi["Name"] = "nn";
            _ravi["amount"] = "700";
            dt.Rows.Add(_ravi);
            _ravi = dt.NewRow();
            _ravi["Name"] = "ss";
            _ravi["amount"] = "300";
            dt.Rows.Add(_ravi);
            _ravi = dt.NewRow();
            _ravi["Name"] = "vv";
            _ravi["amount"] = "400";
            dt.Rows.Add(_ravi);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            myGV.DataSource = dt;
            myGV.DataBind();
            
        }
        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
               
           
                e.Row.BackColor = Color.Cyan;
                string str = "";
                str = "aa";
                // e.Row.Cells[2].Text = Decrypt(e.Row.Cells[2].Text);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                sum = sum + int.Parse(dt.Rows[i]["amount"].ToString());
            
            }
            DataRow _ravi = dt.NewRow();
            _ravi["sum"] = sum;
            dt.Rows.Add(_ravi);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        public void CustomersGridView_SelectedIndexChanged(Object sender, EventArgs e)
        {
            // Get the currently selected row using the SelectedRow property.
            GridViewRow row = GridView1.SelectedRow;
            GridView rowtest = (GridView)sender;
            GridViewRow tester = rowtest.SelectedRow;
            // Display the first name from the selected row.
            // In this example, the third column (index 2) contains
            // the first name.
            name.Text= tester.Cells[1].Text;
            amount.Text = tester.Cells[2].Text;
        //    string s =  "You selected " + row.Cells[2].Text + ".";
            string str = "";
            str = "aa";
        }
        protected void myGV_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (Double.Parse(e.Row.Cells[2].Text, System.Globalization.NumberStyles.Currency) >= 10000.00)
                {
                    e.Row.ForeColor = System.Drawing.Color.Red;
                }
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                if (Double.Parse(e.Row.Cells[2].Text) >= 500)
                {
                    e.Row.ForeColor = System.Drawing.Color.Red;
                    e.Row.Cells[1].Text = "expensive";
                }
                e.Row.BackColor = Color.Cyan;
                string str = "";
                str = "aa";
                // e.Row.Cells[2].Text = Decrypt(e.Row.Cells[2].Text);
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string str;
            str = "22";
        }
    }
}