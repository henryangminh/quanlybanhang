<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GUI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
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
</asp:Content>
