using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace Reflection.Infra
{
    public class ManipuladorRequisicaoController
    {
        public void Manipular (HttpListenerResponse resposta,string path)
        {
            var partes = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            var controllerNome = partes[0];
            var actionNome = partes[1];

            var controllerNomeCompleto = $"Reflection.Controller.{controllerNome}Controller";

            var controllerWrapper = Activator.CreateInstance("Reflection",controllerNomeCompleto, new object[0]);
            var controller = controllerWrapper.Unwrap();
            var methodInfo = controller.GetType().GetMethod(actionNome);

           var resultadoAction = (string)methodInfo.Invoke(controller, new object[0]);


            var bufferArquivo = Encoding.UTF8.GetBytes(resultadoAction);

            resposta.StatusCode = 200;
            resposta.ContentType = "text/html; charset=uft-8";
            resposta.ContentLength64 = bufferArquivo.Length;

            resposta.OutputStream.Write(bufferArquivo, 0, bufferArquivo.Length);
            resposta.OutputStream.Close();

        }
    }
}
