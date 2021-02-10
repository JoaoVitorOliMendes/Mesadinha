<?php
session_start();

require_once "comandos/class.php";
$comando = new comando();

$receitas = 0.0;
$despesas = 0.0;

if(isset($_POST["entrar"]))
{
	$login = $comando->login();
	if ($login): foreach($login as $log): $log = $log->id;
	$_SESSION["id"]= $log; endforeach;endif;
	$receit = $comando->receita();
	$despes = $comando->despesa();
}else if(!empty ($_SESSION["id"]))
{
	$log = $_SESSION["id"];
	$receit = $comando->receita2();
	$despes = $comando->despesa2();
}
else{
	echo "<script>alert('Faça login antes de entrar');</script>";
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
    <title>Home</title>
</head>
<body>
<div class="side">
	<ul class="ul">
	<li><a class="active" href="">Home</a></li>
	<li><a href="dados.php">Mudar dados</a></li>
	<li><a href="senha.php">Mudar senha</a></li>
	<li><a href="categoria.php">Categoria</a></li>
	<li><a href="conta.php">Conta</a></li>
	<li><a href="movimentacao.php">Lancamento</a></li>
	</ul>
</div>
<div class="container inicial main">
	<div class="row float">
		<h1>Receita</h1>
		<p>R$ <?php if($receit):foreach($receit as $rec):echo $rec->receitass;$receitas = $rec->receitass;endforeach;endif; ?></p>
	</div>
	<div class="row float">
		<h1>Despesas</h1>
		<p>R$ <?php if($despes):foreach($despes as $des):echo $des->despesass;$despesas = $des->despesass;endforeach;endif?></p>
	</div>
	<div class="row float">
		<h1>Saldo</h1>
		<p>R$ <?php echo $receitas - $despesas; ?></p>
	</div>
</body>
</html>