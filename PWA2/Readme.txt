1.	Introdução:

O projeto consiste em desenvolver uma Progressive Web Application (PWA) utilizando ASP.NET. A aplicação terá como objetivo fornecer um sistema de gerenciamento de gastos pessoais, permitindo que os usuários definam um orçamento mensal e registrem seus gastos, categorizando-os em categorias pré-definidas, tais como lazer, alimentação, saúde e transporte. O software irá fornecer funcionalidades como acompanhamento do orçamento, gastos mensais, saldo disponível, gastos por categorias e gráficos de análise de gastos.

2. Análise de Requisitos:

Requisitos Funcionais:
RF1: O sistema deve permitir que os usuários definam um orçamento mensal.
RF2: Os usuários devem ser capazes de registrar seus gastos, categorizando-os em categorias pré-definidas.
RF3: O sistema deve calcular o total de gastos mensais.
RF4: Deve haver uma funcionalidade para verificar o saldo disponível com base no orçamento e nos gastos registrados.
RF5: O sistema deve fornecer uma visão dos gastos por categorias.
RF6: Os usuários devem poder visualizar gráficos de análise de gastos.
Requisitos Não Funcionais:
RNF1: A aplicação deve ser acessível em dispositivos móveis e desktops.
RNF2: Deve ser uma PWA para permitir o uso offline e melhorar a experiência do usuário.
RNF3: A aplicação deve ser responsiva e ter uma interface de usuário intuitiva.

3. Projeto:

Arquitetura do Sistema:
O sistema será desenvolvido utilizando a arquitetura MVC (Model-View-Controller) do ASP.NET. Os componentes principais incluirão:
Model: Representações dos objetos de domínio, como Orçamento, Gasto e Categoria.
View: Interfaces do usuário para interação com o sistema.
Controller: Responsável por processar as solicitações do usuário, realizar operações de negócios e atualizar as Views correspondentes.
Tecnologias Utilizadas:
ASP.NET Core: Framework para o desenvolvimento da aplicação web.
Entity Framework Core: ORM (Object-Relational Mapping) para manipulação de dados.
HTML, CSS e JavaScript: Para criação da interface do usuário e funcionalidades front-end.
Bootstrap: Para estilização e responsividade da aplicação.
Chart.js: Biblioteca para criação de gráficos.

Interfaces do Usuário:
Página inicial com opção para definir o orçamento mensal.
Página para registro de gastos, com campos para valor, categoria e data.
Página de visualização de gastos, incluindo saldo disponível, gastos mensais, gastos por categoria e gráficos de análise.

4. Desenvolvimento:

A equipe seguirá a metodologia ágil Scrum para o desenvolvimento do projeto.
O desenvolvimento será realizado em sprints, com reuniões diárias de acompanhamento.
As ferramentas de controle de versão, como Git, serão utilizadas para gerenciar o código-fonte.

5. Testes:

Serão realizados testes unitários e de integração para garantir a qualidade do software.
Testes de aceitação do usuário serão conduzidos para validar os requisitos junto aos usuários finais.

6. Implantação:

A aplicação será implantada em um servidor web compatível com ASP.NET Core.
Será configurado um ambiente de produção para hospedar a aplicação.

7. Manutenção e Suporte:

Será estabelecido um plano de manutenção para correção de bugs e implementação de novas funcionalidades.
Os usuários poderão reportar problemas através de um sistema de suporte integrado na aplicação.

8. Considerações de Segurança e Privacidade:

A aplicação adotará práticas recomendadas de segurança, como autenticação e autorização.
Serão implementadas medidas para proteger os dados dos usuários, incluindo a criptografia de dados sensíveis.

9. Conclusão:

O projeto visa fornecer uma solução eficaz para o gerenciamento de gastos pessoais, oferecendo aos usuários uma maneira fácil e intuitiva de acompanhar suas finanças. Com funcionalidades como definição de orçamento, registro de gastos e análise de despesas, o software pretende auxiliar os usuários no controle de suas finanças pessoais de forma eficiente e segura.

10. Referências:

Documentação do ASP.NET Core
Documentação do Entity Framework Core
Documentação do Bootstrap
Documentação do Chart.js





Casos de uso
1.	Definir Orçamento Mensal:

Ator Principal: Usuário
Pré-condições: O usuário está autenticado no sistema.
Fluxo Principal:
O usuário acessa a aplicação.
O usuário navega até a página de definição de orçamento.
O usuário insere o valor do orçamento mensal desejado.
O usuário confirma a definição do orçamento.
Pós-condições: O orçamento mensal é definido e armazenado no sistema.

2.	Registrar Gasto:

Ator Principal: Usuário
Pré-condições: O usuário está autenticado no sistema e o orçamento mensal já foi definido.
Fluxo Principal:
O usuário acessa a aplicação.
O usuário navega até a página de registro de gastos.
O usuário preenche os campos necessários, incluindo valor do gasto, categoria e data.
O usuário confirma o registro do gasto.
Pós-condições: O gasto é registrado e associado ao orçamento mensal.

3.	Visualizar Gastos Mensais:

Ator Principal: Usuário
Pré-condições: O usuário está autenticado no sistema e possui gastos registrados.
Fluxo Principal:
O usuário acessa a aplicação.
O usuário navega até a página de visualização de gastos.
O sistema exibe o total de gastos mensais.
O sistema lista os gastos registrados no mês atual.
Pós-condições: O usuário visualiza os gastos mensais e suas categorias.

4.	Visualizar Saldo Disponível:

Ator Principal: Usuário
Pré-condições: O usuário está autenticado no sistema e possui um orçamento mensal definido.
Fluxo Principal:
O usuário acessa a aplicação.
O sistema calcula o saldo disponível com base no orçamento mensal e nos gastos registrados.
O sistema exibe o saldo disponível para o usuário.
Pós-condições: O usuário visualiza o saldo disponível para gastos adicionais.

5. Visualizar Gastos por Categoria:
Ator Principal: Usuário
Pré-condições: O usuário está autenticado no sistema e possui gastos registrados.
Fluxo Principal:
O usuário acessa a aplicação.
O usuário navega até a página de visualização de gastos.
O sistema exibe uma lista de categorias de gastos.
O usuário seleciona uma categoria específica.
O sistema exibe os gastos associados à categoria selecionada.
Pós-condições: O usuário visualiza os gastos filtrados por categoria.

6. Visualizar Gráficos de Análise de Gastos:

Ator Principal: Usuário
Pré-condições: O usuário está autenticado no sistema e possui gastos registrados.
Fluxo Principal:
O usuário acessa a aplicação.
O usuário navega até a página de visualização de gastos.
O sistema gera gráficos de análise de gastos, incluindo gráficos de pizza, barras ou linhas.
O usuário visualiza os gráficos de análise de gastos.
Pós-condições: O usuário visualiza os gráficos de análise de gastos para auxiliar na tomada de decisões financeiras.

Stakeholders e Seus Requisitos:

1. Usuários Finais:
Descrição: São os usuários finais da aplicação, que utilizarão o sistema para gerenciar seus gastos pessoais.
Requisitos:
RF1: Capacidade de definir um orçamento mensal.
RF2: Facilidade para registrar gastos, categorizando-os em diferentes categorias.
RF3: Visualização clara do total de gastos mensais.
RF4: Acesso rápido ao saldo disponível com base no orçamento e nos gastos registrados.
RF5: Capacidade de visualizar gastos por categoria para melhor compreensão dos hábitos de gastos.
RF6: Funcionalidade para visualizar gráficos de análise de gastos para tomada de decisões financeiras.

2. Administradores do Sistema:
Descrição: Responsáveis pela administração e manutenção da aplicação.
Requisitos:
RF7: Capacidade de gerenciar usuários e permissões de acesso.
RF8: Funcionalidade para exportar dados de gastos para fins de relatórios ou análises adicionais.
RF9: Ferramentas de monitoramento para identificar problemas de desempenho ou segurança.

3. Desenvolvedores:
Descrição: Equipe responsável pelo desenvolvimento e manutenção do sistema.
Requisitos:
RF11: Disponibilidade de documentação técnica para entender a arquitetura e os componentes do sistema.
RF12: Acesso a ferramentas e ambientes de desenvolvimento adequados para o trabalho eficiente.
RF13: Ambiente de testes para validar novas funcionalidades antes da implantação em produção.
RF14: Colaboração eficaz com outras equipes, como designers de interface do usuário e especialistas em segurança.

4. Gerentes de Projeto:
Descrição: Responsáveis por supervisionar o andamento e o sucesso do projeto.
Requisitos:
RF15: Relatórios de progresso regulares para acompanhar o desenvolvimento do projeto.
RF16: Capacidade de identificar e mitigar riscos potenciais durante o ciclo de vida do projeto.
RF17: Comunicação eficaz com as partes interessadas para garantir a satisfação do cliente e a entrega dentro do prazo e do orçamento.

5. Clientes ou Patrocinadores do Projeto:
Descrição: São os clientes ou patrocinadores do projeto, que financiam e têm interesse no sucesso do sistema.
Requisitos:
RF18: Entrega do sistema dentro do prazo e do orçamento acordados.
RF19: Funcionalidades conforme especificado nos requisitos do cliente.
RF20: Suporte contínuo após a implantação do sistema para garantir sua estabilidade e eficácia.
