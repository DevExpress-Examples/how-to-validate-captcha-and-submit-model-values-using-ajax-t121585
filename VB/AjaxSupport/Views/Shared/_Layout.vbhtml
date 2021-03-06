﻿<!DOCTYPE HTML>

<html>
<head>
    <title>@ViewBag.Title</title>
    @Html.DevExpress().GetStyleSheets(New StyleSheet With { .ExtensionSuite = ExtensionSuite.Editors }    )
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
    <script src="@Url.Content("~/Scripts/jquery-1.10.2.min.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/jquery.unobtrusive-ajax.min.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/jquery.validate.min.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js")" type="text/javascript"></script>
    @Html.DevExpress().GetScripts(New Script With { .ExtensionSuite = ExtensionSuite.Editors }   )
</head>

<body>
    @RenderBody()
</body>
</html>
