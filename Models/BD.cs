using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using Dapper;
namespace TP10.Models;

public static class BD
{
    private static string ConnectionString = @"Server=DESKTOP-E3OHN6P\SQLEXPRESS01; DataBase=BDSeries; Trusted_Connection=True";
        public static List<Series> ListarSeries()
    {
        string sql = "Select S.IdSerie,S.Nombre,S.AñoInicio,S.Sinopsis,S.ImagenSerie From Series S";
        List<Series> series = new List<Series>();
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            series = db.Query<Series>(sql).ToList();
        }
        return series;
    }
        public static List<Temporadas>  VerDetalleTemporadas(int IdSerie)
    {
        string sql = "Select * From Temporadas Where IdSerie=@pidserie";
        List<Temporadas> tempo = new List<Temporadas>();
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            tempo = db.Query<Temporadas>(sql,new{pidserie = IdSerie}).ToList();
        }
        return tempo;
    }

        public static Series VerDetalleSinopsis(int IdSerie)
    {
        string sql = "Select * From Series Where IdSerie = @pidserie";
        Series Sinopsis = new Series();
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            Sinopsis = db.QueryFirstOrDefault<Series>(sql, new {pidserie = IdSerie});
        }
        return Sinopsis;
    }

        public static List<Actores> VerDetalleActores(int IdSerie)
    {
        string sql = "Select * From Actores Where IdSerie = @pidserie";
        List<Actores> listactores = new List<Actores>();
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            listactores = db.Query<Actores>(sql, new {pidserie = IdSerie}).ToList();
        }
        return listactores;
    }
}