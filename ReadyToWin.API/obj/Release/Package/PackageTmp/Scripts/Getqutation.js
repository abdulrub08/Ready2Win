$(document).ready(function () {
    var user_id = getUrlVars()["edit"];
    var prod_id = getUrlVars()["prod"];
    var prod_name = getUrlVars()["name"];
    $('#txtproductName').val(prod_name);
    $('#txtemailID').val(user_id);
    $('#btncancel').on('click', function () {
        alert('Canel' + user_id + " - " + prod_id + " - " + prod_name);
    });
    $('#btnsave').on('click', function () {
        alert('Save' + user_id + " - " + prod_id + " - " + prod_name);
        GetUserInfobyID();
    });
});
function GetUserInfobyID(_id) {
    $.ajax({
        type: 'GET',
        url: 'https://api.bigcommerce.com/api/CreateQutation/GetCustomerDetails/' + _id,
        headers: {
            "Content-Type": "application/json",
            "Accept": "application/json"
        },
        success: function (data) {
            debugger
            $('#txtemailID').val(prod_name);
        },
        error: function (eror, tur) {
            debugger
            alert("error")
        },
    });
}

function getUrlVars() {
    var vars = [], hash;
    var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
    for (var i = 0; i < hashes.length; i++) {
        hash = hashes[i].split('=');
        vars.push(hash[0]);
        vars[hash[0]] = hash[1];
    }
    return vars;
}
function validate() {
    //txtproductName
    //txtemailID
}