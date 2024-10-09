using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Cop.Sbe.Exercism.Registration.Pages
{
    public static class Urls
    {
        public const string UrlBase = "https://developer.grupoa.education/subscription/";
        public const string UrlHome = UrlBase; // Página inicial de assinatura
        public const string UrlCursosUndergraduate = UrlBase + "courses/undergraduate"; // Cursos de graduação
        public const string UrlCursosGraduate = UrlBase + "courses/graduate"; // Cursos de pós-graduação
        public const string UrlPersonalData = UrlBase + "personal-data"; // Dados pessoais
        public const string UrlConfirmation = UrlBase + "personal-data/confirmation"; // Confirmação de dados pessoais
        public const string UrlLogin = UrlBase + "authentication/login"; // Página de login
    }

    public class PortalInscricaoPage
    {
        private readonly IWebDriver _driver;

        public PortalInscricaoPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClicarNaOpcaoGraduacao()
        {
            IWebElement graduacao = _driver.FindElement(By.Id("radix-vue-select-item-text-54"));
            graduacao.Click();
        }

        public void ClicarNaOpcaoPosGraduacao()
        {
            IWebElement posGraduacao = _driver.FindElement(By.Id("radix-vue-select-item-text-55"));
            posGraduacao.Click();
        }

        public string LerTextoGraduacao()
        {
            IWebElement textoGraduacao = _driver.FindElement(By.XPath("//h3[text()='Selecione seu curso de Graduação']"));
            return textoGraduacao.Text;
        }

        public string LerTextoPosGraduacao()
        {
            IWebElement textoPosGraduacao = _driver.FindElement(By.XPath("//h3[text()='Selecione seu curso de Pós-graduação']"));
            return textoPosGraduacao.Text;
        }

        public void BotaoVoltar()
        {
            IWebElement voltarGraduacao = _driver.FindElement(By.CssSelector("[data-testid='back-button']"));
            voltarGraduacao.Click();
        }

        public void BotaoAvancar()
        {
            IWebElement avancaGraduacao = _driver.FindElement(By.CssSelector("[data-testid='next-button']"));
            avancaGraduacao.Click();
        }

        public void SelecionarCursoPorTexto(string opcaoTexto)
        {
            IWebElement comboCursos = _driver.FindElement(By.CssSelector(".graduation-combo"));
            SelectElement selectElement = new SelectElement(comboCursos);
            selectElement.SelectByText(opcaoTexto);
        }

        public void PesquisarCurso(string textoPesquisa)
        {
            IWebElement pesquisa = _driver.FindElement(By.CssSelector("input[placeholder='Pesquise um curso...']"));
            pesquisa.Clear();
            pesquisa.SendKeys(textoPesquisa);
        }

        public string LerMensagemCursoNaoEncontrado()
        {
            IWebElement mensagemElemento = _driver.FindElement(By.CssSelector(".py-6.text-center.text-sm"));
            return mensagemElemento.Text;
        }

        public string LerCursoDisponivel()
        {
            IWebElement cursoElemento = _driver.FindElement(By.Id("radix-vue-combobox-option-188"));
            return cursoElemento.Text;
        }

        public void CursoSelecionado()
        {
            IWebElement cienciaComputacao  = _driver.FindElement(By.Id("radix-vue-combobox-option-74"));
            cienciaComputacao.Click();

        }

        public string LerTextoIntroducaoCadastro()
        {
    
            IWebElement textoIntroducao = _driver.FindElement(By.XPath("//h3[contains(text(), 'Pronto para essa aventura?')]"));
            return textoIntroducao.Text;
        }

        public void InserirCpf(string cpf)
        {
            if (cpf.Length != 11)
            {
                throw new ArgumentException("O CPF deve conter exatamente 11 dígitos.");
            }

            IWebElement campoCPF = _driver.FindElement(By.CssSelector("[data-testid='cpf-input']"));
            campoCPF.SendKeys(cpf);
        }

        public void InserirNome(string nome)
        {
            IWebElement campoNome = _driver.FindElement(By.CssSelector("[data-testid='name-input']"));
            campoNome.SendKeys(nome);
        }

        public void InserirSobreNome(string sobreNome)
        {
            IWebElement campoSobreNome = _driver.FindElement(By.Id("radix-283-form-item"));
            campoSobreNome.SendKeys(sobreNome);
        }

        public void InserirNomeSocial(string nomeSocial)
        {
            IWebElement campoNomeSocial = _driver.FindElement(By.Id("radix-284-form-item"));
            campoNomeSocial.SendKeys(nomeSocial);
        }

        public void InserirDataNascimento(string dataNascimento)
        {
            IWebElement campoDataNascimento = _driver.FindElement(By.Id("birthdate"));
            campoDataNascimento.SendKeys(dataNascimento);
        }

        public void BotaoDeficiencia()
        {
            IWebElement botaoDeficiencia = _driver.FindElement(By.Id("has-disability"));
            botaoDeficiencia.Click();
        }

        public void PreencherDeficiencia(string deficiencia)
        {
            IWebElement campoDeficiencia = _driver.FindElement(By.Id("radix-300-form-item"));
            campoDeficiencia.SendKeys(deficiencia);
        }

        public void PreencherEmail(string email)
        {
            IWebElement campoEmail = _driver.FindElement(By.Id("radix-287-form-item"));
            campoEmail.SendKeys(email);
        }

        public void PreencherCelular(string celular)
        {
            IWebElement campoCelular = _driver.FindElement(By.Id("radix-288-form-item"));
            campoCelular.SendKeys(celular);
        }

        public void PreencherTelefone(string telefone)
        {
            IWebElement campoTelefone = _driver.FindElement(By.Id("radix-289-form-item"));
            campoTelefone.SendKeys(telefone);
        }

        public void PreencherCEP(string cep)
        {
            IWebElement campoCEP = _driver.FindElement(By.Id("radix-290-form-item"));
            campoCEP.SendKeys(cep);
        }

        public void PreencherEndereco(string endereco)
        {
            IWebElement campoEndereco = _driver.FindElement(By.Id("radix-291-form-item"));
            campoEndereco.SendKeys(endereco);
        }

        public void PreencherComplemento(string complemento)
        {
            IWebElement campoComplemento = _driver.FindElement(By.Id("radix-292-form-item"));
            campoComplemento.SendKeys(complemento);
        }

        public void PreencherBairro(string bairro)
        {
            IWebElement campoBairro = _driver.FindElement(By.Id("radix-293-form-item"));
            campoBairro.SendKeys(bairro);
        }

        public void PreencherCidade(string cidade)
        {
            IWebElement campoCidade = _driver.FindElement(By.Id("radix-294-form-item"));
            campoCidade.SendKeys(cidade);
        }

        public void PreencherEstado(string estado)
        {
            IWebElement campoEstado = _driver.FindElement(By.Id("radix-295-form-item"));
            campoEstado.SendKeys(estado);
        }

        public void PreencherPais(string pais)
        {
            IWebElement campoPais = _driver.FindElement(By.Id("radix-296-form-item"));
            campoPais.SendKeys(pais);
        }

        public void BotaoVoltarC()
        {
            IWebElement botaoVoltar = _driver.FindElement(By.CssSelector("[data-testid='back-button']"));
            botaoVoltar.Click();
        }

        public void BotaoAvancaC()
        {
            IWebElement botaoAvanca = _driver.FindElement(By.CssSelector("[data-testid='next-button']"));
            botaoAvanca.Click();
        }

        public string LerTextoJornada()
        {
            IWebElement jornada = _driver.FindElement(By.XPath("//h3[text()='Sua jornada começa aqui!']"));
            return jornada.Text;
        }

        public void BotaoCandidato()
        {
            IWebElement botaoCandidato = _driver.FindElement(By.CssSelector("[data-testid='next-button']"));
            botaoCandidato.Click();
        }

        public string LerTextoAutentica()
        {
            IWebElement autentica = _driver.FindElement(By.XPath("//h3[text()='Autenticação']"));
            return autentica.Text;
        }

        public void PreencherUsuario(string usuario)
        {
            IWebElement campoUsuario = _driver.FindElement(By.Id("radix-301-form-item"));
            campoUsuario.SendKeys(usuario);
        }

        public void PreencherSenha(string senha)
        {
            IWebElement campoSenha = _driver.FindElement(By.Id("password"));
            campoSenha.SendKeys(senha);
        }

        public void BotaoLogin()
        {
            IWebElement botaoLogin = _driver.FindElement(By.CssSelector("[data-testid='login-button']"));
            botaoLogin.Click();
        }
    }
}
