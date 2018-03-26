<%@ Page Language="C#" MasterPageFile="~/index.master" AutoEventWireup="true" CodeFile="EscogerAsiento.aspx.cs" Inherits="EscogerAsiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="main-content">
		<div class="page-content">
            <div class="container seats">
                <div class="row">
					<div class="col-xs-10">
						<table id="simple-table" class="table table-hover seats border">
                            <thead>
                                <tr>
                                    <th class="center">  
                                        <asp:Label ID="lblNombreGraderia" runat="server">OESTE</asp:Label>
                                    </th>
                                    <th class="center"> A </th>
                                    <th class="center"> B </th>
                                    <th class="center"> C </th>
                                    <th class="center"> D </th>
                                    <th class="center"> E </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <th class="center">1</th>
                                    <td class="center">
                                        <asp:Button ID="btnA1" class="btn btn-success" Onclick="btnA1_Click" runat="server"/>
                                    </td>
                                    <td class="center">
                                        <asp:Button ID="btnA2" class="btn btn-success" Onclick="btnA2_Click" runat="server"/>
                                    </td>
                                    <td class="center">
                                        <asp:Button ID="btnA3" class="btn btn-success" Onclick="btnA3_Click" runat="server"/>
                                    </td>
                                    <td class="center">
                                        <asp:Button ID="btnA4" class="btn btn-success" Onclick="btnA4_Click" runat="server"/>
                                    </td>
                                    <td class="center">
                                        <asp:Button ID="btnA5" class="btn btn-success" Onclick="btnA5_Click" runat="server"/>
                                    </td>
                                </tr>
                                <tr>
                                    <th class="center">2</th>
                                   <td class="center">
                                        <asp:Button ID="btnB1" class="btn btn-success" Onclick="btnB1_Click" runat="server"/>
                                    </td>
                                    <td class="center">
                                        <asp:Button ID="btnB2" class="btn btn-success" Onclick="btnB2_Click" runat="server"/>
                                    </td>
                                    <td class="center">
                                        <asp:Button ID="btnB3" class="btn btn-success" Onclick="btnB3_Click" runat="server"/>
                                    </td>
                                    <td class="center">
                                        <asp:Button ID="btnB4" class="btn btn-success" Onclick="btnB4_Click" runat="server"/>
                                    </td>
                                    <td class="center">
                                        <asp:Button ID="btnB5" class="btn btn-success" Onclick="btnB5_Click" runat="server"/>
                                    </td>
                                </tr>
                            </tbody>
						</table>
				    </div><!-- /.span -->
				</div>
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <h4> Cantidad Asientos Escogidos: 
                                <asp:Label ID="lblCantidadAsientos" runat="server">45</asp:Label>
                            </h4>
                        </div>
                        <div class="col-xs-12">
                            <asp:Button class="btn btn-danger" ID="btnCancelarAsiento"  Text="Cancelar" Onclick="btnCancelarAsiento_Click" runat="server"/>
                            <asp:Button ID="btnSiguiente" class="btn btn-grey" Text="Siguiente" Onclick="btnSiguiente_Click" runat="server"/>         
                        </div>
                    </div>
                </div>
            </div>
        </div> 
    </div>
   
    <!-- basic scripts -->

		<!--[if !IE]> -->
		<script src="../assets/js/jquery-2.1.4.min.js"></script>

		<!-- <![endif]-->

		<!--[if IE]>
<script src="../assets/js/jquery-1.11.3.min.js"></script>
<![endif]-->
		<script type="text/javascript">
			if('ontouchstart' in document.documentElement) document.write("<script src='../assets/js/jquery.mobile.custom.min.js'>"+"<"+"/script>");
		</script>
		<script src="../assets/js/bootstrap.min.js"></script>

		<!-- page specific plugin scripts -->
       <script src="assets/js/bootbox.js"></script>

		<!-- ace scripts -->
		<script src="../assets/js/ace-elements.min.js"></script>
		<script src="../assets/js/ace.min.js"></script>

		<!-- inline scripts related to this page -->
</asp:Content>