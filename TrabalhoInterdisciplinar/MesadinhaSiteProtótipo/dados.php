<?php
session_start();
$log = $_SESSION["id"];
if(!empty ($log))
{
	
require_once "comandos/class.php";
$comando = new comando();

$selecionar = $comando->selecionardados();

if(isset($_POST["cad"]))
{
	$comando->alterardados();
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
    <title>Mudar Dados</title>
</head>
<body>
<div class="side">
	<ul class="ul">
	<li><a href="inicial.php">Home</a></li>
	<li><a class="active" href="">Mudar dados</a></li>
	<li><a href="senha.php">Mudar senha</a></li>
	<li><a href="categoria.php">Categoria</a></li>
	<li><a href="conta.php">Conta</a></li>
	<li><a href="movimentacao.php">Lancamento</a></li>
	</ul>
</div>
<div class="main">
	<div class="login row">
		<form action="dados.php" method="post">
			<div class="col-12 form-group">
				<h1><b>Mudar Dados</b></h1>
			</div>
			<div class="col-12 label">
				<label for="nome">Nome</label>
				<input type="text" name="nome" id="nome" class="form-control" value="<?php if ($selecionar): foreach($selecionar as $sel): echo $sel->nome;endforeach;endif;?>" required>
			</div>
			<div class="col-12 label">
				<label for="telefone">Telefone</label>
				<input type="text" name="telefone" id="telefone" class="form-control" value="<?php if ($selecionar): foreach($selecionar as $sel): echo $sel->telefone;endforeach;endif;?>" required>
			</div>
			<div class="col-12 label">
				<label for="endereco">Endereço</label>
				<input type="text" name="endereco" id="endereco" class="form-control" value="<?php if ($selecionar): foreach($selecionar as $sel): echo $sel->endereco;endforeach;endif;?>" required>
			</div>
			<div class="col-12 label">
				<label for="email">E-mail</label>
				<input type="email" name="email" id="email" class="form-control" value="<?php if ($selecionar): foreach($selecionar as $sel): echo $sel->email;endforeach;endif;?>" required>
			</div>
				<button type="submit" name="cad" value="cad" class="btn btn-outline-secondary col-5">Salvar</button>
				<button onclick="window.location.href='inicial.php'" class="btn btn-outline-secondary col-5">Voltar</button>
		</form>
	</div>
</div>
</body>
</html>