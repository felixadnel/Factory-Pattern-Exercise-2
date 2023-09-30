﻿using System;

namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
        public static List<Product> Products = new List<Product>()
        {
            new Product (){ Name="Playstation", Price = 500},
            new Product (){ Name="Controller", Price = 10},
            new Product (){ Name="Robot", Price = 5000},
            new Product (){ Name="Ipad", Price = 600},
        };

        public List<Product> LoadData()
        {
            Console.WriteLine("i am reading data from List Data Access.");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("i am saving data from a List Data Access.");
        }
    }
}

