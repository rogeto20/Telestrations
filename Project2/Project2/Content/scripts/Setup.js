var Setup = {
    Initialize: function () {
        $(document).on("click", "#create", function () {
            Setup.SaveNewGame();
        });
        
    },

    SaveNewGame: function () {
        var nickName = $("#nick-name").val();
        var name = $("#game-name").val();
        var category = $("#category").val();
        var numPlayers = $("#players").val();
        var owner = $("#game-name").attr('data-name');

        PlayAPI.SaveNewGame(nickName, name, category, numPlayers, owner);

    }
}
$(document).ready(Setup.Initialize());