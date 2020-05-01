$(document).ready(function () {

    $('.mainPageTabs').on('click',(function () {
        var itText = $(this).attr('id');

        $('.mainPageTabs').removeClass('active');
        $('#' + itText).toggleClass('active');

        $('.mainDivs').css('display', 'none');
        var mainDivIdText = itText.replace('li', 'div');
        $('#' + mainDivIdText).css('display', 'block');

        var url = itText.replace('li', '');
        //ajax calls
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            type: 'get',
            url: '/Admin/' + url,
            ajax:true,
            success: function (data) {
                $('#MainDiv').html(data);
            },
            failure: function (response) {
                $('#MainDiv').html(response);
            },
            error: function (response) {
                alert(response);
            }
        });

    }));
});

function setMainDivActice(idText) {
    alert(idText);
}

function ShowSuccess(response) {
    alert(response.Message);
}

function ShowFailure() {
    alert('Failed');
}
function callAlert() {
    
}