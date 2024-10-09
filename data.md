# Estratégia que você utilizaria em relação a massa de dados de testes

## Heuristica CRUD

A estretegia para uso dos dados gerados em função dos testes manuais (exploratorios para levamento das Regras) e dos testes automatizados seguiria a Heuristica CRUD que consiste em usar os termos Create, Read, Update e Delete podem ser exercitados, por exemplo, em testes que verificam a consistência dos dados no nosso exemplo seria o seguinte:
Create = Criar o cadastro do usário
Read = Pesquisar pelo cadastro gerado
Update = Realizar uma alteração no cadastro
Delete = E por ultimo deletar o cadastro

Dessa forma garantimos que é possivel realizar, pesquisar, alterar e deletar o cadastro.
O time também pode verificar a necessidade de criar uma massa de dados de teste para executar testes em outras partes do sistema como o acompanhamento do cadastro em curso ou demais funcionalidades que usariam esses dados em suas analises.
