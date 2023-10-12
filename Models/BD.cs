using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using Dapper;
namespace TP10.Models;

public static class BD
{
    private static string ConnectionString = @"Server=localhost; DataBase=BDSeries; Trusted_Connection=True";

    public static List<Actores> ListarActores()
    {
        string sql = "Select * From Actores";
        List<Actores> actores = new List<Actores>();
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            actores = db.Query<Actores>(sql).ToList();
        }
        return actores;
    }
        public static List<Series> ListarSeries()
    {
        string sql = "Select * From Series";
        List<Series> series = new List<Series>();
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            series = db.Query<Series>(sql).ToList();
        }
        return series;
    }
        public static List<Temporadas>  ListarTemporadas()
    {
        string sql = "Select * From Temporadas";
        List<Temporadas> temporadas = new List<Temporadas>();
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            temporadas = db.Query<Temporadas>(sql).ToList();
        }
        return temporadas;
    }

}