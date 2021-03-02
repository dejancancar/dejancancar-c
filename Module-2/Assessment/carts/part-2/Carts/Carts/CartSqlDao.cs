using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Carts
{
    public class CartSqlDao : ICartDao
    {
        private readonly string connectionString;

        public CartSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Cart> GetAllCarts()
        {
            // Implement this method to pull in all carts from database
            IList<Cart> carts = new List<Cart>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM carts", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    carts.Add(RowToObject(rdr));
                }    
            }
                return carts;
        }

        public void Save(Cart newCart)
        {
            // Implement this method to save cart to database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO carts (cookie_value, created, username) VALUES (@cookievalue, @created, @username)", conn);
                cmd.Parameters.AddWithValue("@cookievalue", newCart.CookieValue);
                cmd.Parameters.AddWithValue("@created", newCart.Created);
                cmd.Parameters.AddWithValue("@username", newCart.Username);
                cmd.ExecuteNonQuery();

            }
        }

        public Cart RowToObject(SqlDataReader rdr)
        {
            Cart cart = new Cart();
            cart.CookieValue = Convert.ToString(rdr["cookie_value"]);
            cart.Created = Convert.ToDateTime(rdr["created"]);
            cart.Username = Convert.ToString(rdr["username"]);


            return cart;
        }
    }
}