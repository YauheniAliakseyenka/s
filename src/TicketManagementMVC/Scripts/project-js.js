﻿$(document).ready(function () {
    $('.nav-link').click(function () {
        $('#menu ul li .nav-link').removeClass('active');
        $('div .dropdown-menu').removeClass('show');

        $(this).addClass('active');
    });

    $('.profile-left').click(function () {
        $('div .dropdown-menu').removeClass('show');
    });

    //event manager dropdown list
    $('#eventmanager-dropdown').click(function () {
        $('#eventmanager-dropdown-menu').addClass('show');
    });

    //profile dropdown list
    $('#profile-dropdown').click(function () {
        $('div .dropdown-menu').removeClass('show');
        $('#profile-dropdown-menu').addClass('show');
    });

    $('.body-content, .dropdown-item').click(function () {
        $('div .dropdown-menu').removeClass('show');
    });

    $('.dropdown-item').click(function () {
        $('div .dropdown-menu').removeClass('show');
    });

    //closing modal window
    $('#loginModal').on('hidden.bs.modal', function () {
        $('#errorMessages').hide();
        $('#username').val('');
        $('#password').val('');
    })
});

function SetCultureFromFooter() {
    var selectedCulture = $('#footerCulture').val();
    location.href = '/Home/SetCulture?culture=' + selectedCulture;
}


//// login
function SubmitLogin() {
    $('#errorMessagesLogin').hide();
    $.ajax({
        type: "POST",
        url: "/Account/Login",
        data: $('#loginForm').serialize(),
        success: function (result) {
            if (!result.success) {
                $('#errorMessagesLogin').hide();
                var errors = '';
                $.each(result.errors, function (index, value) {
                    errors += value + ' <br />';
                });
                $('#username').val('');
                $('#password').val('');
                $('#errorMessagesLogin').html(errors + ' <br />');
                $('#errorMessagesLogin').show('200');
            }
            else
                location.href = '/Home/Index';
        },
        error: function () {
            ShowNotify('danger', 'server error');
        }
    });
};

function ShowNotify(type, message) {
    $.notify(message, {
        type: type,
        allow_dismiss: true,
        newest_on_top: true,
        placement: {
            from: "bottom",
            align: "left"
        },
        timer: 1000,
        delay: 100,
        template: '<div data-notify="container" class="col-xs-8 col-sm-3 alert alert-{0}" role="alert">' +
            '<button type="button" aria-hidden="true" class="close" data-notify="dismiss">×</button>' +
            '<span data-notify="message">{2}</span></div>'
    });
}

////account
function AddToCart(seatId, object) {
    $.ajax({
        type: 'POST',
        url: '/Account/AddSeatToCart?seatId=' + seatId,
        success: function (result) {
            if (!result.success) {
                ShowNotify('danger', result.error);
            }
            else {
                $(object).addClass('locked-seat');
                $(object).children().addClass('seat-unavailable').addClass('seat-ordered');

                ShowNotify('info', result.message);
            }
        },
        error: function () {
            ShowNotify('danger', 'server error');
        }
    });
}

function DeleteSeatFromCart(seatId, message, culture, object) {
    $.ajax({
        url: '/Account/DeleteFromCart?seatId=' + seatId,
        success: function () {
            let totalBefore;
            let odds
            let totalAfter;
            if (culture == "en") {
                totalBefore = $('#total').text().substring(1).replace(/[^0-9\.-]+/g, "");
                let price = $(object).parent().parent().find('.price').text().substring(1).replace(/[^0-9\.-]+/g, "");
                odds = parseFloat(totalBefore) - parseFloat(price);
                totalAfter = parseFloat(odds).toFixed(2).replace(/(\d)(?=(\d{3})+\.)/g, "$1,").toString();
            }
            else {
                totalBefore = $('#total').text().substring(1).replace(/\s/g, '').replace(/\,/, '.');
                let price = $(object).parent().parent().find('.price').text().substring(1).replace(/\s/g, '').replace(/\,/, '.');
                odds = parseFloat(totalBefore) - parseFloat(price);
                totalAfter = parseFloat(odds).toFixed(2).replace(/(\d)(?=(\d{3})+\.)/g, "$1 ").replace(/\./g, ',');
            }

            $('#orderedList #' + seatId).remove();
            $('#total').text('$' + totalAfter);

            if (odds == 0)
                $('#order-button').hide();

            ShowNotify('info', message);
        },
        error: function () {
            ShowNotify('danger', 'server error');
        }
    });
}

function CompleteOrder(message) {
    $.ajax({
        type: 'POST',
        url: '/Account/Order',
        success: function (result) {
            if (!result.success) {
                ShowNotify('danger', result.error);
            }
            else {
                ShowNotify('info', message);
                $('#order-button').hide();
                $('tbody').remove();
            }
        },
        error: function () {
            ShowNotify('danger', 'server error');
        }
    });
}

function BalanceReplenishment() {
    $.ajax({
        type: "POST",
        url: '/Account/BalanceReplenishment',
        data: $('#balanceReplenishment-form').serialize(),
        success: function (result) {
            if (!result.success) {
                var errors = '';
                $.each(result.errors, function (index, value) {
                    errors += value + ' <br />';
                });
                $('#errorMessagesBalanceReplenishment').html(errors + ' <br />');
            }
            else {
                location.href = "/Home/Index";
            }
        }
    });
}

function UserValidation(key) {
    let url;
    let formId;
    let errorsId;


    switch (key) {
        case 'registration':
            errorsId = '#errorMessagesRegistration';
            url = '/Account/Registration';
            formId = '#registration-form';
            break;
        case 'userProfile':
            errorsId = '#errorMessagesUserProfile';
            url = '/Account/UserProfile';
            formId = '#userProfile-form';
            break;
    }

    $.ajax({
        type: "POST",
        url: url,
        data: $(formId).serialize(),
        success: function (result) {
            if (!result.success) {
                var errors = '';
                $.each(result.errors, function (index, value) {
                    errors += value + ' <br />';
                });
                $(errorsId).html(errors + ' <br />');

                $("input[type='password']").val('');
            }
            else {
                location.href = "/Home/Index";
            }
        }
    });
}

function Refund(orderId, notisfaction, alert) {
    if (confirm(alert)) {
        $.ajax({
            url: '/Account/Refund?orderId=' + orderId,
            success: function () {
                $('#order_' + orderId).remove();
                ShowNotify('info', notisfaction);
            },
            error: function () {
                ShowNotify('danger', 'server error');
            }
        });
    }
}

////filter
function FilterEventsBy(culture) {
    var option = $('#filterList').val();
    if (option.toLowerCase() === "date") {
        $('#filterInput').attr('readonly', true).val('');
        SetDatePickerCulture('#filterInput', culture);
    }
    else if (option.toLowerCase() === "title") {
        $('#filterInput').attr('readonly', false).datepicker('destroy').val('');
    }
    else {
        $('#filterInput').attr('readonly', true).datepicker('destroy').val('');
    }
}

function GetFiltered(filtered) {
    if (filtered == true) {
        $.ajax({
            url: '/Home/Index?isFirstLoad=false',
            data: $('#filterForm').serialize(),
            success: function (result) {
                $('#eventListPlaceholder').html(result);
            }
        });
    }
    else
        $.ajax({
            url: '/Home/Index?isFirstLoad=false',
            success: function (result) {
                $('#filterList').val('None').trigger('change');
                $('#eventListPlaceholder').html(result);
            }
        });
}

function TakePageEvents(object) {
    $.ajax({
        url: '/Home/Index?index=' + $(object).attr("name") +'&isFirstLoad=false',
        data: $('#filterForm').serialize(),
        success: function (result) {
            $('#eventListPlaceholder').html(result);
        }
    });
}




