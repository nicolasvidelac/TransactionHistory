// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

showInPopup = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $("#form-modal .modal-body").html(res);
            $("#form-modal .modal-title").html(title);
            $("form-modal").modal('show');
        }
    })
}

JqueryAjaxPost = form => {
    try {
        $.ajax({
            type: "POST",
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res)
            {
                if (res.isValid) {

                }
                else {

                }
            },
            error: function (err)
            {
                console.log(err)
            }
        })
    } catch (e) {
        console.log(e)
    }

    //to prevent defaul form submit event
    return false;
}