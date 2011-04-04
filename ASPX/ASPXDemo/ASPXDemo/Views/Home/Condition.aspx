<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Condition</title>
</head>
<body>
    <div>
        <% if (DateTime.Today == new DateTime(2011, 4, 4)) { %>
			<p>It's SDC day!</p>
		<% } else { %>
			<p>It's just another day.</p>
		<% } %>
    </div>
</body>
</html>
