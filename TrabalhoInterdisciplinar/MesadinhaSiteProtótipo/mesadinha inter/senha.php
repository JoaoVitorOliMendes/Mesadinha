<?php
session_start();
$log = $_SESSION["id"];
if(!empty ($log))
{

require_once "comandos/class.php";
$comando = new comando();

if(isset($_POST["sen"]))
{
	$comando->alterarsenha();
}

}else{header("location:naodeu");}
?>
<!DOCTYPE html>
<html lang="pt-BR">
<head>
	<meta charset="UTF-8">
	<link rel="stylesheet" type="text/CSS"
		href="css/bootstrap.min.css">
	<link rel="stylesheet" type="text/CSS"
		href="css/estilo.css">
    <title>Mudar Senha</title>
</head>
<body>
<div class="side">
	<ul class="ul">
	<li><a href="inicial.php">Home</a></li>
	<li><a href="dados.php">Mudar dados</a></li>
	<li><a class="active" href="#">Mudar senha</a></li>
	<li><a href="categoria.php">Categoria</a></li>
	<li><a href="conta.php">Conta</a></li>
	<li><a href="movimentacao.php">Lancamento</a></li>
	</ul>
</div>
<div class="main">
	<div class="login row">
		<form action="senha.php" method="post">
			<div class="col-12 form-group">
				<h1><b>Mudar Senha</b></h1>
			</div>
			<div class="col-12 label">
				<label for="senha">Senha</label>
				<input type="password" name="senha" id="senha" class="form-control" required>
			</div>
			<div class="col-12 label">
				<label for="senha2">Confirmar Senha</label>
				<input type="password" name="senha2" id="senha2" class="form-control" required>
			</div>
				<button type="submit" name="sen" value="sen" class="btn btn-outline-secondary col-5">Salvar</button>
				<button onclick="window.location.href='inicial.php'" class="btn btn-outline-secondary col-5">Voltar</button>
		</form>
	</div>
</div>
</body>
</html>