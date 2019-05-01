var Preview = {
    Initialize: function () {
        Preview.InitializeGameDataTable();
    },

    InitializeGameDataTable: function () {
        
        var table = $("#table-games").DataTable({
            ajax: {
                url: "../Setup/GetGames",
                type: "POST"
            },
            rowId: "GameId",
            serverSide: true,
            searching: false,
            pageLength: 10,
            lengthChange: false,
            order: [1, "asc"],
            processing: true,

            columns: [
                { data: "GameId", sortable: true, searchable: false, name: "GameId" },
                { data: "Owner", sortable: true, searchable: false, name: "Owner" },
                { data: "Name", sortable: true, searchable: false, name: "Name" },
                { data: "Category", sortable: true, searchable: false, name: "Category" },
                { data: "NumOfPlayers", sortable: true, searchable: false, name: "NumOfPlayers" },
            ]
        });
    }
}
$(document).ready(Preview.Initialize());