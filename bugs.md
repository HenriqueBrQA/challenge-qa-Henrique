# Bug's encontrados na seção de testes exploratorios do "Portal de inscrições"

Bug 001
Botão de avançar some ao retornar a seleção tipo de ensino

Comportamento atual: Ao selecionar o nivél de ensino avançar e voltar, não é mais exibido a opção de avançar, tendo que selecionar outra opção para ser reexibido o botão

Comportamento esperado: Ao selecionar o nivel de enino e avançar e voltar, o sistema exibe novamente a opção selecionada anteriormente e o botão avançar

Passos para Reproduzir:
Ao acessar o portal de inscrições e selecionar o nivél de ensino e "Avançar"
O sistema ira exibir a pagina de seleção de curso com as opção de "voltar" e "Avançar"
Ao selecionar a opção de "Voltar"
O sistema retorna a janela de seleção de nivel e não apresenta mais o botão "Avançar"

Conforme evidencia: Bug001.JPG
![Botão não fica visevel](./Bugs/Bug%20001.png)

Bug 002
Formulario de cadastro aceita campos com espaço e caracteres especiais

Comportamento atual: Ao realizar o cadastro os campos de texto não estão validando nomes apenas com espaço " " ou apenas caracteres especiais "%$¨#"

Comportamento esperado: Ao realizar o cadastro, os campos de texto não devem aceitar campos preenchidos apenas com espaço ou campos especiais

Passos para Reproduzir:
Ao acessar o formulario de cadastro
O prencher os campos de texto (string) com espaço " " ou caracteres especiais
O sistema permite avançar com o cadastro

![Caracter especiais](./Bugs/Bug%20002.png)

Bug 003
Campo de data de nascimento aceita selecionar data futura

Comportamento atual: Ao selecionar a data de nascimento o sistema aceita registrar uma data futura 10/01/2025

Comportamento esperado: Ao selecionar a data de nascimento o sistema não deve aceitar data maior do que a atual

Passos para Reproduzir:
Ao acessar o formulario de cadastro
E no campo data de nascimento informar uma data futura

![Data futura](./Bugs/Bug%20003.png)

Bug 004
Campo celular aceita caracteres especiais e letras

Comportamento atual: Ao preencher o campo de celular, o sistema aceita caracteres não numericos

Comportamento esperado: Ao preencher o campo de celular, o sistema deve aceitar apenas caracteres numericos

Passos para Reproduzir:
Ao acessar o formulario de cadastro
Ao preencher o campo celular
O sistema esta permitindo caracteres especiais e letras

![Caracter especiais](./Bugs/Bug%20004,%20005%20e%20006.png)

Bug 005
Campo não obrigatoria se torna obrigatorio ao ser preenchido e apagados.

Comportamento atual: Ao preencher o campo não obrigatorio telefone e apagar, o sistema não permite finalizar o cadastro sem que ele seja preenchido novamente

Comportamento esperado: Ao preencher o campo não obrigatorio telefone e apagar, o sistema permite finalizar o cadastro sem que ele seja preenchido novamente

Passos para Reproduzir:
Ao acessar o formulario de cadastro
Preencher o campo de telefone
E depois apagar e finalizar o cadastro
O sistema solicita o campo como obrigatorio

![Campo se torna obrigatorio](./Bugs/Bug%20004,%20005%20e%20006.png)

Bug 006
Campo de CEP aceita caracteres especiais e letras

Comportamento atual: Ao preencher o campo de CEP, o sistema permite caracteres não numericos

Comportamento esperado: Ao preencher o campo de CEP, o sistema so deve permite caractes numericos

Passos para Reproduzir:
Ao acessar o formulario de cadastro
Preencher o campo CEP com 8 caracteres de qualquer tipo
o sistema permite finalizar o cadastro com o campo preenchido incorretamente

![CPE aceita caracteres especiais e letras](./Bugs/Bug%20004,%20005%20e%20006.png)
