function PageLoad() {
    registerEvent();
}

function registerEvent() {
    var listSelected = [];
    var TotalPrice = 0;

    $('body').on('change', '#chkSelected', function () {
        if ($(this).is(":checked")) {
            Product = new Object();
            Product.TBId = $(this).val();
            Product.ProductName = $(this).parent('td').parent('tr').find('td:eq(1)').text();
            Product.Price = $(this).parent('td').parent('tr').find('td:eq(3)').text();
            Product.Qty = $(this).parent('td').parent('tr').find('td:eq(4)').text();
            listSelected.push(Product);
        }
    })

    $('body').on('click', '#btnSelect', function () {
        var render = '';
        $.each(listSelected, function (i, item) {
            render += '<tr val="'+ item.TBId +'">' +
                '<td>' + item.ProductName + '</td>' +
                '<td><input type="number" class="form-control" value="1" min="1" id="txtQty"/></td>' +
                '<td value="' + item.Price + '">' + item.Price + '</td>' +
                '<td id="btnDelRow"><a><i class="fa fa-trash"></i></a></td>' +
                '</tr>';
            TotalPrice += parseInt(item.Price);
        })
        $('#tblSelectedProduct').append(render);
        $('#frmProduct').trigger('reset');
        listSelected = [];
        $('#lblTotalPrice').text(TotalPrice);
    })

    $('body').on('click', '#btnDelRow', function () {
        $(this).parent('tr').remove();
        TotalPrice = TotalPrice - parseInt($(this).parent('tr').find('td:eq(2)').text());
        $('#lblTotalPrice').text(TotalPrice);
    })

    $('body').on('change', '#txtQty', function () {
        var qty = $(this).val();
        var price = $(this).parent('td').parent('tr').find('td:eq(2)').attr('value');
        TotalPrice = TotalPrice - parseInt($(this).parent('td').parent('tr').find('td:eq(2)').text());
        $(this).parent('td').parent('tr').find('td:eq(2)').text(qty * price);
        TotalPrice = TotalPrice + qty * price;
        $('#lblTotalPrice').text(TotalPrice);
    })
}

PageLoad();