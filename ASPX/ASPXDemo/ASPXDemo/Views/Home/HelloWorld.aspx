<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>HelloWorld</title>
</head>
<body>
    <div>
        Encoded: <%: ViewBag.HelloWorld %>

		<br />

		Not-encoded: <%= ViewBag.HelloWorldHtml %>
    </div>
</body>
</html>
