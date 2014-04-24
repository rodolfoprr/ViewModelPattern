using AutoMapper;
using ViewModelPattern.Models;
using ViewModelPattern.ViewModels;

namespace ViewModelPattern
{
    public class AutoMapperBootStrapper
    {
        public static void ConfigureAutoMapper()
        {
            Mapper.CreateMap<AutenticacaoViewModel, Usuario>();

            Mapper.CreateMap<AlteracaoSenhaViewModel, Usuario>()
                .AfterMap((s, d) => d.Senha = s.NovaSenha);
        }
    }
}