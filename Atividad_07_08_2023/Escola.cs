namespace Atividad_07_08_2023;

public class Escola
{
    private Curso[] _curso;

    public Escola()
    {
        _curso = new Curso[5];
    }

    public Curso[] Curso
    {
        get => _curso;
    }

    public bool adicionarCurso(Curso curso)
    {
        return true;
    }
    public Curso pesquisarCurso(Curso curso)
    {
        return curso;
    }
    public bool removerCurso(Curso curso)
    {
        return true;
    }
}