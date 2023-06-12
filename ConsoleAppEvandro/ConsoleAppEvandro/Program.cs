namespace ConsoleAppEvandro
{
    internal class Program
    {
        public class Programa
        {
            // Vetores para armazenar os registros em memória
            static List<Professor> professores = new List<Professor>();
            static List<Disciplina> disciplinas = new List<Disciplina>();
            static List<Atribuicao> atribuicoes = new List<Atribuicao>();

            // Rotina para cadastrar um novo professor
            static void CadastrarProfessor(int codigo, string nome, string endereco)
            {
                Professor professor = new Professor
                {
                    CodigoProfessor = codigo,
                    Nome = nome,
                    Endereco = endereco
                };

                professores.Add(professor);
                Console.WriteLine("Professor cadastrado com sucesso!");
            }

            // Rotina para buscar todos os professores cadastrados
            static void BuscarProfessores()
            {
                foreach (Professor professor in professores)
                {
                    Console.WriteLine($"Código: {professor.CodigoProfessor}, Nome: {professor.Nome}, Endereço: {professor.Endereco}");
                }
            }

            // Rotina para buscar um professor pelo código
            static void BuscarProfessorPorCodigo(int codigo)
            {
                Professor professor = professores.Find(p => p.CodigoProfessor == codigo);
                if (professor != null)
                {
                    Console.WriteLine($"Código: {professor.CodigoProfessor}, Nome: {professor.Nome}, Endereço: {professor.Endereco}");
                }
                else
                {
                    Console.WriteLine("Professor não encontrado!");
                }
            }

            // Rotina para atualizar os dados de um professor
            static void AtualizarProfessor(int codigo, string nome, string endereco)
            {
                Professor professor = professores.Find(p => p.CodigoProfessor == codigo);
                if (professor != null)
                {
                    professor.Nome = nome;
                    professor.Endereco = endereco;
                    Console.WriteLine("Professor atualizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Professor não encontrado!");
                }
            }

            // Rotina para remover um professor pelo código
            static void RemoverProfessor(int codigo)
            {
                Professor professor = professores.Find(p => p.CodigoProfessor == codigo);
                if (professor != null)
                {
                    professores.Remove(professor);
                    Console.WriteLine("Professor removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Professor não encontrado!");
                }
            }

            // Rotina para cadastrar uma nova disciplina
            static void CadastrarDisciplina(int codigo, string descricao, int cargaHoraria)
            {
                Disciplina disciplina = new Disciplina
                {
                    CodigoDisciplina = codigo,
                    Descricao = descricao,
                    CargaHoraria = cargaHoraria
                };

                disciplinas.Add(disciplina);
                Console.WriteLine("Disciplina cadastrada com sucesso!");
            }

            // Rotina para buscar todas as disciplinas cadastradas
            static void BuscarDisciplinas()
            {
                foreach (Disciplina disciplina in disciplinas)
                {
                    Console.WriteLine($"Código: {disciplina.CodigoDisciplina}, Descrição: {disciplina.Descricao}, Carga Horária: {disciplina.CargaHoraria}");
                }
            }

            // Rotina para buscar uma disciplina pelo código
            static void BuscarDisciplinaPorCodigo(int codigo)
            {
                Disciplina disciplina = disciplinas.Find(d => d.CodigoDisciplina == codigo);
                if (disciplina != null)
                {
                    Console.WriteLine($"Código: {disciplina.CodigoDisciplina}, Descrição: {disciplina.Descricao}, Carga Horária: {disciplina.CargaHoraria}");
                }
                else
                {
                    Console.WriteLine("Disciplina não encontrada!");
                }
            }

            // Rotina para atualizar os dados de uma disciplina
            static void AtualizarDisciplina(int codigo, string descricao, int cargaHoraria)
            {
                Disciplina disciplina = disciplinas.Find(d => d.CodigoDisciplina == codigo);
                if (disciplina != null)
                {
                    disciplina.Descricao = descricao;
                    disciplina.CargaHoraria = cargaHoraria;
                    Console.WriteLine("Disciplina atualizada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Disciplina não encontrada!");
                }
            }

            // Rotina para remover uma disciplina pelo código
            static void RemoverDisciplina(int codigo)
            {
                Disciplina disciplina = disciplinas.Find(d => d.CodigoDisciplina == codigo);
                if (disciplina != null)
                {
                    disciplinas.Remove(disciplina);
                    Console.WriteLine("Disciplina removida com sucesso!");
                }
                else
                {
                    Console.WriteLine("Disciplina não encontrada!");
                }
            }

            // Rotina para cadastrar uma nova atribuição
            static void CadastrarAtribuicao(int codigo, DateTime dataAtribuicao, int codigoProfessor, int codigoDisciplina)
            {
                Atribuicao atribuicao = new Atribuicao
                {
                    CodigoAtribuicao = codigo,
                    DataAtribuicao = dataAtribuicao,
                    CodigoProfessor = codigoProfessor,
                    CodigoDisciplina = codigoDisciplina
                };

                atribuicoes.Add(atribuicao);
                Console.WriteLine("Atribuição cadastrada com sucesso!");
            }

            // Rotina para buscar todas as atribuições cadastradas
            static void BuscarAtribuicoes()
            {
                foreach (Atribuicao atribuicao in atribuicoes)
                {
                    Console.WriteLine($"Código: {atribuicao.CodigoAtribuicao}, Data: {atribuicao.DataAtribuicao}, Código do Professor: {atribuicao.CodigoProfessor}, Código da Disciplina: {atribuicao.CodigoDisciplina}");
                }
            }

            // Rotina para buscar uma atribuição pelo código
            static void BuscarAtribuicaoPorCodigo(int codigo)
            {
                Atribuicao atribuicao = atribuicoes.Find(a => a.CodigoAtribuicao == codigo);
                if (atribuicao != null)
                {
                    Console.WriteLine($"Código: {atribuicao.CodigoAtribuicao}, Data: {atribuicao.DataAtribuicao}, Código do Professor: {atribuicao.CodigoProfessor}, Código da Disciplina: {atribuicao.CodigoDisciplina}");
                }
                else
                {
                    Console.WriteLine("Atribuição não encontrada!");
                }
            }

            // Rotina para atualizar os dados de uma atribuição
            static void AtualizarAtribuicao(int codigo, DateTime dataAtribuicao, int codigoProfessor, int codigoDisciplina)
            {
                Atribuicao atribuicao = atribuicoes.Find(a => a.CodigoAtribuicao == codigo);
                if (atribuicao != null)
                {
                    atribuicao.DataAtribuicao = dataAtribuicao;
                    atribuicao.CodigoProfessor = codigoProfessor;
                    atribuicao.CodigoDisciplina = codigoDisciplina;
                    Console.WriteLine("Atribuição atualizada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Atribuição não encontrada!");
                }
            }

            // Rotina para remover uma atribuição pelo código
            static void RemoverAtribuicao(int codigo)
            {
                Atribuicao atribuicao = atribuicoes.Find(a => a.CodigoAtribuicao == codigo);
                if (atribuicao != null)
                {
                    atribuicoes.Remove(atribuicao);
                    Console.WriteLine("Atribuição removida com sucesso!");
                }
                else
                {
                    Console.WriteLine("Atribuição não encontrada!");
                }
            }

            public static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("Selecione uma opção:");
                    Console.WriteLine("1 - Cadastrar Professor");
                    Console.WriteLine("2 - Buscar Professores");
                    Console.WriteLine("3 - Buscar Professor por Código");
                    Console.WriteLine("4 - Atualizar Professor");
                    Console.WriteLine("5 - Remover Professor");
                    Console.WriteLine("6 - Cadastrar Disciplina");
                    Console.WriteLine("7 - Buscar Disciplinas");
                    Console.WriteLine("8 - Buscar Disciplina por Código");
                    Console.WriteLine("9 - Atualizar Disciplina");
                    Console.WriteLine("10 - Remover Disciplina");
                    Console.WriteLine("11 - Cadastrar Atribuição");
                    Console.WriteLine("12 - Buscar Atribuições");
                    Console.WriteLine("13 - Buscar Atribuição por Código");
                    Console.WriteLine("14 - Atualizar Atribuição");
                    Console.WriteLine("15 - Remover Atribuição");
                    Console.WriteLine("0 - Sair");

                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Digite o código, nome e endereço do professor separados por vírgula:");
                            string[] dadosProfessor = Console.ReadLine().Split(',');
                            int codigoProfessor = int.Parse(dadosProfessor[0]);
                            string nomeProfessor = dadosProfessor[1];
                            string enderecoProfessor = dadosProfessor[2];
                            CadastrarProfessor(codigoProfessor, nomeProfessor, enderecoProfessor);
                            break;
                        case "2":
                            Console.WriteLine("Professores cadastrados:");
                            BuscarProfessores();
                            break;
                        case "3":
                            Console.WriteLine("Digite o código do professor:");
                            int codigoBuscaProfessor = int.Parse(Console.ReadLine());
                            BuscarProfessorPorCodigo(codigoBuscaProfessor);
                            break;
                        case "4":
                            Console.WriteLine("Digite o código, nome e endereço atualizados do professor separados por vírgula:");
                            string[] dadosAtualizacaoProfessor = Console.ReadLine().Split(',');
                            int codigoAtualizacaoProfessor = int.Parse(dadosAtualizacaoProfessor[0]);
                            string nomeAtualizacaoProfessor = dadosAtualizacaoProfessor[1];
                            string enderecoAtualizacaoProfessor = dadosAtualizacaoProfessor[2];
                            AtualizarProfessor(codigoAtualizacaoProfessor, nomeAtualizacaoProfessor, enderecoAtualizacaoProfessor);
                            break;
                        case "5":
                            Console.WriteLine("Digite o código do professor a ser removido:");
                            int codigoRemocaoProfessor = int.Parse(Console.ReadLine());
                            RemoverProfessor(codigoRemocaoProfessor);
                            break;
                        case "6":
                            Console.WriteLine("Digite o código, descrição e carga horária da disciplina separados por vírgula:");
                            string[] dadosDisciplina = Console.ReadLine().Split(',');
                            int codigoDisciplina = int.Parse(dadosDisciplina[0]);
                            string descricaoDisciplina = dadosDisciplina[1];
                            int cargaHorariaDisciplina = int.Parse(dadosDisciplina[2]);
                            CadastrarDisciplina(codigoDisciplina, descricaoDisciplina, cargaHorariaDisciplina);
                            break;
                        case "7":
                            Console.WriteLine("Disciplinas cadastradas:");
                            BuscarDisciplinas();
                            break;
                        case "8":
                            Console.WriteLine("Digite o código da disciplina:");
                            int codigoBuscaDisciplina = int.Parse(Console.ReadLine());
                            BuscarDisciplinaPorCodigo(codigoBuscaDisciplina);
                            break;
                        case "9":
                            Console.WriteLine("Digite o código, descrição e carga horária atualizados da disciplina separados por vírgula:");
                            string[] dadosAtualizacaoDisciplina = Console.ReadLine().Split(',');
                            int codigoAtualizacaoDisciplina = int.Parse(dadosAtualizacaoDisciplina[0]);
                            string descricaoAtualizacaoDisciplina = dadosAtualizacaoDisciplina[1];
                            int cargaHorariaAtualizacaoDisciplina = int.Parse(dadosAtualizacaoDisciplina[2]);
                            AtualizarDisciplina(codigoAtualizacaoDisciplina, descricaoAtualizacaoDisciplina, cargaHorariaAtualizacaoDisciplina);
                            break;
                        case "10":
                            Console.WriteLine("Digite o código da disciplina a ser removida:");
                            int codigoRemocaoDisciplina = int.Parse(Console.ReadLine());
                            RemoverDisciplina(codigoRemocaoDisciplina);
                            break;
                        case "11":
                            Console.WriteLine("Digite o código, data, código do professor e código da disciplina da atribuição separados por vírgula:");
                            string[] dadosAtribuicao = Console.ReadLine().Split(',');
                            int codigoAtribuicao = int.Parse(dadosAtribuicao[0]);
                            DateTime dataAtribuicao = DateTime.Parse(dadosAtribuicao[1]);
                            int codigoProfessorAtribuicao = int.Parse(dadosAtribuicao[2]);
                            int codigoDisciplinaAtribuicao = int.Parse(dadosAtribuicao[3]);
                            CadastrarAtribuicao(codigoAtribuicao, dataAtribuicao, codigoProfessorAtribuicao, codigoDisciplinaAtribuicao);
                            break;
                        case "12":
                            Console.WriteLine("Atribuições cadastradas:");
                            BuscarAtribuicoes();
                            break;
                        case "13":
                            Console.WriteLine("Digite o código da atribuição:");
                            int codigoBuscaAtribuicao = int.Parse(Console.ReadLine());
                            BuscarAtribuicaoPorCodigo(codigoBuscaAtribuicao);
                            break;
                        case "14":
                            Console.WriteLine("Digite o código, data, código do professor e código da disciplina atualizados da atribuição separados por vírgula:");
                            string[] dadosAtualizacaoAtribuicao = Console.ReadLine().Split(',');
                            int codigoAtualizacaoAtribuicao = int.Parse(dadosAtualizacaoAtribuicao[0]);
                            DateTime dataAtualizacaoAtribuicao = DateTime.Parse(dadosAtualizacaoAtribuicao[1]);
                            int codigoProfessorAtualizacaoAtribuicao = int.Parse(dadosAtualizacaoAtribuicao[2]);
                            int codigoDisciplinaAtualizacaoAtribuicao = int.Parse(dadosAtualizacaoAtribuicao[3]);
                            AtualizarAtribuicao(codigoAtualizacaoAtribuicao, dataAtualizacaoAtribuicao, codigoProfessorAtualizacaoAtribuicao, codigoDisciplinaAtualizacaoAtribuicao);
                            break;
                        case "15":
                            Console.WriteLine("Digite o código da atribuição a ser removida:");
                            int codigoRemocaoAtribuicao = int.Parse(Console.ReadLine());
                            RemoverAtribuicao(codigoRemocaoAtribuicao);
                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine("Opção inválida. Digite novamente.");
                            break;
                    }
                }
            }

        }
    }
}







//namespace ConsoleAppEvandro
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Classe Disciplina para representar os registros da tabela de cadastro de disciplinas

//        }

//        // Classe Atribuicao para representar os registros da tabela de movimento (atribuição)

//        public class Program
//        {
//            // Vetores para armazenar os registros em memória
//            static List<Professor> professores = new List<Professor>();
//            static List<Disciplina> disciplinas = new List<Disciplina>();
//            static List<Atribuicao> atribuicoes = new List<Atribuicao>();

//            // Rotina para cadastrar um novo professor
//            static void CadastrarProfessor(int codigo, string nome, string endereco)
//            {
//                Professor professor = new Professor
//                {
//                    CodigoProfessor = codigo,
//                    Nome = nome,
//                    Endereco = endereco
//                };

//                professores.Add(professor);
//                Console.WriteLine("Professor cadastrado com sucesso!");
//            }

//            // Rotina para buscar todos os professores cadastrados
//            static void BuscarProfessores()
//            {
//                foreach (Professor professor in professores)
//                {
//                    Console.WriteLine($"Código: {professor.CodigoProfessor}, Nome: {professor.Nome}, Endereço: {professor.Endereco}");
//                }
//            }

//            // Rotina para buscar um professor pelo código
//            static void BuscarProfessorPorCodigo(int codigo)
//            {
//                Professor professor = professores.Find(p => p.CodigoProfessor == codigo);
//                if (professor != null)
//                {
//                    Console.WriteLine($"Código: {professor.CodigoProfessor}, Nome: {professor.Nome}, Endereço: {professor.Endereco}");
//                }
//                else
//                {
//                    Console.WriteLine("Professor não encontrado!");
//                }
//            }

//            // Rotina para atualizar os dados de um professor
//            static void AtualizarProfessor(int codigo, string nome, string endereco)
//            {
//                Professor professor = professores.Find(p => p.CodigoProfessor == codigo);
//                if (professor != null)
//                {
//                    professor.Nome = nome;
//                    professor.Endereco = endereco;
//                    Console.WriteLine("Professor atualizado com sucesso!");
//                }
//                else
//                {
//                    Console.WriteLine("Professor não encontrado!");
//                }
//            }

//            // Rotina para remover um professor pelo código
//            static void RemoverProfessor(int codigo)
//            {
//                Professor professor = professores.Find(p => p.CodigoProfessor == codigo);
//                if (professor != null)
//                {
//                    professores.Remove(professor);
//                    Console.WriteLine("Professor removido com sucesso!");
//                }
//                else
//                {
//                    Console.WriteLine("Professor não encontrado!");
//                }
//            }

//            // Rotina para cadastrar uma nova disciplina
//            static void CadastrarDisciplina(int codigo, string descricao, int cargaHoraria)
//            {
//                Disciplina disciplina = new Disciplina
//                {
//                    CodigoDisciplina = codigo,
//                    Descricao = descricao,
//                    CargaHoraria = cargaHoraria
//                };

//                disciplinas.Add(disciplina);
//                Console.WriteLine("Disciplina cadastrada com sucesso!");
//            }

//            // Rotina para buscar todas as disciplinas cadastradas
//            static void BuscarDisciplinas()
//            {
//                foreach (Disciplina disciplina in disciplinas)
//                {
//                    Console.WriteLine($"Código: {disciplina.CodigoDisciplina}, Descrição: {disciplina.Descricao}, Carga Horária: {disciplina.CargaHoraria}");
//                }
//            }

//            // Rotina para buscar uma disciplina pelo código
//            static void BuscarDisciplinaPorCodigo(int codigo)
//            {
//                Disciplina disciplina = disciplinas.Find(d => d.CodigoDisciplina == codigo);
//                if (disciplina != null)
//                {
//                    Console.WriteLine($"Código: {disciplina.CodigoDisciplina}, Descrição: {disciplina.Descricao}, Carga Horária: {disciplina.CargaHoraria}");
//                }
//                else
//                {
//                    Console.WriteLine("Disciplina não encontrada!");
//                }
//            }

//            // Rotina para atualizar os dados de uma disciplina
//            static void AtualizarDisciplina(int codigo, string descricao, int cargaHoraria)
//            {
//                Disciplina disciplina = disciplinas.Find(d => d.CodigoDisciplina == codigo);
//                if (disciplina != null)
//                {
//                    disciplina.Descricao = descricao;
//                    disciplina.CargaHoraria = cargaHoraria;
//                    Console.WriteLine("Disciplina atualizada com sucesso!");
//                }
//                else
//                {
//                    Console.WriteLine("Disciplina não encontrada!");
//                }
//            }

//            // Rotina para remover uma disciplina pelo código
//            static void RemoverDisciplina(int codigo)
//            {
//                Disciplina disciplina = disciplinas.Find(d => d.CodigoDisciplina == codigo);
//                if (disciplina != null)
//                {
//                    disciplinas.Remove(disciplina);
//                    Console.WriteLine("Disciplina removida com sucesso!");
//                }
//                else
//                {
//                    Console.WriteLine("Disciplina não encontrada!");
//                }
//            }

//            // Rotina para cadastrar uma nova atribuição
//            static void CadastrarAtribuicao(int codigo, DateTime dataAtribuicao, int codigoProfessor, int codigoDisciplina)
//            {
//                Atribuicao atribuicao = new Atribuicao
//                {
//                    CodigoAtribuicao = codigo,
//                    DataAtribuicao = dataAtribuicao,
//                    CodigoProfessor = codigoProfessor,
//                    CodigoDisciplina = codigoDisciplina
//                };

//                atribuicoes.Add(atribuicao);
//                Console.WriteLine("Atribuição cadastrada com sucesso!");
//            }

//            // Rotina para buscar todas as atribuições cadastradas
//            static void BuscarAtribuicoes()
//            {
//                foreach (Atribuicao atribuicao in atribuicoes)
//                {
//                    Console.WriteLine($"Código: {atribuicao.CodigoAtribuicao}, Data: {atribuicao.DataAtribuicao}, Código do Professor: {atribuicao.CodigoProfessor}, Código da Disciplina: {atribuicao.CodigoDisciplina}");
//                }
//            }

//            // Rotina para buscar uma atribuição pelo código
//            static void BuscarAtribuicaoPorCodigo(int codigo)
//            {
//                Atribuicao atribuicao = atribuicoes.Find(a => a.CodigoAtribuicao == codigo);
//                if (atribuicao != null)
//                {
//                    Console.WriteLine($"Código: {atribuicao.CodigoAtribuicao}, Data: {atribuicao.DataAtribuicao}, Código do Professor: {atribuicao.CodigoProfessor}, Código da Disciplina: {atribuicao.CodigoDisciplina}");
//                }
//                else
//                {
//                    Console.WriteLine("Atribuição não encontrada!");
//                }
//            }

//            // Rotina para atualizar os dados de uma atribuição
//            static void AtualizarAtribuicao(int codigo, DateTime dataAtribuicao, int codigoProfessor, int codigoDisciplina)
//            {
//                Atribuicao atribuicao = atribuicoes.Find(a => a.CodigoAtribuicao == codigo);
//                if (atribuicao != null)
//                {
//                    atribuicao.DataAtribuicao = dataAtribuicao;
//                    atribuicao.CodigoProfessor = codigoProfessor;
//                    atribuicao.CodigoDisciplina = codigoDisciplina;
//                    Console.WriteLine("Atribuição atualizada com sucesso!");
//                }
//                else
//                {
//                    Console.WriteLine("Atribuição não encontrada!");
//                }
//            }

//            // Rotina para remover uma atribuição pelo código
//            static void RemoverAtribuicao(int codigo)
//            {
//                Atribuicao atribuicao = atribuicoes.Find(a => a.CodigoAtribuicao == codigo);
//                if (atribuicao != null)
//                {
//                    atribuicoes.Remove(atribuicao);
//                    Console.WriteLine("Atribuição removida com sucesso!");
//                }
//                else
//                {
//                    Console.WriteLine("Atribuição não encontrada!");
//                }
//            }

//            public static void Main(string[] args)
//            {
//                // Exemplo de uso das rotinas para cadastro, busca, atualização e remoção de registros

//                // Cadastro de um professor
//                CadastrarProfessor(1, "João", "Rua A");
//                CadastrarProfessor(2, "Maria", "Rua B");

//                // Busca de todos os professores cadastrados
//                Console.WriteLine("Professores cadastrados:");
//                BuscarProfessores();

//                // Busca de um professor pelo código
//                Console.WriteLine("Buscar professor pelo código:");
//                BuscarProfessorPorCodigo(1);

//                // Atualização dos dados de um professor
//                Console.WriteLine("Atualizar professor:");
//                AtualizarProfessor(1, "João Silva", "Rua C");

//                // Remoção de um professor pelo código
//                Console.WriteLine("Remover professor:");
//                RemoverProfessor(2);

//                // Cadastro de uma disciplina
//                CadastrarDisciplina(1, "Matemática", 60);
//                CadastrarDisciplina(2, "Física", 80);

//                // Busca de todas as disciplinas cadastradas
//                Console.WriteLine("Disciplinas cadastradas:");
//                BuscarDisciplinas();

//                // Busca de uma disciplina pelo código
//                Console.WriteLine("Buscar disciplina pelo código:");
//                BuscarDisciplinaPorCodigo(1);

//                // Atualização dos dados de uma disciplina
//                Console.WriteLine("Atualizar disciplina:");
//                AtualizarDisciplina(1, "Matemática Avançada", 90);

//                // Remoção de uma disciplina pelo código
//                Console.WriteLine("Remover disciplina:");
//                RemoverDisciplina(2);

//                // Cadastro de uma atribuição
//                CadastrarAtribuicao(1, DateTime.Now, 1, 1);
//                CadastrarAtribuicao(2, DateTime.Now, 2, 2);

//                // Busca de todas as atribuições cadastradas
//                Console.WriteLine("Atribuições cadastradas:");
//                BuscarAtribuicoes();

//                // Busca de uma atribuição pelo código
//                Console.WriteLine("Buscar atribuição pelo código:");
//                BuscarAtribuicaoPorCodigo(1);

//                // Atualização dos dados de uma atribuição
//                Console.WriteLine("Atualizar atribuição:");
//                AtualizarAtribuicao(1, DateTime.Now, 2, 2);

//                // Remoção de uma atribuição pelo código
//                Console.WriteLine("Remover atribuição:");
//                RemoverAtribuicao(2);
//            }
//        }
//    }
//}
