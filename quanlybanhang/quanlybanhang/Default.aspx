<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="quanlybanhang._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <form id="frmSearch">
        <div class="form-row">
            <div class="form-group col-md-6">
                <label for="txtSearch">Tìm theo tên</label>
                <input type="text" id="txtSearch" class="form-control" runat="server">
            </div>
            <div class="form-group col-md-6">
                <label for="slcType">Tìm theo loại</label>
                <select id="slcType" class="form-control">
                    <option selected>Choose...</option>
                    <option>...</option>
                </select>
            </div>
        </div>        
    </form>


    <div class="col-sm-5">
        <table class="table table-bordered" id="tblProduct">
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

    <div class="col-sm-2" style="display: flex;justify-content: center;align-items: center;">
        <button type="button" class="btn btn-default" id="btnSelect">Chọn</button>
    </div>

    <div class="col-sm-5">
        <table class="table table-bordered" id="tblSelected">
            <thead>
                <tr>
                    <th>Tên thiết bị</th>
                    <th>Số lượng</th>
                    <th></th>
                </tr>
            </thead>
        </table>
    </div>

    <div class="col-sm-12" style="display: flex;justify-content: center;align-items: center;">
        <button class="btn btn-primary" type="button" data-toggle="modal" data-target="#LapHoaDon">Lập hóa đơn</button>
    </div>

    <!--Modal-->
    <form id="frmLapHoaDon">
        <!--<asp:TextBox ID="TextBox1" runat="server" Width="757px"></asp:TextBox>-->
        <div class="modal fade" id="LapHoaDon" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5>Lập hóa đơn</h5>
                    </div>
                    <div class="modal-body">
                        <div class="form-group row" style="display: flex;justify-content: center;align-items: center;">
                            <label for="txtCustomerID" class="col-sm-2 col-form-label">Mã Khách Hàng</label>
                            <div class="col-sm-5">
                                <input type="text" class="form-control" id="txtCustomerID" placeholder="Mã Khách Hàng">
                            </div>
                            <button class="btn btn-primary" type="button">Thêm khách hàng mới</button>
                        </div>
                        <p>Địa chỉ: </p>
                        <p>Điện thoại: </p>

                        <div class="row">
                            <div class="col-lg-6">
                                <label for="txtSearch">Tên người nhận hàng:</label>
                                <input type="text" id="txtTenKhachGiao" class="form-control">
                            </div>
                            <div class="col-lg-6">
                                <label for="txtSearch">Địa chỉ nhận hàng:</label>
                                <input type="text" id="txtDiaChi" class="form-control">
                            </div>
                            <div class="col-lg-6">
                                <label for="txtSearch">Điện thoại người nhận hàng:</label>
                                <input type="text" id="txtContact" class="form-control">
                            </div>
                        </div>
                    </div>

                    <div class="modal-footer">
                        <button type="button" class="btn btn-success" id="btnLap">Lập Hóa Đơn</button>
                        <button type="button" class="btn btn-danger" id="btnDismiss" data-dismiss="modal">Hủy</button>
                    </div>
                </div>
            </div>
        </div>
    </form>

</asp:Content>
