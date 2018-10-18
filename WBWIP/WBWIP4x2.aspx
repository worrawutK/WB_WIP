<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WBWIP4x2.aspx.vb" Inherits="WBWIP.WBWIP4x2" %>


<%@ Register Src="~/ControlPosition4x2.ascx" TagPrefix="uc1" TagName="ControlPosition" %>
<%@ Register Src="~/ControlPositionBIG.ascx" TagPrefix="uc1" TagName="ControlPositionBIG" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WB WIP</title>
    <style type="text/css">
        
        .auto-style3 {
            height: 28px;
          
        }
        .hide{
  display:none;  
}
       
    </style>
     
  <style>
    fieldset {
      border: 0;
    }
   label {
      display: block;
      margin: 30px 0 0 0;
      font-size:18px;
    }
    .overflow {
      height: 200px;
    }
  </style>
    <link href="scripts/jquery-ui.css" rel="stylesheet" />
    <link rel="stylesheet" href="/resources/demos/style.css" />
    
     <script src="scripts/jquery-1.12.4.js"></script>
     <script src="scripts/jquery-ui.js"></script>
    <link href="StyleSheet1.css" rel="stylesheet" />

<%--    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"/>
  <link rel="stylesheet" href="/resources/demos/style.css"/>--%>
    <style type="text/css">
html, body{
padding:0px;
margin:0px;
height:100%;
}
        .auto-style7 {
            height: 50px;
        }
        .auto-style8 {
            width: 30%;
            height: 50px;
        }
        
        .auto-style9 {
            height: 314px;
        }
        
    </style>
  <script>
     setTimeout(function ()
      {
          window.parent.$('#dialog-message').dialog('close');
    
         //     $("#tbOPNo").focus();
          }, 3000 // milliseconds delay
      );
      
      function showDialog(text)
      {
        
          $("#dialog-text").text(text);
           $("#dialog-message" ).dialog({
               modal: true
                
               //,
            //buttons: {
            //    Ok: function() {
            //        $( this ).dialog( "close" );
            //    },
            //    "Delete All": function () {
            //        alert('test');
            //    }
            //}
           });
          
        
      }
      function showDialog2() {
         // function showDialog2(Before, Before2, WB, WB2) {
          //$("#dialogBeforeProcess").text(Before);
          //$("#dialog-BeforeProcess2").text(Before2);
          //$("#dialog-WB").text(WB);
          //$("#dialog-WB2").text(WB2);
          $("#dialog-message2").dialog({
              modal: true,
            // resizable: false,
         // height: "auto",
         // width: 400,
       
          buttons: {
             "OK": function ()  {//  "OK": function () {
                 var someValueToPass = 'Hello server';
              
                 var StatusLot = $("#StatusLot");
                 var ProcessBefore = $("#ProcessBefore");
                 var txt = StatusLot.val() + '-' + ProcessBefore.val();
                 $(this).dialog("close");
                 __doPostBack(txt, someValueToPass);
                
              },
              Cancel: function () {
                  $(this).dialog("close");
              }
          }
              //,
              //buttons: {
              //    Ok: function() {
              //        $( this ).dialog( "close" );
              //    },
              //    "Delete All": function () {
              //        alert('test');
              //    }
              //}
          });
      }
      function edValueKeyPress() {
          var edValue = document.getElementById("edValue");
          var s = edValue.value;

          var lblValue = document.getElementById("lblValue");
          lblValue.innerText = "The text box contains: " + s;

          //var s = $("#edValue").val();
          //$("#lblValue").text(s);    
      }

      function showDialogCancel() {
         
          $("#dialog-CancelLot").dialog({
              modal: true,
              buttons: {
                  "OK": function () {
                      var someValueToPass = 'Hello server';

                      var StatusLot = $("#StatusLot");
                      var ProcessBefore = $("#ProcessBefore");
                      var txt = StatusLot.val() + '-' + ProcessBefore.val();
                      $(this).dialog("close");
                      __doPostBack(txt, someValueToPass);

                  },
                  Cancel: function () {
                      $(this).dialog("close");
                  }
              }       
          });
      }
  </script>

<script>
    $(function () {
        $("#speed").selectmenu();

       // $("#files").selectmenu();

      /*  $("#number")
          .selectmenu()
          .selectmenu("menuWidget")
          .addClass("overflow");

        $("#salutation").selectmenu();
        */
    });


     $(function () {
         //initial dialog style 1
         $("#dialog-message").dialog({
             autoOpen: false,
             show: {
                 effect: "shake",
                 duration: 1000
             },
             hide: {
                 effect: "explode",
                 duration: 1000
             }
         });
         //initial dialog style 2
      $("#dialog-message2").dialog({
             autoOpen: false,
             //maxWidth: 600,
             //maxHeight: 500,
          //   width: "auto",
          //   height: "auto",
             modal: true,
             show: {
                 effect: "shake",
                 duration: 1000
             },
             hide: {
                 effect: "puff",//puff
                 duration: 1000

             }
         });

      $("#dialog-CancelLot").dialog({
          autoOpen: false,
     
          modal: true,
          show: {
              effect: "shake",
              duration: 1000
          },
          hide: {
              effect: "puff",//puff
              duration: 1000

          }
      });
         //initial TAB
         var tabs = $( "#tabs" ).tabs();
         tabs.find( ".ui-tabs-nav" ).sortable({
            axis: "x",
            stop: function() {
                tabs.tabs( "refresh" );
            }
         });
  });
  
  </script>
</head>
<body>

        <%--   <%
               For i As Integer = 1 To 10
                   Response.Write("<input type=""text"" value=" & i.ToString() & " />")
               Next
          %>--%>

    <form id="form1" runat="server" >
      
          
                 <div id="dialog-message" title="Message" style="display:none" ><%--style="display:none"--%>
                <span id="dialog-text">Text Message</span>
         </div>
          
        
        <div id="dialog-message2" title="Message"  style="display:none" ><%--style="display:none"--%>            <%-- <span id="dialogBeforeProcess" style="width:1000px;">Text Message</span>--%>            <%--<asp:Label id="dialogBeforeProcess" runat="server" Text="Label" Width="1000px" BorderStyle="Inset"></asp:Label>--%>           <%--   <br />
            <span id="dialog-BeforeProcess2">Text Message</span>
              <br />
                 <span id="dialog-WB">Text Message</span>
              <br />
             <span id="dialog-WB2">Text Message</span>--%>
                  <label for="ProcessBefore">Process Before</label>
    <select name="ProcessBefore" id="ProcessBefore" runat="server">
      <option>INSP</option>
      <option>OVEN</option>
      <option>PLASMA</option>
       
      <option selected="selected">DB</option>
   
    </select>

           <label for="StatusLot">Status Lot</label>
    <select name="StatusLot" id="StatusLot" runat="server">
      <option >DELAY</option>
      <option>URGENT</option>
      <option selected="selected">NORMAL</option>
   
    </select>
         </div>
     <div id="dialog-CancelLot" title="Message"  style="display:none" ><%--style="display:none"--%>        
                  <label for="ProcessBefore">Process Beforexxxxx</label>
         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
          <input id="edValue" type="text" onKeyPress="edValueKeyPress()"><br/>
           <label for="StatusLot">Status Lot</label>
    <select name="StatusLot" id="Select2" runat="server">
      <option >DELAY</option>
      <option>URGENT</option>
      <option selected="selected">NORMAL</option>
   
    </select>
         </div>
    <div id="Main" style="background-color: #f6fad1;">
              
                          <table style="width: 100%;" border="1" >
                    <tr>
                        <td class="auto-style7"><%--Head--%>
                            <asp:Label ID="WebName" runat="server" Text=" WB PROCESS REQUEST WIP" Font-Bold="True" Font-Size="25px" Font-Underline="True" ForeColor="#0033CC"></asp:Label>
                                
                            <asp:SqlDataSource ID="SqlDBx" runat="server" ConnectionString="<%$ ConnectionStrings:DBxConnectionString %>" ></asp:SqlDataSource>
                  
                            
                           
                            <asp:SqlDataSource ID="SqlAPCSDB" runat="server" ConnectionString="Data Source=172.16.0.102;Initial Catalog=APCSDB;User ID=APCSDBUSER" ProviderName="System.Data.SqlClient"></asp:SqlDataSource>
                  
                            
                           
              <asp:ScriptManager ID="ScriptManager2" runat="server">
            </asp:ScriptManager>
                                    
                        </td>
                        <td style="text-align:right;vertical-align:bottom; font-size: 20px;" class="auto-style8" >
                            <asp:Label ID="lbGotoProcess" runat="server" Font-Size="33px" ForeColor="Red" Font-Names="Andalus"></asp:Label>
                          
                         
                        </td>
                    </tr>
                    <tr >
                        <td style="vertical-align:top;text-align:right;" colspan="2">
                          
                            <div >
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <asp:Timer ID="Timer1" runat="server" Interval="1000">
                                        </asp:Timer>
                                    </ContentTemplate>
                                  
                                </asp:UpdatePanel>
                             
                                <asp:UpdatePanel ID="UpdatePanelControl" runat="server">
                                    <ContentTemplate>
                                  <%--     <asp:GridView ID="GridView1" runat="server"></asp:GridView>--%>
                                        <asp:Panel ID="Panel1" runat="server" align="center">
                                           
                                            <table border="1" style="width:100%;height:750px;background-color: #ffffff;" >
                                                <tr>
                                                    <td style="width:50%">
                                                      
                                                    
                                                       <%--  <uc1:ControlPositionBIG ID="ControlPositionBIG01" runat="server" />--%>
                                                        <uc1:ControlPosition ID="ControlPosition01" runat="server" />
                                                    </td>
                                                 
                                                   <td style="width:50%">
                                                    <%--     <uc1:ControlPositionBIG ID="ControlPositionBIG03" runat="server" />--%>
                                                       <uc1:ControlPosition ID="ControlPosition02" runat="server" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                     <%--    <uc1:ControlPositionBIG ID="ControlPositionBIG04" runat="server" />--%>
                                                        <uc1:ControlPosition ID="ControlPosition03" runat="server" />
                                                    </td>
                                               
                                                    <td>
                                                        <%--  <uc1:ControlPositionBIG ID="ControlPositionBIG06" runat="server" />--%>
                                                        <uc1:ControlPosition ID="ControlPosition04" runat="server" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                       <%--   <uc1:ControlPositionBIG ID="ControlPositionBIG07" runat="server" />--%>
                                                        <uc1:ControlPosition ID="ControlPosition05" runat="server" />
                                                    </td>
                                                
                                                    <td>
                                                          <%--<uc1:ControlPositionBIG ID="ControlPositionBIG09" runat="server" />--%>
                                                          <uc1:ControlPosition ID="ControlPosition06" runat="server" />
                                                    </td>
                                                </tr>
                                                   <tr>
                                                    <td class="auto-style9">
                                                       <%--   <uc1:ControlPositionBIG ID="ControlPositionBIG07" runat="server" />--%>
                                                        <uc1:ControlPosition ID="ControlPosition07" runat="server" />
                                                    </td>
                                                
                                                    <td class="auto-style9">
                                                          <%--<uc1:ControlPositionBIG ID="ControlPositionBIG09" runat="server" />--%>
                                                          <uc1:ControlPosition ID="ControlPosition08" runat="server" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                
                            </div>
                            </td>
            </tr>
            <tr>
             <td style="height:400px;vertical-align:top;" colspan="2" >  
                  

    <asp:UpdatePanel ID="UpdatePanelInPut" runat="server" UpdateMode="Conditional"><%--'UpdateMode="Conditional"--%>
               <ContentTemplate>
            <asp:Panel ID="PanelInput" runat="server" DefaultButton="SubmitButton" BackColor="Gray" ><%--DefaultButton="SubmitButton"--%>
                                        <asp:Button ID="SubmitButton" CssClass="hide" runat="server" Text="Input Lot No."  UseSubmitBehavior="False" Font-Bold="True" Font-Size="15pt" Height="33px" Width="100%"  /><%--OnClick="SubmitButton_Click"--%>
      
                                                 <table style="width: 100%;vertical-align:top;" border="1">
                                            <tr >
                                         
                                                <td class="auto-style3" style="text-align:center;"  >
                                    <asp:Label ID="Label2" runat="server" Font-Names="Andalus" Font-Size="18px" ForeColor="White">OP No.</asp:Label>
                                                    <br />
                                                    <asp:TextBox ID="tbOPNo" runat="server" TextMode="Phone" ></asp:TextBox>
                                                   
                                                </td>
                                              
                                                <td class="auto-style3" style="text-align:center;">
                                                      <asp:Label ID="Label3" runat="server" Font-Names="Andalus" Font-Size="18px" ForeColor="White">Lot No.</asp:Label>
                                                    <br />
                                                    <asp:TextBox ID="tbLotNo" runat="server"></asp:TextBox>
                                                  
                                                </td>
                                             
                                                <td class="auto-style3" style="text-align:center;">
                                                       <asp:Label Font-Names="Andalus" ID="Label4" runat="server" Font-Size="18px" ForeColor="White">RackNo</asp:Label>
                                                    <br />
                                                    <asp:TextBox ID="tbRackNo" runat="server"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3" style="text-align:left;">
                                                   
                                                    <asp:Button class="buttonOrange" Height="25px" ID="Button4" Font-Names="Andalus" runat="server" Text="Clear" style="vertical-align:top" Width="117px" />
                                                   <br />
                                                    <asp:Button class="buttonOrange" Height="25px" ID="CacheRemove" Font-Names="Andalus" runat="server" Text="Refresh" style="vertical-align:top" Width="158px" />
                                                  
                                                    <asp:Button ID="CacheRemove0" runat="server" class="buttonRed" Font-Names="Andalus" Height="25px" style="vertical-align:top" Text="Clear Lot" Visible="False" />
                                                   
                                                </td>
                                            </tr>
                                        </table>
                        
                            
                </asp:Panel>   
                   </ContentTemplate>
        </asp:UpdatePanel>
           
           <asp:UpdatePanel ID="UpdatePanel4" runat="server">

                     <ContentTemplate>

                                    <asp:SqlDataSource ID="SqlOrder" runat="server" ConnectionString="<%$ ConnectionStrings:DBxConnectionString %>"></asp:SqlDataSource>
                             <asp:Label ID="lblDate" runat="server" Text=""></asp:Label>
                     </ContentTemplate>

                 </asp:UpdatePanel>            
                     
                
                </td>
            </tr>
        </table>
      
    </div>
    </form>
</body>
</html>
 