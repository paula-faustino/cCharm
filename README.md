## 🍫 ChocoCharm - Sistema de Fabricação de Chocolate
---
Sistema de gestão para a fábrica de chocolates ChocoCharm, voltado para controle de produção, estoque e qualidade dos produtos.

---
## 👥 Desenvolvedores
- KaueAlvess - [GitHub](https://github.com/KaueAlvess )
- Mayara Santana - [GitHub](https://github.com/mayara8666 )
- Paula Faustino - [GitHub](https://github.com/paula-faustino )
  
---
🍫 ChocoCharm - Organização

🔧 Tecnologias Utilizadas:

- Linguagem: C#
- Banco de Dados: MySQL
- IDE: Visual Studio
- Controle de Versão: Git + GitHub/GitLab

---
## 👥 Divisão de Tarefas por Desenvolvedor
---
🧑‍💻 Dev 1 – Banco de Dados & Acesso a Dados
- Paula Faustino - [GitHub](https://github.com/paula-faustino )
  
Responsabilidades:

Modelagem do banco de dados (tabelas principais)
Scripts SQL para criação das tabelas
Camada de acesso a dados (DAL) em C#
Integração MySQL com C# (MySql.Data)
Testes de conexão e CRUD básico
Tarefas Específicas:

Criar modelo ER do sistema
Criar tabelas: Produtos, MateriasPrimas, LotesProducao, Estoque, Usuarios
Implementar métodos de CRUD genéricos
Garantir segurança nas consultas (SQL injection)
Entregáveis:

Script SQL funcional
Classe Conexao.cs e DAO.cs base
Métodos de inserção/consulta/teste funcionando

---
🧑‍💻 Dev 2 – Interface Gráfica (Frontend)

- KaueAlvess - [GitHub](https://github.com/KaueAlvess )

Responsabilidades:

Desenvolvimento das telas do sistema
Organização visual e navegação
Tratamento de eventos dos formulários
Validação de campos na interface
Integração com camada de negócio
Tarefas Específicas:

Criar formulários iniciais (Login, Menu Principal)
Formulário de cadastro de produtos
Formulário de controle de produção
Formulário de estoque
Layout intuitivo e padronizado
Entregáveis:

Pasta Telas/Forms completa
Telas funcionais com navegação
Validações básicas (campos vazios, tipos)
Código limpo e organizado

---
🧑‍💻 Dev 3 – Lógica de Negócio e Integração
- Mayara Santana - [GitHub](https://github.com/mayara8666 )
  
Responsabilidades:

Lógica de negócios do sistema
Classes de domínio (modelos)
Integração entre DAL e Interface
Gerenciamento de fluxo de produção e estoque
Regras de validação de negócio
Tarefas Específicas:

Criar classes modelo: Produto, MateriaPrima, Lote, ItemEstoque
Implementar regras: validade, quantidade mínima, custo de produção
Integrar formulários às funções de negócio
Gerenciar fluxo entre módulos
Garantir consistência nos dados
Entregáveis:

Pasta Modelos/Classes completas
Pasta Negocio/Regras com lógica implementada
Funções de cálculo e validação de negócio
Logs ou mensagens de erro tratadas

---
## 🧱 Módulos Principais do Sistema
1. Cadastros
Produtos
Matérias-primas
Fornecedores
Usuários
2. Controle de Produção
Registro de lotes
Data de fabricação e validade
Quantidade produzida
Status do lote
3. Gestão de Estoque
Entrada e saída de materiais
Nível mínimo de estoque
Histórico de movimentação
4. Relatórios
Produtos mais fabricados
Consumo de matéria-prima
Resumo de estoque
Exportação para PDF ou Excel (opcional)
---
