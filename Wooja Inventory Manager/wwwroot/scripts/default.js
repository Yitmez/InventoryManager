
function addNum() {
    var x = document.getElementById('x').value;
    var y = document.getElementById('y').value;
    var result = document.getElementById('result');

    // The Endpoint URL
    let url = '/addition?x=' + x + '&' + y;
    fetch(url)
        .then(function (response) {
            // Parse the body as JSON
            return response.json();

        })
        .then(function (json) {
            // Use our JSON Object
            result.innerHTML = json.result;
            console.log(json);
        })


}


function giveMeFive() {
    console.log("5");
    //var myVal = $("#xt").data("myValue");
   // console.log(myVal);
    //return myVal;
}