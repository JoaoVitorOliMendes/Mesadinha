<?php
session_start();
$log = $_SESSION["id"];
if(!empty ($log))
{
require_once "comandos/class.php";
$comando = new comando();

$selecionarconta = $comando->selecionarconta();
$selecionarcategoria = $comando->selecionarcategoria();

if(isset($_POST["con"]))
{
	$comando->salvarconta();
}else if(isset($_POST["conta"]))
{
	$comando->alterarconta();
}else if(isset($_GET["delconta"]))
{
	$comando->deletarconta();
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
	<li><a href="categoria.php">Categoria</a></li>
	<li><a class="active" href="">Conta</a></li>
	<li><a href="movimentacao.php">Lancamento</a></li>
	</ul>
</div>
<div class="main">
	<div class="login row">
		<form action="conta.php<?php if(isset ($_GET["altconta"])){echo "?altconta=".$_GET["altconta"];}?>" method="post" class="label">
			<div class="col-12 form-group">
				<h1><b>Cadastrar Conta</b></h1>
			</div>
			<div class="col-12 label">
				<label for="descricao">Nome da Conta</label>
				<input type="text" name="descricao" id="descricao" class="form-control" value="<?php if(isset ($_GET["altconta"])){echo $_GET["altconta"];}?>" required>
			</div>
			<div class="col-12 label">
				<label for="tipo">Tipo</label>
				<select name="tipo" id="tipo" required>
					<option value="receita">Receita</option>
					<option value="despesa">Despesa</option>
				</select></div>
			<div class="col-12 label">
				<label for="cat">Categoria</label>
				<select name="cat" id="cat" required>
				<?php if($selecionarcategoria):foreach($selecionarcategoria as $sel):?>
					<option value="<?php echo $sel->nome;?>"><?php echo $sel->nome; ?></option>
				<?php endforeach;endif; ?>
				</select></div>
				<button type="submit" name="con<?php if(isset($_GET["altconta"])){echo "ta";}?>" value="con<?php if(isset($_GET["altconta"])){echo "ta";}?>" class="btn btn-outline-secondary col-5">Salvar</button>
				<button onclick="window.location.href='inicial.php'" class="btn btn-outline-secondary col-5">Voltar</button>
		</form>
	
<table class="table table-dark">
	<thead>
		<tr>
			<th>Conta</th>
			<th>Tipo</th>
			<th>Categoria</th>
		</tr>
	</thead>
	<tbody>
		<?php
			if ($selecionarconta):
			foreach ($selecionarconta as $sel) : ?>
		<tr>
			<td><?php echo $sel->descricao;?></td>
			<td><?php echo $sel->tipo;?></td>
			<td><?php echo $sel->categorianome;?></td>
			<td><a href="conta.php?altconta=<?php echo $sel->descricao; ?>" class="btn-outline-sucsess">Alt</a></td>
			<td><a href="conta.php?delconta=<?php echo $sel->descricao; ?>" class="btn-outline-danger">Del</a></td>
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