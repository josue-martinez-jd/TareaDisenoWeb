<%@ Page Title="" Language="C#" MasterPageFile="~/index.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="main-content">
				<div class="main-content-inner">
					<div class="breadcrumbs ace-save-state" id="breadcrumbs">
						<ul class="breadcrumb">
							<li>
								<i class="ace-icon fa fa-home home-icon"></i>
								<a href="#">Home</a>
							</li>

							<li>
								<a href="#">Other Pages</a>
							</li>
							<li class="active">Blank Page</li>
						</ul><!-- /.breadcrumb -->

						<div class="nav-search" id="nav-search">
							<form class="form-search">
								<span class="input-icon">
									<input type="text" placeholder="Search ..." class="nav-search-input" id="nav-search-input" autocomplete="off" />
									<i class="ace-icon fa fa-search nav-search-icon"></i>
								</span>
							</form>
						</div><!-- /.nav-search -->
					</div>

					<div class="page-content">
                        <div class="container prices">
                            <div class="row">
                                <div class="col-sm-2">
                                    <label>Precio Oeste: <asp:Label ID="lblPrecioOeste" runat="server">$1214</asp:Label></label>
                                </div>
                                <div class="col-sm-2">
                                    <label>Precio Este: <asp:Label ID="lblPrecioEste" runat="server">$1214</asp:Label></label>
                                </div>
                                <div class="col-sm-2">
                                    <label>Precio Norte: <asp:Label ID="lblPrecioNorte" runat="server">$1214</asp:Label></label>
                                </div>
                                <div class="col-sm-2">
                                    <label>Precio Sur: <asp:Label ID="lblPrecioSur" runat="server">$1214</asp:Label></label>
                                </div>
                            </div>
                        </div>
                        <div class="container stadium">
                            <div class="jumbotron">
                                <asp:Button class="btn btn-grey" ID="btnGraderiaOeste" Text="Oeste" style="top: 11.1%;" runat="server"/>
                                <asp:Button class="btn btn-purple rotated" ID="btnGraderiaSur" Text="Sur" style="left: 0%;" runat="server"/>
                                <img src="assets/images/gallery/stadium.png"
                                    width="1000" />
                                <asp:Button class="btn btn-grey" ID="btnGraderiaEste" Text="Este" style="bottom: 5.4%;" runat="server"/>
                                <asp:Button class="btn btn-purple rotated" ID="btnGraderiaNorte" Style="left: 82%;" Text="Norte"  runat="server"/>
                            </div>
                        </div>
						<div class="row">
							<div class="col-xs-12">
								<!-- PAGE CONTENT BEGINS -->
                                
								<!-- PAGE CONTENT ENDS -->
							</div><!-- /.col -->
						</div><!-- /.row -->
					</div><!-- /.page-content -->
				</div>
			</div><!-- /.main-content -->

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

		<!-- ace scripts -->
		<script src="../assets/js/ace-elements.min.js"></script>
		<script src="../assets/js/ace.min.js"></script>

		<!-- inline scripts related to this page -->
</asp:Content>

