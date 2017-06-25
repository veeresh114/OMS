$(document).ready(function () {

});

$("#AreBothAddressSame").click(function () {
    debugger;
    var selection = $(this).val();
    alert(selection);
    if (selection == "YES") {
        var pAddress = $("#PermanentAddress").val()
        $("#ShippingAddress").val(pAddress);
    }
    else {
        $("#ShippingAddress").val("");
    }
});