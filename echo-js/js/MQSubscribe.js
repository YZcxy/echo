var url = "ws://localhost:61614";
var destination = "/topic/test.general";
var username = "admin";
var password = "admin";

$(document).ready(function () {
    if (window.WebSocket) {
        //创建连接
        var client = Stomp.client(url);
        //日志输出
        client.debug = function (str) {
            $("#debug").append(document.createTextNode(str + "\n"));
        };
        //连接消息队列
        client.connect(username, password, function (frame) {
            //处理日志
            client.debug("connected to Stomp");
            //订阅主题
            client.subscribe(destination, function (message) {
                //处理message对象。
                message = JSON.parse(message.body);
                var p = document.createElement("p");
                p.appendChild(document.createTextNode(message.ID));
                p.appendChild(document.createTextNode(message.Detail));
                p.appendChild(document.createTextNode(message.Time));
                $("#messages").append(p);
            });
        });
    }
})