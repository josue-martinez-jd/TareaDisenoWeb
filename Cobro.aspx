<%@ Page Language="C#" MasterPageFile="~/index.master" AutoEventWireup="true" CodeFile="Cobro.aspx.cs" Inherits="Cobro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="main-content">
		<div class="page-content">
            <div class="container payment">
                <div class="row">
                 <div class="col-md-3">
                    <div class="widget-box">
						<div class="widget-header">
							<h4 ID="lblPaymentTitle" class="widget-title" runat="server"> PAGO</h4>
						</div>
						<div class="widget-body">
							<div class="widget-main">
								<div>
									<label> Descripcion: </label>
                                    <asp:Label ID="lblDescripcion" runat="server"> Partido</asp:Label>
								</div>
                                <div>
									<label> Horario: </label>
                                    <asp:Label ID="lblHorario" runat="server"> 10:00AM</asp:Label>
								</div>
                                <div>
									<label> Translado: </label>
                                    <asp:Label ID="lblTranslado" runat="server"> Cartago</asp:Label>
								</div>
                                <div>
									<label> Precio Translado: </label>
                                    <asp:Label ID="lblPrecioTranslado" runat="server"> $4</asp:Label>
								</div>
                                <div>
									<label> Graderia: </label>
                                    <asp:Label ID="lblGraderia" runat="server"> Norte</asp:Label>
								</div>
                                 <div>
									<label> Precio Unidad: </label>
                                    <asp:Label ID="lblPrecioUnidad" runat="server"> $50 </asp:Label>
								</div>  
                                <div>
									<label> Cantidad Asientos: </label>
                                    <asp:Label ID="lblCantidadAsientos" runat="server"> 4</asp:Label>
								</div>
									<label> Precio Total: </label>
                                    <asp:Label ID="lblTotal" runat="server"> $100</asp:Label>
								</div>
                               <hr />
                            <div class="row">
                                <div class="col-lg-12 center" style="margin-bottom: 5%";>
                                    <asp:Button ID="btnAceptar" Text="Aceptar" class="btn btn-success" runat="server"/>
                                    <asp:Button ID="btnCancelar" Text="Cancelar" class="btn btn-danger" runat="server"/>
                                </div>
                            </div>
                        </div>
                     </div>
                     </div>
                 <div class="col-md-7"></div>
                    <asp:Table ID="tblBoletos" runat="server" 
                        BackColor="White" BorderColor="Black" 
                        BorderWidth="1" ForeColor="Black" GridLines="Both" BorderStyle="Solid"
                        Width="75%"> 
                        <asp:TableRow>
                            <asp:TableHeaderCell><h4>ASIENTO</h4></asp:TableHeaderCell>
                            <asp:TableHeaderCell><h4>DESCRIPCION</h4></asp:TableHeaderCell>
                            <asp:TableHeaderCell><h4>HORARIO</h4></asp:TableHeaderCell>
                            <asp:TableHeaderCell><h4>GRADERIA</h4></asp:TableHeaderCell>
                            <asp:TableHeaderCell><h4>PRECIO</h4></asp:TableHeaderCell>
                        </asp:TableRow>
                </asp:Table>  
            </div>
        </div>
    </div>
     
</asp:Content>