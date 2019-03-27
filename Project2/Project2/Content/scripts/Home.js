var Home = {
    Initialize: function () {
        $(document).on("click", "#join-game", function () {
            console.log("Got here");
            
            var text = $("#game-number").val();
           
            if (text == "") {
                $("#alert").append("Please enter a valid game number to join a game");
            } else {
                Home.checkGame(text);
            }
        });

    },
    checkGame: function (text) {
        $("#test").text(text);
       
    }
}
$(document).ready(Home.Initialize());