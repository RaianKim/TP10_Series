function VerDetalleTemporadas(IdS)
{
    $.ajax({
        url:'/Home/VerDetalleTemporadas',
        data:{IdSerie : IdS},
        type:'GET',
        dataType:'JSON',
        success: 
            function(response)
            {
                for (const temporada in response) {
                    $('#idtemporadas').html(temporada.TituloTemporada);
                }
            },
            error : function(xhr, status)
            {
                alert('Disculpe, existio un problema');
            },
            complete : function(xhr,status)
            {
                console.log('Peticion realizada')
            }
        
        });
}

function VerDetalleInfo(IdS)
{
    $.ajax({
        url:'/Home/VerDetalleInfo',
        data:{IdSerie : IdS},
        type:'POST',
        dataType:'JSON',
        success: 
            function(response)
            {
                $('#idmasinfo').html(response.Sinopsis);
            },
            complete : function(xhr,status)
            {
                console.log('Peticion realizada')
            }
        
        });
}

