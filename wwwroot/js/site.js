function VerDetalleTemporadas(IdS)
    {
        $.ajax({
            url:'/HomeController/VerDetalleTemporadas',
            data:{IdSerie : IdS},
            type:'GET',
            dataType:'json',
            success: function(response)
            {
                //$("ModalTemporadas").html(response.)
            }
        });
        
    }