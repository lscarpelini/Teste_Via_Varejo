
## Começando

Como sou um programador com muitos amigos espalhados pelo mundo. Resolvi fazer um sistema que me ajudasse a localizar meus 3 amigos mais próximos de acordo com a localização do amigo que estou visitando no momento.  Por exemplo. Estou visitando um amigo em São Paulo. O sistema me ajuda a localizar meus 3 amigos  mais próximos a São Paulo para um possível encontro, evento ou qualquer outra coisa.

### Pré-requisitos 

Visual Studio para executar o programa e analisar o código do projeto.


### Arquitetura do Projeto Amigo Próximo

Para melhor entendimento do código o programa ficou dividido em 4 camadas.

```
- Apresentação  (Camada de aplicação)
- Dominio       (Classes de Entidades/Dominio) 
- Negocio       (Classes de Negócio)
- Repositorio   (Classe de Repositório de Dados)
- TesteUnitario (Classes de Testes Unitários)

```

## Como executar o Programa

A camada de projeto de "Apresentação" ser setada como projeto principal. 

```
Set as StartUp Project
```
Após esse passo é só rodar o programa com F5.


## Utilização do Programa

O programa irá listar todos os seus amigos. Você irá informar o código do amigo que você esta visitando e apertar Enter.

```
Exemplo: 1 + Enter
```
O Sistema irá listar os amigos mais próximos as amigo com código "1".

```
Para uma nova consulta digite 'N' + Enter
```

Para sair do sistema digite qualquer tecla + Enter.

## Teste Unitário

A solution possui 3 testes unitário para validar os metodos utilizados no sistema. 

```
- ObterAmigosProximos_Teste
- Obter_Por_Amigo_Teste()
- Obter_Teste()

```
O Sistema irá listar os amigos mais próximos as amigo com código "1".

## Feito com

* [Visual Studio 2015]


## Autor

* **Lucas Scarpelini** 


