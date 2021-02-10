<?php
require_once "classes/metodo.php";
$metodo = new metodo();

if(isset($_POST["entrar"]))
{
	$metodo->validar();
}
?>
<!DOCTYPE html>
<html lang="pt-BR">
<head>
	<link rel="stylesheet" type="text/CSS"
href="css/bootstrap.min.css">
<link rel="stylesheet" type="text/CSS"
href="css/estilo.css">
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.0/css/all.css"
integrity="sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ" crossorigin="anonymous">
<link rel="shortcut icon" href="css/img/logo.png" type="image/x-icon">
    <meta charset="UTF-8">
    <title>Login</title>
</head>
<body>
<div class="container center">
<div class="row cener bot">
<form action="usuario.php" method="post">
<div class="col-12 top form-group">
<h2 id="h">Login no Sistema</h2></div>
<div class="form-group">
    <label for="email" class="col-8">E-mail</label>
    <input class="form-control col-12" type="email" name="email" id="email" placeholder="Ex. joao@gmail.com" required></div>
<div class="form-group">
    <label for="senha" class="col-8">Senha</label>
    <input class="form-control col-12" type="password" name="senha" id="senha" ></div>
    <button type="submit" name="entrar" value="entrar" class="btn btn-success col-6 top" required>Entrar &nbsp&nbsp<i class="fas fa-sign-in-alt"></i></button>
	<label class="col-8">não tem cadastro?</label><button onclick="window.location.href='cadastro.php'" class="btn btn-warning col-6">Cadastre-se  &nbsp&nbsp<i class="fas fa-user-plus"></i></button>
</form>
</div>
</div>
</body>
</html>