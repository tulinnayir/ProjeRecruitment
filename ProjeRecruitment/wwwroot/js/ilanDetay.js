$("body").on("click", ".ilandetay", function () {
   
    var ID = $(this).attr("data-id");
    var url = "/User/GetIlanDetay?ID=" + ID;
    $.post(url, function (data) { })
        .done(function (data) {
            $("#ilanModal1 .modal-body").html("");
            $("#ilanModal1 .modal-body").html(data);
            $("#ilanModal1").modal("show");
        })
        //eğer işlem başarısız olursa
        .fail(function (jqXHR, textStatus, error) {
     
            alert(jqXHR.responseText);
        });

});

