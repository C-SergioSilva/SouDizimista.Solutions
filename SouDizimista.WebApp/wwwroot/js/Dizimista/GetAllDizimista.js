﻿"use strict";
// Class definition

var DataGetAllDizimista = function () {
    // Private functions

    // basic demo
    var buildTable = function () {

        var datatable = $('#kt_datatable').KTDatatable({
            // datasource definition
            data: {
                type: 'remote',
                source: {
                    read: {
                        url: '/api/ApiDizimista/GetAllDizimista/'
                    }
                },
                pageSize: 10,
                serverPaging: true,
                serverFiltering: true,
                serverSorting: true,
            },

            // layout definition
            layout: {
                scroll: false,
                footer: false,
            },

            // column sorting
            sortable: true,

            pagination: true,

            search: {
                input: $('#kt_datatable_search_query'),
                key: 'generalSearch'
            },

            // columns definition
            columns: [                
                {

                    field: 'nome',
                    title: 'Nome',
                    sortable: 'asc',
                    type: 'text',
                    selector: false,
                    textAlign: 'cwnter',
                },

                {

                    field: 'valorDevolucao',
                    title: 'Valor da DevoluÇão',
                    sortable: 'asc',
                    type: 'text',
                    selector: false,
                    textAlign: 'center',
                },

                {
                    field: 'Actions',
                    title: 'Ações',
                    sortable: false,
                    width: 200,
                    overflow: 'visible',
                    autoHide: false,
                    template: function (item) {
                        return '\
                            <a href="/ClientContract/ReadOnlyClientContract/'+ item.id + '" class="btn btn-sm btn-clean btn-icon mr-2">\
                                <i class="far fa-eye"></i>\
                            </a>\
                            <a href="/ClientContract/EditClientContract/'+ item.id + '" class="btn btn-sm btn-clean btn-icon mr-2 update">\
                                <i class="fas fa-pencil-alt"></i>\
                            </a>\
                             <a data-id="' + item.id + '" class="btn btn-sm btn-clean btn-icon mr-2 btn-deletar-item delete">\
                             <i class="fas fa-trash-alt"></i>\
                            </a>';
                    },


                }
            ],

        });      
        $('#kt_datatable').on('click', '.delete', function () {

            var delet = $(this).data('id');

            Swal.fire({
                title: "Excluir ?",
                text: "Não Será possível reverte esta exclusão !",
                icon: "warning",
                showCancelButton: true,
                confirmButtonText: "Ok",
                cancelButtonText: " Cancelar",
                reverseButtons: true
            }).then(function (result) {
                if (result.value) {

                    $.ajax({
                        method: 'POST',
                        url: '/Api/ApiContractClient/MarkAsDeleted/' + delet,
                    }).done(function (response) {

                        Swal.fire({
                            title: "Concluido!",
                            text: "Dados Deletados !",
                            icon: "success",
                            buttonsStyling: false,
                            confirmButtonText: "Ok!",
                            customClass: {
                                confirmButton: "btn btn-success"
                            }
                        }).then(function () {
                            $('#kt_datatable').KTDatatable('reload');
                        });
                      
                    });
                }

            });

           
        });
    }; 

    return {
        // public functions
        init: function () {
            buildTable();
        },
    };
}()

jQuery(document).ready(function () {
    DataGetAllDizimista.init();
});
