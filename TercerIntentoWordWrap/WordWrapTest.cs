using AwesomeAssertions;

namespace TercerIntentoWordWrap;

public class WordWrapTest
{
    [Fact]
    
    public void Si_envioVacio_Debe_RetornarVacio()
    {
        var result = Wrap("", 1);

        result.Should().Be("");
    }
    [Fact]
    public void Si_EnvioThisy10_Debe_Retornarthis()
    {
        var result = Wrap("this", 10);

        result.Should().Be("this");
    }
    private string Wrap(string text, int col)
    {
        return "";
        
    }
    
}