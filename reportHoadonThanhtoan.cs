using QLPH.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPH
{
    public partial class reportHoadonThanhtoan : Form
    {

        private string constr = ConfigurationManager.ConnectionStrings["QLPH"].ConnectionString;
        public static int hoadonID = 0;

        public reportHoadonThanhtoan()
        {
            InitializeComponent();

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("spHoadonThanhtoan", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hoadonID", hoadonID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                rpHoadonThanhtoan rp = new rpHoadonThanhtoan();
                rp.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rp;
            }
        }
    }
}
