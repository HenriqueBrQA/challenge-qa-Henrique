import http from 'k6/http';
import { sleep, check } from 'k6';
import { htmlReport } from "https://raw.githubusercontent.com/benc-uk/k6-reporter/main/dist/bundle.js";


export let options = {
  stages: [
    { duration: '30s', target: 100 },  // 100 usuários simultâneos durante 30 segundos
    { duration: '1m', target: 500 },   // Aumentando para 500 usuários em 1 minuto
    { duration: '30s', target: 1000 }, // Escalando até 1000 usuários
    { duration: '30s', target: 0 },    // Gradualmente encerrando o teste
  ],
  thresholds: {
    'http_req_duration': ['p(95)<500'], // 95% das requisições devem ser concluídas em menos de 200ms
    'http_req_failed': ['rate<0.01'],   // Menos de 1% das requisições podem falhar
  },
};


function login() {
  const payload = {
    username: 'test_user', 
    password: '1234',
  };

  // Envia uma requisição POST para o login
  let res = http.post('https://test.k6.io/login', payload);
  
  check(res, {
    'login bem-sucedido': (r) => r.status === 200,
  });

  return res.cookies;  // Retorna os cookies de sessão
}


function logout(cookies) {
  let res = http.get('https://test.k6.io/logout', {
    cookies: cookies, // Passando os cookies de sessão
  });

  check(res, {
    'logoff bem-sucedido': (r) => r.status === 200,
  });
}

export default function () {
  let cookies = login(); // Realiza o login e captura os cookies

  // Fazendo a requisição autenticada para o endpoint my_messages
  let my_messages_res = http.get('https://test.k6.io/my_messages.php', {
    cookies: cookies // Passando os cookies de sessão
  });

  check(my_messages_res, {
    'status é 200': (r) => r.status === 200,
  });

  // Simulando o logoff após a requisição
  logout(cookies); // Passa os cookies obtidos durante o login para o logoff

  sleep(1); // Aguardar 1 segundo antes de iniciar a próxima iteração
}

export function handleSummary(data) {
  return {
    "teste_login.html": htmlReport(data), // Gera o relatório de desempenho
  };
}
