function PageLoad() {
    registerEvent();
}

function registerEvent() {
    var tempListSelected = [];
    var listSelected = [];
    var TotalPrice = 0;
   
    $('body').on('click', '#btnCreateKH', function () {
        $('#LapHoaDon').modal('hide');
        $('#modal-add-editKH').modal('show');
    });
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
    //
    $('body').on('click', '#btnLapHoaDon', function () {
        $('#MainContent_tblSlc > tbody').empty();
        render = "";
        $.each(listSelected, function (i, item) {
            render += '<tr>' +
                '<td>' + (i + 1) + '</td>' +
                '<td>' + item.ProductName + '</td>' +
                '<td>' + item.SelectedQty + '</td>' +
                '<td>' + item.SelectedQty * item.Price + '</td>' +
                '</tr>';
        })
        render += '<tr>' +
            '<td colspan="4"><h4>Tổng tiền: ' + TotalPrice + '</h4></td>' +
            '</tr>';
        $('#MainContent_tblSlc > tbody').append(render);
    })
    //$('#btnLap').on('click', function (e) {
    //    e.preventDefault();
        
    //    var kHId = parseInt($('#txtMaKhachHang').val());
    //    var totalPrice = $('#lblTotalPrice').text(TotalPrice);
    //    $.ajax({
    //        type: 'POST',
    //        url: '/Default.aspx/SaveEntity',
    //        data: {
    //            Id: 0,
    //            KHId: kHId,
    //            TotalPrice: totalPrice
    //        },
    //        dataType: "json",

    //        success: function (response) {

    //            $('#modal-add-edit').modal('hide');
    //            general.notify('Ghi thành công!', 'success');
               
    //        },
    //        error: function (err) {
    //            general.notify('Có lỗi trong khi ghi !', 'error');

    //        },
    //    });




    //});
}

PageLoad();