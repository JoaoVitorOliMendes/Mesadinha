<?php
require_once "classes/metodo.php";
$metodo = new metodo();

if(isset($_POST["salvar"]))
{
	$metodo->inserir();
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
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.0/css/all.css"
integrity="sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ" crossorigin="anonymous">
<link rel="shortcut icon" href="css/img/logo.png" type="image/x-icon">
    <title>Cadastrar</title>
</head>
<body>
<div class="container center">
<div class="row cener bot">
<form action="cadastro.php" method="post">
<div class="col-12 top">
<h2>Cadastro de Usuário</h2></div>
<div class="col-4 label">
    <label for="nome">Nome </label>
	<input type="text" name="nome" id="nome" class="top" required>
</div>
<div class="col-4 label">
    <label for="tel">Telefone </label>
	<input type="tel" name="tel" class="top" oninput=mascara() maxlength="15" id="t" required>
</div>
<div class="col-4 label">
    <label for="end">Endereco </label>
	<input type="text" name="end" id="end" class="top" required>
</div>
<div class="col-4 label">
    <label for="email">E-mail </label>
	<input type="email" name="email" id="email" class="top" required>
</div>
<div class="col-4 label">   
    <label for="senha">Senha </label>
	<input type="password" name="senha" id="senha" class="top"  required>
</div>
<br>
<button type="submit" name="salvar" value="salvar" class="form-group col-5 btn btn-success">Salvar &nbsp&nbsp<i class="fas fa-user-plus"></i></button>
<button onclick="window.location.href='login.php'" class="form-group col-5 btn btn-primary">Voltar &nbsp&nbsp<i class="fas fa-long-arrow-alt-left"></i></button>
</div>
</form>
</div>
	<script>
	
	function mascara()
	{
		var tel_f = document.getElementById("t").value;
	
		console.log(tel_f);
	
		if (tel_f[0]!="(")
		{
			if (tel_f[0]!=undefined)
			{
				document.getElementById("t").value = "("+tel_f[0];
			}
		}
		if (tel_f[3]!=")")
		{
			if (tel_f[3]!=undefined)
			{
				document.getElementById("t").value = tel_f.slice(0,3)+")"+'\xa0'+tel_f[3];
			}
		}
		if (tel_f[10]!="-")
		{
			if (tel_f[10]!=undefined)
			{
				document.getElementById("t").value = tel_f.slice(0,10)+"-"+tel_f[10];
			}
		}
	}
	
	</script>
</body>
</html>