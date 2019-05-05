var Players = {
    Initialize: function () {

        console.log("Got here");
        Players.InitializePlayersDataTable();

    },

    InitializePlayersDataTable: function () {
        var gameId = $("#game-id").attr('data-id');
        console.log(gameId);
        var table = $("#players").DataTable({
            ajax: {
                url: "../../Home/GetPlayers",
                type: "POST",
                dataType: "json",
                data: {
                    GameId: gameId
                },
                dataSrc: ''

            },
            rowId: "gameId",
            serverSide: true,
            searching: false,
            pageLength: 10,
            lengthChange: false,
            order: [1, "asc"],
            processing: true,

            columns: [
                { data: "position", sortable: true, searchable: false, name: "position" },
                { data: "name", sortable: true, searchable: false, name: "name" },
                { data: "gameId", sortable: true, searchable: false, name: "gameId" }
            ]
        });
    }
}
$(document).ready(Players.Initialize());