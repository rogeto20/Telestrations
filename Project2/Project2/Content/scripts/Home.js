var Home = {
    Initialize: function () {
        $(document).on("click", "#join-game", function () {
            
            
            var text = $("#game-number").val();
           
            if (text == "") {
                console.log("Text box is empty");
            } else {
                Home.checkGame(text);
            }
        });

    },
    checkGame: function (text) {
        window.location.href = '../Home/players/'+text;
    }
}
$(document).ready(Home.Initialize());