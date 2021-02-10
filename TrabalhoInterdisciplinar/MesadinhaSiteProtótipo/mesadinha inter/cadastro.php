<?php
require_once "comandos/class.php";
$comando = new comando();

if(isset($_POST["cad"]))
{
	$comando->cadastrar();
}
?>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
	<link rel="stylesheet" type="text/CSS"
		href="css/bootstrap.min.css">
	<link rel="stylesheet" type="text/CSS"
		href="css/estilo.css">
    <title>Cadastro</title>
</head>
<body>
<div class="main">
	<div class="cad row">
		<form action="cadastro.php" method="post">
			<div class="col-12 form-group">
				<h2>Cadastro</h2>
			</div>
			<div class="col-12 label">
				<label for="nome">Nome</label>
				<input type="text" name="nome" id="nome" class="form-control" required>
			</div>
			<div class="col-12 label">
				<label for="telefone">Telefone</label>
				<input type="text" name="telefone" id="telefone" class="form-control" oninput=mascara() maxlength="14" required>
			</div>
			<div class="col-12 label">
				<label for="endereco">Endereço</label>
				<input type="text" name="endereco" id="endereco" class="form-control" required>
			</div>
			<div class="col-12 label">
				<label for="email">E-mail</label>
				<input type="email" name="email" id="email" class="form-control" required>
			</div>
			<div class="col-12 label">
				<label for="senha">Senha</label>
				<input type="password" name="senha" id="senha" class="form-control" required>
			</div>
				<button type="submit" name="cad" value="cad" class="btn btn-outline-secondary col-5">Cadastrar</button>
				<button onclick="window.location.href='index.php'" class="btn btn-outline-secondary col-5">Voltar</button>
</div>
</form>
</div>
</body>
</html>