﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Food
    {
        private int iD;
        private string name;
        private int idCategory;
        private float price;

        public Food(int id, string name, int idcategory, float price)
        {
            this.iD = id;
            this.name = name;
            this.idCategory = idcategory;
            this.price = price;
        }
        public Food(DataRow row)
        {
            this.iD = (int)row["id"];
            this.name = row["name"].ToString();
            this.idCategory = (int)row["idcategory"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public float Price { get => price; set => price = value; }
    }
}
