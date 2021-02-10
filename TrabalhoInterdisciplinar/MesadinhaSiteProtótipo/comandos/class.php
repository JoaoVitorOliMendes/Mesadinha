<?php

require_once "conectar.php";

class comando
{

public $id;
public $nome;
public $telefone;
public $endereco;
public $email;
public $senha;	
public $descricao;
public $tipo;
public $quant;
public $categoria;
	
	public function login()
	{
		try{
		$this->email = $_POST["email"];
		$this->senha = $_POST["senha"];
		$bd = new conexaobd();
		$con = $bd->funcaocon();
		$sql = $con->prepare("select * from cliente where email = ? and senha = ?;");
		$sql->execute(array(
		$this->email,
		$this->senha));
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				header("location:index.php");
				echo "<script> alert('E-mail ou Senha incorreto(s)') </script>";
		        session_unset();
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível fazer o login: ".$msg->getMessage();
		}
	}
	public function cadastrar()
	{
		try
		{
			if (isset($_POST["nome"]))
			{
				$this->nome = $_POST["nome"];
				$this->telefone = $_POST["telefone"];
				$this->endereco = $_POST["endereco"];
				$this->email = $_POST["email"];
				$this->senha = $_POST["senha"];
						$bd = new conexaobd();
						$con = $bd->funcaocon();
						$sql = $con->prepare("insert into cliente(id,nome,telefone,endereco,email,senha,saldo) values(null,?,?,?,?,?,null);");
						$sql->execute(array(
						$this->nome,
						$this->telefone,
						$this->endereco,
						$this->email,
						$this->senha
						));
					if ($sql->rowCount()>0)
					{
						header("location:index.php");
					}
					else
					{
						echo "naodeu";
					}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível cadastrar: ".$msg->getMessage();
		}
	}
	public function selecionardados()
	{
		try{
		$this->id = $_SESSION["id"];
		
		$bd = new conexaobd();
		$con = $bd->funcaocon();
		$sql = $con->prepare("select * from cliente where id = ?;");
		$sql->execute(array(
		$this->id));
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				header("location:index.php");
				session_unset();
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível fazer o login: ".$msg->getMessage();
		}
	}
	public function alterardados()
	{
		try
		{
			
			if (isset($_POST["cad"]))
			{
				$this->id = $_SESSION["id"];
				$this->nome = $_POST["nome"];
				$this->telefone = $_POST["telefone"];
				$this->endereco = $_POST["endereco"];
				$this->email = $_POST["email"];
				
				$bd = new conexaobd();
				$con = $bd->funcaocon();
				$sql = $con->prepare("update cliente set nome = ?,telefone = ?,endereco = ?,email = ?
				where id = ?;");
				$sql->execute(array(
				$this->nome,
				$this->telefone,
				$this->endereco,
				$this->email,
				$this->id
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('alterado com sucesso!')</script>";
						header("location:dados.php");
					}
				else
				{
					header("location:naodeu");
					session_unset();
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível alterar os dados: ".$msg->getMessage();
		}
	}
	public function alterarsenha()
	{
		try
		{
			
			if (isset($_POST["sen"]))
			{
				$this->id = $_SESSION["id"];
				$this->senha = $_POST["senha"];
				
				$bd = new conexaobd();
				$con = $bd->funcaocon();
				$sql = $con->prepare("update cliente set senha = ?
				where id = ?;");
				$sql->execute(array(
				$this->senha,
				$this->id
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('alterado com sucesso!')</script>";
						header("location:senha.php");
					}
				else
				{
					header("location:naodeu");
					session_unset();
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível alterar a senha: ".$msg->getMessage();
		}
	}
	public function selecionarcategoria()
	{
		try{
		$this->id = $_SESSION["id"];
		
		$bd = new conexaobd();
		$con = $bd->funcaocon();
		$sql = $con->prepare("select nome from categoria;");
		$sql->execute();
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				echo "<script>alert('Nenhuma categoria!')</script>";
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível achar as categorias: ".$msg->getMessage();
		}
	}
	public function alterarcategoria()
	{
		try
		{
			
			if (isset($_POST["catego"]))
			{
				$this->categoria = $_GET["altcategoria"];
				$this->nome = $_POST["nome"];
				
				$bd = new conexaobd();
				$con = $bd->funcaocon();
				$sql = $con->prepare("update categoria set nome = ? where nome = ?;");
				$sql->execute(array(
				$this->nome,
				$this->categoria
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('alterado com sucesso!')</script>";
						header("location:categoria.php");
					}
				else
				{
					echo "<script>alert('Você deve excluir a conta com esta categoria antes de alterala.')</script>";
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível alterar os dados: ".$msg->getMessage();
		}
	}
	public function deletarcategoria()
	{
		try
		{
			
			if (isset($_GET["delcategoria"]))
			{
				$this->id = $_SESSION["id"];
				$this->nome = $_GET["delcategoria"];
				
				$bd = new conexaobd();
				$con = $bd->funcaocon();
				$sql = $con->prepare("delete from categoria where nome = ?;");
				$sql->execute(array(
				$this->nome
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('deletado com sucesso!')</script>";
						header("location:categoria.php");
					}
				else
				{
					echo "<script>alert('Não foi possivel deletar a categoria, já tem uma conta ou lançamento cadastrado!')</script>";
				
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível alterar os dados: ".$msg->getMessage();
		}
	}
	public function salvarcategoria()
	{
		try
		{
			
			if (isset($_POST["cat"]))
			{
				$this->id = $_SESSION["id"];
				$this->nome = $_POST["nome"];
				
				$bd = new conexaobd();
				$con = $bd->funcaocon();
				$sql = $con->prepare("insert into categoria(nome) value(?);");
				$sql->execute(array(
				$this->nome
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('adicionado com sucesso!')</script>";
						header("location:categoria.php##");
					}
				else
				{
					header("location:naodeu");
					session_unset();
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível alterar os dados: ".$msg->getMessage();
		}
	}
	public function selecionarconta()
	{
		try{
		$this->id = $_SESSION["id"];
		
		$bd = new conexaobd();
		$con = $bd->funcaocon();
		$sql = $con->prepare("select * from conta;");
		$sql->execute();
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				echo "<script>alert('Nenhuma conta!')</script>";
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível achar as contas: ".$msg->getMessage();
		}
	}
	public function alterarconta()
	{
		try
		{
			
			if (isset($_POST["conta"]))
			{
				$this->id = $_GET["altconta"];
				$this->descricao = $_POST["descricao"];
				$this->tipo = $_POST["tipo"];
				$this->nome = $_POST["cat"];
				
				$bd = new conexaobd();
				$con = $bd->funcaocon();
				$sql = $con->prepare("update conta set descricao = ?, tipo = ?, categorianome = ? where descricao = ?;");
				$sql->execute(array(
				$this->descricao,
				$this->tipo,
				$this->nome,
				$this->id
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('alterado com sucesso!')</script>";
						header("location:conta.php");
					}
				else
				{
					echo "<script>alert('Você deve excluir o lancamento com esta conta antes de alterala.')</script>";
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível alterar os dados: ".$msg->getMessage();
		}
	}
	public function deletarconta()
	{
		try
		{
			
			if (isset($_GET["delconta"]))
			{
				$this->id = $_SESSION["id"];
				$this->descricao = $_GET["delconta"];
				
				$bd = new conexaobd();
				$con = $bd->funcaocon();
				$sql = $con->prepare("delete from conta	where descricao = ?;");
				$sql->execute(array(
				$this->descricao
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('deletado com sucesso!')</script>";
						header("location:conta.php");
					}
				else
				{
					echo "<script>alert('Não foi possivel deletar a conta, já tem um lançamento cadastrado!')</script>";
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível alterar os dados: ".$msg->getMessage();
		}
	}
	public function salvarconta()
	{
		try
		{
			
			if (isset($_POST["con"]))
			{
				$this->id = $_SESSION["id"];
				$this->descricao = $_POST["descricao"];
				$this->tipo = $_POST["tipo"];
				$this->nome = $_POST["cat"];
				
				$bd = new conexaobd();
				$con = $bd->funcaocon();
				$sql = $con->prepare("insert into conta(descricao,tipo,categorianome) values(?,?,?);");
				$sql->execute(array(
				$this->descricao,
				$this->tipo,
				$this->nome
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('adicionado com sucesso!')</script>";
						header("location:conta.php");
					}
				else
				{
					header("location:naodeu");
					session_unset();
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível alterar os dados: ".$msg->getMessage();
		}
	}
	public function selecionarlanc()
	{
		try{
		$this->id = $_SESSION["id"];
		
		$bd = new conexaobd();
		$con = $bd->funcaocon();
		$sql = $con->prepare("select * from movimentacao where clienteid = ?;");
		$sql->execute(array($this->id));
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				echo "<script>alert('Nenhum lancamento!')</script>";
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível achar os lançamentos: ".$msg->getMessage();
		}
	}
	public function alterarlanc()
	{
		try
		{
			
			if (isset($_POST["lancamento"]))
			{
				$this->id = $_GET["altlanc"];
				$this->quant = $_POST["quant"];
				$this->descricao = $_POST["con"];
				
				$bd = new conexaobd();
				$con = $bd->funcaocon();
				$sql = $con->prepare("update movimentacao set quantia = ?, dia = curdate(), contadescricao = ? where id = ?;");
				$sql->execute(array(
				$this->quant,
				$this->descricao,
				$this->id
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('alterado com sucesso!')</script>";
						header ("location:movimentacao.php");
					}
				else
				{
					echo "<script>alert('erro')</script>";
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível alterar os dados: ".$msg->getMessage();
		}
	}
	public function deletarlanc()
	{
		try
		{
			
			if (isset($_GET["dellanc"]))
			{
				$this->id = $_GET["dellanc"];
				
				$bd = new conexaobd();
				$con = $bd->funcaocon();
				$sql = $con->prepare("delete from movimentacao where id = ?;");
				$sql->execute(array(
				$this->id
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('deletado com sucesso!')</script>";
						header("location:movimentacao.php");
					}
				else
				{
					echo "<script>alert('Não foi possivel deletar!')</script>";
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível alterar os dados: ".$msg->getMessage();
		}
	}
	public function salvarlanc()
	{
		try
		{
			
			if (isset($_POST["lanc"]))
			{
				$this->id = $_SESSION["id"];
				$this->quant = $_POST["quant"];
				$this->descricao = $_POST["con"];
				
				$bd = new conexaobd();
				$con = $bd->funcaocon();
				$sql = $con->prepare("insert into movimentacao(id,contadescricao,clienteid,dia,quantia) values(null,?,?,curdate(),?);");
				$sql->execute(array(
				$this->descricao,
				$this->id,
				$this->quant
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('adicionado com sucesso!')</script>";
						header("location:movimentacao.php");
					}
				else
				{
					
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível alterar os dados: ".$msg->getMessage();
		}
	}
	public function receita()
	{
		try{
		$this->email = $_POST["email"];
		
		$bd = new conexaobd();
		$con = $bd->funcaocon();
		$sql = $con->prepare("select sum(quantia) as receitass,tipo,movimentacao.clienteid,cliente.email from movimentacao join conta join cliente on conta.descricao = movimentacao.contadescricao and cliente.id = movimentacao.clienteid where conta.tipo = 'receita' and cliente.email = ?;");
		$sql->execute(array($this->email));
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				header("location:index.php");
				session_unset();
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível achar os lançamentos: ".$msg->getMessage();
		}
	}
	public function despesa()
	{
		try{
		$this->email = $_POST["email"];
		
		$bd = new conexaobd();
		$con = $bd->funcaocon();
		$sql = $con->prepare("select sum(quantia) as despesass,tipo,movimentacao.clienteid,cliente.email from movimentacao join conta join cliente on conta.descricao = movimentacao.contadescricao and cliente.id = movimentacao.clienteid where conta.tipo = 'despesa' and cliente.email = ?;");
		$sql->execute(array($this->email));
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				header("location:index.php");
				session_unset();
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível achar os lançamentos: ".$msg->getMessage();
		}
	}
		public function receita2()
	{
		try{
		$this->id = $_SESSION["id"];
		
		$bd = new conexaobd();
		$con = $bd->funcaocon();
		$sql = $con->prepare("select sum(quantia) as receitass,tipo,movimentacao.clienteid,cliente.email from movimentacao join conta join cliente on conta.descricao = movimentacao.contadescricao and cliente.id = movimentacao.clienteid where conta.tipo = 'receita' and cliente.id = ?;");
		$sql->execute(array($this->id));
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				header("location:index.php");
				session_unset();
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível achar os lançamentos: ".$msg->getMessage();
		}
	}
	public function despesa2()
	{
		try{
		$this->id = $_SESSION["id"];
		
		$bd = new conexaobd();
		$con = $bd->funcaocon();
		$sql = $con->prepare("select sum(quantia) as despesass,tipo,movimentacao.clienteid,cliente.email from movimentacao join conta join cliente on conta.descricao = movimentacao.contadescricao and cliente.id = movimentacao.clienteid where conta.tipo = 'despesa' and cliente.id = ?;");
		$sql->execute(array($this->id));
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				header("location:index.php");
				session_unset();
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível achar os lançamentos: ".$msg->getMessage();
		}
	}
	public function selecionarlanc2()
	{
		try{
				$this->id = $_GET["altlanc"];
				
				$bd = new conexaobd();
				$con = $bd->funcaocon();
				$sql = $con->prepare("select * from movimentacao where id = ?;");
				$sql->execute(array($this->id));
					if ($sql->rowCount()>0)
					{
					return $result = $sql->fetchAll(PDO::FETCH_CLASS);
					}else{
					echo "deu nao";
					}
		}catch(PDOException $msg)
		{
			echo "Não foi possível achar os lançamentos: ".$msg->getMessage();
		}
	}
}
?>