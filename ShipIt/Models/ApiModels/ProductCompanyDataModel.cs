﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Npgsql;
using ShipIt.Models.ApiModels;

namespace ShipIt.Models.ApiModels
{
    // public class DatabaseColumnName : Attribute
    // {
    //     public string Name { get; set; }

    //     public DatabaseColumnName(string name)
    //     {
    //         Name = name;
    //     }
    // }


    // public abstract class DataModel
    // {
    //     protected DataModel()
    //     {
    //     }

    //     public DataModel(IDataReader dataReader)
    //     {
    //         var type = GetType();
    //         var properties = type.GetProperties();

    //         foreach (var property in properties)
    //         {
    //             var attribute = (DatabaseColumnName)property.GetCustomAttributes(typeof(DatabaseColumnName), false).First();
    //             property.SetValue(this, dataReader[attribute.Name], null);
    //         }
    //     }

    //     public IEnumerable<NpgsqlParameter> GetNpgsqlParameters()
    //     {
    //         var type = GetType();
    //         var properties = type.GetProperties();
    //         var parameters = new List<NpgsqlParameter>();

    //         foreach (var property in properties)
    //         {
    //             var attribute = (DatabaseColumnName)property.GetCustomAttributes(typeof(DatabaseColumnName), false).First();
    //             parameters.Add(new NpgsqlParameter("@" + attribute.Name,property.GetValue(this, null)));
    //         }

    //         return parameters;
    //     }
    // }

    public class ProductCompanyDataModel
    {
        public int Id { get; set; }
        public string Gtin { get; set; }
        public string Gcp { get; set; }
        public string ProductName { get; set; }
        public double Weight { get; set; }
        public int LowerThreshold { get; set; }
        public int Discontinued { get; set; }
        public int MinimumOrderQuantity { get; set; }
        public string CompanyName { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string Addr4 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }

        public ProductCompanyDataModel(IDataReader dataReader) : base(dataReader)
        { }

        public ProductCompanyDataModel()
        { }

        public ProductCompanyDataModel(ProductCompanyDataModel apiModel)
        {
            Id = apiModel.Id;
            Gtin = apiModel.Gtin;
            Gcp = apiModel.Gcp;
            ProductName = apiModel.ProductName;
            Weight = apiModel.Weight;
            LowerThreshold = apiModel.LowerThreshold;
            Discontinued = apiModel.Discontinued;
            MinimumOrderQuantity = apiModel.MinimumOrderQuantity;
            CompanyName = apiModel.CompanyName;
            Addr2 = apiModel.Addr2;
            Addr3 = apiModel.Addr3;
            Addr4 = apiModel.Addr4;
            PostalCode = apiModel.PostalCode;
            City = apiModel.City;
            Tel = apiModel.Tel;
            Mail = apiModel.Mail;

        }
    }

}