<?php
require_once "classes/metodo.php";
$metodo = new metodo();

$cod = $metodo->cod();

if(isset($_POST["salvar"]))
{
	$metodo->alterars();
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
<li class="active" onmouseover=dropdown() onmouseout=away() ><a href="">Usuário</a></li>
	<div class="sub" id="sub">
	<ul onmouseover=dropdown() onmouseout=away()>
		<li class="active"><a href="">Senha</a></li>
		<li><a href="altdados.php?codigo=<?php if ($cod): foreach($cod as $codigo): echo $codigo->codigo;endforeach;endif; ?>">Dados</a></li>
		<li><a href="login.php">Sair</a></li>
	</ul>
	</div>
<li onmouseover=dropdown2() onmouseout=away2() ><a href="">Conta</a></li>
	<div class="sub2" id="sub2">
	<ul onmouseover=dropdown2() onmouseout=away2()>
		<li><a href="categoria.php?codigo=<?php if ($cod): foreach($cod as $codigo): echo $codigo->codigo;endforeach;endif; ?>	">Categorias</a></li>
		<li><a href="conta.php?codigo=<?php if ($cod): foreach($cod as $codigo): echo $codigo->codigo;endforeach;endif; ?>">Conta</a></li>
	</ul>
	</div>
<li><a href="lancamento.php?codigo=<?php if ($cod): foreach($cod as $codigo): echo $codigo->codigo;endforeach;endif; ?>">Lancamento</a></li>
</ul>
</div>
<div class="container center">
<div class="row cener bot">
<form action="altsenha.php?codigo=<?php if ($cod): foreach($cod as $codigo): echo $codigo->codigo;endforeach;endif; ?>" method="post">
<div class="col-12 top">
<h2>Alterar Senha</h2></div>
<div class="col-4 label">   
    <label for="senha">Senha </label>
	<input type="password" name="senha" id="senha" class="top"  required>
</div>
<div class="col-4 label">   
    <label for="senha2">Confirmar senha </label>
	<input type="password" name="senha2" id="senha2" class="top"  required>
</div>
<br>
<button type="submit" name="salvar" value="salvar" class="form-group col-5 btn btn-success">Salvar &nbsp&nbsp<i class="fas fa-user-plus"></i></button>
</div>
</form>
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