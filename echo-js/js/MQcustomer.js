var url = "ws://localhost:61614";
var destination = "/topic/test.general";
var username = "admin";
var password = "admin";

$(document).ready(function () {
    if (window.WebSocket) {
        var client = Stomp.client(url);
        
        client.debug = function(str) {
            $("#debug").append(document.createTextNode(str + "\n"));
          };

        client.connect(username, password, function (frame) {
            client.debug("connected to Stomp");
            client.subscribe(destination, function (message) {
                //处理message对象。
                var p = document.createElement("p");
                p.appendChild(document.createTextNode(message.body));
                $("#messages").append(p);
            });
        });
    }
})