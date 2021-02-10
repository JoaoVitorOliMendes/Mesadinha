<?php
session_start();
$log = $_SESSION["id"];
if(!empty ($log))
{
require_once "comandos/class.php";
$comando = new comando();

$selecionarcategoria = $comando->selecionarcategoria();

if(isset($_POST["cat"]))
{
	$comando->salvarcategoria();
}else if(isset($_POST["catego"]))
{
	$comando->alterarcategoria();
}else if(isset($_GET["delcategoria"]))
{
	$comando->deletarcategoria();
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
    <title>Categorias</title>
</head>
<body>
<div class="side">
	<ul class="ul">
	<li><a href="inicial.php">Home</a></li>
	<li><a href="dados.php">Mudar dados</a></li>
	<li><a href="senha.php">Mudar senha</a></li>
	<li><a class="active" href="#">Categoria</a></li>
	<li><a href="conta.php">Conta</a></li>
	<li><a href="movimentacao.php">Lancamento</a></li>
	</ul>
</div>
<div class="main">
	<div class="login row">
		<form action="categoria.php<?php if(isset ($_GET["altcategoria"])){echo "?altcategoria=".$_GET["altcategoria"];}?>" method="post" class="label">
			<div class="col-12 form-group">
				<h1><b>Cadastrar Categoria</b></h1>
			</div>
			<div class="col-12 label">
				<label for="nome">Nome da Categoria</label>
				<input type="text" name="nome" id="nome" class="form-control" value="<?php if(isset ($_GET["altcategoria"])){echo $_GET["altcategoria"];}?>" required>
			</div>
				<button type="submit" name="cat<?php if(isset($_GET["altcategoria"])){echo "ego";}?>" value="cat<?php if(isset($_GET["altcategoria"])){echo "ego";}?>" class="btn btn-outline-secondary col-5">Salvar</button>
				<button onclick="window.location.href='inicial.php'" class="btn btn-outline-secondary col-5">Voltar</button>
		</form>
	
<table class="table table-dark">
	<thead>
		<tr>
			<th>Categoria</th>
		</tr>
	</thead>
	<tbody>
		<?php
			if ($selecionarcategoria):
			foreach ($selecionarcategoria as $sel) : ?>
		<tr>
			<td><?php echo $sel->nome;?></td>
			<td><a href="categoria.php?altcategoria=<?php echo $sel->nome; ?>" class="btn-outline-sucsess">Alt</a></td>
			<td><a href="categoria.php?delcategoria=<?php echo $sel->nome; ?>" class="btn-outline-danger">Del</a></td>
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
</div>
</body>
</html>