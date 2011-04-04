<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Loops</title>
</head>
<body>
    <div>
		<% var values = new[] { "One", "Two", "Three" }; %>
        <ul>			
			<% foreach (var item in values) {  %>
				<li><%: item %></li>
			<% } %>
		</ul>
    </div>
</body>
</html>
