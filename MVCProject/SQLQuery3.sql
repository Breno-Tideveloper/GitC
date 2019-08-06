SELECT a.Nome AS 'nome', la.Autor AS 'autor', la.Livro AS 'livro'
FROM     LivroAutor AS la INNER JOIN
                  Autores AS a ON la.Autor = a.Id
WHERE  (la.Livro = @Id_livro)