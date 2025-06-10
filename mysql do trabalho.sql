create database trabalho;
use trabalho;

create table if not exists produtos
( cod_prod int primary key,
nome_prod varchar (255),
tipo_prod decimal (10.2),
peso_prod decimal (10,2), 
preco_unitario decimal (10,2),
validade_prod date);

INSERT INTO produtos VALUES 
(1, 'Chocolate ao Leite', 1.00, 0.10, 5.50, '2025-12-31'),
(2, 'Chocolate Amargo', 1.01, 0.10, 6.00, '2025-12-31'),
(3, 'Chocolate Branco',  1.02, 0.10, 5.75, '2025-12-31'),
(4, 'Barra Recheada', 2.00, 0.12, 6.90, '2025-11-30'),
(5, 'Trufa de Morango',2.01, 0.05, 3.20, '2025-10-15'),
(6, 'Cacau em Pó 100g', 3.00, 0.10, 4.50, '2026-01-15'),
(7, 'Tablete Meio Amargo 70%',  1.03, 0.12, 7.20, '2025-12-01');


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

ALTER TABLE clietes 
ADD COLUMN senha_cliente VARCHAR(255);

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

ALTER TABLE receitas
ADD CONSTRAINT fk_receitas_produtos
FOREIGN KEY (produtos_id) REFERENCES produtos(cod_prod);

ALTER TABLE receitas
ADD CONSTRAINT fk_receitas_materiais
FOREIGN KEY (materiais_id) REFERENCES materiais(cod_mat);

ALTER TABLE item_venda
ADD CONSTRAINT fk_itemvenda_produtos
FOREIGN KEY (produtos_id) REFERENCES produtos(cod_prod);

ALTER TABLE item_venda
ADD CONSTRAINT fk_itemvenda_vendas
FOREIGN KEY (vendas_id) REFERENCES vendas(id_vend);

CREATE INDEX idx_clietes_cpf ON clietes(cpf);
CREATE INDEX idx_clietes_cnpj ON clietes(cnpj);

CREATE INDEX idx_usuarios_login ON usuarios(login);

CREATE INDEX idx_vendas_data ON vendas(data_vend);

CREATE INDEX idx_producao_data ON producao(data_prod);



