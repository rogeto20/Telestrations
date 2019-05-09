var Players = {
    Initialize: function () {
        
        Players.InitializePlayersDataTable();
        setTimeout(function () { Players.AutoReload(); }, 2000);
        $(document).on("click", "#register", function () {
            Players.RegisterPlayer();
            $('#form').addClass("hidden");
            $('#start').removeClass("hidden");
        });

    },

    RegisterPlayer: function () {
        var nickName = $("#nick-name").val();
        var gameId = $("#game-id").attr('data-id');
        PlayAPI.RegisterPlayer(nickName, gameId);
        

    },

    InitializePlayersDataTable: function () {
        var gameId = $("#game-id").attr('data-id');
        var user = $("#game-id").attr('data-val');
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
            rowId: "position",
            serverSide: true,
            searching: false,
            pageLength: 10,
            lengthChange: false,
            order: [0, "asc"],
            processing: true,

            columns: [
                { data: "position", sortable: true, searchable: false, name: "position" },
                { data: "name", sortable: true, searchable: false, name: "name" },
                { data: "gameId", sortable: true, searchable: false, name: "gameId", visible:false}
            ]
        });
    },

    RefreshTable: function (tableId, urlData) {
        var table = $("#players").DataTable();
        table.ajax.reload();
    },

    AutoReload: function () {
        Players.RefreshTable();
        setTimeout(function () { Players.AutoReload(); }, 2000);
    }

}
$(document).ready(Players.Initialize());