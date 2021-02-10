<?php
require_once "classes/metodo.php";
$metodo = new metodo();
	$despesas = 0.0;
	$receitas = 0.0;
if(isset($_POST["email"]) && !empty($_POST["email"]))
{
	$metodo->validar();
	$saldo = $metodo->saldo();
	$sald = $metodo->sald();
	$receita = $metodo->receita();
}else if(isset($_GET["codigo"]))
{
	$saldo = $metodo->saldo2();
	$sald = $metodo->sald2();
	$receita = $metodo->receita2();
}else{
	echo "<script>alert('Faça login antes de entrar');window.location.href='login.php'</script>";
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

</head>
<body>
<div class="nav">
<ul>
<img src="css/img/logo.png" class="img">
<li class="active"><a href="">Home</a></li>
<li onmouseover=dropdown() onmouseout=away() ><a href="">Usuário</a></li>
	<div class="sub" id="sub">
	<ul onmouseover=dropdown() onmouseout=away()>
		<li><a href="altsenha.php?codigo=<?php if ($sald): foreach($sald as $valor): echo $valor->codigo;endforeach;endif; ?>">Senha</a></li>
		<li><a href="altdados.php?codigo=<?php if ($sald): foreach($sald as $valor): echo $valor->codigo;endforeach;endif; ?>">Dados</a></li>
		<li><a href="login.php">Sair</a></li>
	</ul>
	</div>
<li onmouseover=dropdown2() onmouseout=away2() ><a href="">Conta</a></li>
	<div class="sub2" id="sub2">
	<ul onmouseover=dropdown2() onmouseout=away2()>
		<li><a href="categoria.php?codigo=<?php if ($sald): foreach($sald as $valor): echo $valor->codigo;endforeach;endif; ?>">Categorias</a></li>
		<li><a href="conta.php?codigo=<?php if ($sald): foreach($sald as $valor): echo $valor->codigo;endforeach;endif; ?>">Conta</a></li>
	</ul>
	</div>
<li><a href="lancamento.php?codigo=<?php if ($sald): foreach($sald as $valor): echo $valor->codigo;endforeach;endif; ?>">Lancamento</a></li>
</ul>
</div>
<div class="container left">
<div class="row cener2">
<div class="col-12">
<h2>Receitas</h2>
<br>
<br>
<br>
<h2>R$ <?php if ($receita): foreach($receita as $valor): if($valor->valor== null){$valor->valor = number_format("0",2);}echo $valor->valor;$receitas = $valor->valor;endforeach;endif; ?></h2>
</div>
</div>
<div class="row cener2">
<div class="col-12">
<h2>Despesas</h2>
<br>
<br>
<br>
<h2>R$ <?php if ($saldo): foreach($saldo as $valor): if($valor->valor == null){$valor->valor = number_format("0",2);}echo $valor->valor;$despesas = $valor->valor;endforeach;endif; ?></h2>
</div>
</div>
<div class="row cener2">
<div class="col-12">
<h2>Saldo</h2>
<br>
<br>
<br>
<h2>R$ <?php echo $receitas - $despesas;?></h2>
</div>
</div>
</div>
<script>
 function dropdown()
 {
	document.getElementById("sub").style.display = "block"; 
 }
 function dropdown2()
 {
	document.getElementById("sub2").style.display = "block"; 
 }
 function away()
 {
	document.getElementById("sub").style.display = "none";  
 }
  function away2()
 {
	document.getElementById("sub2").style.display = "none";  
 }
</script>
</body>
</html>