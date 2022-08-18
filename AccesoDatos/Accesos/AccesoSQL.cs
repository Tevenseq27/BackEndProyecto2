using AccesoDatos.Interfaces;
using Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AccesoDatos
{
    public class AccesoSQL : IAccesoSQL
    {
        #region Bus
        public bool AgregarBus(Bus P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                contexto.Bus.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        public bool ModificarBus(Bus P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                var consulta = (from x in contexto.Bus
                                where x.PlacaUnidad.Equals(P_Entidad.PlacaUnidad)
                                select x).FirstOrDefault();
                if (consulta != null)
                {
                    consulta.NumeroUnidad = P_Entidad.NumeroUnidad;
                    consulta.EstadoUnidad = P_Entidad.EstadoUnidad;
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        public bool EliminarBus(Bus P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                var consulta = (from x in contexto.Bus
                                where x.PlacaUnidad.Equals(P_Entidad.PlacaUnidad)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.Bus.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        public List<Bus> ConsultarBus(Bus P_Entidad)
        {
            Proyecto2_SistemaRuteoContext contexto = null;
            List<Bus> lista = new List<Bus>();
            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();

                if (P_Entidad.PlacaUnidad == null)
                {
                    var consulta = (from x in contexto.Bus
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.Bus
                                    where x.PlacaUnidad.Equals(P_Entidad.PlacaUnidad)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }

        #endregion

        #region Chofer
        public bool AgregarChofer(Chofer P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                contexto.Chofer.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        public List<Chofer> ConsultarChofer(Chofer P_Entidad)
        {
            Proyecto2_SistemaRuteoContext contexto = null;
            List<Chofer> lista = new List<Chofer>();
            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();

                if (P_Entidad.IdChofer == null)
                {
                    var consulta = (from x in contexto.Chofer
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.Chofer
                                    where x.IdChofer.Equals(P_Entidad.IdChofer)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }

        public bool EliminarChofer(Chofer P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                var consulta = (from x in contexto.Chofer
                                where x.IdChofer.Equals(P_Entidad.IdChofer)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.Chofer.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        public bool ModificarChofer(Chofer P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                var consulta = (from x in contexto.Chofer
                                where x.IdChofer.Equals(P_Entidad.IdChofer)
                                select x).FirstOrDefault();
                if (consulta != null)
                {
                    consulta.Nombre1Chofer = P_Entidad.Nombre1Chofer;
                    consulta.Nombre2Chofer = P_Entidad.Nombre2Chofer;
                    consulta.Apellido1Chofer = P_Entidad.Apellido1Chofer;
                    consulta.Apellido2Chofer = P_Entidad.Apellido2Chofer;
                    consulta.TelefonoChofer = P_Entidad.TelefonoChofer;
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        #endregion

        #region Perfil
        public bool AgregarPerfil(Perfil P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                contexto.Perfil.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        public List<Perfil> ConsultarPerfil(Perfil P_Entidad)
        {
            Proyecto2_SistemaRuteoContext contexto = null;
            List<Perfil> lista = new List<Perfil>();
            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();

                if (P_Entidad.CodigoPerfil == 0)
                {
                    var consulta = (from x in contexto.Perfil
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.Perfil
                                    where x.CodigoPerfil.Equals(P_Entidad.CodigoPerfil)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }

        public bool EliminarPerfil(Perfil P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                var consulta = (from x in contexto.Perfil
                                where x.CodigoPerfil.Equals(P_Entidad.CodigoPerfil)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.Perfil.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        public bool ModificarPerfil(Perfil P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                var consulta = (from x in contexto.Perfil
                                where x.CodigoPerfil.Equals(P_Entidad.CodigoPerfil)
                                select x).FirstOrDefault();
                if (consulta != null)
                {
                    consulta.NombrePerfil = P_Entidad.NombrePerfil;
                    consulta.Estado = P_Entidad.Estado;
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        #endregion

        #region Recorrido
        public bool AgregarRecorrido(Recorrido P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                contexto.Recorrido.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        public List<Recorrido> ConsultarRecorrido(Recorrido P_Entidad)
        {
            Proyecto2_SistemaRuteoContext contexto = null;
            List<Recorrido> lista = new List<Recorrido>();
            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();

                if (P_Entidad.Id == 0)
                {
                    var consulta = (from x in contexto.Recorrido
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.Recorrido
                                    where x.Id.Equals(P_Entidad.Id)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }

        public bool EliminarRecorrido(Recorrido P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                var consulta = (from x in contexto.Recorrido
                                where x.Id.Equals(P_Entidad.Id)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.Recorrido.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        public bool ModificarRecorrido(Recorrido P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                var consulta = (from x in contexto.Recorrido
                                where x.Id.Equals(P_Entidad.Id)
                                select x).FirstOrDefault();
                if (consulta != null)
                {
                    consulta.IdRutaAsignada = P_Entidad.IdRutaAsignada;
                    consulta.PlacaUnidadAsignada = P_Entidad.PlacaUnidadAsignada;
                    consulta.IdChoferAsignado = P_Entidad.IdChoferAsignado;
                    consulta.Estado = P_Entidad.Estado;
                    consulta.MontoRecibido = P_Entidad.MontoRecibido;
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        #endregion

        #region Ruta
        public bool AgregarRuta(Ruta P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                contexto.Ruta.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        public List<Ruta> ConsultarRuta(Ruta P_Entidad)
        {
            Proyecto2_SistemaRuteoContext contexto = null;
            List<Ruta> lista = new List<Ruta>();
            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();

                if (P_Entidad.IdRuta == 0)
                {
                    var consulta = (from x in contexto.Ruta
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.Ruta
                                    where x.IdRuta.Equals(P_Entidad.IdRuta)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }

        public bool EliminarRuta(Ruta P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                var consulta = (from x in contexto.Ruta
                                where x.IdRuta.Equals(P_Entidad.IdRuta)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.Ruta.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        public bool ModificarRuta(Ruta P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                var consulta = (from x in contexto.Ruta
                                where x.IdRuta.Equals(P_Entidad.IdRuta)
                                select x).FirstOrDefault();
                if (consulta != null)
                {
                    consulta.TerminalSalida = P_Entidad.TerminalSalida;
                    consulta.TerminalLlegada = P_Entidad.TerminalLlegada;
                    consulta.CantidadParadas = P_Entidad.CantidadParadas;
                    consulta.MontoEstimadoRuta = P_Entidad.MontoEstimadoRuta;
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        #endregion
//--------------------------------------------------------------------------------------------------------
        #region Usuario
        public bool AgregarUsuario(Usuario P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                contexto.Usuario.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        public List<Usuario> ConsultarUsuario(Usuario P_Entidad)
        {
            Proyecto2_SistemaRuteoContext contexto = null;
            List<Usuario> lista = new List<Usuario>();
            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();

                if (P_Entidad.ID_USUARIO == 0)
                {
                    var consulta = (from x in contexto.Usuario
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.Usuario
                                    where x.ID_USUARIO.Equals(P_Entidad.ID_USUARIO)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }

        public bool EliminarUsuario(Usuario P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                var consulta = (from x in contexto.Usuario
                                where x.ID_USUARIO.Equals(P_Entidad.ID_USUARIO)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.Usuario.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        public bool ModificarUsuario(Usuario P_Entidad)
        {
            bool resultado = false;
            Proyecto2_SistemaRuteoContext contexto = null;

            try
            {
                contexto = new Proyecto2_SistemaRuteoContext();
                var consulta = (from x in contexto.Usuario
                                where x.ID_USUARIO.Equals(P_Entidad.ID_USUARIO)
                                select x).FirstOrDefault();
                if (consulta != null)
                {
                    consulta.EMAIL = P_Entidad.EMAIL;
                    consulta.PASS = P_Entidad.PASS;
                    consulta.SALT = P_Entidad.SALT;
                    consulta.NOMBRE = P_Entidad.NOMBRE;
                    consulta.APELLIDOS = P_Entidad.APELLIDOS;
                    consulta.TIPO = P_Entidad.TIPO;
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        #endregion
        //--------------------------------------------------------------------------------------------------------
    }
}
