<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/index.master" CodeFile="EscogerEvento.aspx.cs" Inherits="EscogerEvento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="main-content">
        <div class="container delivery">
            <div class="row">
                <div class="col-md-5">
                    <h4> TRANSLADO :</h4>
                     <asp:DropDownList placeholder="Escoge un Translado" class="chosen-container chosen-container-single" runat="server">
                        <asp:ListItem Value="">Select</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
        </div>
       
        <div class="container events">
            <div class="row">
                <div class="col-md-4">
                    <div class="widget-box">
						<div class="widget-header">
							<h4 ID="lblPrimerEvento" class="widget-title" runat="server"></h4>
						</div>
						<div class="widget-body">
							<div class="widget-main">
								<div>
									<label> Descripcion: </label>
                                    <asp:Label ID="lblDescripcion1" runat="server"> Partido</asp:Label>
								</div>
                                <div>
									<label> Artista: </label>
                                    <asp:Label ID="lblArtista1" runat="server"> Partido</asp:Label>
								</div>
                                <div>
									<label> Costo Oeste: </label>
                                    <asp:Label ID="lblCostoOeste1" runat="server"> Partido</asp:Label>
								</div>
                                <div>
									<label> Costo Este: </label>
                                    <asp:Label ID="lblCostoEste1" runat="server"> Partido</asp:Label>
								</div>
                                 <div>
									<label> Costo Sur: </label>
                                    <asp:Label ID="lblCostoSur1" runat="server"> Partido</asp:Label>
								</div>  
                                <div>
									<label> Costo Norte: </label>
                                    <asp:Label ID="lblCostoNorte1" runat="server"> Partido</asp:Label>
								</div>
                               <hr />
                               <asp:Button ID="btnEscogerEvento1" Text="Escoger" class="btn btn-inverse" runat="server"/>
                        </div>
                     </div>
                     </div>
				</div>	
                <div class="col-md-4">
                    <div class="widget-box">
						<div class="widget-header">
							<h4 ID="lblSegundoEvento" class="widget-title" runat="server"></h4>
						</div>
						<div class="widget-body">
							<div class="widget-main">
								<div>
									<label> Descripcion: </label>
                                    <asp:Label ID="lblDescripcion2" runat="server"> Partido</asp:Label>
								</div>
                                <div>
									<label> Artista: </label>
                                    <asp:Label ID="lblArtista2" runat="server"> Partido</asp:Label>
								</div>
                                <div>
									<label> Costo Oeste: </label>
                                    <asp:Label ID="lblCostoOeste2" runat="server"> Partido</asp:Label>
								</div>
                                <div>
									<label> Costo Este: </label>
                                    <asp:Label ID="lblCostoEste2" runat="server"> Partido</asp:Label>
								</div>
                                 <div>
									<label> Costo Sur: </label>
                                    <asp:Label ID="lblCostoSur2" runat="server"> Partido</asp:Label>
								</div>  
                                <div>
									<label> Costo Norte: </label>
                                    <asp:Label ID="lblCostoNorte2" runat="server"> Partido</asp:Label>
								</div>
                               <hr />
                               <asp:Button ID="btnEscogerEvento2" Text="Escoger" class="btn btn-inverse" runat="server"/>
                        </div>
                     </div>
                     </div>
                </div>
                <div class="col-md-4">
                   <div class="widget-box">
						<div class="widget-header">
							<h4 ID="lblTercerEvento" class="widget-title" runat="server"></h4>
						</div>
						<div class="widget-body">
							<div class="widget-main">
								<div>
									<label> Descripcion: </label>
                                    <asp:Label ID="lblDescripcion3" runat="server"> Partido</asp:Label>
								</div>
                                <div>
									<label> Artista: </label>
                                    <asp:Label ID="lblArtista3" runat="server"> Partido</asp:Label>
								</div>
                                <div>
									<label> Costo Oeste: </label>
                                    <asp:Label ID="lblCostoOeste3" runat="server"> Partido</asp:Label>
								</div>
                                <div>
									<label> Costo Este: </label>
                                    <asp:Label ID="lblCostoEste3" runat="server"> Partido</asp:Label>
								</div>
                                 <div>
									<label> Costo Sur: </label>
                                    <asp:Label ID="lblCostoSur3" runat="server"> Partido</asp:Label>
								</div>  
                                <div>
									<label> Costo Norte: </label>
                                    <asp:Label ID="lblCostoNorte3" runat="server"> Partido</asp:Label>
								</div>
                               <hr />
                               <asp:Button ID="btnEscogerEvento3" Text="Escoger" class="btn btn-inverse" runat="server"/>
                        </div>
                     </div>
                     </div>
                </div>
            </div>
        </div>
    </div>
    

</asp:Content>
