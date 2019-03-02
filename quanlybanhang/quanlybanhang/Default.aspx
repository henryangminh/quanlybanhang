<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="quanlybanhang._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <form>
        <div class="form-row">
            <div class="form-group col-md-6">
                <label for="inputEmail4">Tìm theo tên</label>
                <input type="email" class="form-control" >
            </div>
            <div class="form-group col-md-6">
                <label for="inputPassword4">Tìm theo loại</label>
                <select id="inputState" class="form-control">
                    <option selected>Choose...</option>
                    <option>...</option>
                </select>
            </div>
        </div>        
    </form>


    <div class="col-sm-5">
        <table class="table table-bordered">
            <thead>
                <tr>
                    <th></th>
                    <th>Tên thiết bị</th>
                    <th>Đơn giá</th>
                    <th>Số lượng tồn</th>
                </tr>
            </thead>
        </table>
    </div>

    <div class="col-sm-2" style="display: flex;justify-content: center;align-items: center;">
        <button type="button" class="btn btn-default">Chọn</button>
    </div>

    <div class="col-sm-5">
        <table class="table table-bordered">
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
        <button class="btn btn-primary">Lập hóa đơn</button>
    </div>

</asp:Content>
