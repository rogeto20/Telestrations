var Preview = {
    Initialize: function () {
        Preview.InitializeGameDataTable();
        
    },

    InitializeGameDataTable: function () {
        var owner = $("#games").attr('data-user');
        console.log(owner);
        var table = $("#table-games").DataTable({
            ajax: {
                url: "../Home/GetGames",
                type: "POST",
                dataType: "json",
                data: JSON.stringify({
                    Owner: owner
                }),
                dataSrc: ''

            },
            rowId: "ID",
            serverSide: true,
            searching: false,
            pageLength: 10,
            lengthChange: false,
            order: [1, "asc"],
            processing: true,

            columns: [
                { data: "ID", sortable: true, searchable: false, name: "ID" },
                { data: "owner", sortable: true, searchable: false, name: "owner" , visible: false},
                { data: "name", sortable: true, searchable: false, name: "name" },
                { data: "category", sortable: true, searchable: false, name: "category" },
                { data: "numPlayers", sortable: true, searchable: false, name: "numPlayers" }
            ]
        });
    }
}
$(document).ready(Preview.Initialize());