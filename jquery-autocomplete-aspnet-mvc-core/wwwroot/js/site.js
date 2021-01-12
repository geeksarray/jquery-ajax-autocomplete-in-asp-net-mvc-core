$(document).ready(function () {
    $("#vendorName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: '/api/vendor/search',
                headers: { "RequestVerificationToken": $('input[name="__RequestVerificationToken"]').val() },
                data: { "term": request.term },                
                dataType: "json",
                success: function (data) {
                    response($.map(data, function (item) {
                        return item;
                    }))
                },
                error: function (xhr, textStatus, error) {
                    alert(xhr.statusText);
                    alert(textStatus);
                    alert(error);
                },
                failure: function (response) {
                    alert("failure " + response.responseText);
                }
            });
        },
        select: function (e, i) {
            $("#lblVendorName").text(i.item.value);
        },
        minLength: 3
    });
});
