using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Reflection.PortableExecutable;
using despliege.Models;

namespace despliege.Pages
{
    public class CaracteristicasModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public List<Caracteristica> Lista { get; set; }

        public CaracteristicasModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            Lista = new List<Caracteristica>();

            string conexion = _configuration.GetConnectionString("DefaultConnection");

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Caracteristicas", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Lista.Add(new Caracteristica
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString()
                    });
                }
            }
        }
    }
}
