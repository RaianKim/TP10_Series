using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using Dapper;
namespace TP10.Models;

public static class BD
{
    private static string ConnectionString = @"Server=DESKTOP-E3OHN6P\SQLEXPRESS01; DataBase=BDSeries; Trusted_Connection=True";

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
        public static Temporadas  VerDetalleTemporadas(int IdSerie)
    {
        string sql = "Select * From Temporadas Where IdSerie=@pidserie";
        Temporadas temporadas = new Temporadas();
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            temporadas = db.QueryFirstOrDefault<Temporadas>(sql,new{pidserie = IdSerie});
        }
        return temporadas;
    }

}