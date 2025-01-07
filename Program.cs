using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SqlCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sqlden Veri Cekme
            //SqlConnection conn = new SqlConnection("Data Source=EMU2025\\MSSQLSERVER01;initial Catalog= CourseMYakademi;integrated security=true");
            //conn.Open();
            //SqlCommand command = new SqlCommand("Select * From TblCategory",conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //}
            #endregion
            #region Urun Ekleme Insertt Islemi
            //Console.WriteLine("Product Name Add");
            //string productName = Console.ReadLine();

            //Console.WriteLine("Product Price Add");
            //decimal productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=EMU2025\\MSSQLSERVER01;initial Catalog= CourseMYakademi;integrated security=true");
            //connection.Open();
            //   SqlCommand cmd = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)",connection);
            //cmd.Parameters.AddWithValue("@p1",productName);
            //cmd.Parameters.AddWithValue("@p2",productPrice);
            //cmd.Parameters.AddWithValue("@p3",true);
            //cmd.ExecuteNonQuery();
            //connection.Close();
            //Console.Read();
            #endregion
            #region Urun Silme DElete islemi
            //SqlConnection conn = new SqlConnection("Data Source=EMU2025\\MSSQLSERVER01;initial Catalog= CourseMYakademi;integrated security=true");
            //conn.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Select the product id number you want to DELETE! ");
            //int deleteId =int.Parse(Console.ReadLine());
            //SqlCommand deleteCommand = new SqlCommand("Delete From TblProduct where ProductId=@p1Delete", conn);
            //deleteCommand.Parameters.AddWithValue("@p1Delete", deleteId);
            //deleteCommand.ExecuteNonQuery();
            //conn.Close();
            #endregion
            #region Urun Guncelleme Update!
            SqlConnection conn = new SqlConnection("Data Source=EMU2025\\MSSQLSERVER01;initial Catalog= CourseMYakademi;integrated security=true");
            conn.Open();
            SqlCommand command = new SqlCommand("Select * From TblProduct", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Select the product id number you want to Update! ");
            int UpdateId = int.Parse(Console.ReadLine());
            Console.WriteLine("Update Product Name Add");
            string productName = Console.ReadLine();
            Console.WriteLine("Update Product Price Add");
            decimal productPrice = decimal.Parse(Console.ReadLine());
            SqlCommand updateCommand = new SqlCommand("Update TblProduct Set ProductName=@p1Name,ProductPrice=@p2Price where ProductId=@p3Update", conn);
            updateCommand.Parameters.AddWithValue("@p1Name", productName);
            updateCommand.Parameters.AddWithValue("@p2Price", productPrice);
            updateCommand.Parameters.AddWithValue("@p3Update", UpdateId);
            updateCommand.ExecuteNonQuery();

            conn.Close();
            Console.Read();
            #endregion
        }
    }
}
