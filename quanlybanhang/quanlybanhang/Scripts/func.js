function PageLoad() {
    registerEvent();
}

function registerEvent() {
    var listSelected = [];

    $('body').on('change', '#chkSelected', function () {
        if ($(this).is(":checked")) {
            listSelected.push($(this).val());
        }
    })
}

PageLoad();