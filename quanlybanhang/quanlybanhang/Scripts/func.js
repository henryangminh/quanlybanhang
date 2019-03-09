function PageLoad() {
    var tempListSelected = [];
    var listSelected = [];
    var TotalPrice = 0;
    registerEvent(tempListSelected, listSelected, TotalPrice);
}

function registerEvent(tempListSelected, listSelected, TotalPrice) {
    $('body').on('change', '#chkSelected', function () {
        if ($(this).is(":checked")) {
            Product = new Object();
            Product.TBId = $(this).val();
            Product.ProductName = $(this).parent('td').parent('tr').find('td:eq(1)').text();
            Product.Price = $(this).parent('td').parent('tr').find('td:eq(3)').text();
            Product.Qty = $(this).parent('td').parent('tr').find('td:eq(4)').text();
            Product.SelectedQty = 1;
            tempListSelected.push(Product);
        }
        else {
            index = tempListSelected.findIndex(x => x.TBId == $(this).val());
            tempListSelected.splice(index, 1);
        }
    })

    $('body').on('click', '#btnSelect', function () {
        var render = '';
        $.each(tempListSelected, function (i, item) {
            listSelected.push(item);
            render += '<tr value="'+ item.TBId +'">' +
                '<td>' + item.ProductName + '</td>' +
                '<td><input type="number" class="form-control" value="1" min="1" id="txtQty"/></td>' +
                '<td value="' + item.Price + '">' + item.Price + '</td>' +
                '<td id="btnDelRow"><a><i class="fa fa-trash"></i></a></td>' +
                '</tr>';
            TotalPrice += parseInt(item.Price);
        })
        $('#tblSelectedProduct').append(render);
        $('#frmProduct').trigger('reset');
        tempListSelected = [];
        $('#lblTotalPrice').text(TotalPrice);
    })

    $('body').on('click', '#btnDelRow', function () {
        var thisObj = $(this);
        var id = thisObj.parent('tr').attr('value');
        thisObj.parent('tr').remove();
        TotalPrice = TotalPrice - parseInt($(this).parent('tr').find('td:eq(2)').text());
        $('#lblTotalPrice').text(TotalPrice);
        index = listSelected.findIndex(x => x.TBId == id);
        listSelected.splice(index, 1);
    })

    $('body').on('change', '#txtQty', function () {
        var thisObj = $(this);
        var qty = thisObj.val();
        var price = thisObj.parent('td').parent('tr').find('td:eq(2)').attr('value');
        var id = thisObj.parent('td').parent('tr').attr('value');
        TotalPrice = TotalPrice - parseInt($(this).parent('td').parent('tr').find('td:eq(2)').text());
        $(this).parent('td').parent('tr').find('td:eq(2)').text(qty * price);
        TotalPrice = TotalPrice + qty * price;
        index = listSelected.findIndex(x => x.TBId == id);
        listSelected[index].SelectedQty = qty;
        $('#lblTotalPrice').text(TotalPrice);
    })

    /*
    $('body').on('click', '#btnLapHoaDon', function () {
        $('#MainContent_tblSlc > tbody').empty();
        render = "";
        render += '<tr>' +
            '<th colspan="4">Các sản phẩm đã chọn</th>' +
            '</tr>' +
            '<tr>' +
            '<th>STT</th><th>Tên sản phẩm</th><th>Số lượng</th><th>Thành tiền</th>' +
            '</tr>';
        $.each(listSelected, function (i, item) {
            render += '<tr>' +
                '<td>' + (i + 1) + '</td>' +
                '<td>' + item.ProductName + '</td>' +
                '<td>' + item.SelectedQty + '</td>' +
                '<td>' + item.SelectedQty * item.Price + '</td>' +
                '</tr>';
        })
        render += '<tr>' +
            '<td colspan="4" value="'+ TotalPrice +'"><h4>Tổng tiền: ' + TotalPrice + '</h4></td>' +
            '</tr>';
        //$('#MainContent_tblSlc > tbody').append(render);
        $(render).appendTo($('#MainContent_tblSlc > tbody'))
    })
    */
    $(document).ready(function () {
        function getSelected() {
            $('#tblSelectedProducts').empty();
            render = "";
            /*
            render += '<tr>' +
                '<th colspan="4">Các sản phẩm đã chọn</th>' +
                '</tr>' +
                '<tr>' +
                '<th>STT</th><th>Tên sản phẩm</th><th>Số lượng</th><th>Thành tiền</th>' +
                '</tr>';
            */
            $.each(listSelected, function (i, item) {
                render += '<tr value="' + item.TBId + '">' +
                    '<td>' + (i + 1) + '</td>' +
                    '<td>' + item.ProductName + '</td>' +
                    '<td>' + item.SelectedQty + '</td>' +
                    '<td>>' + item.SelectedQty * item.Price + '</td>' +
                    '</tr>';
            })
            render += '<tr>' +
                '<td colspan="4" value="' + TotalPrice + '"><h4>Tổng tiền: ' + TotalPrice + '</h4></td>' +
                '</tr>';
            $(render).appendTo($('#tblSelectedProducts'))
        }
        $('#btnLapHoaDon').click(getSelected);
    })
}


PageLoad();