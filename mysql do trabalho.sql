create database trabalho;
use trabalho;

create table if not exists produtos
( cod_prod int primary key,
nome_prod varchar (255),
tipo_prod decimal (10.2),
peso_prod decimal (10,2), 
preco_unitario decimal (10,2),
validade_prod date);

create table if not exists materiais 
( cod_mat int primary key,
nome_mat varchar (255),
unidade_medida varchar (20),
validade_mat date,
fornecedor_id int,
qtd_estoque decimal (10,2));

create table if not exists fornecedor 
( id_forn int primary key,
nome_forn varchar (255),
cnpj_forn varchar (14),
tel_forn varchar (9),
email_forn varchar (16),
endereco_forn varchar (60));

create table if not exists receitas
(id_rec int primary key,
produtos_id int,
materiais_id int,
quantidade_rec decimal (10,2));

create table if not exists cargos 
( id_carg int primary key,
setor_carg varchar (255),
horas_carg time,
nome_carg varchar (255));

create table if not exists funcionario
( id_func int primary key,
nome_func varchar (255),
cargo_func varchar (255),
data_func date,
salario_func int,
cargos_id int);

create table if not exists producao
( id_prod int primary key,
data_prod date,
qtd_prod int,
produtos_id int,
responsavel_id int);

CREATE TABLE IF NOT EXISTS clietes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100),
    tipo VARCHAR(50),
    cpf VARCHAR(14),
    cnpj VARCHAR(18),
    telefone VARCHAR(15),
    endereco VARCHAR(255)
);

create table if not exists vendas
( id_vend int primary key,
data_vend date,
valor_vend decimal (10,2),
cliente_vend varchar (20));

create table if not exists item_venda 
( id_item int primary key,
qtd_item int,
preco_uni_item decimal (10,2),
produtos_id int,
vendas_id int);

CREATE TABLE usuarios (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    login VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(255) NOT NULL,
    nivel_acesso ENUM('usuario', 'admin') DEFAULT 'usuario',
    ativo BOOLEAN DEFAULT TRUE
);

select * from produtos;

