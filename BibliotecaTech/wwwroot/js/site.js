
/*Tabela das editoras*/
$(document).ready(function () {
    $('#tabela-editoras').DataTable({
        language: {
            "decimal": "",
            "emptyTable": "Nenhum dado disponível.",
            "info": "Mostrando _START_ para _END_ de _TOTAL_ resultados",
            "infoEmpty": "Mostrando 0 para 0 de 0 resultados",
            "infoFiltered": "(filtrado de _MAX_ resultados totais)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ resultados",
            "loadingRecords": "Carregando...",
            "processing": "",
            "search": "Buscar:",
            "zeroRecords": "Não foram encontrados resultados correspondentes",
            "paginate": {
                "first": "Primeira",
                "last": "Última",
                "next": "Próxima",
                "previous": "Anterior"
            },
            "aria": {
                "orderable": "Ordene por essa coluna",
                "orderableReverse": "Ordem inversa por essa coluna"
            }
        }
    });

    /* para sumir os alerta */
    setTimeout(function () {
        $(".alert").fadeOut("slow", function () {
            $(this).alert('close');
        })
    }, 5000)

});
