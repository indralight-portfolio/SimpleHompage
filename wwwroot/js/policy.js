var action = 'null';
(function () {
    var $ul = $('.dropdown .ui ul');
    var $li = $('.dropdown .ui ul li');
    var isMobile = navigator.userAgent.match(/Android|Mobile|iP(hone|od|ad)|BlackBerry|IEMobile|Kindle|NetFront|Silk-Accelerated|(hpw|web)OS|Fennec|Minimo|Opera M(obi|ini)|Blazer|Dolfin|Dolphin|Skyfire|Zune/);

    if (!isMobile) {
        $('.dropdown select').addClass('hidden');
    }

    $('.dropdown .active').click(function () {
        if (!isMobile) {
            $ul.removeClass('show');
            $(this).closest('.ui').find('ul').addClass('show');
        }
        return false;
    });
    $li.click(function () {
        $ul.removeClass('show');
        $(this).closest('.ui').find('.active').text($(this).text());
        $(this).closest('.ui').find('select').val($(this).data('value')).trigger('change');
        return false;
    });
    $('.dropdown .policy select').on('change', function () {
        location.href = location.pathname.replace(action, $(this).val());
    });
    $('.dropdown .date select').on('change', function () {
        location.href = location.pathname + '?date=' + $(this).val();
    });
    $(document).click(function () {
        $ul.removeClass('show');
    });

    $('header h1').text(document.title);
})();