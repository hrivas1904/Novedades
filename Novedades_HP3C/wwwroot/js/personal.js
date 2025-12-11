//carga de datatable
$(document).ready(function () {
    $('#tb_empleados').DataTable({
        "ajax": {
            "url": "/Personal/ListaEmpleados",
            "type": "GET",
            "datatype": "json",
            "dataSrc": "data",
        },
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.13.5/i18n/es-ES.json"
        },
        screenX: true,
        paging: false,
        scrollY: 'var(--tabla-altura)',
        scrollable: true,
        "columns": [
            { "data": "numeroLegajo" },
            { "data": "nombreCompleto" },
            { "data": "dni" },
            { "data": "cuil" },
            { "data": "fechaIngreso" },
            { "data": "antiguedad" },
            { "data": "area" },
            { "data": "categoria" },
            { "data": "servicio" },
            { "data": "regimen" },
            { "data": "horasDiarias" },
            { "data": "convenio" },
            { "data": "telefono" },
            { "data": "estado" },
            {
                "data": "id_emp",
                "render": function (data) {
                    return `<button type="button" class="btn btn-sm btn-warning btn-editar" 
                                data-id="${data}" title="Ver empleado">
                                <i class="fa fa-pencil-alt"></i>
                            </button>`;
                },
                "orderable": false,
                "searchable": false
            }
        ],
        dom: "Bfrtip",
        buttons: [
            {
                extend: "excelHtml5",
                text: "Exportar Excel",
                filename: "Pedidos de reposición",
                title: "",
                exportOptions: { columns: [0, 1, 2, 3, 4, 5] },
                className: "btn-export-excel"
            },
            {
                extend: "pdfHtml5",
                text: "Exportar PDF",
                filename: "Pedidos de reposición",
                title: "Pedidos de reposición",
                pageSize: "A4",
                exportOptions: { columns: [0, 1, 2, 3, 4, 5] },
                className: "btn-export-pdf"
            },
            {
                extend: "print",
                text: "Imprimir",
                title: "Pedidos de reposición",
                exportOptions: { columns: [0, 1, 2, 3, 4, 5] },
                className: "btn-printer"
            }
        ]
    })
});
