<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Index</title>
</head>
<body>
    <div>
		<ul>
			<li><%=Html.ActionLink("Hello World", "HelloWorld") %></li>
			<li><%=Html.ActionLink("Condition", "Condition") %></li>
			<li><%=Html.ActionLink("Loops", "Loops") %></li>
			<li><%=Html.ActionLink("Layouts", "Layouts") %></li>
			<li><%=Html.ActionLink("Displaying a form", "DisplayingAForm") %></li>
			<li><%=Html.ActionLink("DRY", "Dry") %></li>
		</ul>
    </div>
</body>
</html>
