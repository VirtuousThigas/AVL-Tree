# AVL-Tree
## Desenvolva um sistema de gerenciamento de pacientes de uma clínica. 
Este sistema deve ser capaz de armazenar,
pesquisar, cadastrar e remover pacientes de forma eficiente. Para garantir que essas operações sejam rápidas 
mesmo com um grande número de pacientes, utilize uma árvore AVL para armazenar os dados dos pacientes. 
Para desenvolver o sistema, além das classes relacionadas a árvore AVL, implemente a classe Paciente com os 
seguintes campos: 
• int cpf – cpf do paciente (considere apenas os números do CPF sem pontos e hífen) 
• string nome - nome do paciente. 
• string email – e-mail do paciente. 
• string telefone - telefone do paciente. 
Obs: utilize o CPF como campo chave 
O programa deve apresentar o seguinte menu de opções: 
1- Cadastrar um paciente 
2- Remover um paciente. O usuário deve informar o CPF do paciente a ser removido. 
3- Pesquisar um paciente pelo CPF. Caso conste deve-se imprimir todos os dados do paciente, senão deve-se 
imprimir a mensagem: Paciente não cadastrado. 
4- Mostrar os nomes de todos os pacientes, usando o caminhamento central 
5- Mostrar os CPFs de todos pacientes, usando o caminhamento pós-ordem. 
6- Mostrar os e-mails de todos pacientes, usando o caminhamento pré-ordem. 
7- Sair 
## O programa deve ler a opção escolhida pelo usuário, ler os dados necessários e fazer o processamento. O programa 
deve ser executado até que a opção 7 seja escolhida pelo usuário.
