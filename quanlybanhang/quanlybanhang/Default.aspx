﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="quanlybanhang._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <form id="frmSearch">
        <div class="col-md-12" style="margin-bottom:10px">
            <h1>Xin chào!</h1>
            <div class="form group form-row">
                <div class="col-md-3">
                        <input type="text" id="txtSearch" class="form-control" runat="server" placeholder="Nhập tên Sản phẩm">
                </div>
                <div class="col-md-1">
                    <button type="button" class="btn btn-primary"  id="findTB" style="float:left" onclick="LoadTBByName()"><i class="fa fa-search"></i></button>
                </div>
            </div>
        </div>
    </form>
    <form id="frmProduct">
        <div class="col-sm-5">
            <table class="table table-bordered" id="tblProduct" >
                <thead>
                    <tr>
                        <th></th>
                        <th>Tên thiết bị</th>
                        <th>Loại thiết bị</th>
                        <th>Đơn giá</th>
                        <th>Số lượng tồn</th>
                    </tr>
                </thead>
                <tbody id="tbl_ThietBi" runat="server"></tbody>
            </table>
        </div>
    </form>
    

    <div class="col-sm-2" style="display: flex;justify-content: center;align-items: center;">
        <button type="button" class="btn btn-default" id="btnSelect">Chọn</button>
    </div>

    <div class="col-sm-5">
        
        <table class="table table-bordered" id="tblSelected">
            <thead>
                <tr>
                    <th>Tên thiết bị</th>
                    <th>Số lượng</th>
                    <th>Thành tiền</th>
                    <th></th>
                </tr>
            </thead>
            <tbody id="tblSelectedProduct">

            </tbody>
        </table>
        <div style="display: -webkit-box;">
            <h3>Tổng tiền:</h3> <h3 id="lblTotalPrice"></h3>
        </div>
        <h4>Khách hàng khi mua COMBO 2 sản phẩm khác nhau trở lên sẽ được giảm giá 10%!</h4>
    </div>

    <div class="col-sm-12" style="display: flex;justify-content: center;align-items: center;">
        <button class="btn btn-primary" type="button" data-toggle="modal" data-target="#LapHoaDon" id="btnLapHoaDon">Lập hóa đơn</button>
    </div>
    
    <!--Modal-->
    <form id="formMuahang">
        <div class="modal fade" id="LapHoaDon" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h3>Lập hóa đơn</h3>
                    </div>
                
                    <div class="modal-body">
                        <div class="form-group row" style="display: flex;justify-content: center;align-items: center;">
                            <input type="hidden" id="txtMaKhachHang" value="0" runat="server" />
                            <input type="hidden" id="txtKHContact" value="0" RUNAT="server"/>
                            <div class="col-sm-12" style="display: flex;justify-content: center;align-items: center;">
                                <label for="txtPhoneNumber" class="col-sm-2 col-form-label">Điện thoại: </label>
                                <input type="text" class="form-control" id="txtPhoneNumber" placeholder="Điện thoại" runat="server" onkeydown="return keyispressed(event);">
                                <button type="button" class="btn btn-primary" id="findKH"  onclick="LoadKH()" style="margin-left:10px">Tìm!</button>
                                <button class="btn btn-primary" id="btnAddnewKH" type="button" style="margin-left:10px">Thêm khách hàng mới</button>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-6">
                                <label for="txtAddress">Địa chỉ:</label>
                                <input type="text" id="txtAddress" class="form-control" runat="server" readonly/>
                            </div>
                            <input type="hidden" id="txtCustomerID" class="form-control" value="0" runat="server"/>
                            <div class="col-lg-6">
                                <label for="txtCustomerName">Tên khách hàng:</label>
                                <input type="text" id="txtCustomerName" class="form-control" runat="server" readonly/>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-6">
                                <label for="txtTenKhachGiao">Tên người nhận hàng:</label>
                                <input type="text" id="txtTenKhachGiao" class="form-control" runat="server" placeholder="Để trống sẽ lấy mặc định">
                            </div>
                            <div class="col-lg-6">
                                <label for="txtDiaChi">Địa chỉ nhận hàng:</label>
                                <input type="text" id="txtDiaChi" class="form-control" runat="server" placeholder="Để trống sẽ lấy mặc định">
                            </div>
                            <div class="col-lg-6">
                                <label for="txtContact">Điện thoại người nhận hàng:</label>
                                <input type="text" id="txtContact" class="form-control" runat="server" placeholder="Để trống sẽ lấy mặc định"  onkeydown="return keyispressed(event);">
                            </div>
                        </div>
                        <asp:Panel runat="server" ID="pnlTblSelected">
                            <table id="tblSlc" class="table table-bordered" style="margin-top: 10px;">
                                <thead>
                                    <tr>
                                        <th colspan="4">Các sản phẩm đã chọn
                                        </th>
                                    </tr>
                                    <tr>
                                        <th>STT</th>
                                        <th>Tên sản phẩm</th>
                                        <th>Số lượng</th>
                                        <th>Thành tiền</th>
                                    </tr>
                                </thead>
                                <tbody id="tblSelectedProducts">
                                </tbody>
                                <tfoot>
                                </tfoot>
                            </table>
                        </asp:Panel>
                    </div>
       
                    <div class="modal-footer">
                        <button type="button" class="btn btn-success" id="btnLap" onclick="SaveHoaDon()" runat="server"> Lập Hóa Đơn </button>
  
                        <button type="button" class="btn btn-danger" id="btnDismiss" data-dismiss="modal">Hủy</button>
                    </div>
                </div>
            </div>
        </div>
    </form>
     <!--ModalKH-->
    <div id="modal-add-KH" class="bootbox modal fade modal-darkorange in" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog  modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                
                <h4 class="modal-title">Thêm Khách Hàng</h4>
            </div>
            <div class="modal-body">
                <div id="horizontal-form">
                    <form class="form-horizontal" role="form" id="formKH">
                        <div class="form-group row">
                            <label for="" class="col-sm-2 col-form-label">Họ và tên</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" id="txtAddKHName"  />
                            </div>
                            
                        </div>

                        <div class="form-group row">
                            <label for="" class="col-sm-2 col-form-label">Số điện thoại</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" id="txtAddKHContact"  onkeydown="return keyispressed(event);" />
                            </div>
                            
                        </div>
                        
                        <div class="form-group row">
                            <label for="" class="col-sm-2 col-form-label">Địa chỉ</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" id="txtAddKHAddress"  />
                            </div>
                            
                        </div>
                       
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <button type="button" id="btnSave" onclick="SaveKH()" class="btn btn-success" runat="server">Ghi</button>
                                <button type="button" id="btnCancel" data-dismiss="modal" class="btn btn-danger">Hủy</button>
                            </div>
                        </div>
                    </form>
            </div>
            </div>
        </div>
    </div>
</div>

</asp:Content>
