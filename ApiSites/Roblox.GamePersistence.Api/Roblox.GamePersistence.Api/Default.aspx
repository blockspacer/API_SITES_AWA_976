<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Roblox.GamePersistence.Api.Default" %>
<%@ Import Namespace="Roblox.Web.Util" %>
<%@ Import Namespace="Roblox.Platform.ErrorModels" %>

<% Errors.RespondWithCustomErrors(403, new CustomError[] { new CustomError { code = 403, message = "Not Allowed" } }, Response, true); %>
