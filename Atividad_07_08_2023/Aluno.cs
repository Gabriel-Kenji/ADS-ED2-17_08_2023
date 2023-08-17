namespace Atividad_07_08_2023;

public class Aluno
{
    private int id;
    private string nome;

    public Aluno(int id, string nome)
    {
        this.id = id;
        this.nome = nome;
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Nome
    {
        get => nome;
        set => nome = value ?? throw new ArgumentNullException(nameof(value));
    }

    public bool podeMatricular(Curso cursos)
    {
        return true;
    }
}