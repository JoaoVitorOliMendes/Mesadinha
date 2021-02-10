<?php


class conexaobd
{
	private $servidor;
	private $banco;
	private $usuario;
	private $senha;
	
	
	
	
	
	function __construct()
	{
		$this->servidor = "localhost";
		$this->banco = "trabalhointer";
		$this->usuario = "root";
		$this->senha = "";
		
	}
	
	public function funcaocon()
	{
		try{
		$con = new PDO("mysql:host={$this->servidor};dbname={$this->banco};charset=utf8;",$this->usuario, $this->senha);
		return $con;
		}catch(PDOException $msg){
			echo "Conexão errada {$msg->getMessage()}";
		}
	}
	
	
	
	
	
}


?>