<?php
require_once "classes/metodo.php";
$metodo = new metodo();


$cod = $metodo->cod();
$selectcat = $metodo->selectcat();

if(isset($_GET["categoria"]))
{
	if ($cod): foreach($cod as $codigo): $codig = $codigo->codigo;endforeach;endif;
	$metodo->delcat();
	header("location:categoria.php?codigo=".$codig );
}
if(isset($_POST["salvar"]))
{
	if ($cod): foreach($cod as $codigo): $codig = $codigo->codigo;endforeach;endif;
	$metodo->adicionarcat();
	header("location:categoria.php?codigo=".$codig );
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
<li><a href="usuario.php?codigo=<?php if ($cod): foreach($cod as $codigo): echo $codigo->codigo;endforeach;endif; ?>">Home</a></li>
<li onmouseover=dropdown() onmouseout=away() ><a href="">Usuário</a></li>
	<div class="sub" id="sub">
	<ul onmouseover=dropdown() onmouseout=away()>
		<li><a href="altsenha.php?codigo=<?php if ($cod): foreach($cod as $codigo): echo $codigo->codigo;endforeach;endif; ?>">Senha</a></li>
		<li><a href="altdados.php?codigo=<?php if ($cod): foreach($cod as $codigo): echo $codigo->codigo;endforeach;endif; ?>">Dados</a></li>
		<li><a href="login.php">Sair</a></li>
	</ul>
	</div>
<li onmouseover=dropdown2() onmouseout=away2()  class="active"><a href="">Conta</a></li>
	<div class="sub2" id="sub2">
	<ul onmouseover=dropdown2() onmouseout=away2()>
		<li class="active"><a href="">Categorias</a></li>
		<li><a href="conta.php?codigo=<?php if ($cod): foreach($cod as $codigo): echo $codigo->codigo;endforeach;endif; ?>">Conta</a></li>
	</ul>
	</div>
<li><a href="lancamento.php?codigo=<?php if ($cod): foreach($cod as $codigo): echo $codigo->codigo;endforeach;endif; ?>">Lancamento</a></li>
</ul>
</div>
<div class="container left">
<div class="row cener2 bot">
<form action="categoria.php?codigo=<?php if ($cod): foreach($cod as $codigo): echo $codigo->codigo;endforeach;endif; ?>" method="post">
<div class="col-12 top form-group bot">
<h2 id="h">Cadastrar Categoria</h2></div>
<div class="form-group">
    <label for="nomecat" class="col-8">Categoria</label>
    <input class="form-control col-12" type="text" name="nomecat" id="nomecat" placeholder="Ex. Alimentação" required></div>
    <button type="submit" name="salvar" value="salvar" class="btn btn-success col-6 top" required>Salvar</button>
</form>
</div>
<table class="table table-dark bot">
<thead>
	<tr>
		<th>Categoria</th>
	</tr>
</thead>
<tbody>
<?php
if ($selectcat):
foreach ($selectcat as $select) : ?>
<tr>
	<td><?php echo $select->categoria;?></td>
	<td><a href="categoria.php?codigo=<?php if ($cod): foreach($cod as $codigo): echo $codigo->codigo;endforeach;endif; ?>&categoria=<?php echo $select->categoria; ?>" class="btn-outline-danger">Del</a></td>
</tr>
<?php endforeach;?>
<?php else :?>
<tr>
	<td>Nenhuma categoria</td>
</tr>
<?php endif; ?>
</tbody>
</table>
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