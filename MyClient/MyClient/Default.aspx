<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="MyClient._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

    <script src="/Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="/Scripts/base.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
   <table style="margin:10px">
      <tr>
           <td style="padding:10px">
               <select id="selectJSON">
                    
               </select>
           </td>
           <td style="padding:10px">
               <asp:DropDownList ID="DropDownListSOAP" runat="server">
               </asp:DropDownList>
           </td>
       </tr>
       <tr>
           <td style="padding:10px">
                <input type="button" value="Load with JSONP call" onclick="javascript:loadDropDownJSONP('selectJSON','<%=DropDownListSOAP.ClientID %>');" />
           </td>
           <td style="padding:10px">
                <asp:Button ID="Button1" runat="server" Text="Load with SOAP call" 
                    onclick="Button1_Click" />
           </td>
       </tr>
   </table>
   

    

</asp:Content>
