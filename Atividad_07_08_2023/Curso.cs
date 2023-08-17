namespace Atividad_07_08_2023;

public class Curso
{
    private int id;
    private string descricao;
    private Disciplina[] _diciplina;

    public Curso(int id, string descricao)
    {
        this.id = id;
        this.descricao = descricao;
        _diciplina = new Disciplina[12];
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Descricao
    {
        get => descricao;
        set => descricao = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Disciplina[] Diciplina
    {
        get => _diciplina;
    }

    public bool adicionarDisciplina(Disciplina disciplina)
    {
        return true;
    }
    
    public bool pesquisarDisciplina(Disciplina disciplina)
    {
        return true;
    }
    
    public bool removerDisciplina(Disciplina disciplina)
    {
        return true;
    }
    
    
}