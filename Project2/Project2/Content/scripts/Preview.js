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

            },
            rowId: "GameId",
            serverSide: true,
            searching: false,
            pageLength: 10,
            lengthChange: false,
            order: [1, "asc"],
            processing: true,

            columns: [
                { data: "ID", sortable: true, searchable: false, name: "ID" },
                { data: "Owner", sortable: true, searchable: false, name: "Owner" },
                { data: "GameName", sortable: true, searchable: false, name: "GameName" },
                { data: "Category", sortable: true, searchable: false, name: "Category" },
                { data: "NumPlayers", sortable: true, searchable: false, name: "NumPlayers" }
            ]
        });
    }
}
$(document).ready(Preview.Initialize());