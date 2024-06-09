$(document).ready(function () {
    $('body').on('click', '.ilanbasvuru', function () {
       
        var ID = $(this).attr("data-id");
        $.ajax({
            type: 'POST',
            url: "/User/Basvuru",
            data: { ID: ID },
            success: function (response) {
                alert(response);
            },
            error: function (response) {
            }
        });

    });
});


