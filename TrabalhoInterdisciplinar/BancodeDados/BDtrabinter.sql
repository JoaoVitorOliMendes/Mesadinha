create database mesadinha2;
use mesadinha2;

create table categoria (
categoria varchar(80) not null primary key,
codigo int unsigned not null,
foreign key (codigo) references usuario(codigo)
);

create table conta (
nome varchar(80) not null primary key,
tipo varchar(45) not null,
categoria_conta varchar(80) not null,
foreign key(categoria_conta) references categoria(categoria),
codigo int unsigned not null,
foreign key (codigo) references usuario(codigo)
);

create table usuario  (
codigo int unsigned not null auto_increment primary key,
nome varchar(80) not null,
email varchar(80) not null,
senha varchar (45) not null
);

create table lancamento (
codigolanc int unsigned not null auto_increment primary key,
datalanc date,
valor double (9,2) not null,
nome varchar(80) not null,
codigo int unsigned not null,
foreign key (nome) references conta(nome),
foreign key (codigo) references usuario(codigo)
);

drop table usuario;
select * from usuario;
insert into usuario(codigo,nome,email,senha)values(null,"joao","joao@j","123");
delete from usuario where codigo = 8;

select * from categoria;
drop table categoria;
insert into categoria(categoria)values("banco");
delete from categoria where categoria = "a";

select * from conta;
drop table conta;
delete from conta where nome = "salario";
insert into conta(nome,tipo,categoria_conta)values("sconta","despesa","canco");
insert into conta(nome,tipo,categoria_conta)values("supermercado2","despesa2","banco");

select usuario.codigo,saldo,receitas,despesas from usuario join lancamento on usuario.codigo = lancamento.codigo where usuario.email = "joao@j";

select nome,valor,datalanc,codigolanc from lancamento;
select * from lancamento;
drop table lancamento;
insert into lancamento (codigolanc,datalanc,valor,nome,codigo)values(null,curdate(),925.25,"supermercado",2);
delete from lancamento where codigolanc = 1;

select sum(valor) as valor,tipo,lancamento.codigo,usuario.email from lancamento join conta join usuario on lancamento.nome = conta.nome and lancamento.codigo = usuario.codigo where conta.tipo = 'receita' and usuario.email = "j@ja";
select sum(valor) as valor,tipo,lancamento.codigo,usuario.email from lancamento join conta join usuario on lancamento.nome = conta.nome and lancamento.codigo = usuario.codigo where conta.tipo = 'receita' and usuario.codigo = 5;
select sum(valor) as valor,tipo from lancamento join conta join usuario on lancamento.nome = conta.nome on usuario.codigo = lancamento.codigo where conta.tipo = 'despesa' and usuario.codigo = 4;