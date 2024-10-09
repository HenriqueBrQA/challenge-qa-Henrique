# Estruturação do Desafio

Olá,
Segue abaixo a indicação de resolução do teste técnico para a vaga de QA da A+ Educação. Um passo a passo da configuração utilizada para realizar a reprodução dos testes e tomada de descições estão prensente no arquivo COMMENTS.MD

Desde já agradeço a oportunidade.

Henrique Silva.

## Levantamento de Requisitos

O primeiro passo foi entender o desafio, identificando as atividades a serem realizadas, as especificações técnicas solicitadas, os frameworks que poderiam ser utilizados, como o projeto seria estruturado e levantando as possíveis dificuldades em cada etapa. Para facilitar o entendimento, também criei um mapa mental.

[https://drive.google.com/file/d/1Kho5FkXiaaUk1mSKo9S8Kmgb6XDRe4eX/view?usp=sharing]

Para realizar este desafio, baseei-me bastante nos meus conhecimentos em Cypress e na estrutura de projetos de testes E2E com essa ferramenta. Analisei as possibilidades que o Cypress oferece e busquei identificar seus equivalentes no SpecFlow. Com isso, consegui também observar as diferenças e as vantagens que ambas as plataformas fornecem, além de entender quais delas atendem melhor certos requisitos.

Acredito que o Selenium com SpecFlow tem uma vantagem sobre o Cypress por permitir a realização de mais tipos de testes além dos testes E2E. No entanto, é significativamente mais complexo em termos de configuração e dependências, o que acabou consumindo bastante tempo do meu desafio, especialmente na fase de ajustes.

Atualmente, no meu projeto na empresa, terei contato com a ferramenta Robot, que utiliza Python. Com isso, terei a oportunidade de conhecer as três principais ferramentas para criação de testes E2E no mercado.

## Atividade 01 - Criação de um projeto para automatização E2E com Selenium

Para a primeira atividade, dividi os passos necessários para chegar ao E2E, o ponto focal da tarefa. Foram identificadas as seguintes atividades:

### Testes Exploratórios do Portal de Inscrições

Realizei algumas sessões de testes exploratórios no portal de inscrições, com o objetivo de verificar as regras e requisitos e, posteriormente, escrever os cenários de teste. O teste de performance gerou três saídas:

- **Relatório de Bugs**: Foi criado o arquivo `bugs.md`, onde registrei alguns bugs presentes na aplicação. Como havia muitos bugs, apenas alguns foram relatados para demonstrar como costumo gerenciar e registrar defeitos.
- **Levantamento de Regras**: O arquivo `1.2-Regras.md` contém as regras definidas para a funcionalidade do portal de inscrições.
- **Cenários de Teste**: Após a definição das regras, levantei os cenários de teste necessários para verificar se todas as regras e critérios de aceite foram atendidos. Os cenários estão registrados no arquivo `portal_cadastro.feature`, dentro da pasta `feature`.

### Criação do Projeto

Após os testes exploratórios e a criação dos artefatos, desenvolvi o projeto utilizando o VSCode, atendendo aos critérios do desafio. A estruturação do projeto foi feita da seguinte maneira:

- **Criação da pasta `feature`**: Onde foi criado e preenchido o arquivo `.feature`.
- **Criação da pasta `pages`**: Onde mapeei os elementos do portal de inscrições e encapsulei-os para serem usados nos steps de teste.
- **Criação da pasta `step`**: Onde os steps de teste foram criados para que os testes fossem executados e gerassem um relatório com o LivingDoc.

### Dificuldades Encontradas e Atividades Não Entregues

A criação do projeto de automação E2E com Selenium e SpecFlow foi desafiadora, especialmente porque nunca havia criado um projeto em .NET ou usado o Selenium antes. Tenho mais experiência com automação de testes usando Cypress, então, a componentização e encapsulamento dos elementos foi uma adaptação.

Fiz alguns cursos gratuitos para entender como estruturar o projeto, a sintaxe necessária, como fazer a build e testar os cenários. Porém, a falta de familiaridade com C# trouxe dificuldades na configuração e execução corretas do projeto. Em alguns momentos, o arquivo `.feature` não reconhecia os steps, resultando em falhas na execução.

Alguns cenários de teste, como os que envolvem esquemas de cenários e o mapeamento de pop-ups (por exemplo, a mensagem "Por favor, selecione um nível de ensino..."), não foram automatizados. Como resultado, o relatório do LivingDoc registra esses cenários como falhos.
Poderia deixalos comentados e realizar rodar apenas os cenarios em que estava mais estruturados, mas preferi no final trazer todos como foram pensado para realizar a implementação para poderem serem analisados, mesmo sabendo que eles iram falhar. 

Se eu tivesse mais tempo, gostaria de explorar melhor a documentação do Selenium e do SpecFlow para compreender melhor os métodos e otimizar a criação dos steps. Além disso, gostaria de realizar testes em múltiplos navegadores simultaneamente e melhorar a escrita dos cenários com foco na experiência do usuário, conforme mencionado no artigo [Applitools - Better Automation with Screenplay Pattern](https://applitools.com/blog/better-automation-screenplay-pattern/).
Os meus cenários focaram excessivamente no funcionamento interno do sistema, o que gerou ambiguidades em alguns casos. Isso resultou em desafios adicionais ao implementar os steps de teste e em erros que não consegui identificar claramente durante a execução. Além disso, usei chamadas com padrões como "(.\*)", que poderiam ter sido evitadas se os cenários estivessem melhor definidos com base nas funcionalidades, em vez de no comportamento interno do sistema.

### Curiosidade

Atualmente, participo de um programa de coaching com o arquiteto da empresa onde trabalho, discutindo temas focados em meu desenvolvimento profissional. Um dos tópicos abordados é a implementação de testes automatizados, considerando a pirâmide de testes (não apenas E2E), além de testes unitários e de integração. Estamos discutindo um projeto de automação com Selenium, SpecFlow e C#.

## Atividade 02 - Testes de Performance com K6

Para os testes de performance, já tinha uma base de conhecimento com o JMeter, que estou considerando abandonar após conhecer o K6, uma ferramenta muito mais amigável e parametrizável.

Embora nunca tivesse usado o K6, assisti a uma palestra sobre a ferramenta no TDC deste ano e, como fiz com o Selenium e SpecFlow, busquei cursos, artigos e vídeos. Realizei um curso na Udemy que mostrou de forma clara e objetiva o uso da ferramenta, especialmente por ela ser baseada em JavaScript, o que me deu mais familiaridade.

Instalei o K6 via Chocolatey (`choco install k6`), criei uma pasta específica para os testes de performance ("testePerformance") e rapidamente consegui enviar requisições para os endpoints, criando estratégias de teste para os dois endpoints solicitados. A biblioteca `k6-reporter` foi utilizada para gerar os relatórios em HTML.

### Dificuldades Encontradas

As dificuldades encontradas ao trabalhar com o K6 envolveram a criação de thresholds eficientes, complementando as métricas fornecidas nativamente pela ferramenta. Também tive problemas ao tentar entender melhor as respostas dos endpoints, recebendo um warning atípico (`WARN[0067]`), sem saber se era uma limitação do meu computador ou da rede.

Por receio de problemas de desempenho da minha máquina ou internet, optei por não utilizar o dashboard em tempo real com o plugin `xk6-dashboard`.

Tive mais facilidade com o K6 do que com o Selenium e SpecFlow, por isso dediquei mais tempo à primeira atividade. Se tivesse mais tempo, gostaria de melhorar os testes e expandi-los para todos os endpoints disponíveis no K6.io.

## Considerações Finais

Nas duas atividades, tive a oportunidade de aprender e trabalhar com novas tecnologias, expandindo meus conhecimentos em testes de software e qualidade. Enfrentei dificuldades por nunca ter trabalhado com .NET ou por não conhecer tão bem suas dependências e frameworks.

Por entender o potencial das ferramentas, pretendo continuar estudando e aprimorando meu conhecimento em ambas, pois, mesmo com pouco tempo, consegui visualizar seus benefícios e desafios. São ferramentas nas quais vale a pena investir tempo para me desenvolver e conseguir realizar implementações em mais de uma ferramenta utilizada no mercado posso também trazer essa visão para o time tentando entender qual delas pode atender melhor cada projeto ou caso de teste que tenhamos como desafio.
