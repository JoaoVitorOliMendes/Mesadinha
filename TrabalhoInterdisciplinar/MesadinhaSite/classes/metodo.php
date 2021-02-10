<?php

require_once "conexao.php";

class metodo
{
public $codigo;
public $nome;
public $email;
public $senha;
public $saldo;
public $receita;
public $receita2;
public $despesa;
public $despesa2;
public $tipo;
public $nomecot;
public $nomecat;
public $valor;
	
	public function validar()
	{
		try{
			$this->email = $_POST["email"];
			$this->senha = $_POST["senha"];
			
			$bd = new conexao();
			$con = $bd->conectar();
			$sql = $con->prepare("select * from usuario where email = ? and senha = ?;");
			$sql->execute(array(
			$this->email,
			$this->senha
			));
			
			if ($sql->rowCount()>0)
			{
				echo "<script>alert('Bem Vindo')</script>";
			}else{
				header("location:login.php");
				echo "<script>alert('Não foi possível logar')</script>";
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível logar2: ".$msg->getMessage();
		}
	}
	public function inserir()
	{
		try
		{
			
			if (isset($_POST["nome"]) && isset($_POST["email"]))
			{
				$this->nome = $_POST["nome"];
				$this->email = $_POST["email"];
				$this->senha = $_POST["senha"];
				
				$bd = new conexao();
				$con = $bd->conectar();
				$sql = $con->prepare("insert into usuario(codigo,nome,email,senha)
				values(null,?,?,?);");
				$sql->execute(array(
				$this->nome,
				$this->email,
				$this->senha
				));
				if ($sql->rowCount()>0)
					{
						header("location:login.php");
					}
				else
					{
						header("location:naodeu");
					}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível inserir: ".$msg->getMessage();
		}
	}
	public function deletar($matricula)
	{

		try
		{
			
			if (isset($matricula))
			{
				$this->matricula = $matricula;
				
				$bd = new conexao();
				$con = $bd->conectar();
				$sql = $con->prepare("delete from alunos where MATRICULA = ?");
				$sql->execute(array(
				$this->matricula
				));
				if ($sql->rowCount()>0)
					{
						header("location:testeconexao.php");
					}
				else
				{
					header("location:naodeu");
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível deletar o aluno: ".$msg->getMessage();
		}
	}
	public function alterard()
	{
		try
		{
			
			if (isset($_POST["salvar"]))
			{
				$this->codigo = $_GET["codigo"];
				$this->nome = $_POST["nome"];
				$this->email = $_POST["email"];
				
				$bd = new conexao();
				$con = $bd->conectar();
				$sql = $con->prepare("update usuario set nome = ?,email = ?
				where codigo = ?;");
				$sql->execute(array(
				$this->nome,
				$this->email,
				$this->codigo
				));
				if ($sql->rowCount()>0)
					{
						header("location:usuario.php?codigo=".$this->codigo);
					}
				else
				{
					header("location:naodeu");
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível alterar o aluno: ".$msg->getMessage();
		}
	}
	public function sald()
	{
		try{
			$this->email = $_POST["email"];
			$bd = new conexao();
			$con = $bd->conectar();
			$sql = $con->prepare("select * from usuario where email = ?;");
			$sql->execute(array($this->email));
			
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				echo "<script>alert('Não foi possível selecionar o saldo')</script>";
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível selecionar o sald: ".$msg->getMessage();
		}
	}
	public function sald2()
	{
		try{
			$this->codigo = $_GET["codigo"];
			$bd = new conexao();
			$con = $bd->conectar();
			$sql = $con->prepare("select * from usuario where codigo = ?;");
			$sql->execute(array($this->codigo));
			
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				echo "<script>alert('Não foi possível selecionar o saldo')</script>";
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível selecionar o sald: ".$msg->getMessage();
		}
	}
	public function saldo()
	{
		try{
			$this->email = $_POST["email"];
			$bd = new conexao();
			$con = $bd->conectar();
			$sql = $con->prepare("select sum(valor) as valor,tipo,lancamento.codigo,usuario.email from lancamento join conta join usuario on lancamento.nome = conta.nome and lancamento.codigo = usuario.codigo where conta.tipo = 'despesa' and usuario.email = ?;");
			$sql->execute(array($this->email));
			
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				echo "<script>alert('Não foi possível selecionar o saldo')</script>";
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível selecionar o sald: ".$msg->getMessage();
		}
	}
	public function receita()
	{
		try{
			$this->email = $_POST["email"];
			$bd = new conexao();
			$con = $bd->conectar();
			$sql = $con->prepare("select sum(valor) as valor,tipo,lancamento.codigo,usuario.email from lancamento join conta join usuario on lancamento.nome = conta.nome and lancamento.codigo = usuario.codigo where conta.tipo = 'receita' and usuario.email = ?;");
			$sql->execute(array($this->email));
			
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				echo "<script>alert('Não foi possível selecionar o saldo')</script>";
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível selecionar o sald: ".$msg->getMessage();
		}
	}
	public function saldo2()
	{
		try{
			$this->codigo = $_GET["codigo"];
			$bd = new conexao();
			$con = $bd->conectar();
			$sql = $con->prepare("select sum(valor) as valor,tipo,lancamento.codigo,usuario.email from lancamento join conta join usuario on lancamento.nome = conta.nome and lancamento.codigo = usuario.codigo where conta.tipo = 'despesa' and usuario.codigo = ?;");
			$sql->execute(array($this->codigo));
			
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				echo "<script>alert('Não foi possível selecionar o saldo')</script>";
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível selecionar o sald: ".$msg->getMessage();
		}
	}
	public function receita2()
	{
		try{
			$this->codigo = $_GET["codigo"];
			$bd = new conexao();
			$con = $bd->conectar();
			$sql = $con->prepare("select sum(valor) as valor,tipo,lancamento.codigo,usuario.email from lancamento join conta join usuario on lancamento.nome = conta.nome and lancamento.codigo = usuario.codigo where conta.tipo = 'receita' and usuario.codigo = ?;");
			$sql->execute(array($this->codigo));
			
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				echo "<script>alert('Não foi possível selecionar o saldo')</script>";
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível selecionar o sald: ".$msg->getMessage();
		}
	}
	public function cod()
	{
		try{
			$this->codigo = $_GET["codigo"];
				
			$bd = new conexao();
			$con = $bd->conectar();
			$sql = $con->prepare("select * from usuario where codigo = ?;");
			$sql->execute(array(
			$this->codigo
			));
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				echo "<script>alert('Não foi possível achar o codigo')</script>";
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível achar o codigo: ".$msg->getMessage();
		}
	}
	public function alterars()
	{
		try
		{
			if(isset($_POST["senha"]) && $_POST["senha"] == $_POST["senha2"])
			{
				$this->codigo = $_GET["codigo"];
				$this->senha = $_POST["senha"];
				
				$bd = new conexao();
				$con = $bd->conectar();
				$sql = $con->prepare("update usuario set senha = ?
				where codigo = ?;");
				$sql->execute(array(
				$this->senha,
				$this->codigo
				));
				if ($sql->rowCount()>0)
					{
						header("location:usuario.php?codigo=".$this->codigo);
					}
				else
				{
					header("location:naodeu");
				}
			}
		}
		catch(PDOException $msg)
		{
			echo "Não foi possível alterar a senha: ".$msg->getMessage();
		}
	}
	public function adicionarcat()
	{
		try
		{
			if (isset($_POST["nomecat"]))
				{
				$this->nomecat = $_POST["nomecat"];
				$this->codigo = $_GET["codigo"];
					
				$bd = new conexao();
				$con = $bd->conectar();
				$sql = $con->prepare("insert into categoria(categoria,codigo) value (?,?);");
				$sql->execute(array(
				$this->nomecat,
				$this->codigo
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('Categoria adicionada!')</script>";
					}
				else
					{
						header("location:naodeu");
					}
				}
		}catch(PDOException $msg)
		{
			echo "Não foi possível alterar os dados: ".$msg->getMessage();
		}
	}
	public function selectcat()
	{
		try{
			$this->codigo = $_GET["codigo"];
			
			$bd = new conexao();
			$con = $bd->conectar();
			$sql = $con->prepare("select * from categoria where codigo = ?");
			$sql->execute(array($this->codigo));
			
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				echo "<script>alert('Nenhuma categoria')</script>";
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível selecionar a cat: ".$msg->getMessage();
		}
	}
	public function delcat()
	{
		try
		{
			if (isset($_GET["categoria"]))
			{
				$this->nomecat = $_GET["categoria"];
				
				$bd = new conexao();
				$con = $bd->conectar();
				$sql = $con->prepare("delete from categoria where categoria = ?");
				$sql->execute(array(
				$this->nomecat
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('Categoria deletada')</script>";
					}
				else
				{
					header("location:naodeu");
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível deletar a categoria: ".$msg->getMessage();
		}
	}
	public function adicionarcot()
	{
		try
		{
			if (isset($_POST["nomecot"]))
				{
				$this->nomecot = $_POST["nomecot"];
				$this->tipo = $_POST["tipo"];
				$this->nomecat = $_POST["nomecat"];
				$this->codigo = $_GET["codigo"];
					
				$bd = new conexao();
				$con = $bd->conectar();
				$sql = $con->prepare("insert into conta(nome,tipo,categoria_conta,codigo)values(?,?,?,?);");
				$sql->execute(array(
				$this->nomecot,
				$this->tipo,
				$this->nomecat,
				$this->codigo
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('Conta adicionada!')</script>";
					}
				else
					{
						header("location:naodeu");
					}
				}
		}catch(PDOException $msg)
		{
			echo "Não foi possível alterar a conta: ".$msg->getMessage();
		}
	}
	public function selectcot()
	{
		try{
			$this->codigo = $_GET["codigo"];
			$bd = new conexao();
			$con = $bd->conectar();
			$sql = $con->prepare("select * from conta where codigo = ?");
			$sql->execute(array($this->codigo));
			
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				echo "<script>alert('Nenhuma conta')</script>";
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível selecionar a conta: ".$msg->getMessage();
		}
	}
	public function delcot()
	{
		try
		{
			if (isset($_GET["nomecot"]))
			{
				$this->nomecot = $_GET["nomecot"];
				
				$bd = new conexao();
				$con = $bd->conectar();
				$sql = $con->prepare("delete from conta where nome = ?");
				$sql->execute(array(
				$this->nomecot
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('Conta deletada')</script>";
					}
				else
				{
					header("location:naodeu");
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível deletar a categoria: ".$msg->getMessage();
		}
	}
	public function adicionarlanc()
	{
		try
		{
			if (isset($_POST["nomecot"]) && !empty($_POST["nomecot"]))
				{
				$this->nomecot = $_POST["nomecot"];
				$this->valor = $_POST["valor"];
				$this->codigo = $_GET["codigo"];
					
				$bd = new conexao();
				$con = $bd->conectar();
				$sql = $con->prepare("insert into lancamento (codigolanc,datalanc,valor,nome,codigo)values(null,curdate(),?,?,?);");
				$sql->execute(array(
				$this->valor,
				$this->nomecot,
				$this->codigo
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('Lancamento adicionado')</script>";
					}
				else
					{
						header("location:naodeu");
					}
				}
		}catch(PDOException $msg)
		{
			echo "Não foi possível alterar a conta: ".$msg->getMessage();
		}
	}
	public function selectlanc()
	{
		try{
			$this->codigo = $_GET["codigo"];
			
			$bd = new conexao();
			$con = $bd->conectar();
			$sql = $con->prepare("select nome,valor,datalanc,codigolanc from lancamento where codigo = ?");
			$sql->execute(array($this->codigo));
			
			if ($sql->rowCount()>0)
			{
				return $result = $sql->fetchAll(PDO::FETCH_CLASS);
			}else{
				echo "<script>alert('Nenhum lancamento')</script>";
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível selecionar a conta: ".$msg->getMessage();
		}
	}
	public function dellanc($codigolanc)
	{
		try
		{
			if (isset($codigolanc))
			{
				$this->codigo = $codigolanc;
				
				$bd = new conexao();
				$con = $bd->conectar();
				$sql = $con->prepare("delete from lancamento where codigolanc = ?");
				$sql->execute(array(
				$this->codigo
				));
				if ($sql->rowCount()>0)
					{
						echo "<script>alert('lancamento deletado')</script>";
					}
				else
				{
					header("location:naodeu");
				}
			}
		}catch(PDOException $msg)
		{
			echo "Não foi possível deletar a categoria: ".$msg->getMessage();
		}
	}
}
?>