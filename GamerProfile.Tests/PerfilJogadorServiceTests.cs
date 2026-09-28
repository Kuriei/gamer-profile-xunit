using GamerProfile.App;
using Xunit;

namespace GamerProfile.Tests;

public class PerfilJogadorServiceTests
{
    [Fact]
    public void GerarTagUsuario_DeveRetornarTagFormatada()
    {
        var service = new PerfilJogadorService();

        string resultado = service.GerarTagUsuario("Nickname", "0000");

        Assert.Equal("Nickname#0000", resultado);
    }

    [Fact]
    public void CalcularXPTotal_DeveSomarXPComBonus()
    {
        var service = new PerfilJogadorService();

        int resultado = service.CalcularXPTotal(200, 300);

        Assert.Equal(600, resultado);
    }

    [Fact]
    public void EEligivelParaRanked_DeveValidarNivelDoJogador()
    {
        var service = new PerfilJogadorService();

        Assert.True(service.EEligivelParaRanked(15));
        Assert.False(service.EEligivelParaRanked(14));
    }
}