## MyFinance - Projeto da disciplina Práticas de Implementação e Evolução de Software
Curso de Pós Graduação em Engenharia de Software da PUC-MG 

## Estrutura do banco de dados

<p>O banco de dados é formado por duas tabelas: Transacao e Plano_Conta, como pode ser visto na imagem.</p>

![image](https://user-images.githubusercontent.com/87769071/189543147-2f181225-1f29-4aa1-8b41-230a6ceab29e.png)

A tabela de transação irá guardar as informações de novos lançamentos criados pela usuário. Enquanto a tabela de Plano de Contas será utilizado como uma enumeraçao de tipos diferentes de transações. Esta segunda tabela é importante para facilitar a agregação de dados produzidos para a tabela de Transações.

## Requisitos
Instalar o .NET CORE SDK 6.0 <br>
https://dotnet.microsoft.com/en-us/download

## Instalação do projeto:
Acessar a pasta principal:<br>
### ``cd ./myfinance-web-netcore``

## Compilar e rodar o projeto:<br>
Constrói a aplicação para produção
### ``dotnet build``

Executa o codigo compilado
### ``dotnet run``

Acesse o projeto através do link que irá aparecer no terminal
