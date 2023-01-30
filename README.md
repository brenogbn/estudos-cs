# estudos-cs
C# &amp; dotnet

Estudos estudos e tudo mais.

# Estrutura básica de um projeto

Exemplo:

dotnet new console

Cria 2 pastas e 2 arquivos:
- bin - arquivos binários
- obj - outros arquivos temporários e de debug.
- Nomedoprograma.csproj - config do dotnet
- Program.cs - Programa inicial.

- Arquivos .sln representam "solution" ou agrupamentos de projetos.

# Classes

- Pela convenção, as variáveis e classes começam com letra maiúscula.
- namespaces, etc...

# Arrays

- int[] array = new int[4];
- int[] array = new int[] {40, 32, 16};
- string[] nomes = {"A","B"...};
- int elemento = array[0];
- array[0] = 42

# Comentários
- // aaa
- /* a */
- ///&lt;summary&gt;...&lt;/summary&gt;
- numa função... &lt;param name="nomedavar"&gt;Isso blablabla&lt;/param&gt;