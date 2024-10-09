import http from 'k6/http';
import { sleep, check } from 'k6';
import { htmlReport } from "https://raw.githubusercontent.com/benc-uk/k6-reporter/main/dist/bundle.js";

// Definindo os thresholds
export let options = {
  thresholds: {
    // 99% das requisições devem ser concluídas com sucesso (status 200)
    'http_req_duration': ['p(95)<200'], // 95% das requisições devem ser respondidas em menos de 200ms
    'http_req_failed': ['rate<0.01'],   // Taxa de falhas (requisições com status diferente de 200) deve ser menor que 1%
  },
  stages: [
    { duration: '30s', target: 100 },   
    { duration: '1m', target: 500 },    
    { duration: '30s', target: 1000 },  
    { duration: '30s', target: 0 },  
  ],
};

export default function () {
  let res = http.get('https://test.k6.io/flip_coin.php?bet=tails');
  
  check(res, { 'status é 200': (r) => r.status === 200 });
  
  sleep(1);
}

export function handleSummary(data) {
  return {
    "flip_coin.html": htmlReport(data),
  };
}

