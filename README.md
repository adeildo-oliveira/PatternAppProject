># PatternAppProject
Este projeto tem como finalidade demonstrar alguns exemplos de design patterns.

>## Estrutura
Os exemplos estão separados por pasta, na classe main, temos regions para separar cada exemplo.

Para executar os testes em cada um deles, é preciso descomentar o código em questão e inserir as namespaces para compilar.

>## Subindo o container no docker
* `docker build . -t Nome_Imagem` - criando a imagem a partir do dockerfile;
* `docker container create Nome_Container IMAGE Id_Imagem` - criando o container a partir da imagem;
* `docker start -a -i Id_Container` - inicia o container no modo interativo.