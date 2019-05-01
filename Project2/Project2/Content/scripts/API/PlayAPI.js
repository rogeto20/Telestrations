var PlayAPI = {

    //function that contains AJAX calls
    GetPlayers: function (text, callback) {

        $.ajax({
            type: "POST", //http type. Make sure this matches the header above the function in the controller ie: [HttpPost]
            url: "../Example/GetPlayers", /* .. is the controller folder, 
                                            * Example is the name of the controller ie: ExampleController
                                            * GetWords is the name of the function
                                        */
            contentType: "application/json; charset=utf-8", //standard. all data we use is passed in JSON format
            dataType: "json", //same here
            data: JSON.stringify({
                txt: text //txt is the name of the variable that the controller is accepting, text is the name of the parameter passed in from Example.js
            }),
            success: function (data) { //success function. runs on success of the backend call
                typeof callback === "function" && callback(data); //if the callback parameter is a function, send it our response data
            },
            error: function (jqXHR, textStatus, error) { //error function. runs when we get an error code from the backend like 404, 400, etc. 
                console.log("something went wrong!"); //console log an error. usually there is a custom built function in applications to handle errors
                //for now we will just console log it in this example.
            }
        });
    }
}