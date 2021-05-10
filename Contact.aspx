<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="lidstest.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

    <asp:GridView CssClass="Grid" runat="server" ID="myGV" AutoGenerateColumns="False" AlternatingRowStyle-CssClass="alt"
        onselectedindexchanged="CustomersGridView_SelectedIndexChanged"
        AutoGenerateSelectButton="True" 
        Width="305px" OnRowDataBound="myGV_RowDataBound">
        <Columns>
            <asp:BoundField ControlStyle-Width="200px" HeaderText="Name" DataField="Name" />
            <asp:BoundField ControlStyle-Width="200px" HeaderText="amount" DataField="amount" />

        </Columns>
        
    </asp:GridView>

        <asp:UpdatePanel ID="UpdatePanel1"
            runat="server">
            
            <ContentTemplate>
                <div class="row">
                    <div class="col-md-12 col-sm-12 col-xs-12 col-lg-12">
                        <div class="form-group">
                            <label for="name" class="control-label"> name</label>
                            <asp:TextBox ID="name" placeholder="name" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldname" runat="server" 
                                Style="top: 98px; left: 367px; position: absolute; height: 26px; width: 162px" 
                                ErrorMessage="name required" ControlToValidate="name">
                            </asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12 col-sm-12 col-xs-12 col-lg-12">
                        <div class="form-group">
                            <label for="amount" class="control-label">keywords</label>
                            <asp:TextBox ID="amount" placeholder="amount" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldamount" runat="server" 
                                Style="top: 98px; left: 367px; position: absolute; height: 26px; width: 162px" 
                                ErrorMessage="amount required" ControlToValidate="amount">
                            </asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="amountRange" runat="server" Style="top: 194px; left: 365px;  
        position: absolute; height: 22px; width: 105px" ErrorMessage="RangeValidator"  
        ControlToValidate="amount" MaximumValue="999" MinimumValue="100" Type="Integer"></asp:RangeValidator> 
                        </div>
                    </div>
                </div>
        <asp:Button runat="server" Text="Button" OnClick="Unnamed1_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>

</asp:Content>
