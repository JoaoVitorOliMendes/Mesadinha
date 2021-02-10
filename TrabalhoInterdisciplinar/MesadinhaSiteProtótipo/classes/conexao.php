<?php


class conexao
{
	private $servidor;
	private $banco;
	private $usuario;
	private $senha;
	
	
	
	
	
	function __construct()
	{
		$this->servidor = "localhost:33061";
		$this->banco = "mesadinha2";
		$this->usuario = "root";
		$this->senha = "julimary2019";
		
	}
	
	public function conectar()
	{
		try{
		$con = new PDO("mysql:host={$this->servidor};dbname={$this->banco};charset=utf8;",$this->usuario, $this->senha);
		return $con;
		}catch(PDOException $msg){
			echo "errrrororororo {$msg->getMessage()}";
		}
	}
	
	
	
	
	
}


?>