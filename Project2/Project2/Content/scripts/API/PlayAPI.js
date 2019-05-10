var PlayAPI = {

    RegisterPlayer: function (nickName, gameId, callback) {
        console.log(nickName + gameId);
        $.ajax({
            type: "POST",
            url: "../../Home/RegisterPlayer",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify({
                NickName: nickName,
                GameId: gameId
            }),
            success: function (data) {
                typeof callback === "function" && callback(data);
            },
            error: function (jqXHR, textStatus, error) {
                console.log("something went wrong!");
            }
        });
    },


    SaveNewGame: function (nickName, name, category, numPlayers, owner, callback) {
        console.log(name + category + numPlayers + owner);
        $.ajax({
            type: "POST", 
            url: "../Home/SaveNewGame", 
            contentType: "application/json; charset=utf-8",
            dataType: "json", 
            data: JSON.stringify({
                NickName: nickName,
                Name: name,
                Category: category,
                NumPlayers: numPlayers,
                Owner: owner
            }),
            success: function (data) { 
                typeof callback === "function" && callback(data); 
            },
            error: function (jqXHR, textStatus, error) { 
                console.log("something went wrong!"); 
            }
        });
    },
    //function that contains AJAX calls
    GetPlayers: function (text, callback) {

        $.ajax({
            type: "POST", 
            url: "../Example/GetPlayers", 
            contentType: "application/json; charset=utf-8", 
            dataType: "json", 
            data: JSON.stringify({
                txt: text 
            }),
            success: function (data) { 
                typeof callback === "function" && callback(data); 
            },
            error: function (jqXHR, textStatus, error) { 
                console.log("something went wrong!"); 
            }
        });
    }
}