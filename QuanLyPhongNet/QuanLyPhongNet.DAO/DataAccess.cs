using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongNet.DAO
{
    class DataAccess
    {
        private string strConnect;
        private SqlConnection cnn;

        public DataAccess()
        {
            strConnect = @"Data Source=ROLLER\SQLEXPRESS;Initial Catalog=QuanLyPhongNet;Integrated Security=True";
            //strConnect = QuanLyPhongNet.Common.Properties.Settings.Default.strConnect;
        }

        /// <summary>
        /// Kiem tra ket noi de su dung LINQ.
        /// </summary>
        /// <returns>Tra ve true neu mo ket noi thanh cong, false neu that bai.</returns>
        public bool TestConnection()
        {
            cnn = new SqlConnection(strConnect);
            try
            {
                cnn.Open();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                return false;
            }

            return true;
        }

        /// <summary>
        /// ket noi de su dung ADO.net.
        /// </summary>
        /// <returns>Tra ve doi tuong SqlConnection.</returns>
        public SqlConnection Connect()
        {
            cnn = new SqlConnection(strConnect);
            cnn.Open();

            return cnn;
        }

        /// <summary>
        /// Dong ket noi.
        /// </summary>
        public void DisConnect()
        {
            try
            {
                if (cnn != null)
                    cnn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
                cnn = null;
            }
        }

        public string StrConnect
        {
            get
            {
                return strConnect;
            }

            set
            {
                strConnect = value;
            }
        }
    }
}
