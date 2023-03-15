
using Dependency_Inversion;

IURL iurl = new URL("github.com/clubeprogramacaossa");

Navegador navegador = new Navegador("GoogleChrome",  300, 1);

navegador.acessarInternet(iurl);

IProjetoWeb pw = new ProjetoWeb(
    "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<meta charset=\"UTF-8\"/>" +
    "\r\n<title>Document</title>\r\n</head>\r\n<body>\r\n<!-- Conteúdo -->\r\n</body>\r\n</html>",
    "<style>\r\np {\r\ncolor: blue;\r\ntext-weight: bold;\r\n}\r\n<style>");

navegador.exibirProjetoWeb(pw);

