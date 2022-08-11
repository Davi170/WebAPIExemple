using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("cpf/")]
public class CpfController : ControllerBase
{
   [HittGet("validate/{cpf}")]
   public object validate([FromServices]CpfService CpfService,string cpf)
   {
       throw new NotImplementadException();
   }

   [HittGet("generate")]
   public object Generate([FromServices]CpfService CpfService)
   {
       throw new NotImplementadException();
   }
}