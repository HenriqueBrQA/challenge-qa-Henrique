using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Xunit;
using Cop.Sbe.Exercism.Registration.Pages;

namespace Challange_QA.Obj.Feature
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;
        private PortalInscricaoPage _portalPage;

        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = new ChromeDriver();
            _portalPage = new PortalInscricaoPage(_driver);
        }

        [Given(@"que o usuário acessa o portal de inscrições")]
        public void DadoQueOUsuarioAcessaOPortalDeInscricoes()
        {
            _driver.Navigate().GoToUrl(Urls.UrlBase);
        }

        [When(@"ele seleciona a opção ""(.*)""")]
        public void QuandoEleSelecionaAOpcao(string opcao)
        {
            if (opcao == "graduação")
            {
                _portalPage.ClicarNaOpcaoGraduacao();
            }
        }

        [Then(@"o sistema avança e exibe a mensagem ""(.*)""")]
        public void EntaoOSistemaAvancaEExibeAMensagem(string mensagemEsperada)
        {
             string mensagemAtual = _portalPage.LerTextoGraduacao(); 
             // Compara a mensagem atual com a mensagem esperada
             Assert.Equal(mensagemEsperada, mensagemAtual);
        }

        [When(@"ele seleciona a opção ""(.*)""")]
        public void QuandoEleSelecionaAOpcaoPos(string opcao)
        {
            if (opcao == "pos-graduação")
            {
                _portalPage.ClicarNaOpcaoPosGraduacao();
            }
        }

        [Then(@"o sistema avança e exibe a mensagem ""(.*)""")]
        public void EntaoOSistemaAvancaEExibeAMensagemPos(string mensagemEsperada)
        {
             string mensagemAtual = _portalPage.LerTextoPosGraduacao(); 
             // Compara a mensagem atual com a mensagem esperada
             Assert.Equal(mensagemEsperada, mensagemAtual);
        }

        [Given(@"que o usuário está na área de seleção de curso")]
        public void DadoQueOUsuarioEstaNaAreadeSelecaoDeCurso()
        {
            _driver.Navigate().GoToUrl(Urls.UrlCursosUndergraduate);
        }

        [When(@"ele pesquisa por um curso ""(.*)""")]
        public void QuandoElePesquisaPorUmCurso(string textoCurso)
        {
           _portalPage.PesquisarCurso(textoCurso);
        }

        [Then(@"o sistema apresenta o curso ""(.*)""")]
        public void EntaoOSistemaApresentaOCurso(string cursoEsperado)
        {
            string cursoReal = _portalPage.LerCursoDisponivel();
            Assert.Equal(cursoEsperado, cursoReal);
        }

        [Then(@"o sistema apresenta a mensagem ""(.*)""")]
        public void EntaoOSistemaApresentaAMensagem(string mensagemEsperada)
        {
            string mensagemReal = _portalPage.LerMensagemCursoNaoEncontrado();
            Assert.Equal(mensagemEsperada, mensagemReal);
        }

        [When(@"ele clica em ""avançar""")]
        public void EntaoEleClicaEmAvancar(string opcao)
        {
             if (opcao == "pos-graduação")
            {
                _portalPage.BotaoAvancar();
            }
        }

        [Then(@"o sistema apresenta a mensagem ""(.*)""")]
        public void EntaoOSistemaApresentaAMensagemNao(string mensagemEsperada)
        {
            string mensagemReal = _portalPage.LerMensagemCursoNaoEncontrado();
            Assert.Equal(mensagemEsperada, mensagemReal);
        }

        [Then(@"seleciona a opção ""(.*)""")]
        public void EntaoSelecionaAOpcao(string curso)
        {
            if (curso == "Ciência da Computação")
            {
                _portalPage.CursoSelecionado(); 
            }
        }

        [Then(@"o sistema apresenta a janela de cadastro")]
        public void EntaoSistemaApresentaJanelaDeCadastro()
        {
            string textoEsperado = "Pronto para essa aventura? Comece nos contando um pouco sobre você!";
            string textoAtual = _portalPage.LerTextoIntroducaoCadastro(); 
    
            Assert.Equal(textoEsperado, textoAtual); 
        }

        [AfterScenario]
        public void FecharNavegador()
        {
            // Encerra o navegador após cada cenário
            _driver.Quit();
        }
    }
}
