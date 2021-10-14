﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FoodDA
    {
        //Phương thức lấy hết dữ liệu theo thủ tục Food_GetAll
        public List<Food> GettAll()
        {
            //kKhai báo đối tượng SqlConnection và mở kết nối
            //Đối tượng SqlConnection truyền vào chuỗi kết nối trong App.config
            using (SqlConnection connect = new SqlConnection(Ultilities.ConnectionString))
            {
                connect.Open();

                SqlCommand command = connect.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Ultilities.Food_GetAll;
                //Đọc dữ liệu, trả về danh sách các đối tượng Food
                SqlDataReader reader = command.ExecuteReader();

                List<Food> list = new List<Food>();
                while (reader.Read())
                {
                    Food food = new Food();
                    food.ID = Convert.ToInt32(reader["ID"]);
                    food.Name = reader["Name"].ToString();
                    food.Unit = reader["Unit"].ToString();
                    food.FoodCategoryID = Convert.ToInt32(reader["FoodCategoryID"]);
                    food.Price = Convert.ToInt32(reader["Price"]);
                    food.Notes = reader["Notes"].ToString();

                    list.Add(food);
                }
                connect.Close();    
                return list;
            }
        }
        // Phương thức thêm, xoá, sửa theo thủ tục Food_InsertUpdateDelete

        public int Insert_Update_Delete(Food food, int action)
        {
            //Khai báo đối tượng SqlConnection và mở kết nối
            // Đối tượng SqlConnection truyền vào chuỗi kết nối trong App.config
            using (SqlConnection connect = new SqlConnection(Ultilities.ConnectionString))
            {
                connect.Open();

                SqlCommand command = connect.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Ultilities.Food_InsertUpdateDelete;

                //ID là tham số có giá trị lấy ra khi thêm và truyền vào khi xoá, sửa
                SqlParameter IDpara = new SqlParameter("@ID", SqlDbType.Int);
                IDpara.Direction = ParameterDirection.InputOutput;

                command.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = food.Name;
                command.Parameters.Add("@Unit", SqlDbType.NVarChar).Value = food.Unit;
                command.Parameters.Add("@FoodCategoryID", SqlDbType.Int).Value = food.FoodCategoryID;
                command.Parameters.Add("@Price", SqlDbType.Int).Value = food.Price;
                command.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000).Value = food.Notes;
                command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

                int result = command.ExecuteNonQuery();

                if (result > 0)
                    return (int)command.Parameters["@ID"].Value;
                return 0;
            }
        }
    }
}
