<?php
session_unset();
require_once "comandos/class.php";
$comando = new comando();

?>
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
	<link rel="stylesheet" type="text/CSS"
		href="css/bootstrap.min.css">
	<link rel="stylesheet" type="text/CSS"
		href="css/estilo.css">
    <title>Login</title>
</head>
<body>
<div class="main">
	<div class="login row">
		<form action="inicial.php" method="post">
			<div class="col-12 form-group">
				<h1><b>Login</b></h1>
			</div>
			<div class="form-group">
				<label for="email" class="col-12">E-mail</label>
				<input class="col-12" type="email" name="email" id="email" class="form-control" required>
			</div>
			<div class="form-group">
				<label for="senha" class="col-12">Senha</label>
				<input class="col-12" type="password" name="senha" id="senha" class="form-control" required>
			</div>
			<button type="submit" name="entrar" value="entrar" class="btn btn-outline-secondary col-5">Login</button>
			<button onclick="window.location.href='cadastro.php'" class="btn btn-outline-secondary col-5">Registrar</button>
		</form>
	</div>
</div>
</body>
</html>