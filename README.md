# DivisoresApp

Projeto de teste com WebApi feita em .Net Core e aplicação Web feita com Angular 8 utilizando o Visual Studio 2019.

Apenas uma função para receber um número dado pelo usuário e retornar todos os divisores desse número e falar quais desses divisores são números primos.

Para testar sem utilizar o front-end feito especificamente para este projeto pode-se utilizar alguma outra forma de consumir a API (Postman por exemplo) e utilizar o link da seguinte forma:

https://localhost:44311/api/Divisores/250 

Nesse caso, o sistema estará rodando na porta local 44311 e o valor passado é 250. Como retorno virá um objeto JSON com 2 arrays dentro, um possuindo os divisores e outro possuindo os divisores que são primos. Nesse caso seria:

{
    "Divisores": [
        1,
        2,
        5,
        10,
        25,
        50,
        125,
        250
    ],
    "DivisoresPrimos": [
        2,
        5
    ]
}
