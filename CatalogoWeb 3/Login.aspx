<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CatalogoWeb_3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Iniciar Sesion</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"/>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="display-4 text-primary">
                Iniciar Sesion
            </div>
            <div class="form-group mt-4">
                <label class="text-primary">Nombre de Usuario</label>
                <asp:TextBox CssClass="form-control" Columns="90" MaxLength="80" ID="txtUser" runat="server" />
            </div>
            <div class="form-group mt-2">
                <label  class="text-primary">Contraseña</label>
                <asp:TextBox CssClass="form-control d-block" Columns="90" MaxLength="8" TextMode="Password" ID="txtPass" runat="server" />
            </div>
            <div class="display-7 text-danger"  style="width:500px">
                <asp:Label ID="lblCompletar"  Visible="false" Text="Debe Ingresar Usuario y contraseña para ingresar" runat="server" />
            </div>
            <div class="display-7 text-danger"  style="width:500px">
                <asp:Label ID="lblFaltaUser"  Visible="false" Text="Debe Ingresar un Usuario para ingresar" runat="server" />
            </div>
            <div class="display-7 text-danger"  style="width:500px">
                <asp:Label ID="lblFaltaPass"  Visible="false" Text="Debe Ingresar la contraseña para ingresar" runat="server" />
            </div>
            <asp:Button Text="Iniciar" CssClass="btn btn-primary" ID="btnIniciar" runat="server" OnClick="btnIniciar_Click" />
        </div>


    </form>
</body>
</html>