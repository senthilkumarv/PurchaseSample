using System;
using System.Data;
using System.Data.SqlClient;

namespace PurchaseHelper
{
    public class PurchaseRepository
    {
        private const string ConnectionString = "Data Source=localhost;Initial Catalog=PurchaseSampleDb;Integrated Security=True";
        public Product GetProduct(uint productId)
        {
            var connection = new SqlConnection(ConnectionString);
            var sqlCommand = new SqlCommand("SELECT ProductId, ProductName, Availability, Price, MaxDiscountPercentage FROM Products WHERE ProductID=@ProductId", connection);
            var sqlParameter = new SqlParameter("ProductId", (int)productId);
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
                                  MaxDiscountPercentage = sqlDataReader.GetDecimal(4)
                              };
            connection.Close();
            return product;
        }
        public Customer GetCustomer(uint customerId)
        {
            var connection = new SqlConnection(ConnectionString);
            var sqlCommand = new SqlCommand("SELECT CustomerID, CustomerName, Visits FROM Customers WHERE CustomerID=@CustomerId", connection);
            var sqlParameter = new SqlParameter("CustomerId", (int)customerId);
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
