using System;
using System.Data;
using System.Data.SqlClient;

namespace PurchaseHelper
{
    public class PurchaseRepository
    {
        public Product GetProduct(uint productId)
        {
            var connection = new SqlConnection("");
            var sqlCommand = new SqlCommand("SELECT ProductId, " +
                                                "ProductName, " +
                                                "Availability, " +
                                                "Price, " +
                                                "MaxDiscountPercentage " +
                                            "FROM " +
                                                "PRODUCTS " +
                                            "WHERE " +
                                            "   ProductID=@ProductId");
            var sqlParameter = new SqlParameter("ProductId", productId);
            sqlCommand.Parameters.Add(sqlParameter);
            
            connection.Open();
            var sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);

            if(!sqlDataReader.Read()) throw new ProductNotFoundException();
            var product = new Product
                              {
                                  ProductId =  sqlDataReader.GetInt32(0),
                                  ProductName = sqlDataReader.GetString(1),
                                  Availability = sqlDataReader.GetInt32(2),
                                  Price = sqlDataReader.GetDecimal(3),
                                  MaxDiscountPercentage = sqlDataReader.GetInt32(4)
                              };
            connection.Close();
            return product;
        }
        public Customer GetCustomer(uint customerId)
        {
            var connection = new SqlConnection("");
            var sqlCommand = new SqlCommand("SELECT CustomerID, " +
                                                "CustomerName, " +
                                                "Visits" +
                                            "FROM " +
                                                "CUSTOMERS " +
                                            "WHERE " +
                                                "CUSTOMERID=@CustomerId");
            var sqlParameter = new SqlParameter("CustomerId", customerId);
            sqlCommand.Parameters.Add(sqlParameter);
            
            connection.Open();
            var sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);

            if(!sqlDataReader.Read()) throw new CustomerNotFoundException();
            var customer = new Customer()
                              {
                                  CustomerId =  sqlDataReader.GetInt32(0),
                                  CustomerName = sqlDataReader.GetString(1),
                                  Visits = sqlDataReader.GetInt32(2)
                              };
            connection.Close();
            return customer;
        }

        public bool IsValidCustomer(uint customerId)
        {
            try
            {
                GetCustomer(customerId);
                return true;
            }
            catch (CustomerNotFoundException)
            {
                return false;
            }
        }

        public bool IsValidProduct(uint productId)
        {
            try
            {
                GetProduct(productId);
                return true;
            }
            catch (ProductNotFoundException)
            {
                return false;
            }
        }
    }
}
