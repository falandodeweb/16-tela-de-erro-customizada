using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class cSistema
{
    public static int InserirErro(string mensagem, string inner)
    {
        //Crie uma tabela no banco com os campos abaixo.
        
        try
        {
            //Conexao con = new Conexao();
            //Erro err = new Erro();

            //var req = HttpContext.Current.Request;
            //var br = req.Browser;

            //err.DataCadastro = DateTime.Now;
            //err.Mensagem = mensagem;
            //err.InnerException = inner;
            //err.Navegador = br.Browser + " v" + br.Version;
            //err.URL = req.Url.AbsolutePath.ToLower();
            //err.IP = HttpContext.Current.Request.Params["HTTP_CLIENT_IP"] ?? HttpContext.Current.Request.UserHostAddress;

            //con.Erro.Add(err);
            //con.SaveChanges();

            //return err.Codigo;

            return 10;
        }
        catch { return 0; }
    }
}