using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai34Adonet
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=Dmkh;User ID=sa; Password = 12345678";
            conn.Open();
            // Adonet là tập hợp các thư viện lớp qua đó cho phép ứng dụng tương tác (lấy về, cập nhật, thêm sửa xóa) với các nguồn dữ liệu.
            var dataadapter = new SqlDataAdapter();
            // Thiết lập select command
            dataadapter.SelectCommand = new SqlCommand("select * from dmkh;", conn);
            // Thiết lập Insercommand để khi adapter chọn phương thức update ta gọi được đến hàm insert.
            dataadapter.InsertCommand = new SqlCommand("insert into dmkh(ma_kh, ten_kh) values (@ma_kh, @ten_kh)", conn);
            dataadapter.InsertCommand.Parameters.Add("@ma_kh", SqlDbType.NVarChar, 25, "ma_kh");
            dataadapter.InsertCommand.Parameters.Add("@ten_kh", SqlDbType.NVarChar, 250, "ten_kh");

            // Thiết lập xóa dòng dữ liệu.
            dataadapter.DeleteCommand = new SqlCommand("Delete from dmkh where ma_kh = @ma_kh ", conn);
            var p1 = dataadapter.DeleteCommand.Parameters.Add(new SqlParameter("@ma_kh", SqlDbType.NVarChar, 25));
            p1.SourceColumn = "ma_kh";
            p1.SourceVersion = DataRowVersion.Original;
            // Thiết lập thuộc tính update
            dataadapter.UpdateCommand = new SqlCommand("update dmkh set ten_kh = @ten_kh where ma_kh = @ma_kh", conn);
            var p2 = dataadapter.UpdateCommand.Parameters.Add(new SqlParameter("@ma_kh", SqlDbType.NVarChar, 25));
            p1.SourceColumn = "ma_kh";
            p1.SourceVersion = DataRowVersion.Original;

            DataSet dataSet = new DataSet();
            dataadapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];

            var row = dataTable.Rows.Add();
            row["ma_kh"] = 10001;
            row["ten_kh"] = "Le Van Tung";


            dataadapter.Update(dataSet);

        }
    }
}
