// function getFunction(){
//     var str = "";
//     if(document.getElementById("idGet").value!=null){
//         str = "/"+document.getElementById("idGet").value;
//     }
//     const xmlhttp = new XMLHttpRequest();
//     xmlhttp.onreadystatechange = function() {
//         if( this.readyState==4 && this.status==200){
//             var jsonObj = JSON.parse(this.responseText);
//             //document.getElementById("getArea").innerHTML = this.responseText;
//             console.log(jsonObj);
//             document.querySelector("#responseArea").innerHTML = this.responseText;
//         }
//     }
//     xmlhttp.open("GET", "http://localhost:51716/api/book"+str, true);
//     xmlhttp.send();
// }

