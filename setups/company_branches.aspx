<%@ Page Language="VB" MasterPageFile="~/webroot/web/modules/main.master" AutoEventWireup="false" Inherits="branch_Index_aspx" CodeFile="company_branches.aspx.vb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="masterContent">
        <table id="table8" cellspacing="0" cellpadding="0" width="100%" border="0">
            <tbody>
                <tr>
                    <td class="pageTitleBar">
                        <asp:Label ID="lbHeader" runat="server" Text="Label">Setup Branches</asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <uc:msgbox ID="Msgbox1" runat="server"></uc:msgbox>
                    </td>
                </tr>
                <tr>
                    <td class="sectionTabBar">
                        <uc:toptabs ID="toptabs1" runat="server" GroupName="adm_company" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <uc:gridarea ID="gridarea1" runat="server" GroupName="admin_branch_list" />
                    </td>
                    </tr>
                    <tr>
                    <td>
                        <asp:Panel ID="Panel1" runat="server" CssClass="FloatingFooterDiv1">
                            <asp:Button ID="cmdDelete" runat="server" CssClass="button" Text="Delete..." />
                            <asp:Button ID="cmdNew" runat="server" CssClass="button" Text="New Branch" />
                        </asp:Panel>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>