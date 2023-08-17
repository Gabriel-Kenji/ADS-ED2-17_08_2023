namespace Atividad_07_08_2023;

public class Disciplina
{
    private int _id;
    private string _descricao;
    private Aluno[] _aluno;

    public Disciplina(int id, string descricao)
    {
        _id = id;
        _descricao = descricao;
        _aluno = new Aluno[15];
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Descricao
    {
        get => _descricao;
        set => _descricao = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Aluno[] Aluno
    {
        get => _aluno;
    }

    public bool matricularAluno(Aluno aluno)
    {
        return true;
    }
    
    public bool desmatricularAluno(Aluno aluno)
    {
        return true;
    }
}