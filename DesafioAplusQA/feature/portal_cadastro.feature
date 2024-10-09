# language: pt
Funcionalidade: Portal de Inscrição de cursos de graduação e pos-graduação

    Cenário: AC01 Usuário seleciona nível de ensino
        Dado que o usuário acessa o portal de inscrições
        Quando ele seleciona a opção "graduação"
        Então o sistema avança e exibe a mensagem "Selecione seu curso de Graduação"

    Cenário: AC02 Sistema apresenta os cursos de pós-graduação
        Dado que o usuário acessa o portal de inscrições
        Quando ele seleciona a opção "pos-graduação"
        Então o sistema avança e exibe a mensagem "Selecione seu curso de Pós-graduação"

    Cenário: AC03 Usuário pesquisa pelo curso disponível utilizando o campo de busca
        Dado que o usuário está na área de seleção de curso
        Quando ele pesquisa por um curso "Direito"
        Então o sistema apresenta o curso pesquisado

    Cenário: AC04 Usuário pesquisa por um curso não disponível utilizando o campo de busca
        Dado que o usuário está na área de seleção de curso
        Quando ele pesquisa por um curso "Medicina"
        Então o sistema apresenta a mensagem "Curso não encontrado"

    Cenário: AC05 Usuário avança sem selecionar uma opção de curso
        Dado que o usuário está na área de seleção de curso
        Quando ele clica em "avançar"
        Então o sistema apresenta uma mensagem "Por favor, selecione um curso..."

    Cenário: AC06 Usuário seleciona um curso disponível e avança
        Dado que o usuário está na área de seleção de curso
        E seleciona a opção "Ciência da Computação"
        Quando o usuário clica em "avançar"
        Então o sistema apresenta a janela de cadastro

    Esquema do Cenário: AC07 Preenchimento dos dados obrigatórios no cadastro
        Contexto: O usuário está no formulário de cadastro após ter selecionado um curso.
        Dado que o usuário esta na pagina de cadastro
        E o sistema exibe o formulário de cadastro
        Quando o usuário preenche os seguintes campos obrigatórios <cpf>, <nome>, <sobrenome>, <data>, <email>, <celular>, <CEP>, <endereço>, <bairro>, <cidade>, <estado>, e <país>
        Então o sistema deve <resultado>

        Exemplos:
        | CPF            |Nome  |Sobrenome |Data       |Email           | celular    |CPE      |ENDERECO  |BAIRRO  |Cidade    |ESTADO |PAIS   |Resultado |
        | 321.321.343.56 |Bruce |Silva     |20/04/2022 |Bruce@bruce.com |11983458745 |88058577 |Rua Bruce |Cisfild |São Paulo |SP     |Brasil |Valido    |     

    Cenário: AC8 Ao finalizar o cadastro o sistema fornece login e senha
        Dado que o usuário finaliza o preenchimento do cadastro
        E submete o cadastro
        Então o sistema finaliza o cadastro
        E exibe o usuário e senha para o usuário
        E a mensagem "Sua jornada começa aqui!"

    Esquema do Cenário: AC09 Acesso à área do candidato com login e senha
        Contexto: O usuário recebeu o login e senha após finalizar o cadastro.
        Dado que o usuário recebeu o login e senha
        Quando ele tenta fazer login no portal de candidatos com os seguintes dados <usuario> e <senha>
        Então <resultado>

        Exemplos:
        | Usuário   | Senha        | Resultado | Contexto          |
        | candidato | subscription | Válido    | Dados válidos     |
        | candidato |              | Inválido  | Senha em branco   |
        |           | subscription | Inválido  | Usuário em branco |
        |           |              | Inválido  | Campos em branco  |
