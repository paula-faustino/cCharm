drop database if exists trabaio;
create database trabaio;
use trabaio;

create table if not exists produtos
( cod_prod int auto_increment primary key,
nome_prod varchar (20),
tipo_prod varchar(20),
peso_prod decimal (10,2), 
preco_unitario decimal (10,2),
validade_prod date);

select * from produtos;



create table if not exists fornecedor 
( id_forn int auto_increment primary key,
nome_forn varchar (20),
cnpj_forn varchar (14),
tel_forn varchar (11),
email_forn varchar (16),
endereco_forn varchar (60));
select* from fornecedor ;

CREATE TABLE IF NOT EXISTS materiais 
(
  cod_mat INT AUTO_INCREMENT PRIMARY KEY,
  nome_mat VARCHAR(20),
  validade_mat DATE,
  fornecedor_id INT,
  qtd_estoque DECIMAL(10,2),
  FOREIGN KEY (fornecedor_id) REFERENCES fornecedor(id_forn)
);

select * from materiais;

create table if not exists receitas
(id_rec int primary key,
produtos_id int,
materiais_id int,
quantidade_rec decimal (10,2));

create table if not exists cargos 
( id_carg int primary key,
setor_carg varchar (20),
horas_carg time,
nome_carg varchar (20));

create table if not exists funcionario
( id_func int auto_increment primary key,
nome_func varchar (200),
cpf_func varchar (11),
sexo_func varchar (14),
cargo_func varchar (20),
tel_func varchar (11),
endereco_func varchar (60),
data_func date default CURRENT_DATE,
salario_func int,
cargos_id int);

select*from funcionario;

create table if not exists producao
( id_prod int primary key,
data_prod date,
qtd_prod int,
produtos_id int,
responsavel_id int);

create table if not exists clientes 
( id_cliente int primary key ,
nome_cli varchar (45),
cpf_cli varchar (11),
sexo_cli varchar (14),
tel_cli varchar (11),
endereco_cli varchar (60));

insert into clientes values 
(1,'jose',12345678901,12345678901234,123456789,'rua jose zara');

SHOW COLUMNS FROM clientes;


CREATE TABLE IF NOT EXISTS vendas (
  id_vend INT AUTO_INCREMENT PRIMARY KEY,
  cod_prod INT,
  data_vend DATE,
  cliente_id INT,
  valor_vend DECIMAL(10,2),
  FOREIGN KEY (cod_prod) REFERENCES produtos(cod_prod),
  FOREIGN KEY (cliente_id) REFERENCES clientes(id_cliente)
);


select * from vendas;

CREATE TABLE IF NOT EXISTS venda_produtos (
  id_venda_prod INT AUTO_INCREMENT PRIMARY KEY,
  id_vend INT,
  id_prod INT,
  quantidade INT,
  preco_unitario DECIMAL(10,2),
  FOREIGN KEY (id_vend) REFERENCES vendas(id_vend),
  FOREIGN KEY (id_prod) REFERENCES produtos(id_prod)
);


create table if not exists item_venda 
( id_item int primary key,
qtd_item int,
preco_uni_item decimal (10,2),
produtos_id int,
vendas_id int);


SHOW CREATE TABLE clientes;
select*from clientes 

