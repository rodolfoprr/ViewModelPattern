using AutoMapper;
using PatternViewModel.Models;
using PatternViewModel.ViewModels;

namespace PatternViewModel
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