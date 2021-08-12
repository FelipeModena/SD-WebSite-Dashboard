using Microsoft.EntityFrameworkCore;
using SD_WebSite_DashBoardApi.Models;
using SD_WebSite_DashBoardApi.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Repository.RepositoryImplementation
{
    public class RootRespository : IRootRepository
    {
        MyDbContext _myDbContext;

        public RootRespository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public Administrador CreateAdministrador(string user, string password, int modelo)
        {
            Administrador administrador = new Administrador
            {
                ModeloSite = modelo,
                Usuario = user,
                Password = password,
                Cadastro = DateTime.Now
            };
            try
            {
                _myDbContext.Administrador.Add(administrador);
                _myDbContext.SaveChanges();
                return administrador;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void CreateRodapeEContato(Administrador administrador)
        {
            try
            {
                _myDbContext.Contato.Add(new Contato
                {
                    Administrador = administrador
                });
                _myDbContext.Rodape.Add(new Rodape
                {
                    Administrador = administrador
                });
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Pagina> CreatePages(Administrador administrador, int modelo)
        {
            try
            {
                List<Pagina> paginas = new List<Pagina> { };
                if (modelo==1)
                {
                    _myDbContext.Pagina.Add(new Pagina
                    {
                        NomePagina = "Index",
                        Url = "/",
                        Ordem = 0,
                        Ativa = true,
                        Modificacao = DateTime.Now,
                        Administrador = administrador
                    });
                    _myDbContext.Pagina.Add(new Pagina
                    {
                        NomePagina = "A Empresa",
                        Url = "/quemSomos",
                        Ordem = 1,
                        Ativa = true,
                        Modificacao = DateTime.Now,
                        Administrador = administrador
                    });
                    _myDbContext.Pagina.Add(new Pagina
                    {
                        NomePagina = "Nossas Serviços",
                        Url = "/colecoes",
                        Ordem = 2,
                        Ativa = true,
                        Modificacao = DateTime.Now,
                        Administrador = administrador
                    });
                    _myDbContext.Pagina.Add(new Pagina
                    {
                        NomePagina = "Nossos Clientes",
                        Url = "/lojas",
                        Ordem = 3,
                        Ativa = true,
                        Modificacao = DateTime.Now,
                        Administrador = administrador
                    });
                    _myDbContext.Pagina.Add(new Pagina
                    {
                        NomePagina = "Contato",
                        Url = "/contato",
                        Ordem = 4,
                        Ativa = true,
                        Modificacao = DateTime.Now,
                        Administrador = administrador
                    });
                }

                if (modelo == 2)
                {
                    _myDbContext.Pagina.Add(new Pagina
                    {
                        NomePagina = "Index",
                        Url = "/",
                        Ordem = 0,
                        Ativa = true,
                        Modificacao = DateTime.Now,
                        Administrador = administrador
                    });
                    _myDbContext.Pagina.Add(new Pagina
                    {
                        NomePagina = "Quem Somos",
                        Url = "/quemSomos",
                        Ordem = 1,
                        Ativa = true,
                        Modificacao = DateTime.Now,
                        Administrador = administrador
                    });
                    _myDbContext.Pagina.Add(new Pagina
                    {
                        NomePagina = "Nossas Coleções",
                        Url = "/colecoes",
                        Ordem = 2,
                        Ativa = true,
                        Modificacao = DateTime.Now,
                        Administrador = administrador
                    });
                    _myDbContext.Pagina.Add(new Pagina
                    {
                        NomePagina = "Nossas Lojas",
                        Url = "/lojas",
                        Ordem = 3,
                        Ativa = true,
                        Modificacao = DateTime.Now,
                        Administrador = administrador
                    });
                    _myDbContext.Pagina.Add(new Pagina
                    {
                        NomePagina = "Fale Conosco",
                        Url = "/contato",
                        Ordem = 4,
                        Ativa = true,
                        Modificacao = DateTime.Now,
                        Administrador = administrador
                    });
                }

                if (modelo == 3)
                {
                    _myDbContext.Pagina.Add(new Pagina
                    {
                        NomePagina = "Index",
                        Url = "/",
                        Ordem = 0,
                        Ativa = true,
                        Modificacao = DateTime.Now,
                        Administrador = administrador
                    });
                    _myDbContext.Pagina.Add(new Pagina
                    {
                        NomePagina = "Produtos e serviços",
                        Url = "/quemSomos",
                        Ordem = 1,
                        Ativa = true,
                        Modificacao = DateTime.Now,
                        Administrador = administrador
                    });
                    _myDbContext.Pagina.Add(new Pagina
                    {
                        NomePagina = "Galeria",
                        Url = "/colecoes",
                        Ordem = 2,
                        Ativa = true,
                        Modificacao = DateTime.Now,
                        Administrador = administrador
                    });
                    _myDbContext.Pagina.Add(new Pagina
                    {
                        NomePagina = "Pagina institucional",
                        Url = "/quemSomos",
                        Ordem = 3,
                        Ativa = true,
                        Modificacao = DateTime.Now,
                        Administrador = administrador
                    });
                    _myDbContext.Pagina.Add(new Pagina
                    {
                        NomePagina = "Contato",
                        Url = "/contato",
                        Ordem = 4,
                        Ativa = true,
                        Modificacao = DateTime.Now,
                        Administrador = administrador
                    });
                }

                _myDbContext.SaveChanges();
                return paginas;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Componente CreateComponentes(Pagina pagina, int modelo)
        {
            try
            {
                if (modelo == 1)
                {
                    if (pagina.Ordem == 0)
                    {
                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "BANNER PRINCIPAL",
                            Ativo = true,
                            Pagina = pagina
                        });

                                                _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO DIREITA E IMAGEM ESQUERDA",
                            Ativo = true,
                            Pagina = pagina
                        });

                                                _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "CARDS ESTATICOS",
                            Ativo = true,
                            Pagina = pagina
                        });

                                                                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "FORMULARIO E IFRAME MAPS",
                            Ativo = true,
                            Pagina = pagina
                        });
                        
                    }
                    if (pagina.Ordem == 1)
                    {
                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "BANNER",
                            Ativo = true,
                            Pagina = pagina
                        });

                                                _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO CENTRALIZADO",
                            Ativo = true,
                            Pagina = pagina
                        });

                                                _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "BANNER",
                            Ativo = true,
                            Pagina = pagina
                        });

                                                _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "BANNER PRINCIPAL",
                            Ativo = true,
                            Pagina = pagina
                        });

                                                _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "MINI GALERIA",
                            Ativo = true,
                            Pagina = pagina
                        });
                    }
                    if (pagina.Ordem == 2)
                    {

                                                _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO ESQUERDA E IMAGEM DIREITA",
                            Ativo = true,
                            Pagina = pagina
                        });

                                                _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO DIREITA E IMAGEM ESQUERDA",
                            Ativo = true,
                            Pagina = pagina
                        });

                                                                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO ESQUERDA E IMAGEM DIREITA",
                            Ativo = true,
                            Pagina = pagina
                        });

                                                _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO DIREITA E IMAGEM ESQUERDA",
                            Ativo = true,
                            Pagina = pagina
                        });


                    }
                    if (pagina.Ordem == 3)
                    {

                                                _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO ESQUERDA E IMAGEM DIREITA",
                            Ativo = true,
                            Pagina = pagina
                        });

                                                _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO DIREITA E IMAGEM ESQUERDA",
                            Ativo = true,
                            Pagina = pagina
                        });

                                                                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO ESQUERDA E IMAGEM DIREITA",
                            Ativo = true,
                            Pagina = pagina
                        });

                                                _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO DIREITA E IMAGEM ESQUERDA",
                            Ativo = true,
                            Pagina = pagina
                        });
                    }
                    if (pagina.Ordem == 4)
                    {

                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "MAPA",
                            Ativo = true,
                            Pagina = pagina
                        });

                                                                                                _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "FORMULARIO E IFRAME MAPS",
                            Ativo = true,
                            Pagina = pagina
                        });
                    }
                }
                if (modelo == 2)
                {
                    if (pagina.Ordem == 0)
                    {
                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "FORMULARIO",
                            Ativo = true,
                            Pagina = pagina
                        });

                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "MINI GALERIA",
                            Ativo = true,
                            Pagina = pagina
                        });

                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO DIREITA E IMAGEM ESQUERDA",
                            Ativo = true,
                            Pagina = pagina
                        });

                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO CENTRALIZADO",
                            Ativo = true,
                            Pagina = pagina
                        });

                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "BANNER PRINCIPAL",
                            Ativo = true,
                            Pagina = pagina
                        });

                    }
                    if (pagina.Ordem == 1)
                    {
                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "IMAGEM PRINCIPAL",
                            Ativo = true,
                            Pagina = pagina
                        });

                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO CENTRALIZADO",
                            Ativo = true,
                            Pagina = pagina
                        });

                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "IMAGENS HOVER",
                            Ativo = true,
                            Pagina = pagina
                        });
                    }
                    if (pagina.Ordem == 2)
                    {
                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO ESQUERDA E IMAGEM DIREITA",
                            Ativo = true,
                            Pagina = pagina
                        });

                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO DIREITA E IMAGEM ESQUERDA",
                            Ativo = true,
                            Pagina = pagina
                        });

                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO ESQUERDA E IMAGEM DIREITA",
                            Ativo = true,
                            Pagina = pagina
                        });
                    }
                    if (pagina.Ordem == 3)
                    {
                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "CONTEUDO GALERIA",
                            Ativo = true,
                            Pagina = pagina
                        });
                    }
                    if (pagina.Ordem == 4)
                    {
                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "FORMULARIO",
                            Ativo = true,
                            Pagina = pagina
                        });

                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "MAPA",
                            Ativo = true,
                            Pagina = pagina
                        });

                    }
                }
                if (modelo == 3)
                {
                    if (pagina.Ordem == 0)
                    {

                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO ESQUERDA E IMAGEM DIREITA",
                            Ativo = true,
                            Pagina = pagina
                        });

                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "IMAGENS HOVER",
                            Ativo = true,
                            Pagina = pagina
                        });
                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "BANNER PRINCIPAL",
                            Ativo = true,
                            Pagina = pagina
                        });

                    }
                    if (pagina.Ordem == 1)
                    {
                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO ESQUERDA E IMAGEM DIREITA",
                            Ativo = true,
                            Pagina = pagina
                        });
                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "IMAGEM PRINCIPAL",
                            Ativo = true,
                            Pagina = pagina
                        });
                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "TEXTO DIREITA E IMAGEM ESQUERDA",
                            Ativo = true,
                            Pagina = pagina
                        });
                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "IMAGEM PRINCIPAL",
                            Ativo = true,
                            Pagina = pagina
                        });
                    }
                    if (pagina.Ordem == 2)
                    {
                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "CARROUSEL",
                            Ativo = true,
                            Pagina = pagina
                        });

                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "CARROUSEL",
                            Ativo = true,
                            Pagina = pagina
                        });

                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "CARROUSEL",
                            Ativo = true,
                            Pagina = pagina
                        });
                    }
                    if (pagina.Ordem == 3)
                    {
                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "LOCALIZACAO",
                            Ativo = true,
                            Pagina = pagina
                        });

                    }
                    if (pagina.Ordem == 4)
                    {
                        _myDbContext.Componente.Add(new Componente
                        {
                            TipoComponente = "FORMULARIO",
                            Ativo = true,
                            Pagina = pagina
                        });
                    }
                }

                _myDbContext.SaveChanges();
                return new Componente { };
            }
            catch (Exception)
            {
                return null;
            }
        }




        public void CreateImagem(List<Componente> componente)
        {
            foreach (var comp in componente)
            {
                if (comp.TipoComponente == "MINI GALERIA")
                {
                    for (int i = 0; i < 8; i++)
                    {
                        _myDbContext.Imagem.Add(new Imagem
                        {
                            Componente = comp,
                            Texto = "",
                            Compatibilidade = "",
                        });
                    }
                }

                if (comp.TipoComponente == "TEXTO ESQUERDA E IMAGEM DIREITA" || comp.TipoComponente == "TEXTO DIREITA E IMAGEM ESQUERDA" || comp.TipoComponente == "MAPA" || comp.TipoComponente == "LOCALIZACAO" || comp.TipoComponente == "IMAGEM PRINCIPAL")
                {
                    _myDbContext.Imagem.Add(new Imagem { Componente = comp,
                        Texto = "",
                        Compatibilidade = ""
                    });
                }

                if (comp.TipoComponente == "IMAGENS HOVER")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        _myDbContext.Imagem.Add(new Imagem { Componente = comp,
                            Texto = "",
                            Compatibilidade = ""
                        });
                    }
                }

            }
        }

        public object DeleteUser(int id)
        {
            var administrador = _myDbContext.Administrador.Include(t1=>t1.Pagina).ThenInclude(t2=> t2.Componente).ThenInclude(t3 => t3.Imagens).Where(p=>p.Id ==id);
            var contato  = _myDbContext.Contato.FirstOrDefault(contato => contato.Administrador.Id== id);
            var rodape= _myDbContext.Rodape.FirstOrDefault(rodape => rodape.Administrador.Id == id);
           _myDbContext.Remove(rodape);
           _myDbContext.Remove(contato);

            foreach(var adm in administrador){
           _myDbContext.Remove(adm);
            }

            _myDbContext.SaveChanges();

        return administrador;
        }
    }

}

