function VerDetalleTemporadas(IdS,Nom)
{
    $.ajax({
        url:'/Home/VerDetalleTemporadas',
        data:{IdSerie : IdS},
        type:'GET',
        dataType:'JSON',
        success: 
        function(response)
            {
                $("#idtitulo").html("Titulos de la temporada de la serie de " + Nom);
                $("#idmasinfo").html("");
                $("#idactores").html("");
                let temporadaHTML = '';
                for (const temporada of response) {
                  temporadaHTML += `<p>${temporada.tituloTemporada}</p>`;
                }
                // Agrega el string HTML al contenedor.
                $("#idtemporadas").html(temporadaHTML);
                
              },
            complete : function(xhr,status)
            {
                console.log('Peticion realizada')
            }
        
        });
}
//Recomendado usar for of cuando hay objetos dentro de una lista
//const listaDeObjetos = [
//    { nombre: 'Objeto 1', valor: 10 },
//   { nombre: 'Objeto 2', valor: 20 },
//    { nombre: 'Objeto 3', valor: 30 }
//  ];
  
//  for (const objeto of listaDeObjetos) {
//    console.log(objeto.nombre, objeto.valor);
//  }
function VerDetalleSinopsis(idserie)
{
    $.ajax({
        url:'/Home/VerDetalleSinopsis',
        data:{IdSerie : idserie},
        type:'GET',
        dataType:'JSON',
        success: function(response)
            {
                let temporadaHTML = '';
                temporadaHTML += `<img class="imgTempo" src="${response.imagenSerie}">`;
                temporadaHTML += `<p>Nombre de la serie : ${response.nombre}</p>`;
                temporadaHTML += `<p>Año de inicio : ${response.añoInicio}</p>`;
                temporadaHTML += `<p>Resumen: ${response.sinopsis}</p>`;
                $("#idtitulo").html("Detalle de la serie de " + response.nombre);
                $("#idtemporadas").html("");
                $("#idactores").html("");
                $("#idmasinfo").html(temporadaHTML);
            },
            complete : function(xhr,status)
            {
                console.log('Peticion realizada');
            }
        
        });
}

function VerDetalleActores(idserie,Nom)
{
    $.ajax({
        url:'/Home/VerDetalleActores',
        data:{IdSerie : idserie},
        type:'GET',
        dataType:'JSON',
        success: function(response)
            {
                $("#idtitulo").html("Nombre de los actores de la serie de " + Nom);
                $("#idtemporadas").html("");
                $("#idmasinfo").html("");
                let actoresHTML = '';
                for (const actores of response) {
                    actoresHTML += `<p>${actores.nombre}</p>`;
                }
                // Agrega el string HTML al contenedor.
                $("#idactores").html(actoresHTML);
                
            },
            complete : function(xhr,status)
            {
                console.log('Peticion realizada');
            }
        
        });
}

