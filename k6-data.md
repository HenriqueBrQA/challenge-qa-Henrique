# Estrategia em relação a massa de dados de testes com o K6

## Para o endpoint my_messages.php

Para realizar a análise dos testes, utilizamos as seguintes massas de dados para avaliar os resultados:

**Dados de login:**

-   **Número de logins simultâneos**: Quantos logins estão sendo feitos ao mesmo tempo.
-   **Tempo de resposta do login**: O tempo que o sistema leva para autenticar um login.
-   **Taxa de sucesso de login**: Quantos logins foram realizados com sucesso.

**Dados de logoff:**

-   **Tempo de resposta do logoff**: O tempo que o sistema leva para processar um logoff.
-   **Taxa de sucesso de logoff**: Quantos logoffs foram realizados com sucesso.

**Análise do Throughput:** Como não tínhamos um critério específico para analisar os endpoints solicitados, incluímos alguns pontos de throughput durante os testes, como verificar se o número de requisições estava dentro do limite definido e se as requisições demoravam menos de 200 milissegundos ao observarmos o 95º percentil.

**Análises padrão do K6:**

-   **Quantidade de requisições**.
-   **Tempo de duração de cada requisição**.
-   **Tempo de espera de cada requisição**.
-   **Quantidade de requisições bem-sucedidas** (status 200).
-   **Quantidade de requisições com falha** (status diferente de 200).

Essas foram as principais análises baseadas nas métricas e nos dados obtidos durante os testes de performance. Os resultados completos podem ser acessados nos arquivos:

-   **fli_coin.html**
-   **teste_login.html**
