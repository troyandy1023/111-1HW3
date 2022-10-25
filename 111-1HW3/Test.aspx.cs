using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW3
{
    public partial class Test : System.Web.UI.Page
    {
        string[] ve = new string[2] { "蔬菜", "水果" };
        string[,] cc = new string[2, 2] { { "A菜", "空心菜" }, { "番茄", "火龍果" } };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for(int ct = 0; ct < ve.Length; ct++)
                {
                    ListItem ol = new ListItem();
                    ol.Text = ol.Value = ve[ct];
                    ddl_Category.Items.Add(ol);
                }
                mt_GenSecondList();
            }
        }
        protected void mt_GenSecondList()
        {
            int ind = ddl_Category.SelectedIndex;
            ddl_Food.Items.Clear();
            for (int ct = 0; ct < cc.GetLength(1); ct++)
            {
                ListItem ol = new ListItem();
                ol.Text = ol.Value = cc[ind, ct];
                ddl_Food.Items.Add(ol);
            }
        }

        protected void ddl_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            mt_GenSecondList();
        }
    }
}