<?php
session_start();
$log = $_SESSION["id"];
if(!empty ($log))
{
require_once "comandos/class.php";
$comando = new comando();

$selecionarlanc = $comando->selecionarlanc();
$selecionarconta = $comando->selecionarconta();

if(isset($_POST["lanc"]))
{
	$comando->salvarlanc();
}else if(isset($_POST["lancamento"]))
{
	$comando->alterarlanc();
}else if(isset($_GET["dellanc"]))
{
	$comando->deletarlanc();
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
	<li><a href="conta.php">Conta</a></li>
	<li><a class="active" href="">Lancamento</a></li>
	</ul>
</div>
<div class="main">
	<div class="login row">
		<form action="movimentacao.php<?php if(isset ($_GET["altlanc"])){echo "?altlanc=".$_GET["altlanc"];}?>" method="post" class="label">
			<div class="col-12 form-group">
				<h1><b>Lançamentos</b></h1>
			</div>
			<div class="col-12 label">
				<label for="quant">Quantia</label>
				<input type="text" name="quant" id="quant" class="form-control" value="<?php if(isset($_GET["altlanc"])){$selecionarlanc2 = $comando->selecionarlanc2();if($selecionarlanc2):foreach($selecionarlanc2 as $sel):echo $sel->quantia;endforeach;endif;} ?>" required>
			</div>
			<div class="col-12 label">
				<label for="con">Conta</label>
				<select name="con" id="con" required>
				<?php if($selecionarconta):foreach($selecionarconta as $sel):?>
					<option value="<?php echo $sel->descricao;?>"><?php echo $sel->descricao; ?></option>
				<?php endforeach;endif; ?>
				</select></div>
				<button type="submit" name="lanc<?php if(isset($_GET["altlanc"])){echo "amento";}?>" value="lanc<?php if(isset($_GET["altlanc"])){echo "amento";}?>" class="btn btn-outline-secondary col-5">Salvar</button>
				<button onclick="window.location.href='inicial.php'" class="btn btn-outline-secondary col-5">Voltar</button>
		</form>
	
<table class="table table-dark">
	<thead>
		<tr>
			<th>Data</th>
			<th>Quantia</th>
			<th>Conta</th>
		</tr>
	</thead>
	<tbody>
		<?php
			if ($selecionarlanc):
			foreach ($selecionarlanc as $sel) : ?>
		<tr>
			<td><?php echo $sel->dia;?></td>
			<td><?php echo $sel->quantia;?></td>
			<td><?php echo $sel->contadescricao;?></td>
			<td><a href="movimentacao.php?altlanc=<?php echo $sel->id; ?>" class="btn-outline-sucsess">Alt</a></td>
			<td><a href="movimentacao.php?dellanc=<?php echo $sel->id; ?>" class="btn-outline-danger">Del</a></td>
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