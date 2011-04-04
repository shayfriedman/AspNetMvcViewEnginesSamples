<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Dry</title>
</head>
<body>
    <div>
		<% Html.RenderPartial("SayHello", new {FontSize=40, Text="Hello"}); %>        
    </div>
</body>
</html>
