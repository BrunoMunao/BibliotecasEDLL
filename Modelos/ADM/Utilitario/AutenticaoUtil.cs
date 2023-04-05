namespace Modelos.ADM.Utilitario
{
 internal class AutenticacaoUtil
    {
        public bool ValidarSenha(string senhaverdadeira,string senhatentativa)
        {
            return senhatentativa.Equals(senhatentativa);
        }
    }
}